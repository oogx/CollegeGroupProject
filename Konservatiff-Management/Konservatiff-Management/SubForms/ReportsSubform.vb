Imports System.Windows.Forms.DataVisualization.Charting

Public Class ReportsSubform
    Private Sub ReportsSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblTax"
        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)

        Dim ds As New DataSet()
        DataAdapt.Fill(ds, "Tax")

        Dim ChartArea1 As ChartArea = New ChartArea()
        Dim Legend1 As Legend = New Legend()
        Dim Series1 As Series = New Series()
        Dim Chart1 = New Chart()
        Me.Controls.Add(Chart1)

        Series1.ChartType = SeriesChartType.Bar
        ChartArea1.Name = "ChartArea1"
        Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Chart1.Legends.Add(Legend1)
        Chart1.Location = New System.Drawing.Point(9, 9)
        Chart1.Name = "Tax Bracket Chart"
        Chart1.Titles.Add("Tax Chart")
        Series1.Name = "Bracket"
        Chart1.Series.Add(Series1)
        Chart1.Size = New System.Drawing.Size(740, 550)


        Chart1.Series("Bracket").XValueMember = "TaxID"
        Chart1.Series("Bracket").YValueMembers = "TaxLowerB"

        Chart1.DataSource = ds.Tables("Tax")
        Connection.Close()
    End Sub
End Class