<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class contas
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbCredito = New System.Windows.Forms.RadioButton()
        Me.rdbDebito = New System.Windows.Forms.RadioButton()
        Me.grbDebito = New System.Windows.Forms.GroupBox()
        Me.txtDatPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmbFuncionario = New System.Windows.Forms.ComboBox()
        Me.TxtPagar = New System.Windows.Forms.TextBox()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDatEmissao = New System.Windows.Forms.MaskedTextBox()
        Me.txtDatVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.grbCredito = New System.Windows.Forms.GroupBox()
        Me.txtDatPagamento1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbStatus1 = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbCliente = New System.Windows.Forms.ComboBox()
        Me.txtDatVencimento1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtDatEmissao1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtValor1 = New System.Windows.Forms.TextBox()
        Me.txtDescricao1 = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.grbDebito.SuspendLayout()
        Me.grbCredito.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbCredito)
        Me.GroupBox1.Controls.Add(Me.rdbDebito)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(247, 77)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de conta"
        '
        'rdbCredito
        '
        Me.rdbCredito.AutoSize = True
        Me.rdbCredito.Location = New System.Drawing.Point(24, 44)
        Me.rdbCredito.Name = "rdbCredito"
        Me.rdbCredito.Size = New System.Drawing.Size(58, 17)
        Me.rdbCredito.TabIndex = 2
        Me.rdbCredito.TabStop = True
        Me.rdbCredito.Text = "Crédito"
        Me.rdbCredito.UseVisualStyleBackColor = True
        '
        'rdbDebito
        '
        Me.rdbDebito.AutoSize = True
        Me.rdbDebito.Location = New System.Drawing.Point(24, 20)
        Me.rdbDebito.Name = "rdbDebito"
        Me.rdbDebito.Size = New System.Drawing.Size(56, 17)
        Me.rdbDebito.TabIndex = 1
        Me.rdbDebito.TabStop = True
        Me.rdbDebito.Text = "Débito"
        Me.rdbDebito.UseVisualStyleBackColor = True
        '
        'grbDebito
        '
        Me.grbDebito.Controls.Add(Me.txtDatPagamento)
        Me.grbDebito.Controls.Add(Me.Label7)
        Me.grbDebito.Controls.Add(Me.cmbStatus)
        Me.grbDebito.Controls.Add(Me.Label5)
        Me.grbDebito.Controls.Add(Me.Label16)
        Me.grbDebito.Controls.Add(Me.cmbFuncionario)
        Me.grbDebito.Controls.Add(Me.TxtPagar)
        Me.grbDebito.Controls.Add(Me.txtValor)
        Me.grbDebito.Controls.Add(Me.txtDatEmissao)
        Me.grbDebito.Controls.Add(Me.txtDatVencimento)
        Me.grbDebito.Controls.Add(Me.Label6)
        Me.grbDebito.Controls.Add(Me.txtDescricao)
        Me.grbDebito.Controls.Add(Me.Label4)
        Me.grbDebito.Controls.Add(Me.Label3)
        Me.grbDebito.Controls.Add(Me.Label2)
        Me.grbDebito.Controls.Add(Me.Label1)
        Me.grbDebito.Location = New System.Drawing.Point(12, 124)
        Me.grbDebito.Name = "grbDebito"
        Me.grbDebito.Size = New System.Drawing.Size(247, 244)
        Me.grbDebito.TabIndex = 1
        Me.grbDebito.TabStop = False
        Me.grbDebito.Text = "Débito"
        '
        'txtDatPagamento
        '
        Me.txtDatPagamento.Location = New System.Drawing.Point(141, 212)
        Me.txtDatPagamento.Mask = "00/00/0000"
        Me.txtDatPagamento.Name = "txtDatPagamento"
        Me.txtDatPagamento.Size = New System.Drawing.Size(86, 20)
        Me.txtDatPagamento.TabIndex = 11
        Me.txtDatPagamento.ValidatingType = GetType(Date)
        Me.txtDatPagamento.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(43, 188)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Status da conta: *"
        '
        'cmbStatus
        '
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Location = New System.Drawing.Point(141, 185)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(86, 21)
        Me.cmbStatus.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 215)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Data de pagamento: *"
        Me.Label5.Visible = False
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 161)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(132, 13)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Funcionário responsável: *"
        '
        'cmbFuncionario
        '
        Me.cmbFuncionario.FormattingEnabled = True
        Me.cmbFuncionario.Location = New System.Drawing.Point(141, 158)
        Me.cmbFuncionario.Name = "cmbFuncionario"
        Me.cmbFuncionario.Size = New System.Drawing.Size(86, 21)
        Me.cmbFuncionario.TabIndex = 9
        '
        'TxtPagar
        '
        Me.TxtPagar.Location = New System.Drawing.Point(141, 132)
        Me.TxtPagar.Name = "TxtPagar"
        Me.TxtPagar.Size = New System.Drawing.Size(86, 20)
        Me.TxtPagar.TabIndex = 8
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(141, 54)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(86, 20)
        Me.txtValor.TabIndex = 4
        '
        'txtDatEmissao
        '
        Me.txtDatEmissao.Location = New System.Drawing.Point(141, 80)
        Me.txtDatEmissao.Mask = "00/00/0000"
        Me.txtDatEmissao.Name = "txtDatEmissao"
        Me.txtDatEmissao.Size = New System.Drawing.Size(86, 20)
        Me.txtDatEmissao.TabIndex = 5
        Me.txtDatEmissao.ValidatingType = GetType(Date)
        '
        'txtDatVencimento
        '
        Me.txtDatVencimento.Location = New System.Drawing.Point(141, 106)
        Me.txtDatVencimento.Mask = "00/00/0000"
        Me.txtDatVencimento.Name = "txtDatVencimento"
        Me.txtDatVencimento.Size = New System.Drawing.Size(86, 20)
        Me.txtDatVencimento.TabIndex = 6
        Me.txtDatVencimento.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(88, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Pagar à:"
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(141, 28)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(86, 20)
        Me.txtDescricao.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Data de vencimento: *"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(39, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Data de emissão: *"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(94, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Valor: *"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(70, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Descrição: *"
        '
        'grbCredito
        '
        Me.grbCredito.Controls.Add(Me.txtDatPagamento1)
        Me.grbCredito.Controls.Add(Me.Label12)
        Me.grbCredito.Controls.Add(Me.cmbStatus1)
        Me.grbCredito.Controls.Add(Me.Label14)
        Me.grbCredito.Controls.Add(Me.cmbCliente)
        Me.grbCredito.Controls.Add(Me.txtDatVencimento1)
        Me.grbCredito.Controls.Add(Me.Label13)
        Me.grbCredito.Controls.Add(Me.txtDatEmissao1)
        Me.grbCredito.Controls.Add(Me.Label11)
        Me.grbCredito.Controls.Add(Me.Label10)
        Me.grbCredito.Controls.Add(Me.Label9)
        Me.grbCredito.Controls.Add(Me.Label8)
        Me.grbCredito.Controls.Add(Me.txtValor1)
        Me.grbCredito.Controls.Add(Me.txtDescricao1)
        Me.grbCredito.Location = New System.Drawing.Point(290, 124)
        Me.grbCredito.Name = "grbCredito"
        Me.grbCredito.Size = New System.Drawing.Size(247, 244)
        Me.grbCredito.TabIndex = 2
        Me.grbCredito.TabStop = False
        Me.grbCredito.Text = "Crédito"
        '
        'txtDatPagamento1
        '
        Me.txtDatPagamento1.Location = New System.Drawing.Point(130, 186)
        Me.txtDatPagamento1.Mask = "00/00/0000"
        Me.txtDatPagamento1.Name = "txtDatPagamento1"
        Me.txtDatPagamento1.Size = New System.Drawing.Size(86, 20)
        Me.txtDatPagamento1.TabIndex = 13
        Me.txtDatPagamento1.ValidatingType = GetType(Date)
        Me.txtDatPagamento1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 162)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Status da conta: *"
        '
        'cmbStatus1
        '
        Me.cmbStatus1.FormattingEnabled = True
        Me.cmbStatus1.Location = New System.Drawing.Point(130, 159)
        Me.cmbStatus1.Name = "cmbStatus1"
        Me.cmbStatus1.Size = New System.Drawing.Size(86, 21)
        Me.cmbStatus1.TabIndex = 12
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(13, 189)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(111, 13)
        Me.Label14.TabIndex = 21
        Me.Label14.Text = "Data de pagamento: *"
        Me.Label14.Visible = False
        '
        'cmbCliente
        '
        Me.cmbCliente.FormattingEnabled = True
        Me.cmbCliente.Location = New System.Drawing.Point(130, 132)
        Me.cmbCliente.Name = "cmbCliente"
        Me.cmbCliente.Size = New System.Drawing.Size(86, 21)
        Me.cmbCliente.TabIndex = 11
        '
        'txtDatVencimento1
        '
        Me.txtDatVencimento1.Location = New System.Drawing.Point(130, 106)
        Me.txtDatVencimento1.Mask = "00/00/0000"
        Me.txtDatVencimento1.Name = "txtDatVencimento1"
        Me.txtDatVencimento1.Size = New System.Drawing.Size(86, 20)
        Me.txtDatVencimento1.TabIndex = 9
        Me.txtDatVencimento1.ValidatingType = GetType(Date)
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(75, 136)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(49, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Cliente: *"
        '
        'txtDatEmissao1
        '
        Me.txtDatEmissao1.Location = New System.Drawing.Point(130, 80)
        Me.txtDatEmissao1.Mask = "00/00/0000"
        Me.txtDatEmissao1.Name = "txtDatEmissao1"
        Me.txtDatEmissao1.Size = New System.Drawing.Size(86, 20)
        Me.txtDatEmissao1.TabIndex = 8
        Me.txtDatEmissao1.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 109)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(113, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Data de vencimento: *"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(28, 83)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(96, 13)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Data de emissão: *"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(83, 57)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(41, 13)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Valor: *"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(59, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 13)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Descrição: *"
        '
        'txtValor1
        '
        Me.txtValor1.Location = New System.Drawing.Point(130, 54)
        Me.txtValor1.Name = "txtValor1"
        Me.txtValor1.Size = New System.Drawing.Size(86, 20)
        Me.txtValor1.TabIndex = 7
        '
        'txtDescricao1
        '
        Me.txtDescricao1.Location = New System.Drawing.Point(130, 28)
        Me.txtDescricao1.Name = "txtDescricao1"
        Me.txtDescricao1.Size = New System.Drawing.Size(86, 20)
        Me.txtDescricao1.TabIndex = 6
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(12, 371)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(112, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "* Campos obrigatórios."
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.Location = New System.Drawing.Point(153, 397)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(75, 23)
        Me.btnConfirmar.TabIndex = 4
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(253, 397)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(75, 23)
        Me.btnConsulta.TabIndex = 5
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(366, 397)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(73, 23)
        Me.btnVoltar.TabIndex = 102
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'contas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 440)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.grbCredito)
        Me.Controls.Add(Me.grbDebito)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "contas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "contas"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grbDebito.ResumeLayout(False)
        Me.grbDebito.PerformLayout()
        Me.grbCredito.ResumeLayout(False)
        Me.grbCredito.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbCredito As System.Windows.Forms.GroupBox
    Friend WithEvents grbDebito As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbCredito As System.Windows.Forms.RadioButton
    Friend WithEvents rdbDebito As System.Windows.Forms.RadioButton
    Friend WithEvents txtDatEmissao As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDatVencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents TxtPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtValor1 As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao1 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbCliente As System.Windows.Forms.ComboBox
    Friend WithEvents txtDatVencimento1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtDatEmissao1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmbFuncionario As System.Windows.Forms.ComboBox
    Friend WithEvents txtDatPagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDatPagamento1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
