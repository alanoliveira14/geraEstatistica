<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BackupRestore
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BackupRestore))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBack = New System.Windows.Forms.TextBox()
        Me.btnRestaura = New System.Windows.Forms.Button()
        Me.btnBackup = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRestore = New System.Windows.Forms.TextBox()
        Me.btnSalvarBack = New System.Windows.Forms.Button()
        Me.btnCarregarBack = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 99)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pasta de destino:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 165)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Localizar Arquivo:"
        '
        'txtBack
        '
        Me.txtBack.Location = New System.Drawing.Point(118, 96)
        Me.txtBack.Name = "txtBack"
        Me.txtBack.Size = New System.Drawing.Size(370, 20)
        Me.txtBack.TabIndex = 2
        '
        'btnRestaura
        '
        Me.btnRestaura.ForeColor = System.Drawing.Color.Black
        Me.btnRestaura.Location = New System.Drawing.Point(554, 151)
        Me.btnRestaura.Name = "btnRestaura"
        Me.btnRestaura.Size = New System.Drawing.Size(75, 40)
        Me.btnRestaura.TabIndex = 4
        Me.btnRestaura.Text = "Restaurar"
        Me.btnRestaura.UseVisualStyleBackColor = True
        '
        'btnBackup
        '
        Me.btnBackup.ForeColor = System.Drawing.Color.Black
        Me.btnBackup.Location = New System.Drawing.Point(554, 85)
        Me.btnBackup.Name = "btnBackup"
        Me.btnBackup.Size = New System.Drawing.Size(75, 40)
        Me.btnBackup.TabIndex = 5
        Me.btnBackup.Text = "Backup"
        Me.btnBackup.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.ForeColor = System.Drawing.Color.Black
        Me.RadioButton1.Location = New System.Drawing.Point(8, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton1.TabIndex = 7
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Backup"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.ForeColor = System.Drawing.Color.Black
        Me.RadioButton2.Location = New System.Drawing.Point(109, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(62, 17)
        Me.RadioButton2.TabIndex = 8
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Restore"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(221, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 48)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'txtRestore
        '
        Me.txtRestore.Location = New System.Drawing.Point(118, 162)
        Me.txtRestore.Name = "txtRestore"
        Me.txtRestore.Size = New System.Drawing.Size(370, 20)
        Me.txtRestore.TabIndex = 9
        '
        'btnSalvarBack
        '
        Me.btnSalvarBack.Image = CType(resources.GetObject("btnSalvarBack.Image"), System.Drawing.Image)
        Me.btnSalvarBack.Location = New System.Drawing.Point(509, 92)
        Me.btnSalvarBack.Name = "btnSalvarBack"
        Me.btnSalvarBack.Size = New System.Drawing.Size(39, 27)
        Me.btnSalvarBack.TabIndex = 10
        Me.btnSalvarBack.Text = resources.GetString("btnSalvarBack.Text")
        Me.btnSalvarBack.UseVisualStyleBackColor = True
        '
        'btnCarregarBack
        '
        Me.btnCarregarBack.Image = CType(resources.GetObject("btnCarregarBack.Image"), System.Drawing.Image)
        Me.btnCarregarBack.Location = New System.Drawing.Point(509, 158)
        Me.btnCarregarBack.Name = "btnCarregarBack"
        Me.btnCarregarBack.Size = New System.Drawing.Size(39, 27)
        Me.btnCarregarBack.TabIndex = 11
        Me.btnCarregarBack.Text = resources.GetString("btnCarregarBack.Text")
        Me.btnCarregarBack.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Location = New System.Drawing.Point(554, 241)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(75, 40)
        Me.btnFechar.TabIndex = 12
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = True
        '
        'BackupRestore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 293)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCarregarBack)
        Me.Controls.Add(Me.btnSalvarBack)
        Me.Controls.Add(Me.txtRestore)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnBackup)
        Me.Controls.Add(Me.btnRestaura)
        Me.Controls.Add(Me.txtBack)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "BackupRestore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BackupRestore"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBack As System.Windows.Forms.TextBox
    Friend WithEvents btnRestaura As System.Windows.Forms.Button
    Friend WithEvents btnBackup As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtRestore As System.Windows.Forms.TextBox
    Friend WithEvents btnSalvarBack As System.Windows.Forms.Button
    Friend WithEvents btnCarregarBack As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
