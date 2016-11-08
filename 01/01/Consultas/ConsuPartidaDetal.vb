Imports System.Data.SqlClient

Public Class ConsuPartidaDetal
    Public codPartida As Integer

    Private Sub ConsuPartidaDetal_Load() Handles Me.Load
        carregaDados()
        contaAcoes(1, txtGolsPro)
        contaAcoes(25, txtGolsContra)
        contaAcoes(3, txtChutesGol)
        contaAcoes(5, txtPCertos)
        contaAcoes(6, txtPErrados)
        contaAcoes(7, txtFCometidas)
        contaAcoes(8, txtFSofridas)
        contaAcoes(9, txtCAmarelos)
        contaAcoes(10, txtCVermelho)
        contaAcoes(12, txtImped)
        contaAcoes(13, txtEscanteio)
        contaAcoes(14, txtSubst)
        contaAcoes(15, txtPenalti)
        contaAcoes(20, txtDefesas)
        contaAcoes(21, txtDDificeis)
        contaAcoes(22, txtDesarmes)


    End Sub

    Private Sub carregaDados()
        Using cn As SqlConnection = conexao()
            cn.Close()
            cn.Open()
            Dim sql As String = "select	partida.dataPartida, " &
            "partida.horario, " &
            "partida.situacao, " &
            "clube.alcunha as 'NomeClube', " &
            "clube.imagem as 'ImgClube', " &
            "estadio.nome as 'NomeEstadio', " &
            "timeAdversario.alcunha as 'NomeAdv', " &
            "timeAdversario.imagem as 'ImgAdv', " &
            "campeonato.nome, " &
            "rodada.rodada " &
            "from partida " &
"inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario " &
"inner join clube on clube.codClube = partida.codClube " &
"inner join estadio on partida.codEstadio = estadio.codEstadio " &
"inner join campeonato on partida.codCampeonato = campeonato.codCampeonato " &
"inner join rodada on partida.codRodada = rodada.codRodada " &
"where codPartida = " & codPartida & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim mr As SqlDataReader = cmd.ExecuteReader
            While mr.Read
                txtClube1.Text = mr!NomeClube
                txtClube2.Text = mr!NomeAdv
                txtData.Text = mr!dataPartida
                txtHorario.Text = mr!horario.ToString
                txtEstadio.Text = mr!NomeEstadio
                txtAdversario.Text = mr!NomeAdv
                txtRodada.Text = mr!rodada
                txtCamp.Text = mr!nome
                txtSituacao.Text = mr!situacao
                PictureBox1.ImageLocation = mr!ImgClube
                PictureBox2.ImageLocation = mr!ImgAdv
            End While
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            txtClube1.ReadOnly = True
            txtClube2.ReadOnly = True
        End Using
    End Sub

    Private Sub carregaListAcao()
        ListBox1.Items.Clear()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select jogador.apelido, " &
            "acao.nomeAcao, " &
            "acaoPartida.tempo " &
            "from acaoPartida " &
"inner join jogador on acaoPartida.codJogador = jogador.codJogador " &
"inner join acao on acaoPartida.codAcao = acao.codAcao " &
 " where(acaoPartida.codPartida = " & codPartida & " And (acaoPartida.codAcao = 1 Or acaoPartida.codAcao = 9 Or acaoPartida.codAcao = 10)) " &
"order by tempo asc"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim mr As SqlDataReader = cmd.ExecuteReader(CommandBehavior.Default)
            Dim texto As String
            Dim i As Integer
            'percorre o datareader
            Do While mr.Read
                'le o primeiro campo do datareader
                texto = mr.Item(0).ToString
                For i = 1 To mr.FieldCount - 1
                    texto &= vbTab & mr.Item(i).ToString
                Next i
                'inclui o texto no listbox
                ListBox1.Items.Add(texto)
            Loop
            ' fecha a conexao
            cn.Close()
        End Using
    End Sub

    Private Sub contaAcoes(ByVal codAcao As Integer, ByVal txt As TextBox)
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select COUNT(*) from acaoPartida where codAcao = " & codAcao & " and codPartida = " & codPartida & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim x As String = cmd.ExecuteScalar
            txt.Text = x
            cn.Close()
        End Using
    End Sub

    Private Sub btnDetalhes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDetalhes.Click
        carregaListAcao()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ConsuPartida.Show()
    End Sub
End Class