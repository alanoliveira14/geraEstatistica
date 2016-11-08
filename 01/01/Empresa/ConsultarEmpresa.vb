Imports System.Data.SqlClient

Public Class ConsultarEmpresa

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable()
        dt_grid.DataSource = ""
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()

        If rdCliente.Checked Then
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select codCliente, clube, representante from cliente where clube like '%" & txtNome.Text & "%' or representante like '%" & txtNome.Text & "%'"
                .CommandType = CommandType.Text
            End With
        ElseIf rdFunc.Checked Then
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select codFunc, nomeFunc, codCargo from funcionario where nomeFunc like '%" & txtNome.Text & "%'"
                .CommandType = CommandType.Text
            End With
        ElseIf rdFunc.Checked = False And rdCliente.Checked = False Then
            MsgBox("Por favor, escolha a opção da pesquisa")
            Return
        End If


        With da
            .SelectCommand = cmd
            .Fill(dt)
            .Dispose()
            dt_grid.DataSource = dt
        End With

    End Sub

    Public codSelFromConsulta As Integer

    Private Sub dt_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_grid.CellClick
        If rdCliente.Checked Then
            codSelFromConsulta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            conCliente.cod = codSelFromConsulta
            conCliente.Show()
            Me.Hide()
        ElseIf rdFunc.Checked Then
            codSelFromConsulta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            conFuncionario.cod = codSelFromConsulta
            conFuncionario.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()

    End Sub
End Class