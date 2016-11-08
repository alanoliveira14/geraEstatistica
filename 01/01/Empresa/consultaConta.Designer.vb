<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class consultaConta
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
        Me.grbSelecionar = New System.Windows.Forms.GroupBox()
        Me.chbCredito = New System.Windows.Forms.CheckBox()
        Me.chbDebito = New System.Windows.Forms.CheckBox()
        Me.grbConPor = New System.Windows.Forms.GroupBox()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.TxtPagar = New System.Windows.Forms.TextBox()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.chbCliente = New System.Windows.Forms.CheckBox()
        Me.chbPagar = New System.Windows.Forms.CheckBox()
        Me.chbDataVencimento = New System.Windows.Forms.CheckBox()
        Me.chbDescricao = New System.Windows.Forms.CheckBox()
        Me.dt_grid = New System.Windows.Forms.DataGridView()
        Me.btnAtualizarConta = New System.Windows.Forms.Button()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbrAlterar = New System.Windows.Forms.GroupBox()
        Me.txtDatPagamento = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtValor = New System.Windows.Forms.TextBox()
        Me.txtDatVencimento = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescricaoAlterar = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAlterar = New System.Windows.Forms.Button()
        Me.grbSelecionar.SuspendLayout()
        Me.grbConPor.SuspendLayout()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbrAlterar.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbSelecionar
        '
        Me.grbSelecionar.Controls.Add(Me.chbCredito)
        Me.grbSelecionar.Controls.Add(Me.chbDebito)
        Me.grbSelecionar.Location = New System.Drawing.Point(12, 39)
        Me.grbSelecionar.Name = "grbSelecionar"
        Me.grbSelecionar.Size = New System.Drawing.Size(200, 52)
        Me.grbSelecionar.TabIndex = 0
        Me.grbSelecionar.TabStop = False
        Me.grbSelecionar.Text = "Selecione a consulta"
        '
        'chbCredito
        '
        Me.chbCredito.AutoSize = True
        Me.chbCredito.Location = New System.Drawing.Point(112, 20)
        Me.chbCredito.Name = "chbCredito"
        Me.chbCredito.Size = New System.Drawing.Size(59, 17)
        Me.chbCredito.TabIndex = 1
        Me.chbCredito.Text = "Crédito"
        Me.chbCredito.UseVisualStyleBackColor = True
        '
        'chbDebito
        '
        Me.chbDebito.AutoSize = True
        Me.chbDebito.Location = New System.Drawing.Point(7, 20)
        Me.chbDebito.Name = "chbDebito"
        Me.chbDebito.Size = New System.Drawing.Size(57, 17)
        Me.chbDebito.TabIndex = 0
        Me.chbDebito.Text = "Débito"
        Me.chbDebito.UseVisualStyleBackColor = True
        '
        'grbConPor
        '
        Me.grbConPor.Controls.Add(Me.txtData)
        Me.grbConPor.Controls.Add(Me.txtCliente)
        Me.grbConPor.Controls.Add(Me.TxtPagar)
        Me.grbConPor.Controls.Add(Me.txtDescricao)
        Me.grbConPor.Controls.Add(Me.chbCliente)
        Me.grbConPor.Controls.Add(Me.chbPagar)
        Me.grbConPor.Controls.Add(Me.chbDataVencimento)
        Me.grbConPor.Controls.Add(Me.chbDescricao)
        Me.grbConPor.Location = New System.Drawing.Point(12, 97)
        Me.grbConPor.Name = "grbConPor"
        Me.grbConPor.Size = New System.Drawing.Size(268, 128)
        Me.grbConPor.TabIndex = 2
        Me.grbConPor.TabStop = False
        Me.grbConPor.Text = "Consultar por"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(135, 46)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(65, 20)
        Me.txtData.TabIndex = 8
        Me.txtData.ValidatingType = GetType(Date)
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(135, 98)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(118, 20)
        Me.txtCliente.TabIndex = 7
        '
        'TxtPagar
        '
        Me.TxtPagar.Location = New System.Drawing.Point(135, 72)
        Me.TxtPagar.Name = "TxtPagar"
        Me.TxtPagar.Size = New System.Drawing.Size(118, 20)
        Me.TxtPagar.TabIndex = 6
        '
        'txtDescricao
        '
        Me.txtDescricao.Location = New System.Drawing.Point(135, 20)
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(118, 20)
        Me.txtDescricao.TabIndex = 4
        '
        'chbCliente
        '
        Me.chbCliente.AutoSize = True
        Me.chbCliente.Location = New System.Drawing.Point(7, 100)
        Me.chbCliente.Name = "chbCliente"
        Me.chbCliente.Size = New System.Drawing.Size(58, 17)
        Me.chbCliente.TabIndex = 3
        Me.chbCliente.Text = "Cliente"
        Me.chbCliente.UseVisualStyleBackColor = True
        '
        'chbPagar
        '
        Me.chbPagar.AutoSize = True
        Me.chbPagar.Location = New System.Drawing.Point(7, 74)
        Me.chbPagar.Name = "chbPagar"
        Me.chbPagar.Size = New System.Drawing.Size(63, 17)
        Me.chbPagar.TabIndex = 2
        Me.chbPagar.Text = "Pagar à"
        Me.chbPagar.UseVisualStyleBackColor = True
        '
        'chbDataVencimento
        '
        Me.chbDataVencimento.AutoSize = True
        Me.chbDataVencimento.Location = New System.Drawing.Point(7, 48)
        Me.chbDataVencimento.Name = "chbDataVencimento"
        Me.chbDataVencimento.Size = New System.Drawing.Size(122, 17)
        Me.chbDataVencimento.TabIndex = 1
        Me.chbDataVencimento.Text = "Data de vencimento"
        Me.chbDataVencimento.UseVisualStyleBackColor = True
        '
        'chbDescricao
        '
        Me.chbDescricao.AutoSize = True
        Me.chbDescricao.Location = New System.Drawing.Point(7, 22)
        Me.chbDescricao.Name = "chbDescricao"
        Me.chbDescricao.Size = New System.Drawing.Size(74, 17)
        Me.chbDescricao.TabIndex = 0
        Me.chbDescricao.Text = "Descrição"
        Me.chbDescricao.UseVisualStyleBackColor = True
        '
        'dt_grid
        '
        Me.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid.Location = New System.Drawing.Point(306, 39)
        Me.dt_grid.Name = "dt_grid"
        Me.dt_grid.Size = New System.Drawing.Size(650, 213)
        Me.dt_grid.TabIndex = 3
        '
        'btnAtualizarConta
        '
        Me.btnAtualizarConta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAtualizarConta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAtualizarConta.Location = New System.Drawing.Point(189, 231)
        Me.btnAtualizarConta.Name = "btnAtualizarConta"
        Me.btnAtualizarConta.Size = New System.Drawing.Size(75, 23)
        Me.btnAtualizarConta.TabIndex = 4
        Me.btnAtualizarConta.Text = "Consultar"
        Me.btnAtualizarConta.UseVisualStyleBackColor = False
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(108, 231)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(75, 23)
        Me.btnVoltar.TabIndex = 5
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 15)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "CONSULTA  DE CONTAS"
        '
        'gbrAlterar
        '
        Me.gbrAlterar.Controls.Add(Me.txtDatPagamento)
        Me.gbrAlterar.Controls.Add(Me.Label5)
        Me.gbrAlterar.Controls.Add(Me.txtValor)
        Me.gbrAlterar.Controls.Add(Me.txtDatVencimento)
        Me.gbrAlterar.Controls.Add(Me.Label4)
        Me.gbrAlterar.Controls.Add(Me.Label8)
        Me.gbrAlterar.Controls.Add(Me.txtDescricaoAlterar)
        Me.gbrAlterar.Controls.Add(Me.Label2)
        Me.gbrAlterar.Location = New System.Drawing.Point(12, 260)
        Me.gbrAlterar.Name = "gbrAlterar"
        Me.gbrAlterar.Size = New System.Drawing.Size(434, 81)
        Me.gbrAlterar.TabIndex = 7
        Me.gbrAlterar.TabStop = False
        Me.gbrAlterar.Text = "Alterar Conta"
        '
        'txtDatPagamento
        '
        Me.txtDatPagamento.Location = New System.Drawing.Point(335, 45)
        Me.txtDatPagamento.Mask = "00/00/0000"
        Me.txtDatPagamento.Name = "txtDatPagamento"
        Me.txtDatPagamento.Size = New System.Drawing.Size(86, 20)
        Me.txtDatPagamento.TabIndex = 30
        Me.txtDatPagamento.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(225, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 13)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Data de pagamento:"
        '
        'txtValor
        '
        Me.txtValor.Location = New System.Drawing.Point(78, 45)
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Size = New System.Drawing.Size(86, 20)
        Me.txtValor.TabIndex = 22
        '
        'txtDatVencimento
        '
        Me.txtDatVencimento.Location = New System.Drawing.Point(335, 19)
        Me.txtDatVencimento.Mask = "00/00/0000"
        Me.txtDatVencimento.Name = "txtDatVencimento"
        Me.txtDatVencimento.Size = New System.Drawing.Size(86, 20)
        Me.txtDatVencimento.TabIndex = 25
        Me.txtDatVencimento.ValidatingType = GetType(Date)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(223, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Data de vencimento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(37, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Valor: "
        '
        'txtDescricaoAlterar
        '
        Me.txtDescricaoAlterar.Location = New System.Drawing.Point(78, 19)
        Me.txtDescricaoAlterar.Name = "txtDescricaoAlterar"
        Me.txtDescricaoAlterar.Size = New System.Drawing.Size(86, 20)
        Me.txtDescricaoAlterar.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descrição:"
        '
        'btnAlterar
        '
        Me.btnAlterar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAlterar.Location = New System.Drawing.Point(15, 231)
        Me.btnAlterar.Name = "btnAlterar"
        Me.btnAlterar.Size = New System.Drawing.Size(75, 23)
        Me.btnAlterar.TabIndex = 8
        Me.btnAlterar.Text = "Alterar"
        Me.btnAlterar.UseVisualStyleBackColor = False
        '
        'consultaConta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(974, 347)
        Me.Controls.Add(Me.btnAlterar)
        Me.Controls.Add(Me.gbrAlterar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.btnAtualizarConta)
        Me.Controls.Add(Me.dt_grid)
        Me.Controls.Add(Me.grbConPor)
        Me.Controls.Add(Me.grbSelecionar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "consultaConta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "consultaConta"
        Me.grbSelecionar.ResumeLayout(False)
        Me.grbSelecionar.PerformLayout()
        Me.grbConPor.ResumeLayout(False)
        Me.grbConPor.PerformLayout()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbrAlterar.ResumeLayout(False)
        Me.gbrAlterar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grbSelecionar As System.Windows.Forms.GroupBox
    Friend WithEvents chbCredito As System.Windows.Forms.CheckBox
    Friend WithEvents chbDebito As System.Windows.Forms.CheckBox
    Friend WithEvents grbConPor As System.Windows.Forms.GroupBox
    Friend WithEvents chbDataVencimento As System.Windows.Forms.CheckBox
    Friend WithEvents chbDescricao As System.Windows.Forms.CheckBox
    Friend WithEvents chbPagar As System.Windows.Forms.CheckBox
    Friend WithEvents txtData As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txtCliente As System.Windows.Forms.TextBox
    Friend WithEvents TxtPagar As System.Windows.Forms.TextBox
    Friend WithEvents txtDescricao As System.Windows.Forms.TextBox
    Friend WithEvents chbCliente As System.Windows.Forms.CheckBox
    Friend WithEvents dt_grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAtualizarConta As System.Windows.Forms.Button
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbrAlterar As System.Windows.Forms.GroupBox
    Friend WithEvents txtDescricaoAlterar As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDatPagamento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtValor As System.Windows.Forms.TextBox
    Friend WithEvents txtDatVencimento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents btnAlterar As System.Windows.Forms.Button
End Class
