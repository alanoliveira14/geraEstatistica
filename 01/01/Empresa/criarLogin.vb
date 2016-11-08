Imports System.Data.SqlClient
Public Class criarLogin
    Dim Cod As Integer
    Dim CdFunc As Integer
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub criarLogin_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Using cn As SqlConnection = conexao()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select MAX(codFunc) from funcionario"
                .CommandType = CommandType.Text
            End With
            CdFunc = cmd.ExecuteScalar
            cn.Close()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select nomeFunc from funcionario where codFunc = " & CdFunc & ""
                .CommandType = CommandType.Text
            End With
            Dim nomeFunc As String = cmd.ExecuteScalar
            cn.Close()
            Dim newNomeFunc As String = nomeFunc.Substring(0, nomeFunc.IndexOf(" "))
            txtNomeUsuario.Text = newNomeFunc & "_" & CdFunc
        End Using
        lblCargo.Text = cadFuncionario.codCargo
    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Using cn As SqlConnection = conexao()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into login1 (id, senha,codCargo) values ( '" & txtNomeUsuario.Text & "', '" & txtSenha.Text & "', '" & lblCargo.Text & "')"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
        End Using
        MsgBox("Login Cadastrado")
        cadFuncionario.Show()
        Me.Close()
    End Sub

End Class