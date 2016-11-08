Imports System.Data.SqlClient

Public Class BackupRestore

    Private Sub btnSalvarBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalvarBack.Click
        Dim caixa As SaveFileDialog = New SaveFileDialog
        caixa.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            Me.txtBack.Text = caixa.FileName
        Else
            Me.txtBack.Text = ""
        End If
    End Sub

    Private Sub btnCarregarBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCarregarBack.Click
        Dim caixa As OpenFileDialog = New OpenFileDialog
        caixa.Filter = ("Backup Files (*.bak)|*.bak| All Files (*.*)|*.*")
        caixa.ShowDialog()
        If Windows.Forms.DialogResult.OK Then
            Me.txtRestore.Text = caixa.FileName
        Else
            Me.txtRestore.Text = ""
        End If
    End Sub

    Private Sub btnBackup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBackup.Click
        If txtBack.Text = "" Then
            MessageBox.Show("Por favor, selecione o caminho do BACKUP")
        Else
            Dim cn As SqlConnection = New SqlConnection("server=(local);uid=sa;pwd=123456;database=Master")
            Try
                ' comando para fazer o backup do Banco de dados
                Dim cmdBackup As New SqlCommand("BACKUP DATABASE [bdAgencia1] TO DISK = '" & Me.txtBack.Text & ".bak' WITH INIT", cn)
                cn.Open()
                cmdBackup.ExecuteNonQuery()
            Finally
                cn.Close()
                MessageBox.Show("Backup feito com sucesso")
            End Try
        End If
    End Sub

    Private Sub RadioButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton1.Click
        Me.txtRestore.Enabled = False
        Me.btnCarregarBack.Enabled = False
        Me.btnRestaura.Enabled = False
        Me.txtRestore.Text = ""

        Me.txtBack.Enabled = True
        Me.btnSalvarBack.Enabled = True
        Me.btnBackup.Enabled = True
    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click
        Me.txtBack.Enabled = False
        Me.btnSalvarBack.Enabled = False
        Me.btnBackup.Enabled = False
        txtBack.Text = ""
        Me.txtRestore.Enabled = True
        Me.btnCarregarBack.Enabled = True
        Me.btnRestaura.Enabled = True

    End Sub

    Private Sub BackupRestore_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.txtBack.Enabled = False
        Me.btnSalvarBack.Enabled = False
        Me.btnBackup.Enabled = False
        Me.txtRestore.Enabled = False
        Me.btnCarregarBack.Enabled = False
        Me.btnRestaura.Enabled = False

    End Sub

    Private Sub btnRestaura_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRestaura.Click
        If Me.txtRestore.Text = "" Then
            MessageBox.Show("Por favor, insira o local do arquivo")
        Else
            Dim cn As SqlConnection = New SqlConnection("server=(local);uid=sa;pwd=123456;database=Master")
            cn.Close()
            cn.Open()
            Try
                Dim comando As String = "restores '" & txtRestore.Text & "'"
                Dim cmdBackup As SqlCommand = New SqlCommand(comando, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmdBackup)
                cmdBackup.ExecuteReader()
            Finally
                cn.Close()
                MessageBox.Show("Restauração feita com sucesso")
            End Try
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()

    End Sub
End Class