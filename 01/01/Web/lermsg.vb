Imports System.Data.SqlClient

Public Class lermsg

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub

    Private Sub btnvisualizar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnvisualizar.Click
        consultar()
    End Sub

    Sub consultar()
        Dim da As New SqlDataAdapter
        Dim cmd As New SqlCommand
        Dim dt As New DataTable
        Dim comando As String = "select mensagem as 'Mensagem Recebida', usuario as 'Usuario', email as 'Email', assunto as 'Assunto' from mensagemWeb"

        Using cn As SqlConnection = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Open()
            cmd = New SqlCommand(comando, cn)
            cmd.ExecuteReader()
            cn.Close()

            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                dt_grid.DataSource = dt
            End With

        End Using

    End Sub

    Private Sub lermsg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dt_grid.AutoResizeRows()

    End Sub
End Class