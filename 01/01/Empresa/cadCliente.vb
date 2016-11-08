Imports System.Data.SqlClient
Public Class cadCliente
    Dim cn As SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader

    Private Sub Cliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load
       txtBairro.Enabled = False
        txtCidade.Enabled = False
        txtRua.Enabled = False
        txtUF.Enabled = False
        carregaComboClube()
    End Sub

    Private Sub btnCadastrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCadastrar.Click
        Using cn As SqlConnection = conexao()
            cn.Open()
            With cmd
                .Connection = cn
                .CommandTimeout = 0
                .CommandText = "insert into Cliente (clube, CNPJ, representante, CEP, numero, email, telefone) values ( '" & cmbClube.Text & "','" & txtCNPJ.Text & "', '" & txtRepresentante.Text & "', '" & txtCEP.Text & "', '" & txtNumero.Text & "','" & txtEmail.Text & "', '" & txtTel.Text & "')"
                .CommandType = CommandType.Text
            End With
            mr = cmd.ExecuteReader
            cn.Close()
        End Using
        MessageBox.Show("Cadastrado")
    End Sub


    Private Sub btnBuscar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar1.Click
        validacao.validarcnpj(txtCNPJ.Text)
        If validacao.validarcnpj(txtCNPJ.Text) = False Then
            MessageBox.Show("CNPJ INVÁLIDO")
        ElseIf validacao.validarcnpj(txtCNPJ.Text) = True Then
            MessageBox.Show("CNPJ ACEITO")
        End If
    End Sub

    Private Sub radioFisica_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtRepresentante.Enabled = False
        txtCNPJ.Enabled = False
    End Sub

    Private Sub radioJuridica_GotFocus(ByVal sender As Object, ByVal e As System.EventArgs)
        txtRepresentante.Enabled = True
        txtCNPJ.Enabled = True
    End Sub


    Private Sub btnBuscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuscar.Click
        Dim cep As String
        cep = txtCEP.Text.Substring(0, 5) + txtCEP.Text.Substring(6, 3)
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
        cn.Open()

        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from logradouros where cep = '" & cep & "'"
            .CommandType = CommandType.Text
        End With

        mr = cmd.ExecuteReader
        While mr.Read
            txtBairro.Text = mr!Bairro
            txtCidade.Text = mr!Cidade
            txtRua.Text = mr!Descricao
            txtUF.Text = mr!UF
        End While

        If txtCEP.Text = "" Then
            MsgBox("Digite o CEP", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub dt_grid_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim x As String
        Dim cn As SqlConnection
        Dim cmd As New SqlCommand
        Dim mr As SqlDataReader
        cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=TCC")
        cn.Open()
        With cmd
            .Connection = cn
            .CommandTimeout = 0
            .CommandText = "select * from Cliente where cod_cliente  = '" & x & "'"
            .CommandType = CommandType.Text
        End With
        mr = cmd.ExecuteReader
        While mr.Read
            txtCEP.Text = mr!cep
            txtCNPJ.Text = mr!CNPJ
            txtEmail.Text = mr!Email
            cmbClube.Text = mr!Nome
            txtRepresentante.Text = mr!RazaoSocial
            txtTel.Text = mr!Telefone
            txtBairro.Text = mr!Bairro
            txtCidade.Text = mr!Cidade
            txtRua.Text = mr!Rua
            txtNumero.Text = mr!Numero
            txtUF.Text = mr!UF
        End While
    End Sub
    Public Function carregaComboClube()
        Using cn As SqlConnection = conexao()
            Try
                cn.Open()
                Dim sql As String = "select * from clube order by nomeCompleto asc"
                Dim cmd As SqlCommand = New SqlCommand(sql, cn)
                Dim da As SqlDataAdapter = New SqlDataAdapter(cmd)
                Dim dt As DataTable = New DataTable
                da.Fill(dt)
                Me.cmbClube.ValueMember = "codClube"
                Me.cmbClube.DisplayMember = "nomeCompleto"
                Me.cmbClube.DataSource = dt
                Me.cmbClube.SelectedIndex = -1
            Catch ex As Exception
            Finally
                cn.Close()
            End Try
        End Using
        Return Nothing
    End Function

    Private Sub btnVoltar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVoltar.Click
        Me.Close()

    End Sub
End Class
