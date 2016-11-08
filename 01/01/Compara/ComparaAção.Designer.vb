<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComparaAção
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dtGrid = New System.Windows.Forms.DataGridView()
        Me.selTime = New System.Windows.Forms.CheckBox()
        Me.selCamp = New System.Windows.Forms.CheckBox()
        Me.cmbClube = New System.Windows.Forms.ComboBox()
        Me.cmbCamp = New System.Windows.Forms.ComboBox()
        Me.cmbAcao = New System.Windows.Forms.ComboBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.picJogador = New System.Windows.Forms.PictureBox()
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picJogador, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(24, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Ação:"
        '
        'dtGrid
        '
        Me.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid.Location = New System.Drawing.Point(23, 131)
        Me.dtGrid.Name = "dtGrid"
        Me.dtGrid.Size = New System.Drawing.Size(280, 230)
        Me.dtGrid.TabIndex = 14
        '
        'selTime
        '
        Me.selTime.AutoSize = True
        Me.selTime.Location = New System.Drawing.Point(490, 34)
        Me.selTime.Name = "selTime"
        Me.selTime.Size = New System.Drawing.Size(52, 17)
        Me.selTime.TabIndex = 13
        Me.selTime.Text = "Time:"
        Me.selTime.UseVisualStyleBackColor = True
        '
        'selCamp
        '
        Me.selCamp.AutoSize = True
        Me.selCamp.Location = New System.Drawing.Point(229, 33)
        Me.selCamp.Name = "selCamp"
        Me.selCamp.Size = New System.Drawing.Size(89, 17)
        Me.selCamp.TabIndex = 12
        Me.selCamp.Text = "Campeonato:"
        Me.selCamp.UseVisualStyleBackColor = True
        '
        'cmbClube
        '
        Me.cmbClube.FormattingEnabled = True
        Me.cmbClube.Location = New System.Drawing.Point(550, 31)
        Me.cmbClube.Name = "cmbClube"
        Me.cmbClube.Size = New System.Drawing.Size(121, 21)
        Me.cmbClube.TabIndex = 11
        '
        'cmbCamp
        '
        Me.cmbCamp.FormattingEnabled = True
        Me.cmbCamp.Location = New System.Drawing.Point(326, 32)
        Me.cmbCamp.Name = "cmbCamp"
        Me.cmbCamp.Size = New System.Drawing.Size(135, 21)
        Me.cmbCamp.TabIndex = 10
        '
        'cmbAcao
        '
        Me.cmbAcao.FormattingEnabled = True
        Me.cmbAcao.Location = New System.Drawing.Point(65, 31)
        Me.cmbAcao.Name = "cmbAcao"
        Me.cmbAcao.Size = New System.Drawing.Size(131, 21)
        Me.cmbAcao.TabIndex = 9
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(592, 395)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(85, 66)
        Me.btnVoltar.TabIndex = 19
        Me.btnVoltar.Text = "Fechar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(314, 395)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(91, 66)
        Me.btnConfirmar.TabIndex = 18
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'picJogador
        '
        Me.picJogador.Location = New System.Drawing.Point(412, 131)
        Me.picJogador.Name = "picJogador"
        Me.picJogador.Size = New System.Drawing.Size(203, 161)
        Me.picJogador.TabIndex = 22
        Me.picJogador.TabStop = False
        '
        'ComparaAção
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 473)
        Me.Controls.Add(Me.picJogador)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtGrid)
        Me.Controls.Add(Me.selTime)
        Me.Controls.Add(Me.selCamp)
        Me.Controls.Add(Me.cmbClube)
        Me.Controls.Add(Me.cmbCamp)
        Me.Controls.Add(Me.cmbAcao)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ComparaAção"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = ""
        Me.Text = "ComparaAção"
        CType(Me.dtGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picJogador, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dtGrid As System.Windows.Forms.DataGridView
    Friend WithEvents selTime As System.Windows.Forms.CheckBox
    Friend WithEvents selCamp As System.Windows.Forms.CheckBox
    Friend WithEvents cmbClube As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCamp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbAcao As System.Windows.Forms.ComboBox
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents picJogador As System.Windows.Forms.PictureBox
End Class
