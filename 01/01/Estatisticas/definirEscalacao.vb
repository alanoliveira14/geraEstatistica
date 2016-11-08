Imports System.Data.SqlClient

Public Class definirEscalacao
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim cmd10 As New SqlCommand
    Dim mr As SqlDataReader
    Public a As String = "select * from jogador where codClube = " & (CadPartida.cmbTime1.SelectedValue).ToString
    Dim b As String = "insert into relacionados (codEscalacao, codJogador, situacao) values "
    Dim t As Integer = 0

    Private Sub btnAddTitular_Click() Handles btnAddTitular.Click
        If Me.lstTitulares.Items.Count >= 11 Then
            t = 1
        Else
            t = 0
        End If
        If t = 0 Then
            Using cn As SqlConnection = conexao()
                Me.lstTitulares.Items.Add(Me.lstJogadores.Text)
                Me.lstAux.Items.Add(Me.lstJogadores.SelectedValue)
                Me.lstTitulares.ValueMember = Me.lstJogadores.SelectedValue
                a = a + " and codJogador != " & Me.lstJogadores.SelectedValue
                If b = "insert into relacionados (codEscalacao, codJogador, situacao) values " Then
                    b = b + "((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Titular')"
                Else
                    b = b + ",((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Titular')"
                End If
                cn.Open()
                Try
                    Dim cmd1 As SqlCommand = New SqlCommand(a, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    Me.lstJogadores.ValueMember = "codJogador"
                    Me.lstJogadores.DisplayMember = "apelido"
                    Me.lstJogadores.DataSource = dt
                Catch ex As Exception
                    MessageBox.Show("deu ruim")
                End Try
                cn.Close()
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Open()
                Me.lstSuplentes.Items.Add(Me.lstJogadores.Text)
                Me.lstAux2.Items.Add(Me.lstJogadores.SelectedValue)
                Me.lstSuplentes.ValueMember = Me.lstJogadores.SelectedValue
                a = a + " and codJogador != " & Me.lstJogadores.SelectedValue
                If b = "insert into relacionados (codEscalacao, codJogador, situacao) values " Then
                    b = b + "((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Reserva')"
                Else
                    b = b + ",((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Reserva')"
                End If
                Try
                    Dim cmd1 As SqlCommand = New SqlCommand(a, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    Me.lstJogadores.ValueMember = "codJogador"
                    Me.lstJogadores.DisplayMember = "apelido"
                    Me.lstJogadores.DataSource = dt
                Catch ex As Exception
                End Try
                cn.Close()
            End Using
        End If
    End Sub

    Public Function carregaComboEsquema()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from esqTatico"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbEsqTatico.ValueMember = "codEsqTatico"
                Me.cmbEsqTatico.DisplayMember = "varicaoEsqTatico"
                Me.cmbEsqTatico.DataSource = dt
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
        Return Nothing
    End Function

    Public Function carregaJogadores()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = a
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.lstJogadores.ValueMember = "codJogador"
                Me.lstJogadores.DisplayMember = "apelido"
                Me.lstJogadores.DataSource = dt
            Catch ex As Exception

            End Try
        End Using
        Return Nothing
    End Function

    Public Sub inserts()
        If Me.lstTitulares.Items.Count = 11 And Me.lstSuplentes.Items.Count >= 5 Then
            Using cn As SqlConnection = conexao()
                Dim queryescalacao As String = "insert into escalacao values (" & (CadPartida.cmbTime1.SelectedValue).ToString & "," & (cmbEsqTatico.SelectedValue).ToString & ", (select MAX(codPartida) from partida))"
                Dim commandagoravai As SqlCommand = New SqlCommand(queryescalacao, cn)
                cn.Open()
                commandagoravai.ExecuteReader()
                cn.Close()


                commandagoravai = New SqlCommand(b, cn)
                cn.Open()
                commandagoravai.ExecuteReader()
                cn.Close()
            End Using
            definirEscalacaoAdv.Show()
        Else
            MessageBox.Show("Falta jogador(são 11 titulares e, no mínimo, 5 reservas).")
        End If
    End Sub

    Public Function carregaImagem()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from clube where codClube = " & CadPartida.cmbTime1.SelectedValue & ""
            cmd = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim z As String
            z = cmd.ExecuteScalar
            Me.PictureBox1.ImageLocation = z
            cn.Close()

            cn.Open()
            Dim sql2 As String = "select alcunha from clube where codClube = " & CadPartida.cmbTime1.SelectedValue & ""
            cmd = New SqlCommand(sql2, cn)
            da = New SqlDataAdapter(cmd)
            Dim x As String
            x = cmd.ExecuteScalar
            Me.lblNomeTime.Text = x
            cn.Close()
        End Using        
        Return Nothing
    End Function

    Private Sub definirEscalacao_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lstAux.Hide()
        lstAux2.Hide()
        lstJogadores.Enabled = False
        lstSuplentes.Enabled = False
        lstTitulares.Enabled = False
        carregaComboEsquema()
        carregaJogadores()
        carregaImagem()
    End Sub

    Private Sub cmbEsqTatico_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEsqTatico.SelectedIndexChanged
        lstJogadores.Enabled = True
        lstSuplentes.Enabled = True
        lstTitulares.Enabled = True
    End Sub

    Public qtd As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        qtd = lstSuplentes.Items.Count - 1
        inserts()
    End Sub

    Private Sub lstJogadores_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstJogadores.DoubleClick
        If Me.lstTitulares.Items.Count >= 11 Then
            t = 1
        Else
            t = 0
        End If

        If t = 0 Then
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Me.lstTitulares.Items.Add(Me.lstJogadores.Text)
                Me.lstAux.Items.Add(Me.lstJogadores.SelectedValue)
                Me.lstTitulares.ValueMember = Me.lstJogadores.SelectedValue
                a = a + " and codJogador != " & Me.lstJogadores.SelectedValue
                If b = "insert into relacionados (codEscalacao, codJogador, situacao) values " Then
                    b = b + "((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Titular')"
                Else
                    b = b + ",((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Titular')"
                End If
                Try
                    Dim cmd1 As SqlCommand = New SqlCommand(a, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    Me.lstJogadores.ValueMember = "codJogador"
                    Me.lstJogadores.DisplayMember = "apelido"
                    Me.lstJogadores.DataSource = dt
                Catch ex As Exception
                End Try
            End Using
        Else
            Using cn As SqlConnection = conexao()
                cn.Close()
                cn.Open()
                Me.lstSuplentes.Items.Add(Me.lstJogadores.Text)
                Me.lstAux2.Items.Add(Me.lstJogadores.SelectedValue)
                a = a + " and codJogador != " & Me.lstJogadores.SelectedValue
                If b = "insert into relacionados (codEscalacao, codJogador, situacao) values " Then
                    b = b + "((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Reserva')"
                Else
                    b = b + ",((select MAX(codEscalacao) from escalacao)," & lstJogadores.SelectedValue & ", 'Reserva')"
                End If
                Try
                    Dim cmd1 As SqlCommand = New SqlCommand(a, cn)
                    Dim da As SqlDataAdapter = New SqlDataAdapter(cmd1)
                    Dim dt As DataTable = New DataTable
                    da.Fill(dt)
                    Me.lstJogadores.ValueMember = "codJogador"
                    Me.lstJogadores.DisplayMember = "apelido"
                    Me.lstJogadores.DataSource = dt
                Catch ex As Exception
                End Try
            End Using
        End If
    End Sub

    Private Sub btnRemover_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemover.Click
        removerJogador()
    End Sub

    Private Sub removerJogador()
        Dim tit As Integer = 0
        Dim s As Integer = 0
        tit = Me.lstTitulares.SelectedIndex
        s = Me.lstSuplentes.SelectedIndex
        If tit > 0 Then
            Me.lstAux.Items.RemoveAt(Me.lstTitulares.SelectedIndex)
            Me.lstTitulares.Items.RemoveAt(Me.lstTitulares.SelectedIndex)
        End If
        a = "select * from jogador where codClube = " & (CadPartida.cmbTime1.SelectedValue).ToString
        b = "insert into relacionados(codEscalacao, codJogador, situacao) values "
        For g = 0 To Me.lstAux.Items.Count - 1
            Me.lstAux.SetSelected(g, 1)
            a = a + " and codJogador != " & Me.lstAux.Text
            If g = 0 Then
                b = b + "((select MAX(codEscalacao) from escalacao)," & Me.lstAux.Text & ", 'Titular')"
            Else
                b = b + ",((select MAX(codEscalacao) from escalacao)," & Me.lstAux.Text & ", 'Titular')"
            End If
        Next
        If s > 0 Then
            Me.lstAux2.Items.RemoveAt(Me.lstSuplentes.SelectedIndex)
            Me.lstSuplentes.Items.RemoveAt(Me.lstSuplentes.SelectedIndex)
        End If
        For f = 0 To Me.lstAux2.Items.Count - 1
            Me.lstAux2.SetSelected(f, 1)
            a = a + " and codJogador != " & Me.lstAux2.Text
            b = b + ",((select MAX(codEscalacao) from escalacao)," & Me.lstAux2.Text & ", 'Reserva')"
        Next
        carregaJogadores()
    End Sub
End Class