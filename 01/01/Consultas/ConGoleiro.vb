Imports System.Data.SqlClient

Public Class ConGoleiro
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer
    Dim codClube As Integer

    Private Sub ConGoleiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaDados()
        contaJogos(cod)
        cmbClube.Hide()
        txtClube.Show()
        carregaMediaGoleiro(cod, 25, txtMGSofridos)
        carregaContagemAcaoGol(cod, 19, txtPDefendidos)
        carregaContagemAcaoGol(cod, 1, txtGols)
        carregaContagemAcaoGol(cod, 5, txtPCertos)
        carregaContagemAcaoGol(cod, 8, txtCAmarelos)
        carregaContagemAcaoGol(cod, 9, txtCVermelhos)
        carregaContagemAcaoGol(cod, 25, txtCGSofridos)
    End Sub

    Private Sub carregaDados()
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select imagem from jogador where codJogador = " & cod & ""
            .CommandType = CommandType.Text
        End With
        Dim x As String
        x = cmd.ExecuteScalar
        Me.PictureBox1.ImageLocation = (x)
        cn.Close()

        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select jogador.codClube, nome, apelido, dataNascimento, pePredom, altura, peso, pais.pais, posicao.nomePosicao, clube.alcunha from jogador inner join posicao on posicao.codPosicao = jogador.codPosicao inner join pais on pais.codPais  = jogador.codPais inner join clube on jogador.codClube = clube.codClube where codJogador = " & cod & ""
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        Dim xxx As Integer
        While mr.Read
            codClube = mr!codClube
            xxx = DateDiff(DateInterval.Year, mr!dataNascimento, Today)
            Me.txtNome.Text = mr!nome
            Me.txtApelido.Text = mr!apelido
            Me.txtNacionalidade.Text = mr!pais
            Me.txtIdade.Text = xxx
            Me.txtPePredom.Text = mr!pePredom
            Me.txtAltura.Text = mr!altura
            Me.txtPeso.Text = mr!peso
            Me.txtClube.Text = mr!alcunha
        End While
    End Sub

    Public Sub carregaContagemAcaoGol(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txt As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(codAcao) from acaoPartida where codAcao = " & codAcao & " and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            txt.Text = z
            cn.Close()
        End Using
    End Sub

    Public Sub carregaMediaGoleiro(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txt As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) as Media from acaoPartida where codAcao = " & codAcao & " and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            If txtJogos.Text > 0 Then
                Dim media As Double = z / txtJogos.Text
                If media.ToString.Length > 3 Then
                    media = media.ToString.Substring(0, (media.ToString.IndexOf(",") + 2))
                End If
                txt.Text = media
            Else
                txt.Text = z
            End If
            
            cn.Close()
        End Using
    End Sub

    Public Sub contaJogos(ByVal codJogador As Integer)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(codJogador) from relacionados where codJogador = " & codJogador & " and (situacao = 'Titular' or situacao = 'Substituto')"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            txtJogos.Text = z
            cn.Close()
        End Using
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        Consulta.Show()
    End Sub

    Private Sub btnAtualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizar.Click
        If Me.btnAtualizar.Text = "Atualizar Dados" Then
            Me.txtNome.BackColor = Color.Gainsboro
            Me.txtIdade.BackColor = Color.Gainsboro
            Me.txtPePredom.BackColor = Color.Gainsboro
            Me.txtNacionalidade.BackColor = Color.Gainsboro
            '
            Me.btnAtualizar.Text = "Pronto"
            Me.txtApelido.ReadOnly = False
            Me.txtAltura.ReadOnly = False
            Me.txtPeso.ReadOnly = False
            Me.cmbClube.Show()
            carregaComboClube()
            Me.cmbClube.SelectedValue = codClube
            Me.txtClube.Hide()
        Else
            'Chama a Função
            UpdateJogadorComProcedure()
            '
            Me.txtNome.BackColor = Color.White
            Me.txtIdade.BackColor = Color.White
            Me.txtPePredom.BackColor = Color.White
            Me.txtNacionalidade.BackColor = Color.White
            '
            Me.btnAtualizar.Text = "Atualizar Dados"
            Me.txtApelido.ReadOnly = True
            Me.txtAltura.ReadOnly = True
            Me.txtPeso.ReadOnly = True
            Me.cmbClube.Hide()
            Me.txtClube.Show()
            carregaDados()
        End If
    End Sub
    Private Sub UpdateJogadorComProcedure()
        Dim cn As SqlConnection = conexao()
        Using (cn)
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "UpdateJogador"
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Parameters.AddWithValue("apelido", txtApelido.Text)
            cmd.Parameters.AddWithValue("altura", txtAltura.Text)
            cmd.Parameters.AddWithValue("peso", txtPeso.Text)
            cmd.Parameters.AddWithValue("codClube", cmbClube.SelectedValue)
            cmd.Parameters.AddWithValue("codJogador", cod)
            cn.Open()
            cmd.ExecuteNonQuery()
            cn.Close()
        End Using
    End Sub
    Public Sub carregaComboClube()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from clube order by nomeCompleto asc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbClube.ValueMember = "codClube"
                Me.cmbClube.DisplayMember = "alcunha"
                Me.cmbClube.DataSource = dt
                Me.cmbClube.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub
    
End Class