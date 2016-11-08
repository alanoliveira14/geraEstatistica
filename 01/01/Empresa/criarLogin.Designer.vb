<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class criarLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.txtNomeUsuario = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCadastrar
        '
        Me.btnCadastrar.Location = New System.Drawing.Point(105, 186)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(75, 39)
        Me.btnCadastrar.TabIndex = 0
        Me.btnCadastrar.Text = "Confirmar"
        Me.btnCadastrar.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.Location = New System.Drawing.Point(202, 186)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 39)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Sair"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'txtNomeUsuario
        '
        Me.txtNomeUsuario.Enabled = False
        Me.txtNomeUsuario.Location = New System.Drawing.Point(146, 82)
        Me.txtNomeUsuario.Name = "txtNomeUsuario"
        Me.txtNomeUsuario.Size = New System.Drawing.Size(100, 20)
        Me.txtNomeUsuario.TabIndex = 2
        '
        'txtSenha
        '
        Me.txtSenha.Enabled = False
        Me.txtSenha.Location = New System.Drawing.Point(146, 126)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(100, 20)
        Me.txtSenha.TabIndex = 3
        Me.txtSenha.Text = "123456"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nome de Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(102, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Senha"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cadastro de Login"
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(276, 9)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(0, 13)
        Me.lblCargo.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(186, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Código Cargo:"
        '
        'criarLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 316)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtNomeUsuario)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCadastrar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "criarLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "criarLogin"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents txtNomeUsuario As System.Windows.Forms.TextBox
    Friend WithEvents txtSenha As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents lblCargo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
