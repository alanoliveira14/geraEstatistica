<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comparacoes
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
        Me.cmbSelecionado2 = New System.Windows.Forms.ComboBox()
        Me.cmbSelecionado1 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbCamp = New System.Windows.Forms.ComboBox()
        Me.cmbPaisClube = New System.Windows.Forms.ComboBox()
        Me.txtNomeClube = New System.Windows.Forms.TextBox()
        Me.selNomeClube = New System.Windows.Forms.CheckBox()
        Me.cmbPaisGol = New System.Windows.Forms.ComboBox()
        Me.cmbClubeGol = New System.Windows.Forms.ComboBox()
        Me.txtNomeGol = New System.Windows.Forms.TextBox()
        Me.selNomeGol = New System.Windows.Forms.CheckBox()
        Me.selNacioGol = New System.Windows.Forms.CheckBox()
        Me.selClubeGol = New System.Windows.Forms.CheckBox()
        Me.cmbPaisJog = New System.Windows.Forms.ComboBox()
        Me.cmbClubeJog = New System.Windows.Forms.ComboBox()
        Me.txtNomeJog = New System.Windows.Forms.TextBox()
        Me.selNomeJog = New System.Windows.Forms.CheckBox()
        Me.todosClubes = New System.Windows.Forms.CheckBox()
        Me.selCampeonato = New System.Windows.Forms.CheckBox()
        Me.selPais = New System.Windows.Forms.CheckBox()
        Me.todosGol = New System.Windows.Forms.CheckBox()
        Me.todosJog = New System.Windows.Forms.CheckBox()
        Me.selNacioJog = New System.Windows.Forms.CheckBox()
        Me.selClubeJog = New System.Windows.Forms.CheckBox()
        Me.rdbGoleiro = New System.Windows.Forms.RadioButton()
        Me.rdbJogadores = New System.Windows.Forms.RadioButton()
        Me.rdbClube = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.btnLimpar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lklConfirmaOpcao1 = New System.Windows.Forms.LinkLabel()
        Me.lklConfirmaOpcao2 = New System.Windows.Forms.LinkLabel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbSelecionado2
        '
        Me.cmbSelecionado2.FormattingEnabled = True
        Me.cmbSelecionado2.Location = New System.Drawing.Point(1042, 59)
        Me.cmbSelecionado2.Name = "cmbSelecionado2"
        Me.cmbSelecionado2.Size = New System.Drawing.Size(171, 21)
        Me.cmbSelecionado2.TabIndex = 0
        '
        'cmbSelecionado1
        '
        Me.cmbSelecionado1.FormattingEnabled = True
        Me.cmbSelecionado1.Location = New System.Drawing.Point(753, 59)
        Me.cmbSelecionado1.Name = "cmbSelecionado1"
        Me.cmbSelecionado1.Size = New System.Drawing.Size(171, 21)
        Me.cmbSelecionado1.TabIndex = 1
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cmbCamp)
        Me.GroupBox1.Controls.Add(Me.cmbPaisClube)
        Me.GroupBox1.Controls.Add(Me.txtNomeClube)
        Me.GroupBox1.Controls.Add(Me.selNomeClube)
        Me.GroupBox1.Controls.Add(Me.cmbPaisGol)
        Me.GroupBox1.Controls.Add(Me.cmbClubeGol)
        Me.GroupBox1.Controls.Add(Me.txtNomeGol)
        Me.GroupBox1.Controls.Add(Me.selNomeGol)
        Me.GroupBox1.Controls.Add(Me.selNacioGol)
        Me.GroupBox1.Controls.Add(Me.selClubeGol)
        Me.GroupBox1.Controls.Add(Me.cmbPaisJog)
        Me.GroupBox1.Controls.Add(Me.cmbClubeJog)
        Me.GroupBox1.Controls.Add(Me.txtNomeJog)
        Me.GroupBox1.Controls.Add(Me.selNomeJog)
        Me.GroupBox1.Controls.Add(Me.todosClubes)
        Me.GroupBox1.Controls.Add(Me.selCampeonato)
        Me.GroupBox1.Controls.Add(Me.selPais)
        Me.GroupBox1.Controls.Add(Me.todosGol)
        Me.GroupBox1.Controls.Add(Me.todosJog)
        Me.GroupBox1.Controls.Add(Me.selNacioJog)
        Me.GroupBox1.Controls.Add(Me.selClubeJog)
        Me.GroupBox1.Controls.Add(Me.rdbGoleiro)
        Me.GroupBox1.Controls.Add(Me.rdbJogadores)
        Me.GroupBox1.Controls.Add(Me.rdbClube)
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Window
        Me.GroupBox1.Location = New System.Drawing.Point(26, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 415)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'cmbCamp
        '
        Me.cmbCamp.FormattingEnabled = True
        Me.cmbCamp.Location = New System.Drawing.Point(264, 338)
        Me.cmbCamp.Name = "cmbCamp"
        Me.cmbCamp.Size = New System.Drawing.Size(156, 21)
        Me.cmbCamp.TabIndex = 36
        '
        'cmbPaisClube
        '
        Me.cmbPaisClube.FormattingEnabled = True
        Me.cmbPaisClube.Location = New System.Drawing.Point(129, 338)
        Me.cmbPaisClube.Name = "cmbPaisClube"
        Me.cmbPaisClube.Size = New System.Drawing.Size(129, 21)
        Me.cmbPaisClube.TabIndex = 35
        '
        'txtNomeClube
        '
        Me.txtNomeClube.Location = New System.Drawing.Point(426, 338)
        Me.txtNomeClube.Name = "txtNomeClube"
        Me.txtNomeClube.Size = New System.Drawing.Size(172, 20)
        Me.txtNomeClube.TabIndex = 34
        Me.txtNomeClube.Text = "Digite o nome do time"
        '
        'selNomeClube
        '
        Me.selNomeClube.AutoSize = True
        Me.selNomeClube.BackColor = System.Drawing.Color.Transparent
        Me.selNomeClube.CausesValidation = False
        Me.selNomeClube.ForeColor = System.Drawing.Color.Black
        Me.selNomeClube.Location = New System.Drawing.Point(426, 296)
        Me.selNomeClube.Name = "selNomeClube"
        Me.selNomeClube.Size = New System.Drawing.Size(114, 17)
        Me.selNomeClube.TabIndex = 33
        Me.selNomeClube.Text = "Seleção por Nome"
        Me.selNomeClube.UseVisualStyleBackColor = False
        '
        'cmbPaisGol
        '
        Me.cmbPaisGol.FormattingEnabled = True
        Me.cmbPaisGol.Location = New System.Drawing.Point(264, 215)
        Me.cmbPaisGol.Name = "cmbPaisGol"
        Me.cmbPaisGol.Size = New System.Drawing.Size(156, 21)
        Me.cmbPaisGol.TabIndex = 29
        '
        'cmbClubeGol
        '
        Me.cmbClubeGol.FormattingEnabled = True
        Me.cmbClubeGol.Location = New System.Drawing.Point(129, 214)
        Me.cmbClubeGol.Name = "cmbClubeGol"
        Me.cmbClubeGol.Size = New System.Drawing.Size(129, 21)
        Me.cmbClubeGol.TabIndex = 28
        '
        'txtNomeGol
        '
        Me.txtNomeGol.Location = New System.Drawing.Point(426, 215)
        Me.txtNomeGol.Name = "txtNomeGol"
        Me.txtNomeGol.Size = New System.Drawing.Size(172, 20)
        Me.txtNomeGol.TabIndex = 27
        Me.txtNomeGol.Text = "Digite o nome do goleiro"
        '
        'selNomeGol
        '
        Me.selNomeGol.AutoSize = True
        Me.selNomeGol.BackColor = System.Drawing.Color.Transparent
        Me.selNomeGol.CausesValidation = False
        Me.selNomeGol.ForeColor = System.Drawing.Color.Black
        Me.selNomeGol.Location = New System.Drawing.Point(426, 173)
        Me.selNomeGol.Name = "selNomeGol"
        Me.selNomeGol.Size = New System.Drawing.Size(114, 17)
        Me.selNomeGol.TabIndex = 26
        Me.selNomeGol.Text = "Seleção por Nome"
        Me.selNomeGol.UseVisualStyleBackColor = False
        '
        'selNacioGol
        '
        Me.selNacioGol.AutoSize = True
        Me.selNacioGol.BackColor = System.Drawing.Color.Transparent
        Me.selNacioGol.CausesValidation = False
        Me.selNacioGol.ForeColor = System.Drawing.Color.Black
        Me.selNacioGol.Location = New System.Drawing.Point(266, 196)
        Me.selNacioGol.Name = "selNacioGol"
        Me.selNacioGol.Size = New System.Drawing.Size(154, 17)
        Me.selNacioGol.TabIndex = 24
        Me.selNacioGol.Text = "Seleção por Nacionalidade"
        Me.selNacioGol.UseVisualStyleBackColor = False
        '
        'selClubeGol
        '
        Me.selClubeGol.AutoSize = True
        Me.selClubeGol.BackColor = System.Drawing.Color.Transparent
        Me.selClubeGol.CausesValidation = False
        Me.selClubeGol.ForeColor = System.Drawing.Color.Black
        Me.selClubeGol.Location = New System.Drawing.Point(131, 196)
        Me.selClubeGol.Name = "selClubeGol"
        Me.selClubeGol.Size = New System.Drawing.Size(113, 17)
        Me.selClubeGol.TabIndex = 23
        Me.selClubeGol.Text = "Seleção por Clube"
        Me.selClubeGol.UseVisualStyleBackColor = False
        '
        'cmbPaisJog
        '
        Me.cmbPaisJog.FormattingEnabled = True
        Me.cmbPaisJog.Location = New System.Drawing.Point(264, 86)
        Me.cmbPaisJog.Name = "cmbPaisJog"
        Me.cmbPaisJog.Size = New System.Drawing.Size(156, 21)
        Me.cmbPaisJog.TabIndex = 22
        '
        'cmbClubeJog
        '
        Me.cmbClubeJog.FormattingEnabled = True
        Me.cmbClubeJog.Location = New System.Drawing.Point(129, 86)
        Me.cmbClubeJog.Name = "cmbClubeJog"
        Me.cmbClubeJog.Size = New System.Drawing.Size(129, 21)
        Me.cmbClubeJog.TabIndex = 21
        '
        'txtNomeJog
        '
        Me.txtNomeJog.Location = New System.Drawing.Point(426, 86)
        Me.txtNomeJog.Name = "txtNomeJog"
        Me.txtNomeJog.Size = New System.Drawing.Size(172, 20)
        Me.txtNomeJog.TabIndex = 16
        Me.txtNomeJog.Text = "Digite o nome do jogador"
        '
        'selNomeJog
        '
        Me.selNomeJog.AutoSize = True
        Me.selNomeJog.BackColor = System.Drawing.Color.Transparent
        Me.selNomeJog.CausesValidation = False
        Me.selNomeJog.ForeColor = System.Drawing.Color.Black
        Me.selNomeJog.Location = New System.Drawing.Point(426, 44)
        Me.selNomeJog.Name = "selNomeJog"
        Me.selNomeJog.Size = New System.Drawing.Size(114, 17)
        Me.selNomeJog.TabIndex = 15
        Me.selNomeJog.Text = "Seleção por Nome"
        Me.selNomeJog.UseVisualStyleBackColor = False
        '
        'todosClubes
        '
        Me.todosClubes.AutoSize = True
        Me.todosClubes.BackColor = System.Drawing.Color.Transparent
        Me.todosClubes.CausesValidation = False
        Me.todosClubes.ForeColor = System.Drawing.Color.Black
        Me.todosClubes.Location = New System.Drawing.Point(426, 319)
        Me.todosClubes.Name = "todosClubes"
        Me.todosClubes.Size = New System.Drawing.Size(155, 17)
        Me.todosClubes.TabIndex = 14
        Me.todosClubes.Text = "Todos os Clubes (Aleatória)"
        Me.todosClubes.UseVisualStyleBackColor = False
        '
        'selCampeonato
        '
        Me.selCampeonato.AutoSize = True
        Me.selCampeonato.BackColor = System.Drawing.Color.Transparent
        Me.selCampeonato.CausesValidation = False
        Me.selCampeonato.ForeColor = System.Drawing.Color.Black
        Me.selCampeonato.Location = New System.Drawing.Point(264, 319)
        Me.selCampeonato.Name = "selCampeonato"
        Me.selCampeonato.Size = New System.Drawing.Size(146, 17)
        Me.selCampeonato.TabIndex = 13
        Me.selCampeonato.Text = "Seleção por Campeonato"
        Me.selCampeonato.UseVisualStyleBackColor = False
        '
        'selPais
        '
        Me.selPais.AutoSize = True
        Me.selPais.BackColor = System.Drawing.Color.Transparent
        Me.selPais.CausesValidation = False
        Me.selPais.ForeColor = System.Drawing.Color.Black
        Me.selPais.Location = New System.Drawing.Point(131, 319)
        Me.selPais.Name = "selPais"
        Me.selPais.Size = New System.Drawing.Size(106, 17)
        Me.selPais.TabIndex = 12
        Me.selPais.Text = "Seleção por Pais"
        Me.selPais.UseVisualStyleBackColor = False
        '
        'todosGol
        '
        Me.todosGol.AutoSize = True
        Me.todosGol.BackColor = System.Drawing.Color.Transparent
        Me.todosGol.CausesValidation = False
        Me.todosGol.ForeColor = System.Drawing.Color.Black
        Me.todosGol.Location = New System.Drawing.Point(426, 196)
        Me.todosGol.Name = "todosGol"
        Me.todosGol.Size = New System.Drawing.Size(161, 17)
        Me.todosGol.TabIndex = 11
        Me.todosGol.Text = "Todos os Goleiros (Aleatória)"
        Me.todosGol.UseVisualStyleBackColor = False
        '
        'todosJog
        '
        Me.todosJog.AutoSize = True
        Me.todosJog.BackColor = System.Drawing.Color.Transparent
        Me.todosJog.CausesValidation = False
        Me.todosJog.ForeColor = System.Drawing.Color.Black
        Me.todosJog.Location = New System.Drawing.Point(426, 67)
        Me.todosJog.Name = "todosJog"
        Me.todosJog.Size = New System.Drawing.Size(172, 17)
        Me.todosJog.TabIndex = 5
        Me.todosJog.Text = "Todos os Jogadores (Aleatória)"
        Me.todosJog.UseVisualStyleBackColor = False
        '
        'selNacioJog
        '
        Me.selNacioJog.AutoSize = True
        Me.selNacioJog.BackColor = System.Drawing.Color.Transparent
        Me.selNacioJog.CausesValidation = False
        Me.selNacioJog.ForeColor = System.Drawing.Color.Black
        Me.selNacioJog.Location = New System.Drawing.Point(266, 67)
        Me.selNacioJog.Name = "selNacioJog"
        Me.selNacioJog.Size = New System.Drawing.Size(154, 17)
        Me.selNacioJog.TabIndex = 4
        Me.selNacioJog.Text = "Seleção por Nacionalidade"
        Me.selNacioJog.UseVisualStyleBackColor = False
        '
        'selClubeJog
        '
        Me.selClubeJog.AutoSize = True
        Me.selClubeJog.BackColor = System.Drawing.Color.Transparent
        Me.selClubeJog.CausesValidation = False
        Me.selClubeJog.ForeColor = System.Drawing.Color.Black
        Me.selClubeJog.Location = New System.Drawing.Point(131, 68)
        Me.selClubeJog.Name = "selClubeJog"
        Me.selClubeJog.Size = New System.Drawing.Size(113, 17)
        Me.selClubeJog.TabIndex = 3
        Me.selClubeJog.Text = "Seleção por Clube"
        Me.selClubeJog.UseVisualStyleBackColor = False
        '
        'rdbGoleiro
        '
        Me.rdbGoleiro.AutoSize = True
        Me.rdbGoleiro.BackColor = System.Drawing.Color.Transparent
        Me.rdbGoleiro.CausesValidation = False
        Me.rdbGoleiro.ForeColor = System.Drawing.Color.Black
        Me.rdbGoleiro.Location = New System.Drawing.Point(17, 216)
        Me.rdbGoleiro.Name = "rdbGoleiro"
        Me.rdbGoleiro.Size = New System.Drawing.Size(58, 17)
        Me.rdbGoleiro.TabIndex = 2
        Me.rdbGoleiro.TabStop = True
        Me.rdbGoleiro.Text = "Goleiro"
        Me.rdbGoleiro.UseVisualStyleBackColor = False
        '
        'rdbJogadores
        '
        Me.rdbJogadores.AutoSize = True
        Me.rdbJogadores.BackColor = System.Drawing.Color.Transparent
        Me.rdbJogadores.CausesValidation = False
        Me.rdbJogadores.ForeColor = System.Drawing.Color.Black
        Me.rdbJogadores.Location = New System.Drawing.Point(17, 87)
        Me.rdbJogadores.Name = "rdbJogadores"
        Me.rdbJogadores.Size = New System.Drawing.Size(63, 17)
        Me.rdbJogadores.TabIndex = 1
        Me.rdbJogadores.TabStop = True
        Me.rdbJogadores.Text = "Jogador"
        Me.rdbJogadores.UseVisualStyleBackColor = False
        '
        'rdbClube
        '
        Me.rdbClube.AutoSize = True
        Me.rdbClube.BackColor = System.Drawing.Color.Transparent
        Me.rdbClube.CausesValidation = False
        Me.rdbClube.ForeColor = System.Drawing.Color.Black
        Me.rdbClube.Location = New System.Drawing.Point(17, 339)
        Me.rdbClube.Name = "rdbClube"
        Me.rdbClube.Size = New System.Drawing.Size(52, 17)
        Me.rdbClube.TabIndex = 0
        Me.rdbClube.TabStop = True
        Me.rdbClube.Text = "Clube"
        Me.rdbClube.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(956, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 31)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "X"
        '
        'btnConfirmar
        '
        Me.btnConfirmar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnConfirmar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConfirmar.ForeColor = System.Drawing.Color.Black
        Me.btnConfirmar.Location = New System.Drawing.Point(813, 437)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(111, 55)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Comparar"
        Me.btnConfirmar.UseVisualStyleBackColor = False
        '
        'btnLimpar
        '
        Me.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnLimpar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpar.ForeColor = System.Drawing.Color.Black
        Me.btnLimpar.Location = New System.Drawing.Point(948, 437)
        Me.btnLimpar.Name = "btnLimpar"
        Me.btnLimpar.Size = New System.Drawing.Size(111, 55)
        Me.btnLimpar.TabIndex = 6
        Me.btnLimpar.Text = "Limpar"
        Me.btnLimpar.UseVisualStyleBackColor = False
        '
        'btnSair
        '
        Me.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSair.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSair.ForeColor = System.Drawing.Color.Black
        Me.btnSair.Location = New System.Drawing.Point(1080, 437)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(111, 55)
        Me.btnSair.TabIndex = 7
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(729, 104)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(218, 284)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(1022, 104)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(210, 284)
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'lklConfirmaOpcao1
        '
        Me.lklConfirmaOpcao1.AutoSize = True
        Me.lklConfirmaOpcao1.Location = New System.Drawing.Point(790, 402)
        Me.lklConfirmaOpcao1.Name = "lklConfirmaOpcao1"
        Me.lklConfirmaOpcao1.Size = New System.Drawing.Size(86, 13)
        Me.lklConfirmaOpcao1.TabIndex = 10
        Me.lklConfirmaOpcao1.TabStop = True
        Me.lklConfirmaOpcao1.Text = "Confirmar Opção"
        '
        'lklConfirmaOpcao2
        '
        Me.lklConfirmaOpcao2.AutoSize = True
        Me.lklConfirmaOpcao2.Location = New System.Drawing.Point(1087, 402)
        Me.lklConfirmaOpcao2.Name = "lklConfirmaOpcao2"
        Me.lklConfirmaOpcao2.Size = New System.Drawing.Size(86, 13)
        Me.lklConfirmaOpcao2.TabIndex = 11
        Me.lklConfirmaOpcao2.TabStop = True
        Me.lklConfirmaOpcao2.Text = "Confirmar Opção"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(639, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 20)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "COMPARAÇÕES"
        '
        'Comparacoes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.ClientSize = New System.Drawing.Size(1286, 504)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lklConfirmaOpcao2)
        Me.Controls.Add(Me.lklConfirmaOpcao1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnLimpar)
        Me.Controls.Add(Me.btnConfirmar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmbSelecionado1)
        Me.Controls.Add(Me.cmbSelecionado2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Comparacoes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Comparações"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbSelecionado2 As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSelecionado1 As System.Windows.Forms.ComboBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rdbGoleiro As System.Windows.Forms.RadioButton
    Friend WithEvents rdbJogadores As System.Windows.Forms.RadioButton
    Friend WithEvents rdbClube As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnConfirmar As System.Windows.Forms.Button
    Friend WithEvents btnLimpar As System.Windows.Forms.Button
    Friend WithEvents btnSair As System.Windows.Forms.Button
    Friend WithEvents todosGol As System.Windows.Forms.CheckBox
    Friend WithEvents todosJog As System.Windows.Forms.CheckBox
    Friend WithEvents selNacioJog As System.Windows.Forms.CheckBox
    Friend WithEvents selClubeJog As System.Windows.Forms.CheckBox
    Friend WithEvents txtNomeJog As System.Windows.Forms.TextBox
    Friend WithEvents selNomeJog As System.Windows.Forms.CheckBox
    Friend WithEvents todosClubes As System.Windows.Forms.CheckBox
    Friend WithEvents selCampeonato As System.Windows.Forms.CheckBox
    Friend WithEvents selPais As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPaisJog As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClubeJog As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPaisGol As System.Windows.Forms.ComboBox
    Friend WithEvents cmbClubeGol As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomeGol As System.Windows.Forms.TextBox
    Friend WithEvents selNomeGol As System.Windows.Forms.CheckBox
    Friend WithEvents selNacioGol As System.Windows.Forms.CheckBox
    Friend WithEvents selClubeGol As System.Windows.Forms.CheckBox
    Friend WithEvents cmbCamp As System.Windows.Forms.ComboBox
    Friend WithEvents cmbPaisClube As System.Windows.Forms.ComboBox
    Friend WithEvents txtNomeClube As System.Windows.Forms.TextBox
    Friend WithEvents selNomeClube As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents lklConfirmaOpcao1 As System.Windows.Forms.LinkLabel
    Friend WithEvents lklConfirmaOpcao2 As System.Windows.Forms.LinkLabel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
