<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Consulta
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
        Me.btnConsulta = New System.Windows.Forms.Button()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dt_grid = New System.Windows.Forms.DataGridView()
        Me.GrpConsulta = New System.Windows.Forms.GroupBox()
        Me.rdGoleiro = New System.Windows.Forms.RadioButton()
        Me.rdClube = New System.Windows.Forms.RadioButton()
        Me.rdJogador = New System.Windows.Forms.RadioButton()
        Me.btnFechar = New System.Windows.Forms.Button()
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GrpConsulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnConsulta
        '
        Me.btnConsulta.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConsulta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsulta.Location = New System.Drawing.Point(387, 373)
        Me.btnConsulta.Name = "btnConsulta"
        Me.btnConsulta.Size = New System.Drawing.Size(90, 67)
        Me.btnConsulta.TabIndex = 68
        Me.btnConsulta.Text = "Consultar"
        Me.btnConsulta.UseVisualStyleBackColor = False
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(62, 77)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(486, 20)
        Me.txtNome.TabIndex = 67
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Nome:"
        '
        'dt_grid
        '
        Me.dt_grid.BackgroundColor = System.Drawing.SystemColors.Window
        Me.dt_grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_grid.Location = New System.Drawing.Point(62, 103)
        Me.dt_grid.Name = "dt_grid"
        Me.dt_grid.Size = New System.Drawing.Size(486, 247)
        Me.dt_grid.TabIndex = 69
        '
        'GrpConsulta
        '
        Me.GrpConsulta.Controls.Add(Me.rdGoleiro)
        Me.GrpConsulta.Controls.Add(Me.rdClube)
        Me.GrpConsulta.Controls.Add(Me.rdJogador)
        Me.GrpConsulta.Location = New System.Drawing.Point(153, 12)
        Me.GrpConsulta.Name = "GrpConsulta"
        Me.GrpConsulta.Size = New System.Drawing.Size(314, 42)
        Me.GrpConsulta.TabIndex = 70
        Me.GrpConsulta.TabStop = False
        Me.GrpConsulta.Text = "Selecione a Consulta"
        '
        'rdGoleiro
        '
        Me.rdGoleiro.AutoSize = True
        Me.rdGoleiro.Location = New System.Drawing.Point(137, 19)
        Me.rdGoleiro.Name = "rdGoleiro"
        Me.rdGoleiro.Size = New System.Drawing.Size(58, 17)
        Me.rdGoleiro.TabIndex = 2
        Me.rdGoleiro.TabStop = True
        Me.rdGoleiro.Text = "Goleiro"
        Me.rdGoleiro.UseVisualStyleBackColor = True
        '
        'rdClube
        '
        Me.rdClube.AutoSize = True
        Me.rdClube.Location = New System.Drawing.Point(243, 19)
        Me.rdClube.Name = "rdClube"
        Me.rdClube.Size = New System.Drawing.Size(52, 17)
        Me.rdClube.TabIndex = 1
        Me.rdClube.TabStop = True
        Me.rdClube.Text = "Clube"
        Me.rdClube.UseVisualStyleBackColor = True
        '
        'rdJogador
        '
        Me.rdJogador.AutoSize = True
        Me.rdJogador.Location = New System.Drawing.Point(17, 19)
        Me.rdJogador.Name = "rdJogador"
        Me.rdJogador.Size = New System.Drawing.Size(63, 17)
        Me.rdJogador.TabIndex = 0
        Me.rdJogador.TabStop = True
        Me.rdJogador.Text = "Jogador"
        Me.rdJogador.UseVisualStyleBackColor = True
        '
        'btnFechar
        '
        Me.btnFechar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnFechar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechar.Location = New System.Drawing.Point(484, 373)
        Me.btnFechar.Name = "btnFechar"
        Me.btnFechar.Size = New System.Drawing.Size(93, 67)
        Me.btnFechar.TabIndex = 71
        Me.btnFechar.Text = "Fechar"
        Me.btnFechar.UseVisualStyleBackColor = False
        '
        'Consulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(587, 455)
        Me.Controls.Add(Me.btnFechar)
        Me.Controls.Add(Me.GrpConsulta)
        Me.Controls.Add(Me.dt_grid)
        Me.Controls.Add(Me.btnConsulta)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Consulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta"
        CType(Me.dt_grid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GrpConsulta.ResumeLayout(False)
        Me.GrpConsulta.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnConsulta As System.Windows.Forms.Button
    Friend WithEvents txtNome As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dt_grid As System.Windows.Forms.DataGridView
    Friend WithEvents GrpConsulta As System.Windows.Forms.GroupBox
    Friend WithEvents rdGoleiro As System.Windows.Forms.RadioButton
    Friend WithEvents rdClube As System.Windows.Forms.RadioButton
    Friend WithEvents rdJogador As System.Windows.Forms.RadioButton
    Friend WithEvents btnFechar As System.Windows.Forms.Button
End Class
