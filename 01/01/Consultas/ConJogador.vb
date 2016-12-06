Imports System.Data.SqlClient

Public Class ConJogador

    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer
    Dim codClubeJogador As Integer

    Private Sub ConJogador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmbClube.Hide()
        carregaDados()
        contaJogos(cod)
        carregaContagemAcaoJog(cod, 1, txtGol) 'Contagem de gols
        carregaContagemAcaoJog(cod, 4, txtAssistencia) 'Contagem de Assistencias
        carregaContagemAcaoJog(cod, 9, txtCartaoAm) 'Contagem de cartões vermelhos
        carregaContagemAcaoJog(cod, 10, txtCartaoVe) 'Contagem de cartões amarelos
        carregaMediaJogador(cod, 1, txtMediaGol) 'Media de Gols
        carregaMediaJogador(cod, 3, txtChuteGol) 'Media de Chutes à Gol
        contaPasses(cod)
        carregaMediaJogador(cod, 7, txtFaltaComet) 'Media de Faltas Cometidas
        carregaMediaJogador(cod, 8, txtFaltaReceb) 'Media de Faltas Recebidas
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
            .CommandText = "select *, jogador.codClube as 'ClubeJogador' from jogador inner join posicao on posicao.codPosicao = jogador.codPosicao inner join pais on pais.codPais = jogador.codPais inner join clube on clube.codClube = jogador.codClube where codJogador = " & cod & ""
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader

        Dim xxx As Integer
        While mr.Read
            codClubeJogador = mr!ClubeJogador
            xxx = DateDiff(DateInterval.Year, mr!dataNascimento, Today)
            Me.txtNome.Text = mr!nome
            Me.txtApelido.Text = mr!apelido
            Me.txtNacionalidade.Text = mr!pais
            Me.txtIdade.Text = xxx
            Me.txtPePredom.Text = mr!pePredom
            Me.txtAltura.Text = mr!altura
            Me.txtPeso.Text = mr!peso
            Me.txtPosicao.Text = mr!nomePosicao
            Me.txtClube.Text = mr!alcunha
        End While
        cn.Close()
    End Sub

    Public Sub carregaContagemAcaoJog(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txt As TextBox)
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

    Public Sub carregaMediaJogador(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txt As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) as Media from acaoPartida where codAcao = " & codAcao & " and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            Dim media As String
            
            If Me.txtJogos.Text <> 0 Then
                media = z / txtJogos.Text
                If media.Length > 4 Then
                    media = media.Substring(0, (media.IndexOf(",") + 4))
                End If
                txt.Text = media
            Else
                txt.Text = 0
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

    Public Sub contaPasses(ByVal codJogador As Integer)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) as Passes from acaoPartida where (codAcao = 5  or codAcao = 6) and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            cn.Close()
            cn.Open()
            sql = "select COUNT(*) from acaoPartida where (codAcao = 5) and codJogador = " & cod & ""
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            Dim x As String = cmd.ExecuteScalar
            If z <> 0 Then
                Me.txtPasseCerto.Text = x & " (" & z & ")"
                Me.lblPctgm.Text = CInt((x / z) * 100) & "%"
            Else
                Me.txtPasseCerto.Text = x & " (" & z & ")"
            End If

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
            Me.txtPosicao.BackColor = Color.Gainsboro
            '
            Me.btnAtualizar.Text = "Pronto"
            Me.txtApelido.ReadOnly = False
            Me.txtAltura.ReadOnly = False
            Me.txtPeso.ReadOnly = False
            Me.cmbClube.Show()
            carregaComboClube()
            Me.cmbClube.SelectedValue = codClubeJogador
            Me.txtClube.Hide()
        Else
            'Chama a Função
            UpdateJogadorComProcedure()
            '
            Me.txtNome.BackColor = Color.White
            Me.txtIdade.BackColor = Color.White
            Me.txtPePredom.BackColor = Color.White
            Me.txtNacionalidade.BackColor = Color.White
            Me.txtPosicao.BackColor = Color.White
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

    Private Sub UpdateJogadorSemProcedure()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "update jogador set apelido = '" & txtApelido.Text & "'," &
" altura = '" & txtAltura.Text & "', peso = '" & txtPeso.Text & "', codClube = " & cmbClube.SelectedValue & " where codJogador = " & cod & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim mr As SqlDataReader
            mr = cmd.ExecuteReader
            cn.Close()
        End Using
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

    Private Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        If MessageBox.Show("Realmente deseja exluir o jogador?", "My Application",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question) _
         = DialogResult.Yes Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update jogador set ativo = 0 where codJogador = " & cod & " "
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Jogador exluído com sucesso!")
                cn.Close()
            End Using
        End If


    End Sub
End Class