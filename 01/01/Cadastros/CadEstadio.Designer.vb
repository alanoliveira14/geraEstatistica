<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadEstadio
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.pictEstadio = New System.Windows.Forms.PictureBox()
        Me.linkImagem = New System.Windows.Forms.LinkLabel()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.cmbClube = New System.Windows.Forms.ComboBox()
        Me.cmbCidade = New System.Windows.Forms.ComboBox()
        Me.btnFechar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        CType(Me.pictEstadio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(61, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cidade:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 47)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 123)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Clube:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(119, 44)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(121, 20)
        Me.txtNome.TabIndex = 8
        '
        'pictEstadio
        '
        Me.pictEstadio.Location = New System.Drawing.Point(392, 12)
        Me.pictEstadio.Name = "pictEstadio"
        Me.pictEstadio.Size = New System.Drawing.Size(159, 143)
        Me.pictEstadio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pictEstadio.TabIndex = 66
        Me.pictEstadio.TabStop = False
        '
        'linkImagem
        '
        Me.linkImagem.AutoSize = True
        Me.linkImagem.Location = New System.Drawing.Point(433, 168)
        Me.linkImagem.Name = "linkImagem"
        Me.linkImagem.Size = New System.Drawing.Size(87, 13)
        Me.linkImagem.TabIndex = 67
        Me.linkImagem.TabStop = True
        Me.linkImagem.Text = "Carregar Imagem"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'cmbClube
        '
        Me.cmbClube.FormattingEnabled = True
        Me.cmbClube.Location = New System.Drawing.Point(119, 120)
        Me.cmbClube.Name = "cmbClube"
        Me.cmbClube.Size = New System.Drawing.Size(121, 21)
        Me.cmbClube.TabIndex = 68
        '
        'cmbCidade
        '
        Me.cmbCidade.FormattingEnabled = True
        Me.cmbCidade.Location = New System.Drawing.Point(119, 79)
        Me.cmbCidade.Name = "cmbCidade"
        Me.cmbCidade.Size = New System.Drawing.Size(121, 21)
        Me.cmbCidade.TabIndex = 69
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(480, 214)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 79)
        Me.btnFechar.TabIndex = 70
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(26, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 15)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "CADASTRO DE ESTÁDIO"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(381, 214)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(93, 79)
        Me.btnConfirmar.TabIndex = 72
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'CadEstadio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(586, 306)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.cmbCidade)
        Me.Controls.Add(Me.cmbClube)
        Me.Controls.Add(Me.linkImagem)
        Me.Controls.Add(Me.pictEstadio)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "CadEstadio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CadEstadio"
        CType(Me.pictEstadio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents pictEstadio As System.Windows.Forms.PictureBox
    Friend WithEvents linkImagem As System.Windows.Forms.LinkLabel
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents cmbClube As System.Windows.Forms.ComboBox
    Friend WithEvents cmbCidade As System.Windows.Forms.ComboBox
    Friend WithEvents btnFechar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
End Class
