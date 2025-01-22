Imports System.Threading
Imports System.Data.OleDb

Public Class frmSignInPage
    Private Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub


    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Dim sql As String = "SELECT Forename, Surname, AdminStatus FROM tblMembers WHERE MemberID = @MemberID AND Password = @Password"

        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@MemberID", payrollTxtBx.Text)
                command.Parameters.AddWithValue("@Password", passTxtBx.Text)

                Dim adapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()

                connection.Open()
                adapter.Fill(dataSet, "MembersData")
                connection.Close()

                If dataSet.Tables("MembersData").Rows.Count > 0 Then
                    Dim row As DataRow = dataSet.Tables("MembersData").Rows(0)
                    Username = $"{row("Forename")} {row("Surname")}"
                    AccessLevel = row("AdminStatus")

                    MainDesign.Show()
                    Me.Hide()
                    payrollTxtBx.Text = ""
                    passTxtBx.Text = ""
                Else
                    MessageBox.Show("Invalid MemberID or Password")
                End If
            End Using
        End Using
    End Sub
End Class