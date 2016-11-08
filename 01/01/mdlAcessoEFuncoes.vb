Imports System.Data.SqlClient

Module mdlAcessoEFuncoes


    Public Sub CarregaCombo(ByVal cmb As ComboBox, ByVal ComandoSelect As String)
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = ComandoSelect
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                cmb.ValueMember = dt.Columns(0).ToString
                cmb.DisplayMember = dt.Columns(1).ToString
                cmb.DataSource = dt
                cmb.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
    End Sub

    '-------------------------------------------------------------------------------------------

    Public Function carregarImagemGoleiroTitular()
        Dim caminho, nomeGoleiro As String
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem, apelido from jogador inner join relacionados on jogador.codJogador = relacionados.codJogador inner join posicao on jogador.codPosicao = posicao.codPosicao where posicao.codPosicao = 1 and relacionados.situacao = 'Titular' and codEscalacao = (select MAX(codEscalacao) from escalacao)"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim dr As SqlDataReader = cmd.ExecuteReader
            While dr.Read
                caminho = dr!imagem
                nomeGoleiro = dr!apelido
            End While
            aoVivo.pbxGolTitular.ImageLocation = caminho
            aoVivo.lblNomeGol.Text = nomeGoleiro
            cn.Close()

        End Using
        Return Nothing
    End Function

    Public Function carregarImagemGoleiroReserva()
        Using cn As SqlConnection = conexao()
            cn.Open()
            Dim sql As String = "select imagem from jogador inner join relacionados on jogador.codJogador = relacionados.codJogador inner join posicao on jogador.codPosicao = posicao.codPosicao where posicao.codPosicao = 1 and relacionados.situacao = 'Reserva' and codEscalacao = (select MAX(codEscalacao) from escalacao)"
            Dim cmd As SqlCommand = New SqlCommand(sql, cn)
            Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
            Dim dt As DataTable = New DataTable
            da.Fill(dt)
            Dim z As String
            z = cmd.ExecuteScalar
            aoVivo.pbxGolReserva.ImageLocation = z
            cn.Close()
        End Using
        Return Nothing
    End Function

    '-------------------------------------------------------------------------------------------
    Public Sub enables()
        'Jogador
        Comparacoes.selClubeJog.Enabled = False
        Comparacoes.cmbClubeJog.Enabled = False
        Comparacoes.selNacioJog.Enabled = False
        Comparacoes.cmbPaisJog.Enabled = False
        Comparacoes.selNomeJog.Enabled = False
        Comparacoes.todosJog.Enabled = False
        Comparacoes.txtNomeJog.Enabled = False

        'Goleiro
        Comparacoes.selClubeGol.Enabled = False
        Comparacoes.cmbClubeGol.Enabled = False
        Comparacoes.selNacioGol.Enabled = False
        Comparacoes.cmbPaisGol.Enabled = False
        Comparacoes.selNomeGol.Enabled = False
        Comparacoes.todosGol.Enabled = False
        Comparacoes.txtNomeGol.Enabled = False

        'Clube
        Comparacoes.selPais.Enabled = False
        Comparacoes.cmbPaisClube.Enabled = False
        Comparacoes.selCampeonato.Enabled = False
        Comparacoes.cmbCamp.Enabled = False
        Comparacoes.selNomeClube.Enabled = False
        Comparacoes.todosClubes.Enabled = False
        Comparacoes.txtNomeClube.Enabled = False
    End Sub

    Public Sub fncComparaJogador()
        Comparacoes.selClubeJog.Enabled = True
        Comparacoes.cmbClubeJog.Enabled = True
        Comparacoes.selNacioJog.Enabled = True
        Comparacoes.cmbPaisJog.Enabled = True
        Comparacoes.selNomeJog.Enabled = True
        Comparacoes.todosJog.Enabled = True
        Comparacoes.txtNomeJog.Enabled = True

        'Goleiro
        Comparacoes.selClubeGol.Enabled = False
        Comparacoes.cmbClubeGol.Enabled = False
        Comparacoes.selNacioGol.Enabled = False
        Comparacoes.cmbPaisGol.Enabled = False
        Comparacoes.selNomeGol.Enabled = False
        Comparacoes.todosGol.Enabled = False
        Comparacoes.txtNomeGol.Enabled = False

        'Clube
        Comparacoes.selPais.Enabled = False
        Comparacoes.cmbPaisClube.Enabled = False
        Comparacoes.selCampeonato.Enabled = False
        Comparacoes.cmbCamp.Enabled = False
        Comparacoes.selNomeClube.Enabled = False
        Comparacoes.todosClubes.Enabled = False
        Comparacoes.txtNomeClube.Enabled = False

    End Sub

    Public Sub fncComparaGoleiro()
        'Goleiro
        Comparacoes.selClubeGol.Enabled = True
        Comparacoes.cmbClubeGol.Enabled = True
        Comparacoes.selNacioGol.Enabled = True
        Comparacoes.cmbPaisGol.Enabled = True
        Comparacoes.selNomeGol.Enabled = True
        Comparacoes.todosGol.Enabled = True
        Comparacoes.txtNomeGol.Enabled = True
        'Jogador
        Comparacoes.selClubeJog.Enabled = False
        Comparacoes.cmbClubeJog.Enabled = False
        Comparacoes.selNacioJog.Enabled = False
        Comparacoes.cmbPaisJog.Enabled = False
        Comparacoes.selNomeJog.Enabled = False
        Comparacoes.todosJog.Enabled = False
        Comparacoes.txtNomeJog.Enabled = False
        'Clube
        Comparacoes.selPais.Enabled = False
        Comparacoes.cmbPaisClube.Enabled = False
        Comparacoes.selCampeonato.Enabled = False
        Comparacoes.cmbCamp.Enabled = False
        Comparacoes.selNomeClube.Enabled = False
        Comparacoes.todosClubes.Enabled = False
        Comparacoes.txtNomeClube.Enabled = False
    End Sub

    Public Sub fncComparaClube()
        'Jogador
        Comparacoes.selClubeJog.Enabled = False
        Comparacoes.cmbClubeJog.Enabled = False
        Comparacoes.selNacioJog.Enabled = False
        Comparacoes.cmbPaisJog.Enabled = False
        Comparacoes.selNomeJog.Enabled = False
        Comparacoes.todosJog.Enabled = False
        Comparacoes.txtNomeJog.Enabled = False
        'Goleiro
        Comparacoes.selClubeGol.Enabled = False
        Comparacoes.cmbClubeGol.Enabled = False
        Comparacoes.selNacioGol.Enabled = False
        Comparacoes.cmbPaisGol.Enabled = False
        Comparacoes.selNomeGol.Enabled = False
        Comparacoes.todosGol.Enabled = False
        Comparacoes.txtNomeGol.Enabled = False
        'Clube
        Comparacoes.selPais.Enabled = True
        Comparacoes.cmbPaisClube.Enabled = True
        Comparacoes.selCampeonato.Enabled = True
        Comparacoes.cmbCamp.Enabled = True
        Comparacoes.selNomeClube.Enabled = True
        Comparacoes.todosClubes.Enabled = True
        Comparacoes.txtNomeClube.Enabled = True
    End Sub

    '-------------------------------------------------------------------------------------------

    Public Function conexao() As SqlConnection
        Dim sql As String = "server=(local);uid=sa;pwd=123456;database=bdAgencia1"
        Return New SqlConnection(sql)
    End Function


End Module

Public Class MinhaConexao
    Dim cmd As New SqlCommand
    Dim dtadapter As New SqlDataAdapter
    Dim dtreader As SqlDataReader
    Dim dttable As New DataTable

    Public Function conexao() As SqlConnection
        Dim sql As String = "server=(local);uid=sa;pwd=123456;database=bdAgencia1"
        Return New SqlConnection(sql)
    End Function

    Public Sub OpenConnection()
        If conexao.State = ConnectionState.Closed Then
            conexao.Open()
        End If

    End Sub

    Public Sub CloseConnetion()
        Try
            If conexao.State = ConnectionState.Open Then
                conexao.Close()
            End If
        Catch ex As Exception
        End Try

    End Sub

    Public Sub ExecInsUpdDel(ByVal comando As String)

        Me.cmd = New SqlCommand()
        Me.cmd.Connection = Me.conexao
        Me.cmd.CommandText = comando
        Me.cmd.CommandType = CommandType.Text
        Me.cmd.ExecuteNonQuery()

    End Sub

    Public Function ExecSelect(ByVal strSql As String) As SqlDataReader
        Try
            cmd = New SqlCommand(strSql, conexao)
            cmd.CommandType = CommandType.Text
            OpenConnection()
            dtreader = cmd.ExecuteReader()
            If dtreader.HasRows Then
                Return dtreader
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(Err.Description)
            Return Nothing
        End Try
    End Function
End Class
