<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsuPartida
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
        Me.selData = New System.Windows.Forms.CheckBox()
        Me.selCamp = New System.Windows.Forms.CheckBox()
        Me.selRodada = New System.Windows.Forms.CheckBox()
        Me.selTime = New System.Windows.Forms.CheckBox()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbCamp = New System.Windows.Forms.ComboBox()
        Me.cmbTime1 = New System.Windows.Forms.ComboBox()
        Me.cmbTime2 = New System.Windows.Forms.ComboBox()
        Me.cmbRodada = New System.Windows.Forms.ComboBox()
        Me.dtGrid1 = New System.Windows.Forms.DataGridView()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'selData
        '
        Me.selData.AutoSize = True
        Me.selData.Location = New System.Drawing.Point(26, 64)
        Me.selData.Name = "selData"
        Me.selData.Size = New System.Drawing.Size(52, 17)
        Me.selData.TabIndex = 0
        Me.selData.Text = "Data:"
        Me.selData.UseVisualStyleBackColor = True
        '
        'selCamp
        '
        Me.selCamp.AutoSize = True
        Me.selCamp.Location = New System.Drawing.Point(26, 90)
        Me.selCamp.Name = "selCamp"
        Me.selCamp.Size = New System.Drawing.Size(89, 17)
        Me.selCamp.TabIndex = 1
        Me.selCamp.Text = "Campeonato:"
        Me.selCamp.UseVisualStyleBackColor = True
        '
        'selRodada
        '
        Me.selRodada.AutoSize = True
        Me.selRodada.Location = New System.Drawing.Point(26, 117)
        Me.selRodada.Name = "selRodada"
        Me.selRodada.Size = New System.Drawing.Size(100, 17)
        Me.selRodada.TabIndex = 2
        Me.selRodada.Text = "Rodada/Etapa:"
        Me.selRodada.UseVisualStyleBackColor = True
        '
        'selTime
        '
        Me.selTime.AutoSize = True
        Me.selTime.Location = New System.Drawing.Point(433, 64)
        Me.selTime.Name = "selTime"
        Me.selTime.Size = New System.Drawing.Size(57, 17)
        Me.selTime.TabIndex = 3
        Me.selTime.Text = "Times:"
        Me.selTime.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(522, 332)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(82, 66)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(768, 332)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 66)
        Me.btnVoltar.TabIndex = 6
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.Location = New System.Drawing.Point(649, 332)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(75, 66)
        Me.btnLimpar.TabIndex = 7
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(661, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(25, 29)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "x"
        '
        'cmbCamp
        '
        Me.cmbCamp.FormattingEnabled = True
        Me.cmbCamp.Location = New System.Drawing.Point(131, 88)
        Me.cmbCamp.Name = "cmbCamp"
        Me.cmbCamp.Size = New System.Drawing.Size(121, 21)
        Me.cmbCamp.TabIndex = 10
        '
        'cmbTime1
        '
        Me.cmbTime1.FormattingEnabled = True
        Me.cmbTime1.Location = New System.Drawing.Point(496, 62)
        Me.cmbTime1.Name = "cmbTime1"
        Me.cmbTime1.Size = New System.Drawing.Size(121, 21)
        Me.cmbTime1.TabIndex = 11
        '
        'cmbTime2
        '
        Me.cmbTime2.FormattingEnabled = True
        Me.cmbTime2.Location = New System.Drawing.Point(722, 62)
        Me.cmbTime2.Name = "cmbTime2"
        Me.cmbTime2.Size = New System.Drawing.Size(121, 21)
        Me.cmbTime2.TabIndex = 12
        '
        'cmbRodada
        '
        Me.cmbRodada.FormattingEnabled = True
        Me.cmbRodada.Location = New System.Drawing.Point(131, 115)
        Me.cmbRodada.Name = "cmbRodada"
        Me.cmbRodada.Size = New System.Drawing.Size(121, 21)
        Me.cmbRodada.TabIndex = 14
        '
        'dtGrid1
        '
        Me.dtGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtGrid1.Location = New System.Drawing.Point(26, 173)
        Me.dtGrid1.Name = "dtGrid1"
        Me.dtGrid1.Size = New System.Drawing.Size(451, 254)
        Me.dtGrid1.TabIndex = 19
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(131, 61)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(79, 20)
        Me.txtData.TabIndex = 20
        Me.txtData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(163, 15)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "CONSULTA DE PARTIDA"
        '
        'ConsuPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(860, 439)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.dtGrid1)
        Me.Controls.Add(Me.cmbRodada)
        Me.Controls.Add(Me.cmbTime2)
        Me.Controls.Add(Me.cmbTime1)
        Me.Controls.Add(Me.cmbCamp)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.selTime)
        Me.Controls.Add(Me.selRodada)
        Me.Controls.Add(Me.selCamp)
        Me.Controls.Add(Me.selData)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsuPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsuPartida"
        CType(Me.dtGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents selData As System.Windows.Forms.CheckBox
    Friend WithEvents selCamp As System.Windows.Forms.CheckBox
    Friend WithEvents selRodada As System.Windows.Forms.CheckBox
    Friend WithEvents selTime As System.Windows.Forms.CheckBox
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbCamp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTime1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTime2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbRodada As System.Windows.Forms.ComboBox
    Friend WithEvents dtGrid1 As System.Windows.Forms.DataGridView
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
