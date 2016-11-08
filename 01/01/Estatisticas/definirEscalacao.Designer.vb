<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class definirEscalacao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(definirEscalacao))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lstTitulares = New System.Windows.Forms.ListBox()
        Me.lstJogadores = New System.Windows.Forms.ListBox()
        Me.btnAddTitular = New System.Windows.Forms.Button()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEsqTatico = New System.Windows.Forms.ComboBox()
        Me.lstSuplentes = New System.Windows.Forms.ListBox()
        Me.lstAux = New System.Windows.Forms.ListBox()
        Me.lstAux2 = New System.Windows.Forms.ListBox()
        Me.lblNomeTime = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(535, 456)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 53)
        Me.Button1.TabIndex = 87
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lstTitulares
        '
        Me.lstTitulares.FormattingEnabled = True
        Me.lstTitulares.Location = New System.Drawing.Point(482, 142)
        Me.lstTitulares.Name = "lstTitulares"
        Me.lstTitulares.Size = New System.Drawing.Size(163, 160)
        Me.lstTitulares.TabIndex = 89
        '
        'lstJogadores
        '
        Me.lstJogadores.BackColor = System.Drawing.Color.White
        Me.lstJogadores.FormattingEnabled = True
        Me.lstJogadores.Location = New System.Drawing.Point(56, 142)
        Me.lstJogadores.Name = "lstJogadores"
        Me.lstJogadores.Size = New System.Drawing.Size(163, 290)
        Me.lstJogadores.TabIndex = 90
        '
        'btnAddTitular
        '
        Me.btnAddTitular.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddTitular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTitular.ForeColor = System.Drawing.Color.Black
        Me.btnAddTitular.Location = New System.Drawing.Point(312, 142)
        Me.btnAddTitular.Name = "btnAddTitular"
        Me.btnAddTitular.Size = New System.Drawing.Size(75, 43)
        Me.btnAddTitular.TabIndex = 91
        Me.btnAddTitular.Text = "Adicionar Titular"
        Me.btnAddTitular.UseVisualStyleBackColor = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.Color.Black
        Me.btnRemover.Location = New System.Drawing.Point(312, 191)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 48)
        Me.btnRemover.TabIndex = 92
        Me.btnRemover.Text = "Remover Titular"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(75, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 93
        Me.PictureBox1.TabStop = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(238, 76)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 103
        Me.Label10.Text = "Esquema Tático Inicial"
        '
        'cmbEsqTatico
        '
        Me.cmbEsqTatico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEsqTatico.ForeColor = System.Drawing.Color.Black
        Me.cmbEsqTatico.FormattingEnabled = True
        Me.cmbEsqTatico.Location = New System.Drawing.Point(241, 102)
        Me.cmbEsqTatico.Name = "cmbEsqTatico"
        Me.cmbEsqTatico.Size = New System.Drawing.Size(133, 21)
        Me.cmbEsqTatico.TabIndex = 102
        '
        'lstSuplentes
        '
        Me.lstSuplentes.FormattingEnabled = True
        Me.lstSuplentes.Location = New System.Drawing.Point(482, 324)
        Me.lstSuplentes.Name = "lstSuplentes"
        Me.lstSuplentes.Size = New System.Drawing.Size(163, 108)
        Me.lstSuplentes.TabIndex = 104
        '
        'lstAux
        '
        Me.lstAux.FormattingEnabled = True
        Me.lstAux.Location = New System.Drawing.Point(56, 438)
        Me.lstAux.Name = "lstAux"
        Me.lstAux.Size = New System.Drawing.Size(163, 43)
        Me.lstAux.TabIndex = 106
        '
        'lstAux2
        '
        Me.lstAux2.FormattingEnabled = True
        Me.lstAux2.Location = New System.Drawing.Point(225, 438)
        Me.lstAux2.Name = "lstAux2"
        Me.lstAux2.Size = New System.Drawing.Size(149, 43)
        Me.lstAux2.TabIndex = 107
        '
        'lblNomeTime
        '
        Me.lblNomeTime.AutoSize = True
        Me.lblNomeTime.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeTime.ForeColor = System.Drawing.Color.Black
        Me.lblNomeTime.Location = New System.Drawing.Point(270, 12)
        Me.lblNomeTime.Name = "lblNomeTime"
        Me.lblNomeTime.Size = New System.Drawing.Size(64, 13)
        Me.lblNomeTime.TabIndex = 108
        Me.lblNomeTime.Text = "nomeTime"
        '
        'definirEscalacao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(683, 530)
        Me.Controls.Add(Me.lblNomeTime)
        Me.Controls.Add(Me.lstAux2)
        Me.Controls.Add(Me.lstAux)
        Me.Controls.Add(Me.lstSuplentes)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbEsqTatico)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnRemover)
        Me.Controls.Add(Me.btnAddTitular)
        Me.Controls.Add(Me.lstJogadores)
        Me.Controls.Add(Me.lstTitulares)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "definirEscalacao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Definir Escalação"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lstTitulares As System.Windows.Forms.ListBox
    Friend WithEvents lstJogadores As System.Windows.Forms.ListBox
    Friend WithEvents btnAddTitular As System.Windows.Forms.Button
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbEsqTatico As System.Windows.Forms.ComboBox
    Friend WithEvents lstSuplentes As System.Windows.Forms.ListBox
    Friend WithEvents lstAux As System.Windows.Forms.ListBox
    Friend WithEvents lstAux2 As System.Windows.Forms.ListBox
    Friend WithEvents lblNomeTime As System.Windows.Forms.Label
End Class
