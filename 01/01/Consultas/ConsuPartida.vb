Imports System.Data.SqlClient

Public Class ConsuPartida

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        consultaPartida()
    End Sub

    Public Sub consultaPartida()
        Dim sql As String
        Dim cmd As SqlCommand
        Dim da As SqlDataAdapter

        If Me.selData.Checked And selCamp.Checked And selRodada.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and codCampeonato = " & cmbCamp.SelectedValue & " and codRodada = " & cmbRodada.SelectedValue & " and clube.codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selData.Checked And selCamp.Checked And selRodada.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and codCampeonato = " & cmbCamp.SelectedValue & " and codRodada = " & cmbRodada.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selData.Checked And selCamp.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and codCampeonato = " & cmbCamp.SelectedValue & " and clube.codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selCamp.Checked And selRodada.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                sql = "select partida.codPartida, partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codCampeonato = " & cmbCamp.SelectedValue & " and codRodada = " & cmbRodada.SelectedValue & " and partida.codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selData.Checked And selCamp.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and codCampeonato = " & cmbCamp.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selData.Checked And selRodada.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and codRodada = " & cmbRodada.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selData.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "' and clube.codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selCamp.Checked And selRodada.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codCampeonato = " & cmbCamp.SelectedValue & " and codRodada = " & cmbRodada.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selCamp.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codCampeonato = " & cmbCamp.SelectedValue & " and codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selRodada.Checked And selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codRodada = " & cmbRodada.SelectedValue & " and codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf Me.selData.Checked Then
            If IsDate(txtData.Text) Then
                Using cn As SqlConnection = conexao()
                    sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where dataPartida = '" & txtData.Text & "'"
                    cmd = New SqlCommand(sql, cn)
                    da = New SqlDataAdapter(cmd)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    dtGrid1.DataSource = dt
                End Using
            Else
                MessageBox.Show("Coloque o formato da data corretamente")
            End If
        ElseIf Me.selCamp.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codCampeonato = " & cmbCamp.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf Me.selRodada.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where codRodada = " & cmbRodada.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf selTime.Checked Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario where clube.codClube = " & cmbTime1.SelectedValue & " and codAdversario = " & cmbTime2.SelectedValue & ""
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        ElseIf Me.selCamp.Checked = False And Me.selData.Checked = False And Me.selRodada.Checked = False And Me.selTime.Checked = False Then
            Using cn As SqlConnection = conexao()
                sql = "select	partida.codPartida,	partida.dataPartida as 'Data da Partida', partida.situacao as 'Situação', clube.alcunha as 'Clube Coletado', timeAdversario.alcunha as 'Clube Adversário' from partida inner join clube on partida.codClube = clube.codClube inner join timeAdversario on partida.codAdversario = timeAdversario.codTimeAdversario"
                cmd = New SqlCommand(sql, cn)
                da = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                dtGrid1.DataSource = dt
            End Using
        End If
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

    Public Sub carregaComboRodada()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from rodada where codCampeonato = " & Me.cmbCamp.SelectedValue & ""
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbRodada.ValueMember = "codRodada"
                Me.cmbRodada.DisplayMember = "rodada"
                Me.cmbRodada.DataSource = dt
                Me.cmbRodada.SelectedIndex = -1
                Me.cmbRodada.Text = ""
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub carregaComboTime1()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from clube"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbTime1.ValueMember = "codClube"
                Me.cmbTime1.DisplayMember = "alcunha"
                Me.cmbTime1.DataSource = dt
                Me.cmbTime1.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Public Sub carregaComboTimeAdv()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from timeAdversario"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbTime2.ValueMember = "codTimeAdversario"
                Me.cmbTime2.DisplayMember = "alcunha"
                Me.cmbTime2.DataSource = dt
                Me.cmbTime2.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    Private Sub ConsuPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboCampeonato()
        carregaComboTime1()
        carregaComboTimeAdv()
        txtData.Enabled = False
        cmbCamp.Enabled = False
        cmbRodada.Enabled = False
        cmbTime1.Enabled = False
        cmbTime2.Enabled = False
    End Sub

    Private Sub cmbCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCamp.SelectedIndexChanged
        carregaComboRodada()
    End Sub


    Dim codPartFromConsulta As Integer
    Private Sub dtGrid1_CellClick() Handles dtGrid1.CellClick
        codPartFromConsulta = Me.dtGrid1.Item(0, (dtGrid1.CurrentRow.Index)).Value.ToString
        ConsuPartidaDetal.codPartida = codPartFromConsulta
        ConsuPartidaDetal.Show()
        Me.Hide()

    End Sub



    Private Sub selData_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selData.CheckedChanged
        If selData.Checked = True Then
            txtData.Enabled = True
        Else
            txtData.Enabled = False
            txtData.Text = ""
        End If


    End Sub

    Private Sub selCamp_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selCamp.CheckedChanged
        If selCamp.Checked = True Then
            cmbCamp.Enabled = True
        Else
            cmbCamp.Enabled = False
            cmbCamp.SelectedItem = Nothing
        End If
    End Sub

    Private Sub selRodada_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selRodada.CheckedChanged
        If selRodada.Checked = True Then
            cmbRodada.Enabled = True
        Else
            cmbRodada.Enabled = False
            cmbRodada.SelectedItem = Nothing
        End If
    End Sub

    Private Sub selTime_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles selTime.CheckedChanged
        If selTime.Checked = True Then
            cmbTime1.Enabled = True
            cmbTime2.Enabled = True
        Else
            cmbTime1.Enabled = False
            cmbTime2.Enabled = False
            cmbTime1.SelectedItem = Nothing
            cmbTime2.SelectedItem = Nothing
        End If
    End Sub

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()
    End Sub

End Class