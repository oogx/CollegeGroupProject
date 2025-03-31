Imports System.Data.OleDb

Public Class ViewShifts
    Sub GetLastWeekDates()
        Dim today As Date
        Dim startOfWeek As Date
        Dim i As Integer
        Dim lastWeekDates(6) As Date

        today = Now()
        startOfWeek = DateAdd("d", -Weekday(today, vbMonday) - 6, today)

        For i = 0 To 6
            lastWeekDates(i) = DateAdd("d", i, startOfWeek)
            Debug.Print(lastWeekDates(i))
        Next i
    End Sub
    Private Sub ViewShifts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        GetLastWeekDates()
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Dim sqlTimesheets As String = "SELECT ShiftID, ClockIn, ClockOut, ClockedOut, MinutesWorked FROM tblTimesheets WHERE MemberID = @MemberID"

        Using connection As New OleDbConnection(connectionString)

            Using commandTimesheets As New OleDbCommand(sqlTimesheets, connection)
                commandTimesheets.Parameters.AddWithValue("@MemberID", CurrentMemberID)

                Dim adapterTimesheets As New OleDbDataAdapter(commandTimesheets)
                Dim dataSetTimesheets As New DataSet()

                connection.Open()
                adapterTimesheets.Fill(dataSetTimesheets, "TimesheetData")
                connection.Close()

                If dataSetTimesheets.Tables("TimesheetData").Rows.Count > 0 Then
                    For Each row As DataRow In dataSetTimesheets.Tables("TimesheetData").Rows

                    Next
                Else
                    MessageBox.Show("No timesheet data found for the specified MemberID")
                End If
            End Using
        End Using
    End Sub

End Class