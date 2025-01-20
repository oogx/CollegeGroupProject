Imports System.Threading
Public Class frmSignInPage
    Public Connection As New OleDb.OleDbConnection
    Public SQL As String
    Public DataSet As New DataSet
    Public DataAdapt As OleDb.OleDbDataAdapter
    Public CurrentRows As Integer
    Public MaxRows As Integer
    Dim strTime As System.DateTime
    Public Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub

    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"

        Connection.Open()
        SQL = "SELECT * FROM tblMembers WHERE MemberID = @MemberID AND Password = @Password"

        Dim Command As New OleDb.OleDbCommand(SQL, Connection)
        Command.Parameters.AddWithValue("@MemberID", payrollTxtBx.Text)
        Command.Parameters.AddWithValue("@Password", passTxtBx.Text)

        DataAdapt = New OleDb.OleDbDataAdapter(Command)
        DataAdapt.Fill(DataSet, "MembersData")
        Connection.Close()

        If DataSet.Tables("MembersData").Rows.Count > 0 Then
            MainDesign.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid MemberID or Password")
        End If
    End Sub

End Class