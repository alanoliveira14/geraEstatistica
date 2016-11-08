Imports System.Data.SqlClient
Public Class frmSistema

    Private Sub JogadorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JogadorToolStripMenuItem.Click
        CadJogador.Show()
    End Sub

    Private Sub TécnicoToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TécnicoToolStripMenuItem.Click
        CadTecnico.Show()
    End Sub

    Private Sub ClubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClubeToolStripMenuItem.Click
        CadClube.Show()
    End Sub

    Private Sub EstádioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EstádioToolStripMenuItem.Click
        CadEstadio.Show()
    End Sub

    Private Sub JogadorToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles JogadorToolStripMenuItem1.Click
        Consulta.Show()
    End Sub

    Private Sub NovaPartidaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NovaPartidaToolStripMenuItem.Click
        CadPartida.Show()
    End Sub

    Private Sub InformaçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InformaçõesToolStripMenuItem.Click
        ConsuPartida.Show()
    End Sub

    Private Sub AoVivoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        aoVivo.Show()
    End Sub

    Private Sub frmSistema_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm1.Hide()
        Me.BackgroundImageLayout = ImageLayout.Tile
        If LoginForm1.a = 5 Then
            ConsultaToolStripMenuItem.Visible = False
            PartidaToolStripMenuItem1.Visible = False
            ComparacoesToolStripMenuItem.Visible = False
        ElseIf LoginForm1.a = 4 Or LoginForm1.a = 3 Then
            GerenciamentoToolStripMenuItem.Visible = False
            FerramentasToolStripMenuItem.Visible = False
        ElseIf LoginForm1.a = 2 Then
            GerenciamentoToolStripMenuItem.Visible = False
        End If
        Label3.Text = Now
        Timer1.Interval = 1000
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick() Handles Timer1.Tick
        Me.Label3.Text = DateTime.Now
    End Sub
    Private Sub ComparacoesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComparacoesToolStripMenuItem.Click
        Comparacoes.Show()
    End Sub

    Private Sub BackupERestoreToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BackupERestoreToolStripMenuItem.Click
        BackupRestore.Show()
    End Sub

    Private Sub CidadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CidadeToolStripMenuItem.Click
        CadPaisECidade.Show()
    End Sub

    Private Sub CadastroToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroToolStripMenuItem1.Click
        CadCampeonato.Show()
    End Sub

    Private Sub CadastroClubeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastroClubeToolStripMenuItem.Click
        PrepararCamp.Show()

    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        LoginForm1.Show()
        LoginForm1.txtusu.Text = ""
        LoginForm1.txtSenha.Text = ""
        LoginForm1.txtusu.Focus()
        Me.Close()
    End Sub

    Private Sub PesquisarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles PesquisarToolStripMenuItem.Click
        ConsultarEmpresa.Show()
    End Sub

    Private Sub FuncionárioToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FuncionárioToolStripMenuItem1.Click
        cadFuncionario.Show()
    End Sub

    Private Sub ClienteToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClienteToolStripMenuItem1.Click
        cadCliente.Show()
    End Sub

    Private Sub PagarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PagarToolStripMenuItem.Click
        contas.Show()
    End Sub

    Private Sub ReceberToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceberToolStripMenuItem.Click
        consultaConta.Show()
    End Sub

    Private Sub LerMensagensToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LerMensagensToolStripMenuItem.Click
        lermsg.Show()
    End Sub
End Class
