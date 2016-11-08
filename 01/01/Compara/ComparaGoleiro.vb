Imports System.Data.SqlClient

Public Class ComparaGoleiro
    Public codGol1 As Integer = Comparacoes.cod1
    Public codGol2 As Integer = Comparacoes.cod2

    Private Sub ComparaGoleiro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaImagem()
        carregaJogos(codGol1, txtCJogos1)
        carregaContagemAcaoGol(codGol1, 1, txtCGols1)
        carregaContagemAcaoGol(codGol1, 25, txtCGSofridos1)
        carregaContagemAcaoGol(codGol1, 19, txtCPDefendidos1)
        carregaContagemAcaoGol(codGol1, 7, txtCFCometidas1)
        carregaContagemAcaoGol(codGol1, 8, txtCFSofridas1)
        carregaContagemAcaoGol(codGol1, 9, txtCCAmarelos1)
        carregaContagemAcaoGol(codGol1, 10, txtCCVermelhos1)
        carregaContagemAcaoGol(codGol1, 11, txtCLesoes1)
        carregaMediaGoleiro(codGol1, 1, txtMGSofridos1, txtCJogos1)
        carregaMediaGoleiro(codGol1, 20, txtMDefesas1, txtCJogos1)
        carregaMediaGoleiro(codGol1, 21, txtMDDificeis1, txtCJogos1)
        carregaMediaGoleiro(codGol1, 5, txtMPCertos1, txtCJogos1)
        '
        '
        '----------------Goleiro 2
        carregaJogos(codGol2, txtCJogos2)
        carregaContagemAcaoGol(codGol2, 1, txtCGols2)
        carregaContagemAcaoGol(codGol2, 25, txtCGSofridos2)
        carregaContagemAcaoGol(codGol2, 19, txtCPDefendidos2)
        carregaContagemAcaoGol(codGol2, 7, txtCFCometidas2)
        carregaContagemAcaoGol(codGol2, 8, txtCFSofridas2)
        carregaContagemAcaoGol(codGol2, 9, txtCCAmarelos2)
        carregaContagemAcaoGol(codGol2, 10, txtCCVermelhos2)
        carregaContagemAcaoGol(codGol2, 11, txtCLesoes2)
        carregaMediaGoleiro(codGol2, 1, txtMGSofridos2, txtCJogos2)
        carregaMediaGoleiro(codGol2, 20, txtMDefesas2, txtCJogos2)
        carregaMediaGoleiro(codGol2, 21, txtMDDificeis2, txtCJogos2)
        carregaMediaGoleiro(codGol2, 5, txtMPCertos2, txtCJogos2)
    End Sub

    Private Sub carregaImagem()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador where codJogador = " & codGol1 & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            PictureBox1.ImageLocation = z
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            sql = "select apelido from jogador where codJogador = " & codGol1 & ""
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            z = cmd.ExecuteScalar
            txtJogador1.Text = z
            cn.Close()
        End Using
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador where codJogador = " & codGol2 & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            PictureBox2.ImageLocation = z
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            sql = "select apelido from jogador where codJogador = " & codGol2 & ""
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            z = cmd.ExecuteScalar
            txtJogador2.Text = z
            cn.Close()
        End Using
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

    Public Sub carregaMediaGoleiro(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txtOndeAparece As TextBox, ByVal txtJogosGoleiro As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) as Media from acaoPartida where codAcao = " & codAcao & " and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            If txtJogosGoleiro.Text > 0 Then
                Dim media As Double = z / txtJogosGoleiro.Text
                txtOndeAparece.Text = media
            Else
                txtOndeAparece.Text = z
            End If

            cn.Close()
        End Using
    End Sub

    Public Sub carregaJogos(ByVal codJogador As Integer, ByVal txtJogos As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(codJogador) from relacionados where codJogador = " & codJogador & " and situacao = 'Titular' or situacao = 'Substituto'"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            txtJogos.Text = z
            cn.Close()
        End Using
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Comparacoes.Show()
        Me.Close()
    End Sub
End Class