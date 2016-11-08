Imports System.Data
Imports System.Data.SqlClient

Public Class CadJogador
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim conv_posi As Integer
    Dim caminho As String
    Dim pe As String

    Private Sub CadJogador_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregacombos()
    End Sub

    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        InsertJogador()
    End Sub

    Private Sub InsertJogador()
        Dim asd As String
        asd = txtNasc.Text.Replace("/", "")
        If txtNome.Text = "" Or txtApelido.Text = "" Or txtNasc.Text = "" Or txtPeso.Text = "" Or txtAltura.Text = "" Or cmbClube.Text = "" Or cmbNacio.Text = "" Or cmbPosicao.Text = "" Or asd = "    " Then
            MessageBox.Show("Por favor, insira as informações necessárias!")
        ElseIf Not IsNumeric(txtPeso.Text) Or Not IsNumeric(txtAltura.Text) Then
            MessageBox.Show("Por favor, insira corretamente os valores de altura e/ou peso")
        ElseIf caminho = "" Then
            MessageBox.Show("Por favor, escolha a imagem do jogador que deseja cadastrar!")
        Else
            fPe()
            cn = conexao()
            Try
                Using cn As SqlConnection = conexao()
                    Dim sql As String = "insertJogador"
                    Dim cmd As New SqlCommand
                    cmd.Connection = cn
                    cmd.CommandText = sql
                    cmd.CommandType = CommandType.StoredProcedure
                    With cmd.Parameters
                        .AddWithValue("nome", txtNome.Text)
                        .AddWithValue("apelido", txtApelido.Text)
                        .AddWithValue("dataNascimento", txtNasc.Text)
                        .AddWithValue("pePredom", pe)
                        .AddWithValue("altura", txtAltura.Text)
                        .AddWithValue("peso", txtPeso.Text)
                        .AddWithValue("imagem", caminho)
                        .AddWithValue("codClube", cmbClube.SelectedValue)
                        .AddWithValue("codPais", cmbNacio.SelectedValue)
                        .AddWithValue("codPosicao", cmbPosicao.SelectedValue)
                    End With
                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()
                End Using
            Catch ex As Exception
                MessageBox.Show("Por favor, verefique as informações")
            End Try
            MessageBox.Show("O jogador " + txtApelido.Text + " foi cadastrado com sucesso!")
            txtNome.Text = ""
            txtAltura.Text = ""
            txtApelido.Text = ""
            txtNasc.Text = ""
            txtPeso.Text = ""
            PictureBox1.Image = Nothing
            cmbClube.SelectedIndex = -1
            cmbNacio.SelectedIndex = -1
            cmbPosicao.SelectedIndex = -1
        End If
    End Sub

    Private Sub fPe()
        If rdbDireito.Checked = True Then
            pe = "D"
        Else
            pe = "E"
        End If
    End Sub

    Private Sub lklCarregarImagem_LinkClicked_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCarregarImagem.LinkClicked
        OpenFileDialog1.FileName = ""
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.Cancel Then
            caminho = "C:\Users\Dr. Carvalhaes\Pictures\TCC\ImgPadrao.jpg"
        ElseIf Windows.Forms.DialogResult.OK Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select imagem from jogador where imagem = '" & OpenFileDialog1.FileName & "'"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim x As String = cmd.ExecuteScalar
                cn.Close()
                If x <> "" Then
                    MessageBox.Show("Já existe um jogador com essa imagem. Por favor, renomeie-a ou selecione uma imagem diferente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                Else
                    caminho = OpenFileDialog1.FileName
                End If
            End Using
        End If
        PictureBox1.Image = Image.FromFile(caminho)
    End Sub

    Private Sub carregacombos()
        CarregaCombo(cmbClube, "select codClube, alcunha from clube order by alcunha asc")
        CarregaCombo(cmbPosicao, "select * from posicao")
        CarregaCombo(cmbNacio, "select codPais, pais from pais")
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class