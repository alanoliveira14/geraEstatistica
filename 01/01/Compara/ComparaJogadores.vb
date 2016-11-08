Imports System.Data.SqlClient

Public Class ComparaJogadores
    Dim cod As Integer = Comparacoes.cmbSelecionado1.SelectedValue
    Dim cod2 As Integer = Comparacoes.cmbSelecionado2.SelectedValue

    Private Sub ComparaçãoJogadores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaImagem()

        'Jogador 1
        'Contagens
        carregaJogos(cod, txtCJogos1) 'Contagem de Jogos
        carregaContagemAcaoJog(cod, 1, txtCGols1) 'Contagem de gols
        carregaContagemAcaoJog(cod, 4, txtCAssistencia1) 'Contagem de Assistencias
        carregaContagemAcaoJog(cod, 10, txtCCVermelho1) 'Contagem de cartões vermelhos
        carregaContagemAcaoJog(cod, 9, txtCCAmarelo1) 'Contagem de cartões amarelos
        carregaContagemAcaoJog(cod, 11, txtCLesoes1)
        carregaContagemAcaoJog(cod, 17, txtCGPenalti1)
        'Medias
        carregaMediaJogador(cod, 1, txtMGols1, txtCJogos1) 'Media de Gols
        carregaMediaJogador(cod, 2, txtMChutes1, txtCJogos1) 'Media de Chutes
        carregaMediaJogador(cod, 3, txtMCCertos1, txtCJogos1) 'Media de Chutes à Gol

        carregaMediaJogador(cod, 5, txtMPCertos1, txtCJogos1) 'Media de Passes Certos
        carregaMediaJogador(cod, 6, txtMPErrados1, txtCJogos1) 'Media de Passes Errados
        carregaMediaJogador(cod, 7, txtMFCometidas1, txtCJogos1) 'Media de Faltas Cometidas
        carregaMediaJogador(cod, 8, txtMFSofridas1, txtCJogos1) 'Media de Faltas Recebidas

        carregaMediaJogador(cod, 12, txtMImpe1, txtCJogos1)
        carregaMediaJogador(cod, 22, txtMDesarmes1, txtCJogos1)
        '-------------------------------------------------------------------------------------------
        'Jogador 2
        'Contagens
        carregaJogos(cod2, txtCJogos2) 'Contagem de Jogos
        carregaContagemAcaoJog(cod2, 1, txtCGols2) 'Contagem de gols
        carregaContagemAcaoJog(cod2, 4, txtCAssistencia2) 'Contagem de Assistencias
        carregaContagemAcaoJog(cod2, 10, txtCCVermelho2) 'Contagem de cartões vermelhos
        carregaContagemAcaoJog(cod2, 9, txtCCAmarelo2) 'Contagem de cartões amarelos
        carregaContagemAcaoJog(cod2, 11, txtCLesoes2)
        carregaContagemAcaoJog(cod2, 17, txtCGPenalti2)
        'Medias
        carregaMediaJogador(cod2, 1, txtMGols2, txtCJogos2) 'Media de Gols
        carregaMediaJogador(cod2, 2, txtMChutes2, txtCJogos2) 'Media de Chutes
        carregaMediaJogador(cod2, 3, txtMCCertos2, txtCJogos2) 'Media de Chutes à Gol

        carregaMediaJogador(cod2, 5, txtMPCertos2, txtCJogos2) 'Media de Passes Certos
        carregaMediaJogador(cod2, 6, txtMPErrados2, txtCJogos2) 'Media de Passes Errados
        carregaMediaJogador(cod2, 7, txtMFCometidas2, txtCJogos2) 'Media de Faltas Cometidas
        carregaMediaJogador(cod2, 8, txtMFSofridas2, txtCJogos2) 'Media de Faltas Recebidas

        carregaMediaJogador(cod2, 12, txtMImpe2, txtCJogos2)
        carregaMediaJogador(cod2, 22, txtMDesarmes2, txtCJogos2)

        
    End Sub

    Private Sub carregaImagem()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador where codJogador = " & Comparacoes.cod1 & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            PictureBox1.ImageLocation = z
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            sql = "select apelido from jogador where codJogador = " & Comparacoes.cod1 & ""
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            z = cmd.ExecuteScalar
            txtJogador1.Text = z
            cn.Close()
        End Using
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador where codJogador = " & Comparacoes.cod2 & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            PictureBox2.ImageLocation = z
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            sql = "select apelido from jogador where codJogador = " & Comparacoes.cod2 & ""
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            z = cmd.ExecuteScalar
            txtJogador2.Text = z
            cn.Close()
        End Using
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

    Public Sub carregaMediaJogador(ByVal codJogador As Integer, ByVal codAcao As Integer, ByVal txtOndeAparece As TextBox, ByVal txtJogosJogador As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) as Media from acaoPartida where codAcao = " & codAcao & " and codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String = cmd.ExecuteScalar
            Dim media As String

            If txtJogosJogador.Text <> 0 Then
                media = z / txtJogosJogador.Text
                If media.Length > 4 Then
                    media = media.Substring(0, (media.IndexOf(",") + 4))
                End If
                txtOndeAparece.Text = media
            Else
                txtOndeAparece.Text = 0
            End If
            cn.Close()
        End Using
    End Sub

    Public Sub carregaJogos(ByVal codJogador As Integer, ByVal txtJogos As TextBox)
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Comparacoes.Show()
        Me.Close()
    End Sub
End Class