<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadPaisECidade
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
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.GroupBoxSeleciona = New System.Windows.Forms.GroupBox()
        Me.rdbCidade = New System.Windows.Forms.RadioButton()
        Me.rdbPais = New System.Windows.Forms.RadioButton()
        Me.lblPaiscmb = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.lblCidade = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.TextBox()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.GroupBoxSeleciona.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(97, 252)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(99, 64)
        Me.btnCadastrar.TabIndex = 0
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(230, 252)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(99, 64)
        Me.btnFechar.TabIndex = 1
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'cmbPais
        '
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(266, 146)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(136, 21)
        Me.cmbPais.TabIndex = 2
        '
        'GroupBoxSeleciona
        '
        Me.GroupBoxSeleciona.Controls.Add(Me.rdbCidade)
        Me.GroupBoxSeleciona.Controls.Add(Me.rdbPais)
        Me.GroupBoxSeleciona.Location = New System.Drawing.Point(131, 12)
        Me.GroupBoxSeleciona.Name = "GroupBoxSeleciona"
        Me.GroupBoxSeleciona.Size = New System.Drawing.Size(162, 42)
        Me.GroupBoxSeleciona.TabIndex = 3
        Me.GroupBoxSeleciona.TabStop = False
        '
        'rdbCidade
        '
        Me.rdbCidade.AutoSize = True
        Me.rdbCidade.Location = New System.Drawing.Point(97, 19)
        Me.rdbCidade.Name = "rdbCidade"
        Me.rdbCidade.Size = New System.Drawing.Size(58, 17)
        Me.rdbCidade.TabIndex = 1
        Me.rdbCidade.TabStop = True
        Me.rdbCidade.Text = "Cidade"
        Me.rdbCidade.UseVisualStyleBackColor = True
        '
        'rdbPais
        '
        Me.rdbPais.AutoSize = True
        Me.rdbPais.Location = New System.Drawing.Point(6, 19)
        Me.rdbPais.Name = "rdbPais"
        Me.rdbPais.Size = New System.Drawing.Size(47, 17)
        Me.rdbPais.TabIndex = 0
        Me.rdbPais.TabStop = True
        Me.rdbPais.Text = "País"
        Me.rdbPais.UseVisualStyleBackColor = True
        '
        'lblPaiscmb
        '
        Me.lblPaiscmb.AutoSize = True
        Me.lblPaiscmb.Location = New System.Drawing.Point(228, 149)
        Me.lblPaiscmb.Name = "lblPaiscmb"
        Me.lblPaiscmb.Size = New System.Drawing.Size(32, 13)
        Me.lblPaiscmb.TabIndex = 5
        Me.lblPaiscmb.Text = "País:"
        '
        'txtCidade
        '
        Me.txtCidade.Location = New System.Drawing.Point(266, 98)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(136, 20)
        Me.txtCidade.TabIndex = 6
        '
        'lblCidade
        '
        Me.lblCidade.AutoSize = True
        Me.lblCidade.Location = New System.Drawing.Point(217, 101)
        Me.lblCidade.Name = "lblCidade"
        Me.lblCidade.Size = New System.Drawing.Size(43, 13)
        Me.lblCidade.TabIndex = 4
        Me.lblCidade.Text = "Cidade:"
        '
        'txtPais
        '
        Me.txtPais.Location = New System.Drawing.Point(67, 127)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(129, 20)
        Me.txtPais.TabIndex = 2
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Location = New System.Drawing.Point(29, 130)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(32, 13)
        Me.lblPais.TabIndex = 3
        Me.lblPais.Text = "País:"
        '
        'CadPaisECidade
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 328)
        Me.Controls.Add(Me.lblPaiscmb)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.GroupBoxSeleciona)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.lblCidade)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.cmbPais)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadPaisECidade"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadPaisECidade"
        Me.GroupBoxSeleciona.ResumeLayout(False)
        Me.GroupBoxSeleciona.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBoxSeleciona As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCidade As System.Windows.Forms.RadioButton
    Friend WithEvents rdbPais As System.Windows.Forms.RadioButton
    Friend WithEvents txtPais As System.Windows.Forms.TextBox
    Friend WithEvents lblPais As System.Windows.Forms.Label
    Friend WithEvents lblCidade As System.Windows.Forms.Label
    Friend WithEvents lblPaiscmb As System.Windows.Forms.Label
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
End Class
