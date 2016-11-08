<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadJogador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadJogador))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbEsquerdo = New System.Windows.Forms.RadioButton()
        Me.rdbDireito = New System.Windows.Forms.RadioButton()
        Me.lklCarregarImagem = New System.Windows.Forms.LinkLabel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtNasc = New System.Windows.Forms.MaskedTextBox()
        Me.cmbPosicao = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtAltura = New System.Windows.Forms.TextBox()
        Me.txtApelido = New System.Windows.Forms.TextBox()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmbNacio = New System.Windows.Forms.ComboBox()
        Me.cmbClube = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(86, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 37
        Me.Label6.Text = "Peso:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.rdbEsquerdo)
        Me.GroupBox1.Controls.Add(Me.rdbDireito)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(130, 194)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(121, 65)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pé predominante:"
        '
        'rdbEsquerdo
        '
        Me.rdbEsquerdo.AutoSize = True
        Me.rdbEsquerdo.Location = New System.Drawing.Point(6, 42)
        Me.rdbEsquerdo.Name = "rdbEsquerdo"
        Me.rdbEsquerdo.Size = New System.Drawing.Size(70, 17)
        Me.rdbEsquerdo.TabIndex = 1
        Me.rdbEsquerdo.TabStop = True
        Me.rdbEsquerdo.Text = "Esquerdo"
        Me.rdbEsquerdo.UseVisualStyleBackColor = True
        '
        'rdbDireito
        '
        Me.rdbDireito.AutoSize = True
        Me.rdbDireito.Location = New System.Drawing.Point(6, 19)
        Me.rdbDireito.Name = "rdbDireito"
        Me.rdbDireito.Size = New System.Drawing.Size(55, 17)
        Me.rdbDireito.TabIndex = 0
        Me.rdbDireito.TabStop = True
        Me.rdbDireito.Text = "Direito"
        Me.rdbDireito.UseVisualStyleBackColor = True
        '
        'lklCarregarImagem
        '
        Me.lklCarregarImagem.AutoSize = True
        Me.lklCarregarImagem.BackColor = System.Drawing.Color.Transparent
        Me.lklCarregarImagem.ForeColor = System.Drawing.SystemColors.Control
        Me.lklCarregarImagem.Location = New System.Drawing.Point(481, 267)
        Me.lklCarregarImagem.Name = "lklCarregarImagem"
        Me.lklCarregarImagem.Size = New System.Drawing.Size(87, 13)
        Me.lklCarregarImagem.TabIndex = 9
        Me.lklCarregarImagem.TabStop = True
        Me.lklCarregarImagem.Text = "Carregar Imagem"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(385, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(278, 237)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 50
        Me.PictureBox1.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label12.Location = New System.Drawing.Point(258, 171)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(19, 13)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "kg"
        '
        'txtNasc
        '
        Me.txtNasc.Location = New System.Drawing.Point(130, 116)
        Me.txtNasc.Mask = "00/00/0000"
        Me.txtNasc.Name = "txtNasc"
        Me.txtNasc.Size = New System.Drawing.Size(66, 20)
        Me.txtNasc.TabIndex = 3
        Me.txtNasc.ValidatingType = GetType(Date)
        '
        'cmbPosicao
        '
        Me.cmbPosicao.FormattingEnabled = True
        Me.cmbPosicao.Location = New System.Drawing.Point(130, 282)
        Me.cmbPosicao.Name = "cmbPosicao"
        Me.cmbPosicao.Size = New System.Drawing.Size(121, 21)
        Me.cmbPosicao.TabIndex = 7
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label9.Location = New System.Drawing.Point(258, 145)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 13)
        Me.Label9.TabIndex = 46
        Me.Label9.Text = "cm"
        '
        'btnConf
        '
        Me.btnConf.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConf.ForeColor = System.Drawing.Color.Black
        Me.btnConf.Location = New System.Drawing.Point(464, 351)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(91, 67)
        Me.btnConf.TabIndex = 10
        Me.btnConf.Text = "Confirmar"
        Me.btnConf.UseVisualStyleBackColor = False
        '
        'txtPeso
        '
        Me.txtPeso.Location = New System.Drawing.Point(130, 168)
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(121, 20)
        Me.txtPeso.TabIndex = 5
        '
        'txtAltura
        '
        Me.txtAltura.Location = New System.Drawing.Point(130, 142)
        Me.txtAltura.Name = "txtAltura"
        Me.txtAltura.Size = New System.Drawing.Size(121, 20)
        Me.txtAltura.TabIndex = 4
        '
        'txtApelido
        '
        Me.txtApelido.Location = New System.Drawing.Point(130, 64)
        Me.txtApelido.Name = "txtApelido"
        Me.txtApelido.Size = New System.Drawing.Size(149, 20)
        Me.txtApelido.TabIndex = 1
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(130, 38)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(149, 20)
        Me.txtNome.TabIndex = 0
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label11.Location = New System.Drawing.Point(75, 67)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 39
        Me.Label11.Text = "Apelido:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(72, 285)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Posição:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(83, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(37, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Altura:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(15, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Data de nascimento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(42, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Nacionalidade:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(82, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nome:"
        '
        'cmbNacio
        '
        Me.cmbNacio.FormattingEnabled = True
        Me.cmbNacio.Location = New System.Drawing.Point(130, 90)
        Me.cmbNacio.Name = "cmbNacio"
        Me.cmbNacio.Size = New System.Drawing.Size(147, 21)
        Me.cmbNacio.TabIndex = 2
        '
        'cmbClube
        '
        Me.cmbClube.FormattingEnabled = True
        Me.cmbClube.Location = New System.Drawing.Point(131, 309)
        Me.cmbClube.Name = "cmbClube"
        Me.cmbClube.Size = New System.Drawing.Size(121, 21)
        Me.cmbClube.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(83, 312)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 53
        Me.Label2.Text = "Clube:"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.ForeColor = System.Drawing.Color.Black
        Me.btnFechar.Location = New System.Drawing.Point(570, 351)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 67)
        Me.btnFechar.TabIndex = 11
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(25, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(171, 15)
        Me.Label4.TabIndex = 56
        Me.Label4.Text = "CADASTRO DE JOGADOR"
        '
        'CadJogador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(675, 430)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.cmbClube)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbNacio)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lklCarregarImagem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtNasc)
        Me.Controls.Add(Me.cmbPosicao)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtPeso)
        Me.Controls.Add(Me.txtAltura)
        Me.Controls.Add(Me.txtApelido)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "CadJogador"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cadastro de Jogador"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbEsquerdo As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDireito As System.Windows.Forms.RadioButton
    Friend WithEvents lklCarregarImagem As System.Windows.Forms.LinkLabel
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtNasc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbPosicao As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents txtPeso As System.Windows.Forms.TextBox
    Friend WithEvents txtAltura As System.Windows.Forms.TextBox
    Friend WithEvents txtApelido As System.Windows.Forms.TextBox
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbNacio As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClube As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
