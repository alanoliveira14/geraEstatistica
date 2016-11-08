Imports System.Data.SqlClient
Imports _01.Classes
Imports _01.mdlAcessoEFuncoes

Public Class CadTecnico
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Dim dao As SistemaDAO

    Private Sub CadTecnico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboPais()
    End Sub

    Private Sub inserirTecnicoComODAO()
        Dim tecnico As New Tecnico
        Try
            tecnico.Nome = txtNome.Text
            tecnico.DataNascimento = txtNasc.Text
            tecnico.Apelido = txtApelido.Text
            tecnico.codPais = cmbNacio.SelectedValue
            dao.InserirTecnico(tecnico)
        Catch ex As Exception
            MessageBox.Show("Por Favor, verefique as informações")
        End Try
    End Sub

    Public Sub insertTecnico()
        Try
            Using cn As SqlConnection = conexao()
                Dim sql As String = "insertTecnico"
                Dim cmd As New SqlCommand
                cmd.Connection = cn
                cmd.CommandText = sql
                cmd.CommandType = CommandType.StoredProcedure
                With cmd.Parameters
                    .AddWithValue("nome", txtNome.Text)
                    .AddWithValue("dtNasc", txtNasc.Text)
                    .AddWithValue("apelido", txtApelido.Text)
                    .AddWithValue("codPais", cmbNacio.SelectedValue)
                End With
                cn.Open()
                cmd.ExecuteReader()
                cn.Close()
            End Using
        Catch ex As Exception
            MessageBox.Show("Por Favor, verefique as informações")
        End Try
        
    End Sub

    Private Sub btnConf_Click() Handles btnConf.Click
        If txtNome.Text = "" Then
            MessageBox.Show("Todo técnico tem um nome")
            Exit Sub
        ElseIf txtApelido.Text = "" Then
            MessageBox.Show("Digite um apelido(como o técnico é conhecido)")
            Exit Sub
        ElseIf Not IsDate(txtNasc.Text) Then
            MessageBox.Show("Digite a data de nascimento")
            Exit Sub
        Else
            inserirTecnicoComODAO()
            MessageBox.Show("Técnico cadastrado")
            txtNome.Text = ""
            txtApelido.Text = ""
            txtNasc.Text = ""
            cmbNacio.SelectedIndex = -1
        End If
    End Sub

    Private Sub testeGetNSet()
        Dim objInsertInto As Tecnico = New Tecnico
        objInsertInto.Nome = txtNome.Text
        objInsertInto.Apelido = txtApelido.Text
        objInsertInto.DataNascimento = txtNasc.Text
        objInsertInto.codPais = cmbNacio.SelectedValue

    End Sub

    Public Sub carregaComboPais()
        Dim sql As String = "select codPais, pais from pais"
        CarregaCombo(cmbNacio, sql)
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

End Class