Imports System.Data.OleDb

Public Class ViewPayslip
    Private Sub ViewPayslip_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim CurrentHours As Integer
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Dim sql As String = "SELECT Sum(tblTimecards.MinutesWorked) AS SumOfMinutesWorked, tblPayRates.payRate, tblMembers.Forename, tblMembers.Surname FROM tblPayRates INNER JOIN (tblTimecards INNER JOIN tblMembers ON tblTimecards.MemberID = tblMembers.MemberID) ON tblPayRates.PayRateID = tblMembers.PayRateID GROUP BY tblTimecards.MemberID, tblPayRates.payRate, tblMembers.Forename, tblMembers.Surname HAVING (((tblTimecards.MemberID)=@MembersID));"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@MemberID", CurrentMemberID)

                Dim adapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()

                connection.Open()
                adapter.Fill(dataSet, "CustomMembersData")
                connection.Close()

                If dataSet.Tables("CustomMembersData").Rows.Count > 0 Then
                    Dim row As DataRow = dataSet.Tables("CustomMembersData").Rows(0)
                    CurrentHours = (row("SumOfMinutesWorked").ToString() / 60)

                    lblEmployeeName.Text = $"{row("Forename")} {row("Surname")}"
                    lblEmployeeNumber.Text = CurrentMemberID
                    lblHoursW.Text = CurrentHours
                    lblPayRate.Text = $"£{row("payRate").ToString()}"
                    lblValue.Text = $"£{CurrentHours * row("payRate").ToString()}"

                    lblTotal.Text = lblValue.Text

                    If lblValue.Text >= 1047 Then
                        lblTotalNetPay.Text = lblValue.Text * 0.8
                    Else
                        lblTotalNetPay.Text = lblValue.Text
                    End If
                End If
            End Using
        End Using
    End Sub
End Class