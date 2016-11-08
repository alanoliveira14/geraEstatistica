<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConsultarEmpresa
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
        Me.GrpConsulta = New System.Windows.Forms.GroupBox()
        Me.rdFunc = New System.Windows.Forms.RadioButton()
        Me.rdCliente = New System.Windows.Forms.RadioButton()
        Me.dt_grid = New System.Windows.Forms.DataGridView()
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnVoltar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GrpConsulta.SuspendLayout()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GrpConsulta
        '
        Me.GrpConsulta.BackColor = System.Drawing.Color.Transparent
        Me.GrpConsulta.Controls.Add(Me.rdFunc)
        Me.GrpConsulta.Controls.Add(Me.rdCliente)
        Me.GrpConsulta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GrpConsulta.Location = New System.Drawing.Point(206, 32)
        Me.GrpConsulta.Name = "GrpConsulta"
        Me.GrpConsulta.Size = New System.Drawing.Size(199, 42)
        Me.GrpConsulta.TabIndex = 75
        Me.GrpConsulta.TabStop = False
        Me.GrpConsulta.Text = "Selecione a Consulta"
        '
        'rdFunc
        '
        Me.rdFunc.AutoSize = True
        Me.rdFunc.Location = New System.Drawing.Point(102, 19)
        Me.rdFunc.Name = "rdFunc"
        Me.rdFunc.Size = New System.Drawing.Size(80, 17)
        Me.rdFunc.TabIndex = 2
        Me.rdFunc.TabStop = True
        Me.rdFunc.Text = "Funcionário"
        Me.rdFunc.UseVisualStyleBackColor = True
        '
        'rdCliente
        '
        Me.rdCliente.AutoSize = True
        Me.rdCliente.Location = New System.Drawing.Point(25, 19)
        Me.rdCliente.Name = "rdCliente"
        Me.rdCliente.Size = New System.Drawing.Size(57, 17)
        Me.rdCliente.TabIndex = 0
        Me.rdCliente.TabStop = True
        Me.rdCliente.Text = "Cliente"
        Me.rdCliente.UseVisualStyleBackColor = True
        '
        'dt_grid
        '
        Me.dt_grid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid.Location = New System.Drawing.Point(82, 106)
        Me.dt_grid.Name = "dt_grid"
        Me.dt_grid.Size = New System.Drawing.Size(486, 164)
        Me.dt_grid.TabIndex = 74
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(375, 295)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(90, 56)
        Me.btnConsulta.TabIndex = 73
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(82, 80)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(486, 20)
        Me.txtNome.TabIndex = 72
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(32, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "Nome:"
        '
        'btnVoltar
        '
        Me.btnVoltar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnVoltar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVoltar.Location = New System.Drawing.Point(477, 295)
        Me.btnVoltar.Name = "btnVoltar"
        Me.btnVoltar.Size = New System.Drawing.Size(91, 56)
        Me.btnVoltar.TabIndex = 101
        Me.btnVoltar.Text = "Voltar"
        Me.btnVoltar.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 15)
        Me.Label2.TabIndex = 102
        Me.Label2.Text = "CONSULTA"
        '
        'ConsultarEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(605, 364)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnVoltar)
        Me.Controls.Add(Me.GrpConsulta)
        Me.Controls.Add(Me.dt_grid)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ConsultarEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ConsultarEmpresa"
        Me.GrpConsulta.ResumeLayout(False)
        Me.GrpConsulta.PerformLayout()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GrpConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents rdFunc As System.Windows.Forms.RadioButton
    Friend WithEvents rdCliente As System.Windows.Forms.RadioButton
    Friend WithEvents dt_grid As System.Windows.Forms.DataGridView
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnVoltar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
