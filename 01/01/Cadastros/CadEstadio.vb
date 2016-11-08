Imports System.Data.SqlClient
Public Class CadEstadio
    Dim caminho As String
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader

    Private Sub CadEstadio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
        carregaComboCidade()
        carregaComboClube()
    End Sub

    Private Sub linkImagem_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles linkImagem.LinkClicked
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.ShowDialog()
        caminho = OpenFileDialog1.FileName
        If OpenFileDialog1.FileNames.Length > 0 Then
            pictEstadio.Image = Image.FromFile(OpenFileDialog1.FileName)
        Else
            MsgBox("Por Favor, selecione um batata com vermelho")
        End If
    End Sub

    Public Sub carregaComboCidade()
        Dim sql As String = "select * from cidade"
        CarregaCombo(cmbCidade, sql)
    End Sub

    Public Sub carregaComboClube()
        Dim sql As String = "select * from clube"
        CarregaCombo(cmbClube, sql)
    End Sub


    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If Me.txtNome.Text = "" Or cmbCidade.Text = "" Or cmbClube.Text = "" Or caminho = "" Then
            MessageBox.Show("Por Favor, preencha as informações necessárias!")
            Exit Sub
        Else
            cn = conexao()
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = "insertEstadio"
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("nome", txtNome.Text)
                .AddWithValue("codClube", cmbClube.SelectedValue)
                .AddWithValue("imagem", caminho)
                .AddWithValue("codCidade", cmbCidade.SelectedValue)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
            MsgBox("Estádio cadastrado")
        End If
    End Sub

    Private Sub btnFechar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class