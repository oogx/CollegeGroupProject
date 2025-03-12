Public Class ClockInSubform
    Dim Max As Integer
    Dim TempTime As String
    Private Sub ClockInSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub
    Private Sub ClockInBtn_Click(sender As Object, e As EventArgs) Handles ClockInBtn.Click
        Connection.Close()
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblTimecards WHERE MemberID = @MemberID AND ClockedOut = False"
        Dim CheckCmd As New OleDb.OleDbCommand(SQL, Connection)
        CheckCmd.Parameters.AddWithValue("@MemberID", MemberID)
        Dim Reader As OleDb.OleDbDataReader = CheckCmd.ExecuteReader()

        If Reader.HasRows Then
            MsgBox("You are already clocked in.")
            Reader.Close()
            Connection.Close()
            Exit Sub
        End If
        Reader.Close()

        SQL = "SELECT * FROM tblTimecards"

        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)
        DataAdapt.Fill(DataSet, "Timecards")
        Max = DataSet.Tables("Timecards").Rows.Count

        Dim CommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapt)
        Dim NewRow As DataRow

        TempTime = strTime.Now

        CommandBuilder.QuotePrefix = "["
        CommandBuilder.QuoteSuffix = "]"

        NewRow = DataSet.Tables("Timecards").NewRow()
        Max = Max + 1
        NewRow.Item("ShiftID") = Max + 1
        NewRow.Item("MemberID") = MemberID
        NewRow.Item("ClockIn") = TempTime
        NewRow.Item("ClockOut") = Date.Now
        NewRow.Item("ClockedOut") = False
        NewRow.Item("HoursWorked") = "0"

        DataSet.Tables("Timecards").Rows.Add(NewRow)

        DataAdapt.Update(DataSet, "Timecards")
        MsgBox("ShiftID: " & Max + 1 & " Clocked in at " & TempTime)
        Connection.Close()
    End Sub

    Private Sub ClockOutBtn_Click(sender As Object, e As EventArgs) Handles ClockOutBtn.Click
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblTimecards WHERE MemberID = @MemberID AND ClockedOut = False"
        Dim CheckCmd As New OleDb.OleDbCommand(SQL, Connection)
        CheckCmd.Parameters.AddWithValue("@MemberID", MemberID)
        Dim Reader As OleDb.OleDbDataReader = CheckCmd.ExecuteReader()

        If Reader.HasRows Then 'If the user has clocked in - should be able to clock out.
            MsgBox("Cannot clock out yet.")
            Reader.Close()
            Connection.Close()
            Exit Sub
        Else 'If the user has not clocked in - should be not be able to clock out.
            MsgBox("You have not clocked in.")
            Exit Sub
        End If
        Reader.Close()
    End Sub
End Class