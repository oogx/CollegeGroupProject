Imports System.Threading
Imports System.Data.OleDb
Imports System.Diagnostics.Contracts

Public Class frmSignInPage
    Private Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start() 'One tick a second timer which will be used to update the time and date clock
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now) 'Updates the clock to today's time and date
    End Sub


    Private Sub LogInBtn_Click(sender As Object, e As EventArgs) Handles LogInBtn.Click 'When login button clicked.
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb" 'Stating the path of the database for the connection
        Dim sql As String = "SELECT Forename, Surname, AdminStatus, DarkTheme, Contrast, TextSize FROM tblMembers WHERE MemberID = @MemberID AND Password = @Password" 'Selecting certain fields from the database for this program's data set
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@MemberID", payrollTxtBx.Text)
                command.Parameters.AddWithValue("@Password", passTxtBx.Text) 'Taking the values from the memberId and password from database to add to the textboxes on the page

                Dim adapter As New OleDbDataAdapter(command) '
                Dim dataSet As New DataSet() 'Shortening the recall of these functions 

                connection.Open()
                adapter.Fill(dataSet, "MembersData")
                connection.Close() 'Opening the connection and filling the dataset

                If dataSet.Tables("MembersData").Rows.Count > 0 Then 'If the dataset is not empty from the selected data 
                    Dim row As DataRow = dataSet.Tables("MembersData").Rows(0)
                    MemberID = payrollTxtBx.Text
                    Username = $"{row("Forename")} {row("Surname")}"
                    AccessLevel = row("AdminStatus")
                    DarkTheme = row("DarkTheme")
                    Contrast = row("Contrast")
                    TextSize = row("TextSize")

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