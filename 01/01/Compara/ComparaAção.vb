Imports System.Data.SqlClient

Public Class ComparaAção

    Private Sub ComparaAção_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboAcao()
        carregaComboCampeonato()
        carregaComboClubes()
    End Sub

    Public Sub carregaComboAcao()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from acao"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbAcao.ValueMember = "codAcao"
                Me.cmbAcao.DisplayMember = "nomeAcao"
                Me.cmbAcao.DataSource = dt
                Me.cmbAcao.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub carregaComboCampeonato()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from campeonato"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbCamp.ValueMember = "codCampeonato"
                Me.cmbCamp.DisplayMember = "nome"
                Me.cmbCamp.DataSource = dt
                Me.cmbCamp.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub carregaComboClubes()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from clube"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbClube.ValueMember = "codClube"
                Me.cmbClube.DisplayMember = "alcunha"
                Me.cmbClube.DataSource = dt
                Me.cmbClube.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub consultaPricipal()
        If selCamp.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "exec contaAcaoRestritoTodos " & Me.cmbAcao.SelectedValue & ", " & Me.cmbCamp.SelectedValue & ", " & Me.cmbClube.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid.DataSource = dt
                cn.Close()
            End Using
        ElseIf selCamp.Checked Then
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "exec contaAcaoRestritoCamp " & Me.cmbAcao.SelectedValue & ", " & Me.cmbCamp.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid.DataSource = dt
                cn.Close()
            End Using
        ElseIf selTime.Checked Then
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Dim sql As String = "exec contaAcaoRestritoClube " & Me.cmbAcao.SelectedValue & ", " & cmbClube.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid.DataSource = dt
                cn.Close()
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "exec ContaAcaoMundial " & Me.cmbAcao.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid.DataSource = dt
                cn.Close()
            End Using
        End If
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        consultaPricipal()
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub
End Class