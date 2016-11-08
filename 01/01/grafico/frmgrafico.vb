Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Data.SqlClient

Public Class frmgrafico
    Dim cn As New SqlConnection
    Dim cmd As New SqlCommand
    Dim mr As SqlDataReader
    Public cod As Integer
    Public numeros1 As String
    Dim codJog1 = Comparacoes.cod1
    Dim codJog2 = Comparacoes.cod2
    Dim codAcao = ComparaJogadores2.codAcao
    Dim nomeJog1 = ComparaJogadores2.txtJogador1.Text
    Dim nomeJog2 = ComparaJogadores2.txtJogador2.Text

    'Private Sub btnGráficoLinha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGráficoLinha.Click


    '    'Chart1.DataSource = ds.Tables("a234")
    '    'Chart1.DataSource = ds2.Tables("a235")

    '    'Dim da As New SqlDataAdapter
    '    'Dim dt As New DataTable
    '    'DataGridView1.DataSource = ""
    '    'cn = New SqlConnection("server=(local);uid=sa;pwd=123456;database=bdAgencia1")
    '    'cn.Open()
    '    'With cmd
    '    '    .Connection = cn
    '    '    .CommandTimeout = 0
    '    '    .CommandText = "a234 10, 5"
    '    '    .CommandType = CommandType.Text

    '    'End With
    '    'mr = cmd.ExecuteReader
    '    'cn.Close()
    '    'With da
    '    '    .SelectCommand = cmd
    '    '    .Fill(dt)
    '    '    .Dispose()
    '    '    DataGridView1.DataSource = dt
    '    'End With
    '    'Dim caunti As Integer = DataGridView1.RowCount
    '    'Dim aux As String
    '    'For i As Integer = 0 To caunti - 1
    '    '    aux = DataGridView1.Item(0, caunti).Value.ToString()
    '    '    'xxxxxx.SetValue(0, caunti) = aux
    '    'Next

    'End Sub

    Private Sub grafico_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim strConn As String = "server=(local);uid=sa;pwd=123456;database=bdAgencia1"

        Dim conn As New SqlConnection(strConn)

        Dim sqlProducts As String = "a234 " & codJog1 & "," & codAcao & ""
        Dim sqlProducts2 As String = "a234 " & codJog2 & "," & codAcao & ""
        Dim da As New SqlDataAdapter(sqlProducts, conn)
        Dim da2 As New SqlDataAdapter(sqlProducts2, conn)
        Dim ds As New DataSet()
        Dim ds2 As New DataSet()
        da.Fill(ds, "a234")
        da2.Fill(ds2, "a234")

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim ChartArea2 As ChartArea = New ChartArea()
        Dim Legend2 As Legend = New Legend()
        Dim Series2 As Series = New Series()
        Dim Chart1 = New Chart()
        Dim Chart2 = New Chart()


        Me.Controls.Add(Chart1)
        Me.Controls.Add(Chart2)

        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(13, 13)
        Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = nomeJog1
        Series1.ChartType = SeriesChartType.Line
        Series1.BorderWidth = 3.5


        ChartArea2.Name = "ChartArea2"
        Chart2.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend2"
        Chart2.Legends.Add(Legend2)
        Chart2.Location = New System.Drawing.Point(13, 400)
        Series2.ChartArea = "ChartArea2"
        Series2.Legend = "Legend2"
        Series2.Name = nomeJog2
        Series2.ChartType = SeriesChartType.Line
        Series2.BorderWidth = 3.5
        Series2.Color = Color.Red
        Dim asd As System.Drawing.SizeF
        asd.Height = 3
        Chart1.Scale(asd)
        Chart1.Series.Add(Series1)
        Chart2.Series.Add(Series2)

        Chart1.Size = New System.Drawing.Size(1200, 300)
        Chart1.TabIndex = 0
        Chart1.Text = "Chart1"


        Chart2.Size = New System.Drawing.Size(1200, 300)
        Chart2.TabIndex = 1
        Chart2.Text = "Chart2"

        Chart1.DataSource = ds.Tables("a234")
        Chart2.DataSource = ds2.Tables("a234")

        Chart1.Series(nomeJog1).XValueMember = "adversario"
        Chart1.Series(nomeJog1).YValueMembers = "qtdAcao"
        Chart2.Series(nomeJog2).YValueMembers = "qtdAcao"
        Chart2.Series(nomeJog2).XValueMember = "adversario"


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        ComparaJogadores2.Show()

    End Sub
End Class