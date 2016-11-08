Imports System.Data.SqlClient

Public Class RatingFIFA

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        insertOverallFIFA()
        insertRating()
    End Sub

    Public codJogador As Integer

    Private Sub RatingFIFA_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtCodJogador.Text = codJogador
        Using cn As SqlConnection = conexao()
            Dim sql As String = "select imagem from jogador where codJogador = " & codJogador & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            cn.Open()
            Dim caminho As String = cmd.ExecuteScalar
            cn.Close()
            picJogador.ImageLocation = caminho
        End Using
    End Sub

    Private Sub insertOverallFIFA()
        Using cn As SqlConnection = conexao()
            Dim Sql As String = "insertOverallFIFA"
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = Sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("codJogador", txtCodJogador.Text)
                .AddWithValue("PAC", txtPAC.Text)
                .AddWithValue("DRI", txtSHO.Text)
                .AddWithValue("SHO", txtSHO.Text)
                .AddWithValue("DEF", txtDEF.Text)
                .AddWithValue("PAS", txtPAS.Text)
                .AddWithValue("PHY", txtPHY.Text)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
            MessageBox.Show("Qualidades atribuídas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Using
    End Sub

    Private Sub insertRating()
        Using cn As SqlConnection = conexao()
            Dim sql As String = "insertRating"
            Dim cmd As New SqlCommand
            cmd.Connection = cn
            cmd.CommandText = sql
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("codJogador", txtCodJogador.Text)
                .AddWithValue("PAC", txtPAC.Text)
                .AddWithValue("DRI", txtSHO.Text)
                .AddWithValue("SHO", txtSHO.Text)
                .AddWithValue("DEF", txtDEF.Text)
                .AddWithValue("PAS", txtPAS.Text)
                .AddWithValue("PHY", txtPHY.Text)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
        End Using
        MessageBox.Show("Qualidades atribuídas com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    End Sub
End Class