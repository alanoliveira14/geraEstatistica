Imports System.Data
Imports System.Data.SqlClient

Public Class ComparaClub
    Public codClub1 As Integer
    Public codClub2 As Integer

    Private Sub ComparaClub_Load() Handles MyBase.Load
        CarregaImagem()

    End Sub

    Public Sub CarregaImagem()
        Using cn As SqlConnection = conexao()
            Dim sql As String = "select imagem from clube where codClube = " & codClub1
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            cn.Open()
            Dim z As String = cmd.ExecuteScalar
            cn.Close()
            PictureBox1.ImageLocation = z
            PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

            sql = "select imagem from clube where codClube = " & codClub2
            cmd = New SqlCommand(sql, cn)
            da = New SqlDataAdapter(cmd)
            cn.Open()
            z = cmd.ExecuteScalar
            cn.Close()
            PictureBox2.ImageLocation = z
            PictureBox2.SizeMode = PictureBoxSizeMode.Zoom

        End Using

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Comparacoes.Show()
        Me.Close()
    End Sub
End Class