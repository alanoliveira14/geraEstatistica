Imports System.Data.SqlClient
Public Class contas
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Private Sub contas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboCliente()
        carregaComboFuncionario()
        grbCredito.Hide()
        grbDebito.Hide()
        cmbStatus.Items.Add("Pendente")
        cmbStatus.Items.Add("Paga")
        cmbStatus1.Items.Add("Pendente")
        cmbStatus1.Items.Add("Paga")
    End Sub

    Private Sub rdbDebito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbDebito.CheckedChanged
        grbDebito.Show()
        grbCredito.Hide()
    End Sub

    Private Sub rdbCredito_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCredito.CheckedChanged
        grbCredito.Show()
        grbDebito.Hide()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If rdbDebito.Checked And Not (txtDatEmissao.Text = "" Or txtDatVencimento.Text = "" Or txtDescricao.Text = "" Or txtValor.Text = "" Or cmbFuncionario.Text = "" Or txtDatEmissao.Text > txtDatVencimento.Text) And cmbStatus.Text = "Pendente" Then
            cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into contas (descricao, valor, dtEmissao, dtVencimento, pagara, codFuncionario) values('" &
                    txtDescricao.Text & "', '" & txtValor.Text & "','" & txtDatEmissao.Text & "','" &
                    txtDatVencimento.Text & "','" & TxtPagar.Text & "'," & cmbFuncionario.SelectedValue & ")"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            cadastroRealizado()
        ElseIf rdbDebito.Checked And Not (txtDatEmissao.Text = "" Or txtDatVencimento.Text = "" Or txtDescricao.Text = "" Or txtValor.Text = "" Or cmbFuncionario.Text = "" Or txtDatEmissao.Text > txtDatVencimento.Text) And cmbStatus1.Text = "Pendente" Then
            cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into contas (descricao, valor, dtEmissao, dtVencimento, pagara, codFuncionario) values('" & txtDescricao.Text & "', " & txtValor.Text & ",'" & txtDatEmissao.Text & "','" & txtDatVencimento.Text & "','" & TxtPagar.Text & "'," & cmbFuncionario.SelectedValue & ")"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            cadastroRealizado()
        ElseIf rdbDebito.Checked And Not (txtDatEmissao.Text = "" Or txtDatVencimento.Text = "" Or txtDescricao.Text = "" Or txtValor.Text = "" Or cmbFuncionario.Text = "" Or txtDatPagamento.Text = "" Or txtDatPagamento.Text < txtDatEmissao.Text Or txtDatEmissao.Text > txtDatVencimento.Text) Then
            cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into contas (descricao, valor, dtEmissao, dtVencimento, pagara, codFuncionario, dtPagamento) values('" & txtDescricao.Text & "', '" & txtValor.Text & "','" & txtDatEmissao.Text & "','" & txtDatVencimento.Text & "','" & TxtPagar.Text & "'," & cmbFuncionario.SelectedValue & ", '" & txtDatPagamento.Text & "')"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            cadastroRealizado()
        ElseIf rdbCredito.Checked And Not (txtDatEmissao1.Text = "" Or txtDatVencimento1.Text = "" Or txtDescricao1.Text = "" Or cmbCliente.Text = "" Or txtValor1.Text = "" Or txtDatPagamento1.Text < txtDatEmissao1.Text Or txtDatEmissao1.Text > txtDatVencimento1.Text) And cmbStatus1.Text = "" Then
            cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into contas (descricao, valor, dtEmissao, dtVencimento, codCliente) values('" & txtDescricao1.Text & "', " & txtValor1.Text & ",'" & txtDatEmissao1.Text & "','" & txtDatVencimento1.Text & "'," & cmbCliente.SelectedValue & "', '" & txtDatPagamento1.Text & "')"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            cadastroRealizado()
        ElseIf rdbCredito.Checked And Not (txtDatEmissao1.Text = "" Or txtDatVencimento1.Text = "" Or txtDescricao1.Text = "" Or cmbCliente.Text = "" Or txtValor1.Text = "" Or txtDatPagamento1.Text = "" Or txtDatPagamento1.Text < txtDatEmissao1.Text Or txtDatEmissao1.Text > txtDatVencimento1.Text) Then
            cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into contas (descricao, valor, dtEmissao, dtVencimento, codCliente, dtPagamento) values('" & txtDescricao1.Text & "', " & txtValor1.Text & ",'" & txtDatEmissao1.Text & "','" & txtDatVencimento1.Text & "'," & cmbCliente.SelectedValue & ", '" & txtDatPagamento1.Text & "')"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
            cadastroRealizado()
        ElseIf txtDatEmissao.Text > txtDatVencimento.Text Or (IsDate(txtDatPagamento) And txtDatPagamento.Text < txtDatEmissao.Text) Or txtDatEmissao1.Text > txtDatVencimento1.Text Or txtDatPagamento1.Text < txtDatEmissao1.Text Then
            MessageBox.Show("Datas inválidas")
        Else
            MessageBox.Show("Preencher todos os campos obrigatórios")
        End If

    End Sub

    Private Sub btnConsulta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConsulta.Click
        consultaConta.Show()
        Me.Close()
        consultaConta.grbConPor.Enabled = False
        consultaConta.chbCliente.Enabled = False
        consultaConta.chbPagar.Enabled = False
        consultaConta.txtCliente.Enabled = False
        consultaConta.TxtPagar.Enabled = False
        consultaConta.txtData.Enabled = False
        consultaConta.txtDescricao.Enabled = False
    End Sub
    Public Function carregaComboCliente()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from cliente"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbCliente.ValueMember = "codCliente"
                Me.cmbCliente.DisplayMember = "clube"
                Me.cmbCliente.DataSource = dt
                Me.cmbFuncionario.SelectedIndex = -1
                Me.cmbFuncionario.Text = ""
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
        Return Nothing
    End Function
    Public Function carregaComboFuncionario()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select codFunc, nomeFunc from funcionario order by nomeFunc asc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbFuncionario.ValueMember = "codFunc"
                Me.cmbFuncionario.DisplayMember = "nomeFunc"
                Me.cmbFuncionario.DataSource = dt
                Me.cmbFuncionario.SelectedIndex = -1
                Me.cmbFuncionario.Text = ""
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
        Return Nothing
    End Function
    Private Sub cadastroRealizado()
        MessageBox.Show("Cadastro feito")
        txtDatEmissao.Text = ""
        txtDatEmissao1.Text = ""
        txtDatPagamento.Text = ""
        txtDatPagamento1.Text = ""
        txtDatVencimento.Text = ""
        txtDatVencimento1.Text = ""
        txtDescricao.Text = ""
        txtDescricao1.Text = ""
        TxtPagar.Text = ""
        txtValor.Text = ""
        txtValor1.Text = ""
        cmbCliente.Text = ""
        cmbFuncionario.Text = ""
        cmbStatus.Text = ""
        cmbStatus1.Text = ""
    End Sub
    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()

    End Sub

    Private Sub cmbStatus_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStatus.SelectedIndexChanged
        
        If cmbStatus.Text = "Paga" Then
            Label5.Visible = True
            txtDatPagamento.Visible = True
        Else
            Label5.Visible = False
            txtDatPagamento.Visible = False
        End If
    End Sub

    Private Sub cmbStatus1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbStatus1.SelectedIndexChanged
        If cmbStatus1.Text = "Paga" Then
            Label14.Visible = True
            txtDatPagamento1.Visible = True
        Else
            Label14.Visible = False
            txtDatPagamento1.Visible = False
        End If
    End Sub

    Private Sub btnAtualiza_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub
End Class