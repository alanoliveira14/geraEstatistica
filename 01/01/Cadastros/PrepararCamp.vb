Imports System.Data.SqlClient

Public Class PrepararCamp

    Private Sub PrepararCamp_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaCamp()
        carregaTimes()
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub carregaTimes()
        Dim sql As String = "select codClube, alcunha from clube"
        CarregaCombo(cmbClube, sql)
    End Sub

    Private Sub carregaCamp()
        Dim sql As String = "select codCampeonato, nome from campeonato"
        CarregaCombo(cmbCamp, sql)
    End Sub

    Private Sub btnCadastrar_Click() Handles btnCadastar.Click
        If cmbCamp.Text = "" Or cmbClube.Text = "" Then
            MessageBox.Show("Por Favor, verefique as informações")
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Dim sql As String = "insert into clubCamp values (" & cmbCamp.SelectedValue & ", " & cmbClube.SelectedValue & ")"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim mr As SqlDataReader = cmd.ExecuteReader
                cn.Close()
                cn.Open()
                sql = "insert into advCamp values (" & cmbCamp.SelectedValue & ", " & cmbClube.SelectedValue & ")"
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                mr = cmd.ExecuteReader
                cn.Close()
                MessageBox.Show(Me.cmbClube.Text & " incluso no(a) " & cmbCamp.Text, "Concluído")
                cmbCamp_SelectedValueChanged()
            End Using
        End If
    End Sub

    Private Sub cmbCamp_SelectedValueChanged() Handles cmbCamp.SelectedIndexChanged
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select clube.alcunha from clubCamp inner join clube on ClubCamp.codClube = clube.codClube inner join campeonato on ClubCamp.codCampeonato = campeonato.codCampeonato where campeonato.codCampeonato = " & Me.cmbCamp.SelectedValue & ""
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            Me.ListBox1.DisplayMember = "alcunha"
            Me.ListBox1.DataSource = dt
        End Using
    End Sub
End Class