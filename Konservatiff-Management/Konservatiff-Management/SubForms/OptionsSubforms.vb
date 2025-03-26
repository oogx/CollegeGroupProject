Imports System.Data.Common

Public Class OptionsSubforms
    Private Sub OptionsSubforms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        darkThemeCheckBx.Checked = DarkTheme
        highContrastCheckBx.Checked = Contrast
        textSizeCbo.Text = TextSize

        ModifiedLabel1.Text = ""
        ModifiedLabel2.Text = ""
        ModifiedLabel3.Text = ""

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles SavePassBtn.Click
        'Checking the passwords match.
        If setPassTxtBx.Text = repeatSetPassTxtBx.Text Then
            Dim strUpdatedPassword As String = setPassTxtBx.Text

            'Opening the database connection.
            Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
            Connection.Open()

            'Query
            SQL = "SELECT * FROM tblMembers WHERE MemberID = @MemberID"

            'Inserting the MemberID into the SQL Query.
            Dim CheckCmd As New OleDb.OleDbCommand(SQL, Connection)
            CheckCmd.Parameters.Add("@MemberID", OleDb.OleDbType.Integer).Value = MemberID
            Dim Reader As OleDb.OleDbDataReader = CheckCmd.ExecuteReader()

            Dim DataAdapt As New OleDb.OleDbDataAdapter(CheckCmd)
            Dim DataSet As New DataSet()
            Reader.Close()
            DataAdapt.Fill(DataSet, "Members")

            Dim CommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapt)
            CommandBuilder.QuotePrefix = "["
            CommandBuilder.QuoteSuffix = "]"

            CurrentRow = 0
            DataSet.Tables("Members").Rows(CurrentRow).Item(9) = strUpdatedPassword

            Connection.Close()
            'Updating the dataset and sending back the updated password.
            DataAdapt.Update(DataSet, "Members")
            MsgBox("Password has been updated successfully.")

            'Clearing the text in textboxes
            setPassTxtBx.Text = ""
            repeatSetPassTxtBx.Text = ""
            Exit Sub
        Else
            MsgBox("Passwords do not match.")
            Exit Sub
        End If
    End Sub

    Private Sub SetOptionsBtn_Click(sender As Object, e As EventArgs) Handles SetOptionsBtn.Click
        'Opening the database connection.
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        'Query
        SQL = "SELECT * FROM tblMembers WHERE MemberID = @MemberID"

        'Inserting the MemberID into the SQL Query.
        Dim CheckCmd As New OleDb.OleDbCommand(SQL, Connection)
        CheckCmd.Parameters.Add("@MemberID", OleDb.OleDbType.Integer).Value = MemberID
        Dim Reader As OleDb.OleDbDataReader = CheckCmd.ExecuteReader()

        Dim DataAdapt As New OleDb.OleDbDataAdapter(CheckCmd)
        Dim DataSet As New DataSet()
        Reader.Close()
        DataAdapt.Fill(DataSet, "Members")

        Dim CommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapt)
        CommandBuilder.QuotePrefix = "["
        CommandBuilder.QuoteSuffix = "]"

        CurrentRow = 0
        DataSet.Tables("Members").Rows(CurrentRow).Item(11) = darkThemeCheckBx.Checked
        DataSet.Tables("Members").Rows(CurrentRow).Item(12) = highContrastCheckBx.Checked
        DataSet.Tables("Members").Rows(CurrentRow).Item(13) = textSizeCbo.SelectedItem

        Connection.Close()
        'Updating the dataset and sending back the updated preferences.
        DataAdapt.Update(DataSet, "Members")
        MsgBox("Your user options have been successfully updated")
        'Refreshing the global variables to be correct
        DarkTheme = darkThemeCheckBx.Checked
        Contrast = highContrastCheckBx.Checked
        TextSize = textSizeCbo.Text
        'Hiding the modified indicators on top of the options.
        ModifiedLabel1.Text = ""
        ModifiedLabel2.Text = ""
        ModifiedLabel3.Text = ""
        Exit Sub
    End Sub

    Private Sub darkThemeCheckBx_Click(sender As Object, e As EventArgs) Handles darkThemeCheckBx.Click
        ModifiedLabel1.Text = "Modified"
    End Sub

    Private Sub highContrastCheckBx_Click(sender As Object, e As EventArgs) Handles highContrastCheckBx.Click
        ModifiedLabel2.Text = "Modified"
    End Sub
    Private Sub textSizeCbo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles textSizeCbo.SelectedIndexChanged
        ModifiedLabel3.Text = "Modified"
    End Sub
End Class