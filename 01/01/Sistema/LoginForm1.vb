Imports System.Data.SqlClient

Public Class LoginForm1
    Public nvlAcesso As Integer
    Public Acesso As String
    Public a As String
    Public mr As SqlDataReader
    Public cmd As New SqlCommand
    Public cn As New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        If txtusu.Text = "" Or txtSenha.Text = "" Then
            MessageBox.Show("DIGITA OS BAGUIU TIO!")
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select codCargo from login1 where id =  '" & txtusu.Text & "' COLLATE sql_latin1_general_cp1_cs_as and senha = '" & txtSenha.Text & "' COLLATE sql_latin1_general_cp1_cs_as"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim z As String
                z = cmd.ExecuteScalar
                a = z
            End Using
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "select * from login1 where id =  '" & txtusu.Text & "' COLLATE sql_latin1_general_cp1_cs_as and senha= '" & txtSenha.Text & "' COLLATE sql_latin1_general_cp1_cs_as"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            If mr.Read Then
                frmSistema.Show()
            Else
                MessageBox.Show("Login Errado")
                txtusu.Text = ""
                txtSenha.Text = ""
                txtusu.Focus()
            End If
            cn.Close()
        End If

    End Sub

    Private Sub txtSenha_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtSenha.KeyDown
        If e.KeyCode = Keys.Enter Then
            frmSistema.Show()
        End If
    End Sub
    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        Me.Close()
    End Sub

End Class
