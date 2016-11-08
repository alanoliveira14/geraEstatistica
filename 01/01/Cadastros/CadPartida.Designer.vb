<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadPartida
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadPartida))
        Me.cmbEtapa = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbCamp = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtHorario = New System.Windows.Forms.MaskedTextBox()
        Me.pbxEstadio = New System.Windows.Forms.PictureBox()
        Me.pbxTime2 = New System.Windows.Forms.PictureBox()
        Me.pbxTime1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbTime2 = New System.Windows.Forms.ComboBox()
        Me.cmbTime1 = New System.Windows.Forms.ComboBox()
        Me.cmbEstadio = New System.Windows.Forms.ComboBox()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCadPart = New System.Windows.Forms.Button()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.rdbMandante = New System.Windows.Forms.RadioButton()
        CType(Me.pbxEstadio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTime2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbxTime1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbEtapa
        '
        Me.cmbEtapa.FormattingEnabled = True
        Me.cmbEtapa.Location = New System.Drawing.Point(609, 66)
        Me.cmbEtapa.Name = "cmbEtapa"
        Me.cmbEtapa.Size = New System.Drawing.Size(121, 21)
        Me.cmbEtapa.TabIndex = 4
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(522, 69)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(81, 13)
        Me.Label9.TabIndex = 51
        Me.Label9.Text = "Etapa/Rodada:"
        '
        'cmbCamp
        '
        Me.cmbCamp.FormattingEnabled = True
        Me.cmbCamp.Location = New System.Drawing.Point(373, 66)
        Me.cmbCamp.Name = "cmbCamp"
        Me.cmbCamp.Size = New System.Drawing.Size(121, 21)
        Me.cmbCamp.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(297, 69)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(70, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Campeonato:"
        '
        'txtHorario
        '
        Me.txtHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHorario.Location = New System.Drawing.Point(71, 94)
        Me.txtHorario.Mask = "00:00"
        Me.txtHorario.Name = "txtHorario"
        Me.txtHorario.Size = New System.Drawing.Size(56, 23)
        Me.txtHorario.TabIndex = 1
        Me.txtHorario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtHorario.ValidatingType = GetType(Date)
        '
        'pbxEstadio
        '
        Me.pbxEstadio.Location = New System.Drawing.Point(71, 151)
        Me.pbxEstadio.Name = "pbxEstadio"
        Me.pbxEstadio.Size = New System.Drawing.Size(121, 121)
        Me.pbxEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxEstadio.TabIndex = 47
        Me.pbxEstadio.TabStop = False
        '
        'pbxTime2
        '
        Me.pbxTime2.Location = New System.Drawing.Point(609, 251)
        Me.pbxTime2.Name = "pbxTime2"
        Me.pbxTime2.Size = New System.Drawing.Size(121, 121)
        Me.pbxTime2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTime2.TabIndex = 46
        Me.pbxTime2.TabStop = False
        '
        'pbxTime1
        '
        Me.pbxTime1.Location = New System.Drawing.Point(372, 251)
        Me.pbxTime1.Name = "pbxTime1"
        Me.pbxTime1.Size = New System.Drawing.Size(121, 121)
        Me.pbxTime1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxTime1.TabIndex = 45
        Me.pbxTime1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte), True)
        Me.Label1.Location = New System.Drawing.Point(538, 298)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(21, 20)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "X"
        '
        'cmbTime2
        '
        Me.cmbTime2.FormattingEnabled = True
        Me.cmbTime2.Location = New System.Drawing.Point(609, 224)
        Me.cmbTime2.Name = "cmbTime2"
        Me.cmbTime2.Size = New System.Drawing.Size(121, 21)
        Me.cmbTime2.TabIndex = 7
        '
        'cmbTime1
        '
        Me.cmbTime1.FormattingEnabled = True
        Me.cmbTime1.Location = New System.Drawing.Point(372, 224)
        Me.cmbTime1.Name = "cmbTime1"
        Me.cmbTime1.Size = New System.Drawing.Size(121, 21)
        Me.cmbTime1.TabIndex = 6
        '
        'cmbEstadio
        '
        Me.cmbEstadio.FormattingEnabled = True
        Me.cmbEstadio.Location = New System.Drawing.Point(71, 124)
        Me.cmbEstadio.Name = "cmbEstadio"
        Me.cmbEstadio.Size = New System.Drawing.Size(121, 21)
        Me.cmbEstadio.TabIndex = 2
        '
        'txtData
        '
        Me.txtData.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtData.Location = New System.Drawing.Point(71, 67)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(77, 23)
        Me.txtData.TabIndex = 0
        Me.txtData.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(522, 227)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Confronto"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 127)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Estádio:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Horário:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Data:"
        '
        'btnCadPart
        '
        Me.btnCadPart.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadPart.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadPart.Location = New System.Drawing.Point(372, 393)
        Me.btnCadPart.Name = "btnCadPart"
        Me.btnCadPart.Size = New System.Drawing.Size(121, 67)
        Me.btnCadPart.TabIndex = 8
        Me.btnCadPart.Text = "Ir Para Partida"
        Me.btnCadPart.UseVisualStyleBackColor = False
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(609, 393)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(121, 67)
        Me.btnFechar.TabIndex = 9
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(35, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(163, 15)
        Me.Label10.TabIndex = 55
        Me.Label10.Text = "CADASTRO DE PARTIDA"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.rdbMandante)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Black
        Me.GroupBox1.Location = New System.Drawing.Point(372, 127)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 62)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Situação"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(6, 37)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Visitante"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'rdbMandante
        '
        Me.rdbMandante.AutoSize = True
        Me.rdbMandante.Location = New System.Drawing.Point(6, 14)
        Me.rdbMandante.Name = "rdbMandante"
        Me.rdbMandante.Size = New System.Drawing.Size(73, 17)
        Me.rdbMandante.TabIndex = 0
        Me.rdbMandante.TabStop = True
        Me.rdbMandante.Text = "Mandante"
        Me.rdbMandante.UseVisualStyleBackColor = True
        '
        'CadPartida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(787, 483)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.btnCadPart)
        Me.Controls.Add(Me.cmbEtapa)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmbCamp)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtHorario)
        Me.Controls.Add(Me.pbxEstadio)
        Me.Controls.Add(Me.pbxTime2)
        Me.Controls.Add(Me.pbxTime1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTime2)
        Me.Controls.Add(Me.cmbTime1)
        Me.Controls.Add(Me.cmbEstadio)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "CadPartida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadPartida"
        CType(Me.pbxEstadio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTime2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbxTime1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbEtapa As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbCamp As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtHorario As System.Windows.Forms.MaskedTextBox
    Friend WithEvents pbxEstadio As System.Windows.Forms.PictureBox
    Friend WithEvents pbxTime2 As System.Windows.Forms.PictureBox
    Friend WithEvents pbxTime1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbTime2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbTime1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbEstadio As System.Windows.Forms.ComboBox
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCadPart As System.Windows.Forms.Button
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents rdbMandante As System.Windows.Forms.RadioButton
End Class
