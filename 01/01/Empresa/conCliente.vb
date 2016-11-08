Imports System.Data.SqlClient
Public Class conCliente
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
        ConsultarEmpresa.Show()
    End Sub

    Private Sub conCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from cliente where codCliente = " & cod & ""
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader

        While mr.Read
            Me.txtCEP.Text = mr!CEP
            Me.txtClub.Text = mr!clube
            Me.txtCNPJ.Text = mr!CNPJ
            Me.txtRepresen.Text = mr!representante
            Me.txtEmail.Text = mr!email
            Me.txtNum.Text = mr!numero
            Me.txtTele.Text = mr!telefone
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

    Private Sub btnAlterar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAlterar.Click
        If Me.btnAlterar.Text = "Alterar" Then
            Me.btnAlterar.Text = "Pronto"
            Me.txtCEP.Enabled = True
            Me.txtNum.Enabled = True
            Me.txtTele.Enabled = True
            Me.txtEmail.Enabled = True
            Me.txtRepresen.Enabled = True
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "update Cliente set CEP = '" & txtCEP.Text & "'," & " numero = '" & txtNum.Text & "', representante = '" & txtRepresen.Text & "', telefone = '" & txtTele.Text & "', email = '" & txtEmail.Text & "' where codCliente = " & cod & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader
                mr = cmd.ExecuteReader
                cn.Close()
            End Using
            Me.btnAlterar.Text = "Alterar"
            Me.txtCEP.Enabled = False
            Me.txtNum.Enabled = False
            Me.txtTele.Enabled = False
            Me.txtEmail.Enabled = False
            Me.txtRepresen.Enabled = False
        End If
    End Sub
End Class