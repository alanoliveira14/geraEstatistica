Imports System.Data.SqlClient
Public Class cadFuncionario
    Public CadFunc As String
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim recebeCPF As Integer
    Public codCargo As Integer
    Private Sub cadFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtSalario.Focus()

        txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtRua.Enabled = False
        txtUF.Enabled = False
        carregaComboCargo()
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cep As String
        cep = txtCEP.Text
        If cep.Length = 9 Then
            cep = txtCEP.Text.Substring(0, 5) + txtCEP.Text.Substring(6, 3)
        End If

        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()

        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from logradouros where CEP = " & cep & ""
            .CommandType = CommandType.Text
        End With

        mr = cmd.ExecuteReader
        While mr.Read
            txtBairro.Text = mr!Bairro
            txtCidade.Text = mr!Cidade
            txtRua.Text = mr!Descricao
            txtUF.Text = mr!UF
        End While

        If txtCEP.Text = "" Then
            MsgBox("Por favor , digite o cep", MsgBoxStyle.Critical)
        End If
    End Sub
    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Dim sexo As String
        If SexoM.Checked Then
            sexo = "M"
        ElseIf SexoF.Checked Then
            sexo = "F"
        End If
        If txtNasci.Text = "" Then
            MsgBox("Digite a data de  Nascimento")
        End If
        If recebeCPF = 1 Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into funcionario (nomeFunc, RG, CPF, Sexo, Numero, CEP, Telefone, Email, Salario, dataNasci, codCargo) values ( '" & txtNome.Text & "', '" & txtRG.Text & "','" & txtCPF.Text & "','" & sexo & "', '" & txtN.Text & "', '" & txtCEP.Text & "','" & txtTel.Text & "','" & txtEmail.Text & "','" & txtSalario.Text & "','" & txtNasci.Text & "', '" & cmbCargo.SelectedValue & "')"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                cn.Close()
            End Using
        Else : validacao.validarCPF(txtCPF.Text)
            If validacao.validarCPF(txtCPF.Text) = True Then
                cn.Close()
                cn.Open()
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "insert into funcionario (nomeFunc, RG, CPF, Sexo, Numero, CEP, Telefone, Email, Salario, dataNasci, codCargo) values ( '" & txtNome.Text & "', '" & txtRG.Text & "','" & txtCPF.Text & "','" & sexo & "', '" & txtN.Text & "', '" & txtCEP.Text & "','" & txtTel.Text & "','" & txtEmail.Text & "','" & txtSalario.Text & "','" & txtNasci.Text & "', '" & cmbCargo.SelectedValue & "')"
                    .CommandType = CommandType.Text
                End With
                mr = cmd.ExecuteReader
                cn.Close()
            ElseIf validacao.validarCPF(txtCPF.Text) = False Then
                MsgBox("CPF INVÁLIDO, CORRIJA")
                Return
            End If
        End If

        codCargo = cmbCargo.SelectedValue
        If rdbSim.Checked = False And rdbNao.Checked = False Then
            MsgBox("Escolha se é necessário Login")
            Return
        ElseIf rdbNao.Checked Then
            MsgBox("Cadastro Realizado")
            Me.Close()
        ElseIf rdbSim.Checked Then
            criarLogin.Show()
            Me.Close()
        End If
        cn.Close()


    End Sub

    Public Function carregaComboCargo()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select codCargo, descricao from cargo"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbCargo.ValueMember = "codCargo"
                Me.cmbCargo.DisplayMember = "descricao"
                Me.cmbCargo.DataSource = dt
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
        Return Nothing
    End Function


    Private Sub btnBuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        validacao.validarCPF(txtCPF.Text)
        If validacao.validarCPF(txtCPF.Text) = False Then
            MessageBox.Show("CPF INVÁLIDO!")
        ElseIf validacao.validarCPF(txtCPF.Text) = True Then
            MessageBox.Show("CPF ACEITO")
            recebeCPF = 1
        End If

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

End Class