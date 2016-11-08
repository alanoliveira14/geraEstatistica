<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadTecnico
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
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.cmbNacio = New System.Windows.Forms.ComboBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtApelido
        '
        Me.txtApelido.Location = New System.Drawing.Point(145, 91)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(121, 20)
        Me.txtApelido.TabIndex = 41
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(145, 65)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(121, 20)
        Me.txtNome.TabIndex = 40
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 94)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 37
        Me.Label11.Text = "Apelido:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 31
        Me.Label5.Text = "Data de nascimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Nacionalidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Nome:"
        '
        'txtNasc
        '
        Me.txtNasc.Location = New System.Drawing.Point(145, 146)
        Me.txtNasc.Mask = "00/00/0000"
        Me.txtNasc.Name = "txtNasc"
        Me.txtNasc.Size = New System.Drawing.Size(121, 20)
        Me.txtNasc.TabIndex = 49
        Me.txtNasc.ValidatingType = GetType(Date)
        '
        'btnConf
        '
        Me.btnConf.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConf.Location = New System.Drawing.Point(293, 82)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(86, 67)
        Me.btnConf.TabIndex = 50
        Me.btnConf.Text = "Confirma"
        Me.btnConf.UseVisualStyleBackColor = False
        '
        'cmbNacio
        '
        Me.cmbNacio.FormattingEnabled = True
        Me.cmbNacio.Location = New System.Drawing.Point(145, 120)
        Me.cmbNacio.Name = "cmbNacio"
        Me.cmbNacio.Size = New System.Drawing.Size(121, 21)
        Me.cmbNacio.TabIndex = 51
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(396, 82)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 67)
        Me.btnFechar.TabIndex = 52
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(165, 15)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "CADASTRO DE TÉCNICO"
        '
        'CadTecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 210)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.cmbNacio)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.txtNasc)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadTecnico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadTecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtApelido As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents cmbNacio As System.Windows.Forms.ComboBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
