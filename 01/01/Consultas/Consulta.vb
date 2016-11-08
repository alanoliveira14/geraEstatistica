Imports System.Data.SqlClient

Public Class Consulta

    Private Sub btnConsulta_Click() Handles btnConsulta.Click
        Dim cn As New SqlConnection
        Dim cmd As New SqlCommand
        Dim da As New SqlDataAdapter
        Dim dt As New DataTable()
        dt_grid.DataSource = ""

        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        If Me.rdClube.Checked = False And Me.rdGoleiro.Checked = False And rdJogador.Checked = False Then
            MessageBox.Show("Por favor, selecione uma opção")
        Else
            If rdJogador.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    '.CommandText = "select codJogador as 'Código do Jogador', apelido as 'Nome do Jogador', clube as 'Clube do Jogador' from jogador where apelido like '%" & txtNome.Text & "%' and codPosicao >=2"
                    .CommandText = "select codJogador as 'Código do Jogador', apelido as 'Nome do Jogador', alcunha as 'Clube do Jogador' from jogador inner join clube on clube.codClube = jogador.codClube and  apelido like '%" & txtNome.Text & "%' where codPosicao>=2 order by clube.alcunha asc"
                    .CommandType = CommandType.Text
                End With

            ElseIf rdClube.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codClube as 'Código do Clube', alcunha as 'Clube' from clube where nomeCompleto like '%" & txtNome.Text & "%' "
                    .CommandType = CommandType.Text
                End With

            ElseIf rdGoleiro.Checked Then
                With cmd
                    .Connection = cn
                    .CommandTimeout = 0
                    .CommandText = "select codJogador as 'Código do Goleiro', apelido as 'Nome do Goleiro' from jogador where apelido like '%" & txtNome.Text & "%' and codPosicao = 1"
                    .CommandType = CommandType.Text
                End With
            End If

            With da
                .SelectCommand = cmd
                .Fill(dt)
                .Dispose()
                dt_grid.DataSource = dt
            End With
        End If

    End Sub

    Public codSelFromConsulta As Integer

    Private Sub dt_grid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dt_grid.CellClick
        If rdJogador.Checked Then
            codSelFromConsulta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            ConJogador.cod = codSelFromConsulta
            ConJogador.Show()
            Me.Hide()
        ElseIf rdClube.Checked Then
            codSelFromConsulta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            ConClube.cod = codSelFromConsulta
            ConClube.Show()
            Me.Hide()
        ElseIf rdGoleiro.Checked Then
            codSelFromConsulta = Me.dt_grid.Item(0, (dt_grid.CurrentRow.Index)).Value.ToString
            ConGoleiro.cod = codSelFromConsulta
            ConGoleiro.Show()
            Me.Hide()
        End If

    End Sub

    Private Sub txtNome_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtNome.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsulta_Click()
        End If
    End Sub

    Private Sub rdJogador_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdJogador.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsulta_Click()
        End If
    End Sub

    Private Sub rdClube_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdClube.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsulta_Click()
        End If
    End Sub

    Private Sub rdGoleiro_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rdGoleiro.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnConsulta_Click()
        End If
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Public Sub testa()

    End Sub

End Class