Imports System.Data.SqlClient

Public Class CadPaisECidade
    Private Sub btnFechar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFechar.Click
        Me.Close()
    End Sub

    Private Sub CadPaisECidade_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        carregaComboPais()
    End Sub

    Public Sub carregaComboPais()
        Dim sql As String = "select codPais, pais from pais order by pais asc"
        CarregaCombo(cmbPais, sql)
    End Sub

    Private Sub rdbPais_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbPais.CheckedChanged
        If rdbPais.Checked Then
            cmbPais.Enabled = False
            txtCidade.Enabled = False
            txtCidade.Text = ""
            txtPais.Enabled = True
        End If
    End Sub

    Private Sub rdbCidade_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbCidade.CheckedChanged
        If rdbCidade.Checked Then
            txtCidade.Enabled = True
            cmbPais.Enabled = True
            txtPais.Enabled = False
            txtPais.Text = ""
        End If
    End Sub

    Dim cmd As New SqlCommand
    Private Sub btnCadastrar_Click() Handles btnCadastrar.Click
        Using cn As SqlConnection = conexao()
            If Me.rdbCidade.Checked = True Then
                If Me.txtCidade.Text = "" Or cmbPais.Text = "" Then
                    MessageBox.Show("Por Favor, Verefique as informações!")
                    Exit Sub
                Else
                    cmd.Connection = cn
                    cmd.CommandText = "insertCidade"
                    cmd.CommandType = CommandType.StoredProcedure
                    With cmd.Parameters
                        .AddWithValue("nomeCidade", txtCidade.Text)
                        .AddWithValue("codPais", cmbPais.SelectedValue)
                    End With
                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()
                    MessageBox.Show("Cidade cadastrada com sucesso!", "Concluído")
                    txtCidade.Text = ""
                    cmbPais.SelectedIndex = -1
                End If


            ElseIf Me.rdbPais.Checked = True Then
                If Me.txtPais.Text = "" Then
                    MessageBox.Show("Por favor, verefique as informações")
                    Exit Sub
                Else
                    cmd.Connection = cn
                    cmd.CommandText = "insertPais"
                    cmd.CommandType = CommandType.StoredProcedure
                    With cmd.Parameters
                        .AddWithValue("nomePais", txtCidade.Text)
                    End With
                    cn.Open()
                    cmd.ExecuteReader()
                    cn.Close()
                    MessageBox.Show("País cadastrado com sucesso!", "Concluído")
                    txtPais.Text = ""
                    rdbPais.Checked = False
                    carregaComboPais()
                End If
            End If
        End Using
    End Sub

End Class