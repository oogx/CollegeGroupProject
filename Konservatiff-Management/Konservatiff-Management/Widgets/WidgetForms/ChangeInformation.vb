Imports System.Data.OleDb

Public Class ChangeInformation
    Sub OpenChildForm(childForm As Form) ' Creating a Sub called OpenChildForm which has a parameter which is passed called childForm which is a Form.
        currentChildForm = childForm ' Declaring a currentchildForm as the passed paremeter.
        childForm.TopLevel = False ' Setting the childform as not the top most form, this would mess up things yano.
        childForm.FormBorderStyle = FormBorderStyle.None ' Setting the childform to have no border.
        childForm.Dock = DockStyle.Fill ' This sets the dockstyle to fill.
        User_Desktop_Panel.Controls.Add(childForm) ' This actually populates the childform making it appear on the current main page.
        User_Desktop_Panel.Tag = childForm ' This sets the tag of the main panel to the childform
        childForm.BringToFront() ' Instead of setting the childform to topmost it brings it to the front of the other panel so meshes dont collide.
        childForm.Show() ' This then shows the child form.
        KMText.Text = "Konservatiff Management | " & childForm.Text ' This changes the text on the main form to insert what the child form text is.
    End Sub ' Ending the current OpenChildForm sub.

    Private Sub ChangeInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Dim sql As String = "SELECT Forename,Surname,TaxID,NINo,DoB,MobileNo,Email,AdminStatus,Password,Sex,DarkTheme,Contrast,TextSize,PayRateID FROM tblMembers WHERE MemberID = @MemberID"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.AddWithValue("@MemberID", CurrentMemberID)

                Dim adapter As New OleDbDataAdapter(command)
                Dim dataSet As New DataSet()

                connection.Open()
                adapter.Fill(dataSet, "CurrentUserData")
                connection.Close()

                If dataSet.Tables("CurrentUserData").Rows.Count > 0 Then
                    Dim row As DataRow = dataSet.Tables("CurrentUserData").Rows(0)

                    LblStaffName.Text = $"{row("Forename")} {row("Surname")}"
                    fNameTxtBx.Text = row("Forename")
                    sNameTxtBx.Text = row("Surname")
                    taxIDTxtBx.Text = row("TaxID")
                    niNoTxtBx.Text = row("NINo")
                    dobTxtBx.Text = row("DoB").ToString()
                    mobNoTxtBx.Text = row("MobileNo")
                    emailTxtBx.Text = row("Email")
                    passwordTxtBx.Text = row("Password")
                    textSizeCbo.SelectedItem = row("TextSize")
                    sexCbo.SelectedItem = row("Sex")
                    adminStatusChkBx.Checked = row("AdminStatus")
                    darkThemeChkBx.Checked = row("DarkTheme")
                    highContrastChkBx.Checked = row("Contrast")

                Else
                    MessageBox.Show("Invalid MemberID or Password")
                End If
            End Using
        End Using
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles cancelBtn.Click
        OpenChildForm(New MembersSubform) ' This changes the page back to the members subform.
    End Sub

    Private Sub saveBtn_Click(sender As Object, e As EventArgs) Handles saveBtn.Click
        Dim connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Dim sql As String = "SELECT * FROM tblMembers WHERE MemberID = @MemberID"
        Using connection As New OleDbConnection(connectionString)
            Using command As New OleDbCommand(sql, connection)
                command.Parameters.Add("@MemberID", OleDbType.Integer).Value = CurrentMemberID
                Dim adapter As New OleDbDataAdapter(command)
                Dim commandBuilder As New OleDbCommandBuilder(adapter)
                Dim dataSet As New DataSet()

                connection.Open()
                adapter.Fill(dataSet, "CurrentUserData")
                connection.Close()

                If dataSet.Tables("CurrentUserData").Rows.Count > 0 Then
                    Dim row As DataRow = dataSet.Tables("CurrentUserData").Rows(0)

                    row("Forename") = fNameTxtBx.Text
                    row("Surname") = sNameTxtBx.Text
                    row("TaxID") = taxIDTxtBx.Text
                    row("NINo") = niNoTxtBx.Text
                    row("DoB") = DateTime.Parse(dobTxtBx.Text)
                    row("MobileNo") = mobNoTxtBx.Text
                    row("Email") = emailTxtBx.Text
                    row("Password") = passwordTxtBx.Text
                    row("TextSize") = textSizeCbo.SelectedItem
                    row("Sex") = sexCbo.SelectedItem
                    row("AdminStatus") = adminStatusChkBx.Checked
                    row("DarkTheme") = darkThemeChkBx.Checked
                    row("Contrast") = highContrastChkBx.Checked

                    adapter.Update(dataSet, "CurrentUserData")
                    MessageBox.Show("Information updated successfully.")
                Else
                    MessageBox.Show("Invalid MemberID or Password")
                End If
            End Using
        End Using
    End Sub

End Class