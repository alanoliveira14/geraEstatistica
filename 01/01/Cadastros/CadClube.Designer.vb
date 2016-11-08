<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadClube
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.txtAlcunha = New System.Windows.Forms.TextBox()
        Me.txtSigla = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lklCarregarImagem = New System.Windows.Forms.LinkLabel()
        Me.btnConf = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbTecnico = New System.Windows.Forms.ComboBox()
        Me.cmbPais = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDataFund = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(73, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 93)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alcunha:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(78, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(33, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Sigla:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(62, 172)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Técnico:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(117, 50)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(121, 20)
        Me.txtNome.TabIndex = 1
        '
        'txtAlcunha
        '
        Me.txtAlcunha.Location = New System.Drawing.Point(117, 93)
        Me.txtAlcunha.Name = "txtAlcunha"
        Me.txtAlcunha.Size = New System.Drawing.Size(121, 20)
        Me.txtAlcunha.TabIndex = 2
        '
        'txtSigla
        '
        Me.txtSigla.Location = New System.Drawing.Point(117, 131)
        Me.txtSigla.MaxLength = 3
        Me.txtSigla.Name = "txtSigla"
        Me.txtSigla.Size = New System.Drawing.Size(121, 20)
        Me.txtSigla.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.PictureBox1.Location = New System.Drawing.Point(295, 11)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(321, 250)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 10
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.WaitOnLoad = True
        '
        'lklCarregarImagem
        '
        Me.lklCarregarImagem.AutoSize = True
        Me.lklCarregarImagem.Location = New System.Drawing.Point(412, 264)
        Me.lklCarregarImagem.Name = "lklCarregarImagem"
        Me.lklCarregarImagem.Size = New System.Drawing.Size(87, 13)
        Me.lklCarregarImagem.TabIndex = 6
        Me.lklCarregarImagem.TabStop = True
        Me.lklCarregarImagem.Text = "Carregar Imagem"
        '
        'btnConf
        '
        Me.btnConf.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConf.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConf.Location = New System.Drawing.Point(424, 324)
        Me.btnConf.Name = "btnConf"
        Me.btnConf.Size = New System.Drawing.Size(93, 67)
        Me.btnConf.TabIndex = 12
        Me.btnConf.Text = "Confirmar"
        Me.btnConf.UseVisualStyleBackColor = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbTecnico
        '
        Me.cmbTecnico.FormattingEnabled = True
        Me.cmbTecnico.Location = New System.Drawing.Point(117, 172)
        Me.cmbTecnico.Name = "cmbTecnico"
        Me.cmbTecnico.Size = New System.Drawing.Size(121, 21)
        Me.cmbTecnico.TabIndex = 4
        '
        'cmbPais
        '
        Me.cmbPais.FormattingEnabled = True
        Me.cmbPais.Location = New System.Drawing.Point(117, 216)
        Me.cmbPais.Name = "cmbPais"
        Me.cmbPais.Size = New System.Drawing.Size(121, 21)
        Me.cmbPais.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(79, 216)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "País:"
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(523, 324)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 67)
        Me.btnFechar.TabIndex = 15
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 13)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(151, 15)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "CADASTRO DE CLUBE"
        '
        'txtDataFund
        '
        Me.txtDataFund.Location = New System.Drawing.Point(118, 257)
        Me.txtDataFund.Mask = "00/00/0000"
        Me.txtDataFund.Name = "txtDataFund"
        Me.txtDataFund.Size = New System.Drawing.Size(120, 20)
        Me.txtDataFund.TabIndex = 17
        Me.txtDataFund.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(12, 261)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Data de Fundação:"
        '
        'CadClube
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(628, 403)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtDataFund)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.cmbPais)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbTecnico)
        Me.Controls.Add(Me.btnConf)
        Me.Controls.Add(Me.lklCarregarImagem)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtSigla)
        Me.Controls.Add(Me.txtAlcunha)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadClube"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadClube"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents txtAlcunha As System.Windows.Forms.TextBox
    Friend WithEvents txtSigla As System.Windows.Forms.TextBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lklCarregarImagem As System.Windows.Forms.LinkLabel
    Friend WithEvents btnConf As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbTecnico As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPais As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDataFund As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
