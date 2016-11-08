Imports System.Data.SqlClient
Public Class conFuncionario
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer

    Private Sub conFuncionario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from funcionario inner join cargo on cargo.codCargo = funcionario.codCargo where codFunc = " & cod & ""
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader

        While mr.Read
            Me.txtNome.Text = mr!nomeFunc
            Me.txtRG.Text = mr!RG
            Me.txtCPF.Text = mr!CPF
            Me.txtCEP.Text = mr!CEP
            Me.txtN.Text = mr!numero
            Me.txtSexo.Text = mr!sexo
            Me.txtNascimento.Text = mr!dataNasci
            Me.txtCargo.Text = mr!descricao
            Me.txtEmail.Text = mr!email
            Me.txtTel.Text = mr!telefone
        End While
        cn.Close()

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

    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
        ConsultarEmpresa.Show()
    End Sub

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.btnAlterar.Text = "Alterar" Then
            Me.txtNome.Enabled = False
            Me.txtNascimento.Enabled = False
            Me.txtRG.Enabled = False
            Me.txtCPF.Enabled = False
            Me.txtSexo.Enabled = False
            Me.txtCargo.Enabled = False
            '
            Me.btnAlterar.Text = "Pronto"
            Me.txtCEP.Enabled = True
            Me.txtN.Enabled = True
            'Me.txtComplemento.Enabled = True
            Me.txtTel.Enabled = True
            Me.txtEmail.Enabled = True
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update funcionario set CEP = '" & txtCEP.Text & "'," & " numero = '" & txtN.Text & "', telefone = '" & txtTel.Text & "', email = '" & txtEmail.Text & "' where codFunc = " & cod & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                cn.Close()
            End Using
            Me.btnAlterar.Text = "Alterar"
            Me.txtCEP.Enabled = False
            Me.txtN.Enabled = False
            'Me.txtComplemento.Enabled = False
            Me.txtTel.Enabled = False
            Me.txtEmail.Enabled = False
        End If
    End Sub
End Class