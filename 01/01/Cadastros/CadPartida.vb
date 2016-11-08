Imports System.Data.SqlClient
Imports _01.Classes

Public Class CadPartida
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim situacao As String = ""

    Private Sub rdb()
        If rdbMandante.Checked = True Then
            situacao = "Mandante"
        ElseIf RadioButton2.Checked = True Then
            situacao = "Visitante"
        Else
            MessageBox.Show("selecione a situação")
        End If
    End Sub

    Private Sub btnCadPart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCadPart.Click
        rdb()
        Dim asd As String = txtHorario.Text
        If Not IsDate(txtData.Text) Or cmbEstadio.Text = "" Or cmbCamp.Text = "" Or cmbEtapa.Text = "" Or situacao = "" Or cmbTime1.Text = "" Or cmbTime2.Text = "" Then
            MessageBox.Show("Por Favor, verefique as informações")
        Else
            cn = conexao()
            rdb()
            cmd.Connection = cn
            cmd.CommandText = "insertPartida"
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("dataPartida", txtData.Text)
                .AddWithValue("horario", txtHorario.Text)
                .AddWithValue("situacao", situacao)
                .AddWithValue("codEstadio", cmbEstadio.SelectedValue)
                .AddWithValue("codClube", cmbTime1.SelectedValue)
                .AddWithValue("codAdversario", cmbTime2.SelectedValue)
                .AddWithValue("codCampeonato", cmbCamp.SelectedValue)
                .AddWithValue("codRodada", cmbEtapa.SelectedValue)
            End With
            cn.Open()
            cmd.ExecuteReader()
            MessageBox.Show("Defina a escalação do Time Coletado")
            cn.Close()
            '---------------------------------------------
            definirEscalacao.Show()
            '---------------------------------------------
        End If
    End Sub

    Private Sub cmbEstadio_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbEstadio.SelectedIndexChanged
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select imagem from estadio where codEstadio = " & cmbEstadio.SelectedValue & ""
            .CommandType = CommandType.Text
        End With
        Dim z As String
        z = cmd.ExecuteScalar
        Me.pbxEstadio.ImageLocation = (z)
        cn.Close()
    End Sub

    Private Sub cmbTime1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTime1.SelectedIndexChanged
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select imagem from clube where codClube = " & cmbTime1.SelectedValue & ""
            .CommandType = CommandType.Text
        End With
        Dim x As String
        x = cmd.ExecuteScalar
        cn.Close()
        Me.pbxTime1.ImageLocation = (x)
        carregaComboTimeAdv()
    End Sub

    Private Sub cmbTime2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbTime2.SelectedIndexChanged
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select imagem from clube where codClube = " & cmbTime2.SelectedValue & ""
            .CommandType = CommandType.Text
        End With
        Dim hue As String
        hue = cmd.ExecuteScalar
        cn.Close()
        Me.pbxTime2.ImageLocation = (hue)
    End Sub

    Private Sub CadPartida_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cmbEstadio.SelectedIndex = -1
        carregaComboCampeonato()
        carregaComboEstadio()

        pbxTime1.Image = Nothing
        pbxTime2.Image = Nothing


    End Sub

    Public Sub carregaComboEstadio()
        Dim sql As String = "select * from estadio"
        CarregaCombo(cmbEstadio, sql)
    End Sub

    Public Sub carregaComboCampeonato()
        Dim sql As String = "select * from campeonato"
        CarregaCombo(cmbCamp, sql)
    End Sub

    Public Sub carregaComboRodada()
        Dim sql As String = "select * from rodada where codCampeonato = " & Me.cmbCamp.SelectedValue & ""
        CarregaCombo(cmbEtapa, sql)
    End Sub

    Public Sub carregaComboTime1()
        Dim sql As String = "select clube.codClube, clube.alcunha from clube inner join ClubCamp on clube.codClube = ClubCamp.codClube where clubCamp.codCampeonato = " & cmbCamp.SelectedValue & ""
        CarregaCombo(cmbTime1, sql)
    End Sub

    Public Sub carregaComboTimeAdv()
        Dim sql As String = "select timeAdversario.codTimeAdversario, timeAdversario.alcunha from advCamp inner join timeAdversario on advCamp.codTimeAdversario = timeAdversario.codTimeAdversario where advCamp.codCampeonato = " & cmbCamp.SelectedValue & " and timeAdversario.codTimeAdversario != " & Me.cmbTime1.SelectedValue
        CarregaCombo(cmbTime2, sql)
    End Sub

    Private Sub cmbCamp_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCamp.SelectedIndexChanged
        carregaComboRodada()
        carregaComboTime1()

    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class