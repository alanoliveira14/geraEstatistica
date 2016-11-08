<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSistema
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSistema))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TécnicoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogadorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EstádioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CampeonatoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CadastroClubeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CidadeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ConsultaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.JogadorToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PartidaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NovaPartidaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformaçõesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComparacoesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FerramentasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackupERestoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LerMensagensToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GerenciamentoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PesquisarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FuncionárioToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClienteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PagarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReceberToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Transparent
        Me.MenuStrip1.Font = New System.Drawing.Font("Century", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem, Me.ConsultaToolStripMenuItem, Me.PartidaToolStripMenuItem1, Me.ComparacoesToolStripMenuItem, Me.FerramentasToolStripMenuItem, Me.GerenciamentoToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1370, 31)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastroToolStripMenuItem
        '
        Me.CadastroToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TécnicoToolStripMenuItem, Me.ClubeToolStripMenuItem, Me.JogadorToolStripMenuItem, Me.EstádioToolStripMenuItem, Me.CidadeToolStripMenuItem, Me.CampeonatoToolStripMenuItem})
        Me.CadastroToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.CadastroToolStripMenuItem.Name = "CadastroToolStripMenuItem"
        Me.CadastroToolStripMenuItem.Size = New System.Drawing.Size(111, 27)
        Me.CadastroToolStripMenuItem.Text = "Cadastro"
        '
        'TécnicoToolStripMenuItem
        '
        Me.TécnicoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.TécnicoToolStripMenuItem.Name = "TécnicoToolStripMenuItem"
        Me.TécnicoToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.TécnicoToolStripMenuItem.Text = "Técnico"
        '
        'ClubeToolStripMenuItem
        '
        Me.ClubeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClubeToolStripMenuItem.Name = "ClubeToolStripMenuItem"
        Me.ClubeToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.ClubeToolStripMenuItem.Text = "Clube"
        '
        'JogadorToolStripMenuItem
        '
        Me.JogadorToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.JogadorToolStripMenuItem.Name = "JogadorToolStripMenuItem"
        Me.JogadorToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.JogadorToolStripMenuItem.Text = "Jogador"
        '
        'EstádioToolStripMenuItem
        '
        Me.EstádioToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.EstádioToolStripMenuItem.Name = "EstádioToolStripMenuItem"
        Me.EstádioToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.EstádioToolStripMenuItem.Text = "Estádio"
        '
        'CampeonatoToolStripMenuItem
        '
        Me.CampeonatoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastroToolStripMenuItem1, Me.CadastroClubeToolStripMenuItem})
        Me.CampeonatoToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CampeonatoToolStripMenuItem.Name = "CampeonatoToolStripMenuItem"
        Me.CampeonatoToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.CampeonatoToolStripMenuItem.Text = "Campeonato"
        '
        'CadastroToolStripMenuItem1
        '
        Me.CadastroToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.CadastroToolStripMenuItem1.Name = "CadastroToolStripMenuItem1"
        Me.CadastroToolStripMenuItem1.Size = New System.Drawing.Size(298, 28)
        Me.CadastroToolStripMenuItem1.Text = "Cadastro Campeonato"
        '
        'CadastroClubeToolStripMenuItem
        '
        Me.CadastroClubeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CadastroClubeToolStripMenuItem.Name = "CadastroClubeToolStripMenuItem"
        Me.CadastroClubeToolStripMenuItem.Size = New System.Drawing.Size(298, 28)
        Me.CadastroClubeToolStripMenuItem.Text = "Inserir Clube"
        '
        'CidadeToolStripMenuItem
        '
        Me.CidadeToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.CidadeToolStripMenuItem.Name = "CidadeToolStripMenuItem"
        Me.CidadeToolStripMenuItem.Size = New System.Drawing.Size(203, 28)
        Me.CidadeToolStripMenuItem.Text = "País/Cidade"
        '
        'ConsultaToolStripMenuItem
        '
        Me.ConsultaToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.JogadorToolStripMenuItem1})
        Me.ConsultaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ConsultaToolStripMenuItem.Name = "ConsultaToolStripMenuItem"
        Me.ConsultaToolStripMenuItem.Size = New System.Drawing.Size(111, 27)
        Me.ConsultaToolStripMenuItem.Text = "Consulta"
        '
        'JogadorToolStripMenuItem1
        '
        Me.JogadorToolStripMenuItem1.ForeColor = System.Drawing.Color.Black
        Me.JogadorToolStripMenuItem1.Name = "JogadorToolStripMenuItem1"
        Me.JogadorToolStripMenuItem1.Size = New System.Drawing.Size(152, 28)
        Me.JogadorToolStripMenuItem1.Text = "Dados"
        '
        'PartidaToolStripMenuItem1
        '
        Me.PartidaToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovaPartidaToolStripMenuItem, Me.InformaçõesToolStripMenuItem})
        Me.PartidaToolStripMenuItem1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.PartidaToolStripMenuItem1.Name = "PartidaToolStripMenuItem1"
        Me.PartidaToolStripMenuItem1.Size = New System.Drawing.Size(96, 27)
        Me.PartidaToolStripMenuItem1.Text = "Partida"
        '
        'NovaPartidaToolStripMenuItem
        '
        Me.NovaPartidaToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.NovaPartidaToolStripMenuItem.Name = "NovaPartidaToolStripMenuItem"
        Me.NovaPartidaToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.NovaPartidaToolStripMenuItem.Text = "Nova Partida"
        '
        'InformaçõesToolStripMenuItem
        '
        Me.InformaçõesToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.InformaçõesToolStripMenuItem.Name = "InformaçõesToolStripMenuItem"
        Me.InformaçõesToolStripMenuItem.Size = New System.Drawing.Size(210, 28)
        Me.InformaçõesToolStripMenuItem.Text = "Informações"
        '
        'ComparacoesToolStripMenuItem
        '
        Me.ComparacoesToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ComparacoesToolStripMenuItem.Name = "ComparacoesToolStripMenuItem"
        Me.ComparacoesToolStripMenuItem.Size = New System.Drawing.Size(152, 27)
        Me.ComparacoesToolStripMenuItem.Text = "Comparações"
        '
        'FerramentasToolStripMenuItem
        '
        Me.FerramentasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BackupERestoreToolStripMenuItem, Me.LerMensagensToolStripMenuItem})
        Me.FerramentasToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.FerramentasToolStripMenuItem.Name = "FerramentasToolStripMenuItem"
        Me.FerramentasToolStripMenuItem.Size = New System.Drawing.Size(149, 27)
        Me.FerramentasToolStripMenuItem.Text = "Ferramentas"
        '
        'BackupERestoreToolStripMenuItem
        '
        Me.BackupERestoreToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.BackupERestoreToolStripMenuItem.Name = "BackupERestoreToolStripMenuItem"
        Me.BackupERestoreToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.BackupERestoreToolStripMenuItem.Text = "Backup e Restore"
        '
        'LerMensagensToolStripMenuItem
        '
        Me.LerMensagensToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.LerMensagensToolStripMenuItem.Name = "LerMensagensToolStripMenuItem"
        Me.LerMensagensToolStripMenuItem.Size = New System.Drawing.Size(251, 28)
        Me.LerMensagensToolStripMenuItem.Text = "Ler Mensagens"
        '
        'GerenciamentoToolStripMenuItem
        '
        Me.GerenciamentoToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PesquisarToolStripMenuItem, Me.FuncionárioToolStripMenuItem, Me.ClienteToolStripMenuItem})
        Me.GerenciamentoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GerenciamentoToolStripMenuItem.Name = "GerenciamentoToolStripMenuItem"
        Me.GerenciamentoToolStripMenuItem.Size = New System.Drawing.Size(171, 27)
        Me.GerenciamentoToolStripMenuItem.Text = "Gerenciamento"
        '
        'PesquisarToolStripMenuItem
        '
        Me.PesquisarToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.PesquisarToolStripMenuItem.Name = "PesquisarToolStripMenuItem"
        Me.PesquisarToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.PesquisarToolStripMenuItem.Text = "Pesquisar"
        '
        'FuncionárioToolStripMenuItem
        '
        Me.FuncionárioToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FuncionárioToolStripMenuItem1, Me.ClienteToolStripMenuItem1})
        Me.FuncionárioToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.FuncionárioToolStripMenuItem.Name = "FuncionárioToolStripMenuItem"
        Me.FuncionárioToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.FuncionárioToolStripMenuItem.Text = "Cadastrar"
        '
        'FuncionárioToolStripMenuItem1
        '
        Me.FuncionárioToolStripMenuItem1.Name = "FuncionárioToolStripMenuItem1"
        Me.FuncionárioToolStripMenuItem1.Size = New System.Drawing.Size(199, 28)
        Me.FuncionárioToolStripMenuItem1.Text = "Funcionário"
        '
        'ClienteToolStripMenuItem1
        '
        Me.ClienteToolStripMenuItem1.Name = "ClienteToolStripMenuItem1"
        Me.ClienteToolStripMenuItem1.Size = New System.Drawing.Size(199, 28)
        Me.ClienteToolStripMenuItem1.Text = "Cliente"
        '
        'ClienteToolStripMenuItem
        '
        Me.ClienteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PagarToolStripMenuItem, Me.ReceberToolStripMenuItem})
        Me.ClienteToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ClienteToolStripMenuItem.Name = "ClienteToolStripMenuItem"
        Me.ClienteToolStripMenuItem.Size = New System.Drawing.Size(179, 28)
        Me.ClienteToolStripMenuItem.Text = "Contas"
        '
        'PagarToolStripMenuItem
        '
        Me.PagarToolStripMenuItem.Name = "PagarToolStripMenuItem"
        Me.PagarToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.PagarToolStripMenuItem.Text = "Nova Conta"
        '
        'ReceberToolStripMenuItem
        '
        Me.ReceberToolStripMenuItem.Name = "ReceberToolStripMenuItem"
        Me.ReceberToolStripMenuItem.Size = New System.Drawing.Size(195, 28)
        Me.ReceberToolStripMenuItem.Text = "Consulta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Monotype Corsiva", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1262, 675)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Logoff"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Transparent
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(1262, 608)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(68, 66)
        Me.Button1.TabIndex = 3
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Monotype Corsiva", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(225, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(62, 675)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 36)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "hr"
        '
        'Timer1
        '
        '
        'frmSistema
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global._01.My.Resources.Resources.lionel_andres_leo_messi_3_by_mq18_d5ovkga
        Me.ClientSize = New System.Drawing.Size(1370, 772)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmSistema"
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents CadastroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogadorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TécnicoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EstádioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ConsultaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents JogadorToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CampeonatoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PartidaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NovaPartidaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformaçõesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComparacoesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FerramentasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BackupERestoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CidadeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CadastroClubeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents GerenciamentoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PesquisarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FuncionárioToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClienteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PagarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ReceberToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents LerMensagensToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
