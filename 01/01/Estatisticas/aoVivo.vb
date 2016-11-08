Imports System.Data.SqlClient
Imports _01.Classes

Public Class aoVivo
    Dim acao As Integer = 0
    Dim min As String = "00"
    Dim seg As String = 0
    Dim result As String
    Dim caunti As Integer

    '---------------------Sistema e Subs-----------------------

    Private Sub loadForm() Handles Me.Load
        PegaNomeTime()
        Tempo_Part.Enabled = False
        carregarImagemGoleiroTitular()
        carregarImagemGoleiroReserva()
        'Jogadores Titulares
        carregaImagemJogTitular(1, PictureBox2, lblNomeJogPic2)
        carregaImagemJogTitular(2, PictureBox3, lblNomeJogPic3)
        carregaImagemJogTitular(3, PictureBox4, lblNomeJogPic4)
        carregaImagemJogTitular(4, PictureBox5, lblNomeJogPic5)
        carregaImagemJogTitular(5, PictureBox6, lblNomeJogPic6)
        carregaImagemJogTitular(6, PictureBox7, lblNomeJogPic7)
        carregaImagemJogTitular(7, PictureBox8, lblNomeJogPic8)
        carregaImagemJogTitular(8, PictureBox9, lblNomeJogPic9)
        carregaImagemJogTitular(9, PictureBox10, lblNomeJogPic10)
        carregaImagemJogTitular(10, PictureBox11, lblNomeJogPic11)
        'Jogadores Reservas
        carregaImagemJogReserva2()
        PictureBox2.ImageLocation = caminho2(1)
        PictureBox3.ImageLocation = caminho2(2)
        PictureBox4.ImageLocation = caminho2(3)
        PictureBox5.ImageLocation = caminho2(4)
        PictureBox6.ImageLocation = caminho2(5)
        PictureBox7.ImageLocation = caminho2(6)
        PictureBox8.ImageLocation = caminho2(7)
        PictureBox9.ImageLocation = caminho2(8)
        PictureBox10.ImageLocation = caminho2(9)
        PictureBox11.ImageLocation = caminho2(10)
    End Sub

    Private Sub carregaListAcao()
        ListBox1.Items.Clear()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select top 20 jogador.apelido, acao.nomeAcao, acaoPartida.tempo from acaoPartida inner join jogador on acaoPartida.codJogador = jogador.codJogador inner join acao on acaoPartida.codAcao = acao.codAcao where acaoPartida.codPartida = (select MAX(codPartida) from partida) order by tempo desc"
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
    Public pbx1 As PictureBox
    Public lblnomesub As Label
    Private Sub insertAcao(ByVal pbx As PictureBox, ByVal lblnome As Label)
        If acao = 0 Then
            MessageBox.Show("Escolha uma ação")
        ElseIf acao = 3 Then
            'Chute
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "')," & 2 & ",'" & Me.Label1.Text & "', 'Confirmada')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                cn.Close()
            End Using
            'Chute ao gol
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "')," & 3 & ",'" & Me.Label1.Text & "', 'Confirmada')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                cn.Close()
            End Using
        ElseIf acao = 14 Then
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "')," & 14 & ",'" & Me.Label1.Text & "', 'Confirmada')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim sql1 As String = "update relacionados set situacao = 'Substituido', obs = '" & Me.Label1.Text & "' where codJogador = (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "') and codEscalacao = (select MAX(codEscalacao) from escalacao)"
                Dim cmd1 As SqlCommand = New SqlCommand(sql1, cn)
                Dim da1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
                Dim mr As SqlDataReader
                Dim mr1 As SqlDataReader
                mr = cmd.ExecuteReader
                mr.Close()
                mr1 = cmd1.ExecuteReader
                cn.Close()
                BtnSubstituiu.Visible = True
                BtnSubstituido.Visible = False
                lblnomesub = lblnome
                pbx1 = pbx
                pbx.Image = Nothing
                lblnome.Text = ""
            End Using
        ElseIf acao = 26 Then
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "')," & 26 & ",'" & Me.Label1.Text & "', 'Confirmada')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim sql1 As String = "update relacionados set situacao = 'Substituto', obs = '" & Me.Label1.Text & "' where codJogador = (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "') and codEscalacao = (select MAX(codEscalacao) from escalacao)"
                Dim cmd1 As SqlCommand = New SqlCommand(sql1, cn)
                Dim da1 As SqlDataAdapter = New SqlDataAdapter(cmd1)
                Dim mr As SqlDataReader
                Dim mr1 As SqlDataReader
                mr = cmd.ExecuteReader
                mr.Close()
                mr1 = cmd1.ExecuteReader
                cn.Close()
                carregaImagemJogSub(pbx, lblnomesub)
                BtnSubstituiu.Visible = False
                pbx1.ImageLocation = pbx.ImageLocation
                pbx.Enabled = False
                pbx.Image = Nothing
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "')," & acao & ",'" & Me.Label1.Text & "', 'Confirmada')"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                cn.Close()

                If acao = 9 And lblnome.BackColor = Color.Yellow Then
                    cn.Open()
                    Dim sql1 As String = "insert into acaoPartida (codPartida, codJogador, codAcao, tempo, statusAcao) values ((select MAX(codPartida) from partida), (select codjogador from jogador where imagem = '" & pbx.ImageLocation & "'), 10 ,'" & Me.Label1.Text & "', 'Confirmada')"
                    Dim cmd1 As SqlCommand = New SqlCommand(sql1, cn)
                    Dim mr1 As SqlDataReader
                    mr1 = cmd1.ExecuteReader
                    cn.Close()
                    pbx.Image = Nothing
                    pbx.Enabled = False
                    lblnome.Text = ""
                    lblnome.BackColor = Color.Transparent
                ElseIf acao = 9 Then
                    lblnome.BackColor = Color.Yellow
                End If

                If acao = 10 Then
                    pbx.Image = Nothing
                    pbx.Enabled = False
                    lblnome.Text = ""
                ElseIf acao = 1 Then
                    lblGPro.Text = lblGPro.Text + 1
                ElseIf acao = 25 Then
                    lblGContra.Text = lblGContra.Text + 1
                End If
            End Using
        End If
    End Sub

    Dim caminho2(10) As String

    Private Sub carregaImagemJogTitular(ByVal lstIndex As Integer, ByVal pbx As PictureBox, ByVal lblNomeJogador As Label)
        Dim codJogador As Integer
        definirEscalacao.lstAux.SetSelected(lstIndex, 1)
        codJogador = definirEscalacao.lstAux.SelectedItem
        Using cn As SqlConnection = conexao()
            cn.Close()
            cn.Open()
            Dim sql As String = "select	jogador.apelido, jogador.imagem, posicao.nomePosicao from jogador inner join posicao on jogador.codPosicao = posicao.codPosicao where codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim mr As SqlDataReader
            mr = cmd.ExecuteReader
            While mr.Read
                caminho2(lstIndex) = mr!imagem
                lblNomeJogador.Text = mr!apelido
            End While
            cn.Close()
        End Using
    End Sub
    Private Sub carregaImagemJogReserva(ByVal lstIndex As Integer, ByVal pbx As PictureBox)
        Dim codJogador As Integer
        definirEscalacao.lstAux2.SetSelected(lstIndex, 1)
        codJogador = definirEscalacao.lstAux2.Text
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador inner join relacionados on jogador.codJogador = relacionados.codJogador where relacionados.situacao = 'Reserva' and codEscalacao = (select MAX(codEscalacao) from escalacao) and jogador.codPosicao <> 1 and jogador.codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            Dim caminho As String
            caminho = cmd.ExecuteScalar
            pbx.ImageLocation = caminho
            cn.Close()
            pbx.SizeMode = PictureBoxSizeMode.Zoom
        End Using
    End Sub

    Private Sub carregaImagemJogReserva2()
        caunti = definirEscalacao.lstSuplentes.Items.Count - 1
        If caunti = 4 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
        ElseIf caunti = 5 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
        ElseIf caunti = 6 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
        ElseIf caunti = 7 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
            carregaImagemJogReserva(7, PictureBox18)
        ElseIf caunti = 8 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
            carregaImagemJogReserva(7, PictureBox18)
            carregaImagemJogReserva(8, PictureBox19)
        ElseIf caunti = 9 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
            carregaImagemJogReserva(7, PictureBox18)
            carregaImagemJogReserva(8, PictureBox19)
        ElseIf caunti = 10 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
            carregaImagemJogReserva(7, PictureBox18)
            carregaImagemJogReserva(8, PictureBox19)
            carregaImagemJogReserva(10, PictureBox21)
        ElseIf caunti = 11 Then
            carregaImagemJogReserva(1, PictureBox12)
            carregaImagemJogReserva(2, PictureBox13)
            carregaImagemJogReserva(3, PictureBox14)
            carregaImagemJogReserva(4, PictureBox15)
            carregaImagemJogReserva(5, PictureBox16)
            carregaImagemJogReserva(6, PictureBox17)
            carregaImagemJogReserva(7, PictureBox18)
            carregaImagemJogReserva(8, PictureBox19)
            carregaImagemJogReserva(10, PictureBox21)
            carregaImagemJogReserva(11, PictureBox22)
        End If
    End Sub

    Private Sub TempoTick() Handles Tempo_Part.Tick
        Tempo_Part.Interval = 444
        seg = seg + 1
        If seg > 59 Then
            min = min + 1
            seg = 0
            If min < 9 Then
                min = "0" + min
            End If
        End If
        If 10 > seg Then
            seg = "0" + seg
        Else
            seg = seg
        End If
        result = (min + ":" + seg).Trim
        Label1.Text = result
    End Sub

    Private Sub btnComecar_Click() Handles btnComecar.Click
        If Tempo_Part.Enabled = False Then
            Me.Tempo_Part.Enabled = True
            Me.btnComecar.Text = "Parar"
        Else
            Tempo_Part.Enabled = False
            Me.btnComecar.Text = "Começar"
        End If
    End Sub


    '--------------------Ações-----------------------
    Private Sub btnGol_Click() Handles btnGol.Click
        acao = 1
    End Sub

    Private Sub btnChute_Click() Handles btnChute.Click
        acao = 2
    End Sub

    Private Sub btnChuteAoGol_Click() Handles btnChuteGol.Click
        acao = 3
    End Sub

    Private Sub btnAssistencia_Click() Handles btnAssitencia.Click
        acao = 4
    End Sub

    Private Sub btnPasseCerto_Click() Handles btnPassesCertos.Click
        acao = 5
    End Sub

    Private Sub btnPasseErrado_Click() Handles btnPasseErrado.Click
        acao = 6
    End Sub

    Private Sub btnFaltaCometida_Click() Handles btnFaltaComet.Click
        acao = 7
    End Sub

    Private Sub btnFaltaSofrida_Click() Handles btnFaltaSofrida.Click
        acao = 8
    End Sub

    Private Sub btnCartaoAmarelo_Click() Handles btnCartaoA.Click
        acao = 9
    End Sub

    Private Sub btnCartaoVermelho_Click() Handles btnCartaoV.Click
        acao = 10
    End Sub

    Private Sub btnLesao_Click() Handles btnLesao.Click
        acao = 11
    End Sub

    Private Sub btnImpedimento_Click() Handles btnImped.Click
        acao = 12
    End Sub

    Private Sub btnEscanteio_Click() Handles btnEscanteio.Click
        acao = 13
    End Sub

    Private Sub btnSubstituicao_Click() Handles btnSubst.Click
        BtnSubstituido.Visible = True

    End Sub
    Private Sub btnSubstituido_Click() Handles BtnSubstituido.Click
        acao = 14
    End Sub
    Private Sub btnPenSofrido_Click() Handles btnPenSofri.Click
        acao = 15
    End Sub

    Private Sub btnPenCometido_Click() Handles btnPenCome.Click
        acao = 16
    End Sub

    Private Sub btnPenConvertido_Click() Handles btnPenConver.Click
        acao = 17
    End Sub

    Private Sub btnPenPerdido_Click() Handles btnPenPerd.Click
        acao = 18
    End Sub

    Private Sub btnPenDefendido_Click() Handles btnPenDefen.Click
        acao = 19
    End Sub

    Private Sub btnDefesa_Click() Handles btnDefesa.Click
        acao = 20
    End Sub

    Private Sub btnDefesaDificil_Click() Handles btnDefesaDifi.Click
        acao = 21
    End Sub

    Private Sub btnDesarme_Click() Handles btnDesarme.Click
        acao = 22
    End Sub

    Private Sub btnLancamento_Click() Handles btnLanca.Click
        acao = 23
    End Sub

    Private Sub btnCruzamento_Click() Handles btnCruza.Click
        acao = 24
    End Sub

    Private Sub btnGolSofrido_Click() Handles btnGolSofrido.Click
        acao = 25
    End Sub
    Private Sub btnSubstituiu_Click() Handles BtnSubstituiu.Click
        acao = 26
    End Sub


    '-----------------------------Click das PicBox's---------------------------------------
    Private Sub pbxGolTitular_Click() Handles pbxGolTitular.Click
        insertAcao(pbxGolTitular, lblNomeGol)
        carregaListAcao()
    End Sub

    Private Sub PictureBox2_Click() Handles PictureBox2.Click
        insertAcao(PictureBox2, lblNomeJogPic2)
        carregaListAcao()
    End Sub

    Private Sub PictureBox3_Click() Handles PictureBox3.Click
        insertAcao(PictureBox3, lblNomeJogPic3)
        carregaListAcao()
    End Sub

    Private Sub PictureBox4_Click() Handles PictureBox4.Click
        insertAcao(PictureBox4, lblNomeJogPic4)
        carregaListAcao()
    End Sub

    Private Sub PictureBox5_Click() Handles PictureBox5.Click
        insertAcao(PictureBox5, lblNomeJogPic5)
        carregaListAcao()
    End Sub

    Private Sub PictureBox6_Click() Handles PictureBox6.Click
        insertAcao(PictureBox6, lblNomeJogPic6)
        carregaListAcao()
    End Sub

    Private Sub PictureBox7_Click() Handles PictureBox7.Click
        insertAcao(PictureBox7, lblNomeJogPic7)
        carregaListAcao()
    End Sub

    Private Sub PictureBox8_Click() Handles PictureBox8.Click
        insertAcao(PictureBox8, lblNomeJogPic8)
        carregaListAcao()
    End Sub

    Private Sub PictureBox9_Click() Handles PictureBox9.Click
        insertAcao(PictureBox9, lblNomeJogPic9)
        carregaListAcao()
    End Sub

    Private Sub PictureBox10_Click() Handles PictureBox10.Click
        insertAcao(PictureBox10, lblNomeJogPic10)
        carregaListAcao()
    End Sub

    Private Sub PictureBox11_Click() Handles PictureBox11.Click
        insertAcao(PictureBox11, lblNomeJogPic11)
        carregaListAcao()
    End Sub
    Private Sub pbxGolReserva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pbxGolReserva.Click
        If acao = 26 Then
            insertAcao(pbxGolReserva, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox12_Click() Handles PictureBox12.Click
        If acao = 26 Then
            insertAcao(PictureBox12, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox13_Click() Handles PictureBox13.Click
        If acao = 26 Then
            insertAcao(PictureBox13, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox14_Click() Handles PictureBox14.Click
        If acao = 26 Then
            insertAcao(PictureBox14, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox15_Click() Handles PictureBox15.Click
        If acao = 26 Then
            insertAcao(PictureBox15, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox16_Click() Handles PictureBox16.Click
        If acao = 26 Then
            insertAcao(PictureBox16, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox17_Click() Handles PictureBox17.Click
        If acao = 26 Then
            insertAcao(PictureBox17, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox18_Click() Handles PictureBox18.Click
        If acao = 26 Then
            insertAcao(PictureBox18, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox19_Click() Handles PictureBox19.Click
        If acao = 26 Then
            insertAcao(PictureBox19, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox20_Click() Handles PictureBox20.Click
        If acao = 26 Then
            insertAcao(PictureBox20, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox21_Click() Handles PictureBox21.Click
        If acao = 26 Then
            insertAcao(PictureBox21, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub
    Private Sub PictureBox22_Click() Handles PictureBox22.Click
        If acao = 26 Then
            insertAcao(PictureBox22, Nothing)
            carregaListAcao()
        Else
            MessageBox.Show("Este jogador não pode receber esta ação.")
        End If
    End Sub

    Private Sub btnFechar_Click() Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        insertDetalhePartida()
        ResultadoPartida()
        definirEscalacaoAdv.Close()
        definirEscalacao.Close()
        Me.Close()
    End Sub

    Private Sub insertDetalhePartida()
        Using cn As SqlConnection = conexao()
            Dim sql As String
            Dim cmd As SqlCommand
            Dim da As SqlDataAdapter
            cn.Open()
            sql = "select COUNT(*) from acao"
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            Dim x As Integer = cmd.ExecuteScalar
            cn.Close()
            For codAcao As Integer = 1 To x
                cn.Open()
                sql = "insert into detalhePartida " &
                "values ((select MAX(codPartida) from partida), " &
                codAcao & " , " &
                "(select COUNT(*) from acaoPartida where codPartida = (select MAX(codPartida) from partida) and codAcao = " & codAcao & "))"
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                cmd.ExecuteReader()
                cn.Close()
            Next
        End Using
    End Sub


    Dim codClube As Integer = CadPartida.cmbTime1.SelectedValue

    Private Sub ResultadoPartida()
        If lblGPro.Text > lblGContra.Text Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update clube set vitoria = vitoria + 1 where codClube = " & codClube & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim x As Integer = cmd.ExecuteScalar
                cn.Close()
            End Using
        ElseIf lblGPro.Text = lblGContra.Text Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update clube set empate = empate + 1 where codClube = " & codClube & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim x As Integer = cmd.ExecuteScalar
                cn.Close()
            End Using
        ElseIf lblGPro.Text < lblGContra.Text Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update clube set derrota = derrota + 1 where codClube = " & codClube & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim x As Integer = cmd.ExecuteScalar
                cn.Close()
            End Using
        End If
    End Sub

    Private Sub PegaNomeTime()
        lblTime1.Text = definirEscalacao.lblNomeTime.Text
        lblTime2.Text = definirEscalacaoAdv.lblNomeTimeAdv.Text
    End Sub
    Private Sub carregaImagemJogSub(ByVal pbx As PictureBox, ByVal lblNomeJogador As Label)
        Using cn As SqlConnection = conexao()
            cn.Close()
            cn.Open()
            Dim sql As String = "select	jogador.apelido, jogador.imagem, posicao.nomePosicao from jogador inner join posicao on jogador.codPosicao = posicao.codPosicao where jogador.imagem = '" & pbx.ImageLocation & "'"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim mr As SqlDataReader
            mr = cmd.ExecuteReader
            While mr.Read
                lblNomeJogador.Text = mr!apelido
            End While
            cn.Close()
        End Using
    End Sub

End Class