<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lermsg
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
        Me.dt_grid = New System.Windows.Forms.DataGridView()
        Me.btnvisualizar = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dt_grid
        '
        Me.dt_grid.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid.Location = New System.Drawing.Point(12, 12)
        Me.dt_grid.Name = "dt_grid"
        Me.dt_grid.Size = New System.Drawing.Size(809, 228)
        Me.dt_grid.TabIndex = 0
        '
        'btnvisualizar
        '
        Me.btnvisualizar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnvisualizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnvisualizar.Location = New System.Drawing.Point(604, 285)
        Me.btnvisualizar.Name = "btnvisualizar"
        Me.btnvisualizar.Size = New System.Drawing.Size(94, 63)
        Me.btnvisualizar.TabIndex = 1
        Me.btnvisualizar.Text = "Visualizar Mensagens "
        Me.btnvisualizar.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(727, 285)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(94, 63)
        Me.btnFechar.TabIndex = 2
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'lermsg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(848, 360)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnvisualizar)
        Me.Controls.Add(Me.dt_grid)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "lermsg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "lermsg"
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dt_grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnvisualizar As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
