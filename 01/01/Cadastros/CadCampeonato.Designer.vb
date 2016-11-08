<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadCampeonato
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
        Me.txtNomeCamp = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CmbModoDisp = New System.Windows.Forms.ComboBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtNomeCamp
        '
        Me.txtNomeCamp.Location = New System.Drawing.Point(131, 47)
        Me.txtNomeCamp.Name = "txtNomeCamp"
        Me.txtNomeCamp.Size = New System.Drawing.Size(145, 20)
        Me.txtNomeCamp.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Nome do Campeonato:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Modo de Disputa:"
        '
        'CmbModoDisp
        '
        Me.CmbModoDisp.FormattingEnabled = True
        Me.CmbModoDisp.Location = New System.Drawing.Point(131, 103)
        Me.CmbModoDisp.Name = "CmbModoDisp"
        Me.CmbModoDisp.Size = New System.Drawing.Size(145, 21)
        Me.CmbModoDisp.TabIndex = 4
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(131, 173)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(93, 67)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(246, 173)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 67)
        Me.btnFechar.TabIndex = 6
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(199, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "CADASTRO DE CAMPEONATO"
        '
        'CadCampeonato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(360, 252)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.CmbModoDisp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtNomeCamp)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadCampeonato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadCampeonato"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNomeCamp As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CmbModoDisp As System.Windows.Forms.ComboBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
