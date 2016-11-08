Imports System.Data.SqlClient
Public Class CadCampeonato
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader

    Private Sub CadCampeonato_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboModoDisputa()
    End Sub

    Private Sub btnConfirmar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConfirmar.Click
        If txtNomeCamp.Text = "" Or CmbModoDisp.Text = "" Then
            MessageBox.Show("Complete as informações, por favor")
            Exit Sub
        Else
            cn = mdlAcessoEFuncoes.conexao()
            cmd.Connection = cn
            cmd.CommandText = "insertCampeonato"
            cmd.CommandType = CommandType.StoredProcedure
            With cmd.Parameters
                .AddWithValue("nome", txtNomeCamp.Text)
                .AddWithValue("codModo", CmbModoDisp.SelectedValue)
            End With
            cn.Open()
            cmd.ExecuteReader()
            cn.Close()
            MsgBox("Cadastro Realizado")
        End If
        
    End Sub

    Public Sub carregaComboModoDisputa()
        Dim sql As String = "SELECT * FROM ESTILOCAMPEONATO"
        CarregaCombo(CmbModoDisp, sql)
    End Sub

    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub
End Class