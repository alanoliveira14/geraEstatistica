<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class definirEscalacaoAdv
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
        Me.lstAux2 = New System.Windows.Forms.ListBox()
        Me.lstAux = New System.Windows.Forms.ListBox()
        Me.lstSuplentes = New System.Windows.Forms.ListBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbEsqTatico = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btnRemover = New System.Windows.Forms.Button()
        Me.btnAddTitular = New System.Windows.Forms.Button()
        Me.lstJogadores = New System.Windows.Forms.ListBox()
        Me.lstTitulares = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblNomeTimeAdv = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstAux2
        '
        Me.lstAux2.FormattingEnabled = True
        Me.lstAux2.Location = New System.Drawing.Point(26, 485)
        Me.lstAux2.Name = "lstAux2"
        Me.lstAux2.Size = New System.Drawing.Size(120, 30)
        Me.lstAux2.TabIndex = 119
        '
        'lstAux
        '
        Me.lstAux.FormattingEnabled = True
        Me.lstAux.Location = New System.Drawing.Point(26, 449)
        Me.lstAux.Name = "lstAux"
        Me.lstAux.Size = New System.Drawing.Size(120, 30)
        Me.lstAux.TabIndex = 118
        '
        'lstSuplentes
        '
        Me.lstSuplentes.FormattingEnabled = True
        Me.lstSuplentes.Location = New System.Drawing.Point(452, 317)
        Me.lstSuplentes.Name = "lstSuplentes"
        Me.lstSuplentes.Size = New System.Drawing.Size(163, 108)
        Me.lstSuplentes.TabIndex = 116
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(208, 63)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(136, 13)
        Me.Label10.TabIndex = 115
        Me.Label10.Text = "Esquema Tático Inicial"
        '
        'cmbEsqTatico
        '
        Me.cmbEsqTatico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbEsqTatico.ForeColor = System.Drawing.Color.Black
        Me.cmbEsqTatico.FormattingEnabled = True
        Me.cmbEsqTatico.Location = New System.Drawing.Point(211, 85)
        Me.cmbEsqTatico.Name = "cmbEsqTatico"
        Me.cmbEsqTatico.Size = New System.Drawing.Size(133, 21)
        Me.cmbEsqTatico.TabIndex = 114
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(45, 5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(121, 124)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 113
        Me.PictureBox1.TabStop = False
        '
        'btnRemover
        '
        Me.btnRemover.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnRemover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnRemover.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRemover.ForeColor = System.Drawing.Color.Black
        Me.btnRemover.Location = New System.Drawing.Point(282, 247)
        Me.btnRemover.Name = "btnRemover"
        Me.btnRemover.Size = New System.Drawing.Size(75, 48)
        Me.btnRemover.TabIndex = 112
        Me.btnRemover.Text = "Remover"
        Me.btnRemover.UseVisualStyleBackColor = False
        '
        'btnAddTitular
        '
        Me.btnAddTitular.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAddTitular.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAddTitular.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTitular.ForeColor = System.Drawing.Color.Black
        Me.btnAddTitular.Location = New System.Drawing.Point(282, 182)
        Me.btnAddTitular.Name = "btnAddTitular"
        Me.btnAddTitular.Size = New System.Drawing.Size(75, 43)
        Me.btnAddTitular.TabIndex = 111
        Me.btnAddTitular.Text = "Adicionar Titular"
        Me.btnAddTitular.UseVisualStyleBackColor = False
        '
        'lstJogadores
        '
        Me.lstJogadores.BackColor = System.Drawing.Color.White
        Me.lstJogadores.FormattingEnabled = True
        Me.lstJogadores.Location = New System.Drawing.Point(26, 135)
        Me.lstJogadores.Name = "lstJogadores"
        Me.lstJogadores.Size = New System.Drawing.Size(163, 290)
        Me.lstJogadores.TabIndex = 110
        '
        'lstTitulares
        '
        Me.lstTitulares.FormattingEnabled = True
        Me.lstTitulares.Location = New System.Drawing.Point(452, 135)
        Me.lstTitulares.Name = "lstTitulares"
        Me.lstTitulares.Size = New System.Drawing.Size(163, 160)
        Me.lstTitulares.TabIndex = 109
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(505, 449)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 53)
        Me.Button1.TabIndex = 108
        Me.Button1.Text = "Confirmar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'lblNomeTimeAdv
        '
        Me.lblNomeTimeAdv.AutoSize = True
        Me.lblNomeTimeAdv.BackColor = System.Drawing.Color.Transparent
        Me.lblNomeTimeAdv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeTimeAdv.ForeColor = System.Drawing.Color.Black
        Me.lblNomeTimeAdv.Location = New System.Drawing.Point(231, 9)
        Me.lblNomeTimeAdv.Name = "lblNomeTimeAdv"
        Me.lblNomeTimeAdv.Size = New System.Drawing.Size(86, 13)
        Me.lblNomeTimeAdv.TabIndex = 120
        Me.lblNomeTimeAdv.Text = "nomeTimeAdv"
        '
        'definirEscalacaoAdv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(641, 523)
        Me.Controls.Add(Me.lblNomeTimeAdv)
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
        Me.Name = "definirEscalacaoAdv"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "definirEscalacaoAdv"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lstAux2 As System.Windows.Forms.ListBox
    Friend WithEvents lstAux As System.Windows.Forms.ListBox
    Friend WithEvents lstSuplentes As System.Windows.Forms.ListBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbEsqTatico As System.Windows.Forms.ComboBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btnRemover As System.Windows.Forms.Button
    Friend WithEvents btnAddTitular As System.Windows.Forms.Button
    Friend WithEvents lstJogadores As System.Windows.Forms.ListBox
    Friend WithEvents lstTitulares As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblNomeTimeAdv As System.Windows.Forms.Label
End Class
