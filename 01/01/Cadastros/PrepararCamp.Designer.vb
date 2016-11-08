<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrepararCamp
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
        Me.lblClube = New System.Windows.Forms.Label()
        Me.lblCamp = New System.Windows.Forms.Label()
        Me.btnCadastar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.cmbClube = New System.Windows.Forms.ComboBox()
        Me.cmbCamp = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblClube
        '
        Me.lblClube.AutoSize = True
        Me.lblClube.Location = New System.Drawing.Point(40, 120)
        Me.lblClube.Name = "lblClube"
        Me.lblClube.Size = New System.Drawing.Size(37, 13)
        Me.lblClube.TabIndex = 0
        Me.lblClube.Text = "Clube:"
        '
        'lblCamp
        '
        Me.lblCamp.AutoSize = True
        Me.lblCamp.Location = New System.Drawing.Point(7, 80)
        Me.lblCamp.Name = "lblCamp"
        Me.lblCamp.Size = New System.Drawing.Size(70, 13)
        Me.lblCamp.TabIndex = 1
        Me.lblCamp.Text = "Campeonato:"
        '
        'btnCadastar
        '
        Me.btnCadastar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastar.Location = New System.Drawing.Point(240, 204)
        Me.btnCadastar.Name = "btnCadastar"
        Me.btnCadastar.Size = New System.Drawing.Size(91, 73)
        Me.btnCadastar.TabIndex = 2
        Me.btnCadastar.Text = "Cadastrar"
        Me.btnCadastar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(343, 204)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(91, 73)
        Me.btnFechar.TabIndex = 3
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'cmbClube
        '
        Me.cmbClube.FormattingEnabled = True
        Me.cmbClube.Location = New System.Drawing.Point(83, 117)
        Me.cmbClube.Name = "cmbClube"
        Me.cmbClube.Size = New System.Drawing.Size(121, 21)
        Me.cmbClube.TabIndex = 4
        '
        'cmbCamp
        '
        Me.cmbCamp.FormattingEnabled = True
        Me.cmbCamp.Location = New System.Drawing.Point(83, 77)
        Me.cmbCamp.Name = "cmbCamp"
        Me.cmbCamp.Size = New System.Drawing.Size(121, 21)
        Me.cmbCamp.TabIndex = 5
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(298, 12)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(136, 134)
        Me.ListBox1.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 12)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(177, 15)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "PREPARAR CAMPEONATO"
        '
        'PrepararCamp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 289)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cmbCamp)
        Me.Controls.Add(Me.cmbClube)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCadastar)
        Me.Controls.Add(Me.lblCamp)
        Me.Controls.Add(Me.lblClube)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "PrepararCamp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PrepararCamp"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblClube As System.Windows.Forms.Label
    Friend WithEvents lblCamp As System.Windows.Forms.Label
    Friend WithEvents btnCadastar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents cmbClube As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCamp As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
