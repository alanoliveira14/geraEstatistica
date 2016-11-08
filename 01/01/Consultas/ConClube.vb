Imports System.Data.SqlClient
Public Class ConClube

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer
    Dim codTecnico As Integer
    Dim codEstadio As Integer
    Private Sub carregaDados()
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select imagem from clube where codClube = " & cod & ""
            .CommandType = CommandType.Text
        End With
        Dim x As String
        x = cmd.ExecuteScalar
        Me.pictClube.ImageLocation = (x)
        cn.Close()
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from estadio where codClube = " & cod
            .CommandType = CommandType.Text
        End With
        Dim estadio As String = cmd.ExecuteScalar
        cn.Close()
        If estadio <> "" Then
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select *, estadio.nome, pais.pais, tecnico.codTecnico, tecnico.apelido as 'nomeTecnico' from clube inner join estadio on estadio.codClube = clube.codClube inner join pais on clube.codPais = pais.codPais inner join tecnico on tecnico.codTecnico = clube.codTecnico where clube.codClube = " & cod & ""
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                codTecnico = mr!codTecnico
                codEstadio = mr!codEstadio
                Me.txtNome.Text = mr!nomeCompleto
                Me.txtAlcunha.Text = mr!alcunha
                Me.txtSigla.Text = mr!sigla
                Me.txtEstadio.Text = mr!nome
                Me.txtFundacao.Text = mr!dataFundacao
                Me.txtPais.Text = mr!pais
                Me.txtTecnico.Text = mr!nomeTecnico
                Me.txtVitorias.Text = mr!vitoria.ToString
                Me.txtEmpates.Text = mr!empate.ToString
                Me.txtDerrotas.Text = mr!derrota.ToString
            End While
            cn.Close()
        Else
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select *, pais.pais, tecnico.codTecnico, tecnico.apelido as 'nomeTecnico' from clube inner join pais on clube.codPais = pais.codPais inner join tecnico on tecnico.codTecnico = clube.codTecnico where clube.codClube = " & cod & ""
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                codTecnico = mr!codTecnico
                codEstadio = 0
                Me.txtNome.Text = mr!nomeCompleto
                Me.txtAlcunha.Text = mr!alcunha
                Me.txtSigla.Text = mr!sigla
                Me.txtEstadio.Text = "Clube sem Estadio Definido"
                Me.txtFundacao.Text = mr!dataFundacao
                Me.txtPais.Text = mr!pais
                Me.txtTecnico.Text = mr!nomeTecnico
                Me.txtVitorias.Text = mr!vitoria.ToString
                Me.txtEmpates.Text = mr!empate.ToString
                Me.txtDerrotas.Text = mr!derrota.ToString
            End While
            cn.Close()
        End If
        Dim a As String = "select * from jogador where codClube = " & cod
        Try
            Dim cmd1 As SqlCommand = New SqlCommand(a, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            Me.lstJogadores.DisplayMember = "apelido"
            Me.lstJogadores.DataSource = dt
        Catch ex As Exception
        End Try

    End Sub

    Private Sub carregaStats(ByVal codAcao As Integer, ByVal txt As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Close()
            cn.Open()
            Dim sql As String
            Dim cmd As SqlCommand
            Dim da As SqlDataAdapter
            sql = "select COUNT(*) from acaoPartida inner join partida on partida.codPartida = acaoPartida.codPartida where codAcao = " & codAcao & " and partida.codClube = " & cod
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            Dim x As String = cmd.ExecuteScalar
            txt.Text = x
            cn.Close()
        End Using
    End Sub

    Private Sub ConClube_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaDados()
        carregaStats(1, txtGolsPro)
        carregaStats(25, txtGolsContra)
        cmbEstadio.Hide()
        txtEstadio.Show()
        cmbTecnico.Hide()
        txtTecnico.Show()
        Dim vit, der, emp As Integer
        vit = txtVitorias.Text
        der = txtDerrotas.Text
        emp = txtEmpates.Text

        Me.txtJogos.Text = vit + emp + der
        Dim x, y, z As Double
        x = txtGolsPro.Text
        If Me.txtJogos.Text = "" Then
            y = "0"
        Else
            y = txtJogos.Text
        End If
        If y = "0" Then
            z = "0"
        Else
            z = x / y
        End If
        txtMediaGols.Text = z
        'txtMediaGols.Text = txtGolsPro.Text / txtJogos.Text

        carregaStats(9, txtCAmarelos)
        carregaStats(10, txtCVermelhos)
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Consulta.Show()
    End Sub
    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        If Me.btnAtualizar.Text = "Atualizar Dados" Then
            Me.txtFundacao.BackColor = Color.Gainsboro
            Me.txtPais.BackColor = Color.Gainsboro
            '
            Me.btnAtualizar.Text = "Pronto"
            Me.txtNome.ReadOnly = False
            Me.txtAlcunha.ReadOnly = False
            Me.txtSigla.ReadOnly = False
            Me.txtTecnico.Hide()
            carregaComboTecnico()
            Me.cmbTecnico.SelectedValue = codTecnico
            Me.cmbTecnico.Show()
            Me.cmbEstadio.Show()
            carregaComboEstadio()
            Me.cmbEstadio.SelectedValue = codEstadio
            Me.txtEstadio.Hide()
        Else
            'Chama a Função
            UpdateClubeComProcedure()
            '
            Me.txtFundacao.BackColor = Color.White
            Me.txtPais.BackColor = Color.White
            '
            Me.btnAtualizar.Text = "Atualizar Dados"
            Me.txtNome.ReadOnly = True
            Me.txtAlcunha.ReadOnly = True
            Me.txtSigla.ReadOnly = True
            Me.txtTecnico.Show()
            Me.cmbTecnico.Hide()
            Me.cmbEstadio.Hide()
            Me.txtEstadio.Show()
            carregaDados()
        End If
    End Sub

    Public Sub carregaComboEstadio()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from estadio order by nome asc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbEstadio.ValueMember = "codEstadio"
                Me.cmbEstadio.DisplayMember = "nome"
                Me.cmbEstadio.DataSource = dt
                Me.cmbEstadio.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Public Sub carregaComboTecnico()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from tecnico order by nome asc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbTecnico.ValueMember = "codTecnico"
                Me.cmbTecnico.DisplayMember = "nome"
                Me.cmbTecnico.DataSource = dt
                Me.cmbTecnico.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    Private Sub UpdateClubeComProcedure()
        Dim codEstadioo As Integer
        codEstadioo = cmbEstadio.SelectedValue

        Dim cn As SqlConnection = conexao()
        Using (cn)
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "UpdateClube"
            cmd.CommandType = CommandType.StoredProcedure
            '
            cmd.Parameters.AddWithValue("nome", txtNome.Text)
            cmd.Parameters.AddWithValue("alcunha", txtAlcunha.Text)
            cmd.Parameters.AddWithValue("sigla", txtSigla.Text)
            cmd.Parameters.AddWithValue("codTecnico", cmbTecnico.SelectedValue)
            cmd.Parameters.AddWithValue("codEstadio", codEstadioo)
            cmd.Parameters.AddWithValue("codClube", cod)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
    End Sub
End Class