Imports System.Data.SqlClient
Public Class CadClube
    Dim caminho As String
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader

    Private Sub btnConf_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConf.Click
        Dim asd As String
        asd = txtDataFund.Text.Replace("/", "")
        If txtNome.Text = "" Or txtSigla.Text = "" Or txtAlcunha.Text = "" Or cmbTecnico.Text = "" Or cmbPais.Text = "" Or Not IsDate(txtDataFund.Text) Then
            MessageBox.Show("Por favor, preencha as informações necessárias!")
            Exit Sub
        ElseIf caminho = "" Then
            MessageBox.Show("Por favor, escolha a imagem do clube que você deseja cadastrar!")
            Exit Sub
        End If
        Try
            Using cn As SqlConnection = conexao()
                Dim sql As String = "insertClube"
                Dim cmd As New SqlCommand
                cmd.Connection = cn
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .AddWithValue("nomeCompleto", txtNome.Text)
                    .AddWithValue("alcunha", txtAlcunha.Text)
                    .AddWithValue("sigla", txtSigla.Text)
                    .AddWithValue("imagem", caminho)
                    .AddWithValue("codTecnico", cmbTecnico.SelectedValue)
                    .AddWithValue("codPais", cmbPais.SelectedValue)
                    .AddWithValue("dataFundacao", txtDataFund.Text)
                End With
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Por Favor, verefique as informações")
            Exit Sub
        End Try
        cn.Close()
        Using cn As SqlConnection = conexao()
            Dim sql As String = "insertTimeAdv"
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("nomeComp", txtNome.Text)
                .AddWithValue("alcunha", txtAlcunha.Text)
                .AddWithValue("sigla", txtSigla.Text)
                .AddWithValue("imagem", caminho)
                .AddWithValue("codPais", cmbPais.SelectedValue)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
        End Using
        MessageBox.Show("Clube cadastrado")
        txtNome.Text = ""
        txtAlcunha.Text = ""
        txtSigla.Text = ""
        cmbTecnico.SelectedIndex = -1
        cmbPais.SelectedIndex = -1
        txtDataFund.Text = ""
        PictureBox1.Image = Nothing
    End Sub

    Private Sub lklCarregarImagem_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklCarregarImagem.LinkClicked
        OpenFileDialog1.ShowDialog()
        caminho = OpenFileDialog1.FileName
        If OpenFileDialog1.FileNames.Length > 0 Then
            PictureBox1.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MsgBox("Por Favor, selecione um batata com vermelho")
        End If
    End Sub
    Private Sub CadClube_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboPais()
        carregaComboTecnico()
    End Sub

    Public Sub carregaComboTecnico()
        Dim sql As String = "SELECT * FROM TECNICO"
        CarregaCombo(cmbTecnico, sql)
    End Sub

    Public Sub carregaComboPais()
        Dim sql As String = "select codPais, pais from pais"
        CarregaCombo(cmbPais, sql)
    End Sub


    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class