Imports System.Data.SqlClient
Public Class consultaConta
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim da As New SqlDataAdapter
    Dim dt As New DataTable

    Private Sub chbDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbDebito.CheckedChanged
        If chbDebito.Checked Then
            grbConPor.Enabled = True
            chbPagar.Enabled = True
        Else
            chbPagar.Enabled = False
        End If
        If chbCredito.Checked = False And chbDebito.Checked = False Then
            grbConPor.Enabled = False
        End If
    End Sub

    Private Sub chbCredito_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCredito.CheckedChanged
        If chbCredito.Checked Then
            grbConPor.Enabled = True
            chbCliente.Enabled = True
        Else
            chbCliente.Enabled = False
        End If
        If chbCredito.Checked = False And chbDebito.Checked = False Then
            grbConPor.Enabled = False
        End If
    End Sub

    Private Sub chbCliente_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbCliente.CheckedChanged
        If chbCliente.Checked Then
            txtCliente.Enabled = True
        Else
            txtCliente.Enabled = False
        End If
    End Sub

    Private Sub chbDataVencimento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbDataVencimento.CheckedChanged
        If chbDataVencimento.Checked Then
            txtData.Enabled = True
        Else
            txtData.Enabled = False
        End If
    End Sub

    Private Sub chbPagar_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbPagar.CheckedChanged
        If chbPagar.Checked Then
            TxtPagar.Enabled = True
        Else
            TxtPagar.Enabled = False
        End If
    End Sub

    Private Sub chbDescricao_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chbDescricao.CheckedChanged
        If chbDescricao.Checked Then
            txtDescricao.Enabled = True
        Else
            txtDescricao.Enabled = False
        End If
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        contas.Show()
        Me.Close()
    End Sub

    Private Sub btnConsulta_Click() Handles btnAtualizarConta.Click
        dt_grid.DataSource = ""

        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        If Me.chbCredito.Checked = False And Me.chbDebito.Checked = False Then
            MessageBox.Show("Por favor, selecione uma opção")
        Else
            If chbCredito.Checked And chbDebito.Checked And chbDataVencimento.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, pagara, clube, dtPagamento from contas left join cliente on contas.codCliente = cliente.codCliente where contas.descricao like '%" & txtDescricao.Text & "%' and contas.dtVencimento <= '" & txtData.Text & "' and (cliente.clube like '%" & txtCliente.Text & "%' or cliente.clube is null) and (contas.pagara like '%" & TxtPagar.Text & "%' or contas.pagara is null)"
                    .CommandType = CommandType.Text
                End With
            ElseIf chbCredito.Checked And chbDebito.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, pagara, clube, dtPagamento from contas left join cliente on contas.codCliente = cliente.codCliente where contas.descricao like '%" & txtDescricao.Text & "%' and (cliente.clube like '%" & txtCliente.Text & "%' or cliente.clube is null) and (pagara like '%" & TxtPagar.Text & "%' or pagara is null)"
                    .CommandType = CommandType.Text
                End With
            ElseIf chbDebito.Checked And chbDataVencimento.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, pagara, dtPagamento from contas where descricao like '%" & txtDescricao.Text & "%' and contas.dtVencimento <= '" & txtData.Text & "' and pagara like '%" & TxtPagar.Text & "%' "
                    .CommandType = CommandType.Text
                End With

            ElseIf chbCredito.Checked And chbDataVencimento.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, clube, dtPagamento from contas inner join cliente on contas.codCliente = cliente.codCliente where contas.descricao like '%" & txtDescricao.Text & "%' and contas.dtVencimento <= '" & txtData.Text & "' and cliente.clube like '%" & txtCliente.Text & "%' "
                    .CommandType = CommandType.Text
                End With
            ElseIf chbDebito.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, pagara, dtPagamento from contas where descricao like '%" & txtDescricao.Text & "%' and pagara like '%" & TxtPagar.Text & "%' "
                    .CommandType = CommandType.Text
                End With

            ElseIf chbCredito.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, clube, dtPagamento from contas inner join cliente on contas.codCliente = cliente.codCliente where contas.descricao like '%" & txtDescricao.Text & "%' and cliente.clube like '%" & txtCliente.Text & "%' "
                    .CommandType = CommandType.Text
                End With
            End If

            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                dt_grid.DataSource = dt
            End With
        End If

    End Sub

    Public codConta As Integer
    Private Sub dt_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_grid.CellClick
        txtDatPagamento.Enabled = True
        Using cn As SqlConnection = conexao()
            cn.Open()
            codConta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            Dim cmd As New SqlCommand
            Dim mr As SqlDataReader

            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select codConta, descricao, valor, dtEmissao, dtVencimento, pagara, dtPagamento, nomeFunc, clube from contas left join cliente on contas.codCliente = cliente.codCliente inner join funcionario on contas.codFuncionario = funcionario.codFunc where contas.codConta = " & codConta
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            While mr.Read
                If Not IsDBNull(mr!dtPagamento) Then
                    txtDescricaoAlterar.Text = mr!descricao
                    txtValor.Text = mr!valor
                    txtDatVencimento.Text = mr!dtVencimento
                    txtDatPagamento.Text = mr!dtPagamento
                    txtDatPagamento.Enabled = False
                Else
                    txtDescricaoAlterar.Text = mr!descricao
                    txtValor.Text = mr!valor
                    txtDatVencimento.Text = mr!dtVencimento
                End If
            End While
            cn.Close()
            gbrAlterar.Enabled = True
        End Using
    End Sub

    Private Sub consultaConta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        grbConPor.Enabled = False
        chbCliente.Enabled = False
        chbPagar.Enabled = False
        txtCliente.Enabled = False
        TxtPagar.Enabled = False
        txtData.Enabled = False
        txtDescricao.Enabled = False
        txtDatVencimento.Enabled = False
        txtValor.Enabled = False
        txtDescricaoAlterar.Enabled = False
        gbrAlterar.Enabled = False
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        Using cn As SqlConnection = conexao()
            Dim mr As SqlDataReader
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "update contas set dtPagamento = '" & txtDatPagamento.Text & "' where codConta = " & codConta & ""
                .CommandType = CommandType.Text
                MessageBox.Show("Alteração concluida com sucesso")
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            gbrAlterar.Enabled = False
            btnConsulta_Click()
        End Using
    End Sub
End Class