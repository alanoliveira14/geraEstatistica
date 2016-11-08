<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cadCliente
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
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtRepresentante = New System.Windows.Forms.TextBox()
        Me.txtTel = New System.Windows.Forms.MaskedTextBox()
        Me.txtNumero = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.btnBuscar1 = New System.Windows.Forms.Button()
        Me.txtRua = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.TextBox()
        Me.txtCidade = New System.Windows.Forms.TextBox()
        Me.txtUF = New System.Windows.Forms.TextBox()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.txtCEP = New System.Windows.Forms.MaskedTextBox()
        Me.txtCNPJ = New System.Windows.Forms.MaskedTextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.cmbClube = New System.Windows.Forms.ComboBox()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Clube Representado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(88, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "CEP"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(81, 253)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "E-mail"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(479, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(19, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nº"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(39, 105)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Representante" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'txtRepresentante
        '
        Me.txtRepresentante.Location = New System.Drawing.Point(122, 105)
        Me.txtRepresentante.Name = "txtRepresentante"
        Me.txtRepresentante.Size = New System.Drawing.Size(444, 20)
        Me.txtRepresentante.TabIndex = 4
        '
        'txtTel
        '
        Me.txtTel.Location = New System.Drawing.Point(122, 216)
        Me.txtTel.Mask = "(99) 0000-0000"
        Me.txtTel.Name = "txtTel"
        Me.txtTel.Size = New System.Drawing.Size(83, 20)
        Me.txtTel.TabIndex = 8
        '
        'txtNumero
        '
        Me.txtNumero.Location = New System.Drawing.Point(504, 158)
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Size = New System.Drawing.Size(62, 20)
        Me.txtNumero.TabIndex = 7
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(67, 219)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(49, 13)
        Me.Label11.TabIndex = 19
        Me.Label11.Text = "Telefone"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(122, 246)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(187, 20)
        Me.txtEmail.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(82, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "CNPJ"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(89, 165)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(27, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "Rua"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(323, 197)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 13)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Cidade"
        '
        'btnBuscar1
        '
        Me.btnBuscar1.Location = New System.Drawing.Point(244, 70)
        Me.btnBuscar1.Name = "btnBuscar1"
        Me.btnBuscar1.Size = New System.Drawing.Size(87, 27)
        Me.btnBuscar1.TabIndex = 3
        Me.btnBuscar1.Text = "Validar"
        Me.btnBuscar1.UseVisualStyleBackColor = True
        '
        'txtRua
        '
        Me.txtRua.Enabled = False
        Me.txtRua.Location = New System.Drawing.Point(122, 158)
        Me.txtRua.Name = "txtRua"
        Me.txtRua.Size = New System.Drawing.Size(348, 20)
        Me.txtRua.TabIndex = 27
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(82, 193)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(34, 13)
        Me.Label12.TabIndex = 28
        Me.Label12.Text = "Bairro"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(479, 197)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(21, 13)
        Me.Label14.TabIndex = 29
        Me.Label14.Text = "UF"
        '
        'txtBairro
        '
        Me.txtBairro.Enabled = False
        Me.txtBairro.Location = New System.Drawing.Point(122, 190)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.Size = New System.Drawing.Size(187, 20)
        Me.txtBairro.TabIndex = 31
        '
        'txtCidade
        '
        Me.txtCidade.Enabled = False
        Me.txtCidade.Location = New System.Drawing.Point(369, 190)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.Size = New System.Drawing.Size(100, 20)
        Me.txtCidade.TabIndex = 32
        '
        'txtUF
        '
        Me.txtUF.Enabled = False
        Me.txtUF.Location = New System.Drawing.Point(504, 194)
        Me.txtUF.Name = "txtUF"
        Me.txtUF.Size = New System.Drawing.Size(62, 20)
        Me.txtUF.TabIndex = 33
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCadastrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.Location = New System.Drawing.Point(600, 229)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(123, 45)
        Me.btnCadastrar.TabIndex = 12
        Me.btnCadastrar.Text = "Cadastrar"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'txtCEP
        '
        Me.txtCEP.Location = New System.Drawing.Point(122, 131)
        Me.txtCEP.Mask = "00000-000"
        Me.txtCEP.Name = "txtCEP"
        Me.txtCEP.Size = New System.Drawing.Size(74, 20)
        Me.txtCEP.TabIndex = 5
        '
        'txtCNPJ
        '
        Me.txtCNPJ.Location = New System.Drawing.Point(122, 74)
        Me.txtCNPJ.Mask = "00.000.000/0000-00"
        Me.txtCNPJ.Name = "txtCNPJ"
        Me.txtCNPJ.Size = New System.Drawing.Size(107, 20)
        Me.txtCNPJ.TabIndex = 2
        '
        'btnBuscar
        '
        Me.btnBuscar.Location = New System.Drawing.Point(234, 129)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(129, 23)
        Me.btnBuscar.TabIndex = 6
        Me.btnBuscar.Text = "Preencher Endereço"
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'cmbClube
        '
        Me.cmbClube.FormattingEnabled = True
        Me.cmbClube.Location = New System.Drawing.Point(122, 43)
        Me.cmbClube.Name = "cmbClube"
        Me.cmbClube.Size = New System.Drawing.Size(209, 21)
        Me.cmbClube.TabIndex = 1
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(749, 229)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(106, 45)
        Me.btnVoltar.TabIndex = 81
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 15)
        Me.Label1.TabIndex = 82
        Me.Label1.Text = "CADASTRO DE CLIENTE"
        '
        'cadCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(867, 284)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.cmbClube)
        Me.Controls.Add(Me.txtCNPJ)
        Me.Controls.Add(Me.txtCEP)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.btnBuscar)
        Me.Controls.Add(Me.txtUF)
        Me.Controls.Add(Me.txtCidade)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtRua)
        Me.Controls.Add(Me.btnBuscar1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.txtNumero)
        Me.Controls.Add(Me.txtTel)
        Me.Controls.Add(Me.txtRepresentante)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "cadCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtRepresentante As System.Windows.Forms.TextBox
    Friend WithEvents txtTel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtNumero As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents btnBuscar1 As System.Windows.Forms.Button
    Friend WithEvents txtRua As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtBairro As System.Windows.Forms.TextBox
    Friend WithEvents txtCidade As System.Windows.Forms.TextBox
    Friend WithEvents txtUF As System.Windows.Forms.TextBox
    Friend WithEvents btnCadastrar As System.Windows.Forms.Button
    Friend WithEvents txtCEP As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCNPJ As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnBuscar As System.Windows.Forms.Button
    Friend WithEvents cmbClube As System.Windows.Forms.ComboBox
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
