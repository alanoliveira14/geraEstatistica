Imports System.Data.SqlClient

Public Class Comparacoes
    '--------------------------------------------------------------------------
    'Sistema
    Public cod1, cod2 As Integer

    Private Sub cmbSelecionado1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelecionado1.SelectedIndexChanged
        If rdbClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select imagem from clube where codClube = " & cmbSelecionado1.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim z As String = cmd.ExecuteScalar
                PictureBox1.ImageLocation = z
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select imagem from jogador where codJogador = " & cmbSelecionado1.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim z As String = cmd.ExecuteScalar
                PictureBox1.ImageLocation = z
                PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
            End Using
        End If

    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If Me.cmbSelecionado1.Text = "" Or cmbSelecionado2.Text = "" Then
            MessageBox.Show("Por favor, selecione a segunda opção", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            cod1 = cmbSelecionado1.SelectedValue
            cod2 = cmbSelecionado2.SelectedValue
            If rdbJogadores.Checked = True Then
                ComparaJogadores2.Show()
                Me.Hide()
            ElseIf rdbGoleiro.Checked = True Then
                ComparaGoleiro.Show()
                Me.Hide()
            Else
                ComparaClub.codClub1 = cmbSelecionado1.SelectedValue
                ComparaClub.codClub2 = cmbSelecionado2.SelectedValue
                ComparaClub.Show()
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub lklConfirmaOpcao1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklConfirmaOpcao1.LinkClicked
        If lklConfirmaOpcao1.Text = "Confirmar Opção" Then
            Me.cmbSelecionado1.Enabled = False
            Me.lklConfirmaOpcao1.Text = "Remover Opção"
            If rdbJogadores.Checked = True Then
                fncComparaJogador()
            ElseIf rdbGoleiro.Checked = True Then
                fncComparaGoleiro()
            Else
                fncComparaClube()
            End If
        Else
            Me.cmbSelecionado1.Enabled = True
            Me.cmbSelecionado1.Text = ""
            Me.PictureBox1.Image = Nothing
            Me.lklConfirmaOpcao1.Text = "Confirmar Opção"

        End If

    End Sub

    Private Sub cmbSelecionado2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSelecionado2.SelectedIndexChanged
        If rdbClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select imagem from clube where codClube = " & cmbSelecionado2.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim z As String = cmd.ExecuteScalar
                PictureBox2.ImageLocation = z
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select imagem from jogador where codJogador = " & cmbSelecionado2.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim z As String = cmd.ExecuteScalar
                PictureBox2.ImageLocation = z
                PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
            End Using
        End If
    End Sub

    Private Sub lklConfirmaOpcao2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lklConfirmaOpcao2.LinkClicked
        If lklConfirmaOpcao2.Text = "Confirmar Opção" Then
            Me.cmbSelecionado2.Enabled = False
            Me.lklConfirmaOpcao2.Text = "Remover Opção"

            If rdbJogadores.Checked = True Then
                fncComparaJogador()
            ElseIf rdbGoleiro.Checked = True Then
                fncComparaGoleiro()
            Else
                fncComparaClube()
            End If

        Else
            Me.cmbSelecionado2.Enabled = True
            Me.cmbSelecionado2.Text = ""
            Me.PictureBox2.Image = Nothing
            Me.lklConfirmaOpcao2.Text = "Confirmar Opção"
        End If
    End Sub

    Private Sub Comparacoes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        enables()
    End Sub

    Private Sub rdbJogadores_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbJogadores.Click
        fncComparaJogador()
        Me.cmbSelecionado1.Text = ""
        Me.cmbSelecionado2.Text = ""
        Me.PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        Me.cmbSelecionado1.Enabled = True
        Me.cmbSelecionado2.Enabled = True
        Me.lklConfirmaOpcao1.Text = "Confirmar Opção"
        Me.lklConfirmaOpcao2.Text = "Confirmar Opção"

    End Sub

    Private Sub rdbGoleiro_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbGoleiro.Click
        fncComparaGoleiro()
        Me.cmbSelecionado1.Text = ""
        Me.cmbSelecionado2.Text = ""
        Me.PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        Me.cmbSelecionado1.Enabled = True
        Me.cmbSelecionado2.Enabled = True
        Me.lklConfirmaOpcao1.Text = "Confirmar Opção"
        Me.lklConfirmaOpcao2.Text = "Confirmar Opção"
    End Sub

    Private Sub rdbClube_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdbClube.Click
        fncComparaClube()
        Me.cmbSelecionado1.Text = ""
        Me.cmbSelecionado2.Text = ""
        Me.PictureBox1.Image = Nothing
        PictureBox2.Image = Nothing
        Me.cmbSelecionado1.Enabled = True
        Me.cmbSelecionado2.Enabled = True
        Me.lklConfirmaOpcao1.Text = "Confirmar Opção"
        Me.lklConfirmaOpcao2.Text = "Confirmar Opção"
        selCampeonato_CheckedChanged()
        selPais_CheckedChanged()

    End Sub

    'Jogador
    Public Sub fncSelectJog1()
        If Me.selClubeJog.Checked = True And Me.selNacioJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and codPais = " & Me.cmbPaisJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNacioJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True And Me.selNacioJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and codClube = " & Me.cmbClubeJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado1.ValueMember = "codJogador"
                    Me.cmbSelecionado1.DisplayMember = "apelido"
                    Me.cmbSelecionado1.DataSource = dt
                End If

            End Using
        ElseIf Me.selNacioJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    Me.cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado1.ValueMember = "codJogador"
                    Me.cmbSelecionado1.DisplayMember = "apelido"
                    Me.cmbSelecionado1.DataSource = dt
                End If

            End Using
        ElseIf Me.todosJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        End If

    End Sub

    Public Sub fncSelectJog2()
        If Me.selClubeJog.Checked = True And Me.selNacioJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and codPais = " & Me.cmbPaisJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNacioJog.Checked = True And Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True And Me.selNacioJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and codClube = " & Me.cmbClubeJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado2.ValueMember = "codJogador"
                    Me.cmbSelecionado2.DisplayMember = "apelido"
                    Me.cmbSelecionado2.DataSource = dt
                End If

            End Using
        ElseIf Me.selNacioJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisJog.SelectedValue & " and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNomeJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where apelido like '%" & Me.txtNomeJog.Text & "%' and codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    Me.cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado2.ValueMember = "codJogador"
                    Me.cmbSelecionado2.DisplayMember = "apelido"
                    Me.cmbSelecionado2.DataSource = dt
                End If

            End Using
        ElseIf Me.todosJog.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPosicao <> 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        End If

    End Sub

    Private Sub selClubeJog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selClubeJog.CheckedChanged
        If selClubeJog.Checked Then
            cmbClubeJog.Enabled = True
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select * from clube"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmbClubeJog.ValueMember = "codClube"
                cmbClubeJog.DisplayMember = "alcunha"
                cmbClubeJog.DataSource = dt
                cn.Close()
            End Using
        Else
            cmbClubeJog.SelectedIndex = -1
            cmbClubeJog.Enabled = False
        End If

    End Sub

    Private Sub selNacioJog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selNacioJog.CheckedChanged
        If selNacioJog.Checked Then
            cmbPaisJog.Enabled = True
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select * from pais"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmbPaisJog.ValueMember = "codPais"
                cmbPaisJog.DisplayMember = "pais"
                cmbPaisJog.DataSource = dt
                cn.Close()
            End Using
        Else
            cmbPaisJog.SelectedIndex = -1
            cmbPaisJog.Enabled = False
        End If
    End Sub

    Private Sub selNomeJog_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selNomeJog.CheckedChanged
        If selNomeJog.Checked = True Then
            txtNomeJog.Enabled = True
        Else
            txtNomeJog.Enabled = False
        End If
    End Sub

    Private Sub todosJog_CheckedChanged() Handles todosJog.CheckedChanged
        If todosJog.Checked = True Then
            selClubeJog.Checked = False
            selClubeJog.Enabled = False
            selNacioJog.Checked = False
            selNacioJog.Enabled = False
            txtNomeJog.Enabled = False
            cmbPaisJog.SelectedIndex = -1
            cmbPaisJog.Enabled = False
            cmbClubeJog.SelectedIndex = -1
            cmbClubeJog.Enabled = False
        Else
            selClubeJog.Enabled = True
            selNacioJog.Enabled = True
            txtNomeJog.Enabled = True
        End If
    End Sub

    Private Sub txtNomeJog_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeJog.GotFocus
        txtNomeJog.Text = ""
    End Sub

    Private Sub txtNomeJog_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNomeJog.TextChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectJog2()
        Else
            fncSelectJog1()
        End If
    End Sub

    Private Sub cmbClubeJog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbClubeJog.SelectedIndexChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectJog2()
        Else
            fncSelectJog1()
        End If
    End Sub

    Private Sub cmbPaisJog_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisJog.SelectedIndexChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectJog2()
        Else
            fncSelectJog1()
        End If
    End Sub

    'Goleiro------------------------------------------------------------------------------------------
    Public Sub fncSelectGoleiro1()
        If Me.selClubeGol.Checked = True And Me.selNacioGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and codPais = " & Me.cmbPaisGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNacioGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True And Me.selNacioGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and codClube = " & Me.cmbClubeGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNacioGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.todosGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codJogador"
                Me.cmbSelecionado1.DisplayMember = "apelido"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        End If
    End Sub

    Public Sub fncSelectGoleiro2()
        If Me.selClubeGol.Checked = True And Me.selNacioGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and codPais = " & Me.cmbPaisGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNacioGol.Checked = True And Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True And Me.selNacioGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and codClube = " & Me.cmbClubeGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selClubeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codClube = " & Me.cmbClubeGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNacioGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPais = " & Me.cmbPaisGol.SelectedValue & " and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNomeGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where apelido like '%" & Me.txtNomeGol.Text & "%' and codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.todosGol.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from jogador where codPosicao = 1"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codJogador"
                Me.cmbSelecionado2.DisplayMember = "apelido"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        End If
    End Sub

    Private Sub selClubeGol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selClubeGol.CheckedChanged
        If selClubeGol.Checked Then
            cmbClubeGol.Enabled = True
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select * from clube"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmbClubeGol.ValueMember = "codClube"
                cmbClubeGol.DisplayMember = "alcunha"
                cmbClubeGol.DataSource = dt
                cn.Close()
            End Using
        Else
            cmbClubeGol.SelectedIndex = -1
            cmbClubeGol.Enabled = False
        End If
    End Sub

    Private Sub selNacioGol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selNacioGol.CheckedChanged
        If selNacioGol.Checked Then
            cmbPaisGol.Enabled = True
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select * from pais"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmbPaisGol.ValueMember = "codPais"
                cmbPaisGol.DisplayMember = "pais"
                cmbPaisGol.DataSource = dt
                cn.Close()
            End Using
        Else
            cmbPaisGol.SelectedIndex = -1
            cmbPaisGol.Enabled = False
        End If
    End Sub

    Private Sub selNomeGol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selNomeGol.CheckedChanged
        If selNomeGol.Checked = True Then
            txtNomeGol.Enabled = True
        Else
            txtNomeGol.Enabled = False
        End If
    End Sub

    Private Sub todosGol_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles todosGol.CheckedChanged
        If todosGol.Checked = True Then
            selClubeGol.Checked = False
            selClubeGol.Enabled = False
            selNacioGol.Checked = False
            selNacioGol.Enabled = False
            txtNomeGol.Enabled = False
            cmbPaisGol.SelectedIndex = -1
            cmbPaisGol.Enabled = False
            cmbClubeGol.SelectedIndex = -1
            cmbClubeGol.Enabled = False
        Else
            selClubeGol.Enabled = True
            selNacioGol.Enabled = True
            txtNomeGol.Enabled = True
        End If
    End Sub

    Private Sub txtNomeGol_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeGol.GotFocus
        txtNomeGol.Text = ""
    End Sub

    Private Sub txtNomeGol_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles txtNomeGol.TextChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectGoleiro2()
        Else
            fncSelectGoleiro1()
        End If
    End Sub

    Private Sub cmbPaisGol_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbPaisGol.SelectedIndexChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectGoleiro2()
        Else
            fncSelectGoleiro1()
        End If
    End Sub

    Private Sub cmbClubeGol_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbClubeGol.SelectedIndexChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectGoleiro2()
        Else
            fncSelectGoleiro1()
        End If
    End Sub


    'Clube---------------------------------------------------------------------------------------------

    Public Sub fncSelectClube1()
        If Me.selPais.Checked = True And Me.selCampeonato.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where clube.codPais = " & Me.cmbPaisClube.SelectedValue & " and ClubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcunha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube where clube.codPais = " & Me.cmbPaisClube.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcunha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selCampeonato.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubeCamp.codClube where clubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcunha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True And Me.selCampeonato.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubeCamp.codClube where codPais = " & Me.cmbPaisClube.SelectedValue & " and clubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcunha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube where codPais = " & Me.cmbPaisClube.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado1.ValueMember = "codClube"
                    Me.cmbSelecionado1.DisplayMember = "alcunha"
                    Me.cmbSelecionado1.DataSource = dt
                End If
            End Using
        ElseIf Me.selCampeonato.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where ClubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcunha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        ElseIf Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube where apelido like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    Me.cmbSelecionado1.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado1.ValueMember = "codClube"
                    Me.cmbSelecionado1.DisplayMember = "alcunha"
                    Me.cmbSelecionado1.DataSource = dt
                End If
            End Using
        ElseIf Me.todosClubes.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado1.ValueMember = "codClube"
                Me.cmbSelecionado1.DisplayMember = "alcuha"
                Me.cmbSelecionado1.DataSource = dt
            End Using
        End If

    End Sub

    Public Sub fncSelectClube2()
        If Me.selPais.Checked = True And Me.selCampeonato.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where clube.codPais = " & Me.cmbPaisClube.SelectedValue & " and ClubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcunha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where clube.codPais = " & Me.cmbPaisClube.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcunha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selCampeonato.Checked = True And Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubeCamp.codClube where clubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & " and nomeCompleto like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcunha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True And Me.selCampeonato.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubeCamp.codClube where codPais = " & Me.cmbPaisClube.SelectedValue & " and clubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcunha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selPais.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube where codPais = " & Me.cmbPaisClube.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    cmbSelecionado2.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado2.ValueMember = "codClube"
                    Me.cmbSelecionado2.DisplayMember = "alcunha"
                    Me.cmbSelecionado2.DataSource = dt
                End If

            End Using
        ElseIf Me.selCampeonato.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubCamp.codClube where ClubCamp.codCampeonato = " & Me.cmbCamp.SelectedValue & ""
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcunha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        ElseIf Me.selNomeClube.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube inner join ClubCamp on clube.codClube = clubeCamp.codClube where apelido like '%" & Me.txtNomeClube.Text & "%'"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                If dt.Rows.Count = 0 Then
                    Me.cmbSelecionado2.Text = "Nenhum Jogador encontrado"
                Else
                    Me.cmbSelecionado2.ValueMember = "codClube"
                    Me.cmbSelecionado2.DisplayMember = "alcunha"
                    Me.cmbSelecionado2.DataSource = dt
                End If

            End Using
        ElseIf Me.todosClubes.Checked = True Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql2 As String = "select * from clube"
                Dim cmd = New SqlCommand(sql2, cn)
                Dim da = New SqlDataAdapter(cmd)
                Dim dt = New DataTable
                da.Fill(dt)
                Me.cmbSelecionado2.ValueMember = "codClube"
                Me.cmbSelecionado2.DisplayMember = "alcuha"
                Me.cmbSelecionado2.DataSource = dt
            End Using
        End If
    End Sub

    Private Sub cmbPaisClube_SelectedIndexChanged() Handles cmbPaisClube.SelectedValueChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectClube2()
        Else
            fncSelectClube1()
        End If
    End Sub

    Private Sub cmbCamp_SelectedIndexChanged() Handles cmbCamp.SelectedIndexChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectClube2()
        Else
            fncSelectClube1()
        End If
    End Sub

    Private Sub txtNomeClube_TextChanged() Handles txtNomeClube.TextChanged
        If Me.lklConfirmaOpcao1.Text = "Remover Opção" Then
            fncSelectClube2()
        Else
            fncSelectClube1()
        End If
    End Sub

    Private Sub txtNomeClube_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtNomeClube.GotFocus
        txtNomeClube.Text = ""
    End Sub

    Private Sub btnSair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSair.Click
        Me.Close()
    End Sub

    Private Sub selPais_CheckedChanged() Handles selPais.CheckedChanged
        'If selPais.Checked Then
        '    cmbPaisClube.Enabled = True
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select * from pais"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            cmbPaisClube.ValueMember = "codPais"
            cmbPaisClube.DisplayMember = "pais"
            cmbPaisClube.DataSource = dt
            cn.Close()
        End Using
        'Else
        'cmbPaisClube.SelectedIndex = -1
        'cmbPaisClube.Enabled = False
        'End If
    End Sub

    Private Sub selCampeonato_CheckedChanged() Handles selCampeonato.CheckedChanged
        If selCampeonato.Checked Then
            cmbCamp.Enabled = True
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "select * from campeonato"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmbCamp.ValueMember = "codCampeonato"
                cmbCamp.DisplayMember = "nome"
                cmbCamp.DataSource = dt
                cn.Close()
            End Using
        Else
            cmbCamp.SelectedIndex = -1
            cmbCamp.Enabled = False
        End If
    End Sub


End Class