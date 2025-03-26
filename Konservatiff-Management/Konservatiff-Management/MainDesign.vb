Imports System.Web.UI.HtmlControls ' Importing Web controls for the system.
Imports FontAwesome.Sharp   ' Importing fontawsome for icons on the forms.

Public Class MainDesign ' Declaring a public classed named MainDesign.

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

        If childForm.Text = "Clock In" Then ' This is a IF Statement, it checks if the childform text is the same as "Clock In".
            lblClock.Hide() ' If the text is the same then hide the clock that is on the navigation bar.
        Else ' If the IF Statement is not true
            lblClock.Show() ' This means if the IF Statement is not true then show the clock that is on the navigation page.
        End If ' Ending the IF Statement.
    End Sub ' Ending the current OpenChildForm sub.

    Private Sub MainDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load ' This is a private sub that is ran upon the form loading the maindesign.
        OpenChildForm(New ClockInSubform) ' Upon opening the main deisng it loads the clock in subform as the main default sub form.
        Timer1.Start() ' This then starts the current clock which is show on all pages.
        UsersNameLbl.Text = Username ' It then populates the label from the username global variable which was set in the login page SQL.
        If Not AccessLevel Then ' This checks if the user has no admin from the database.
            AdminLabel.Visible = False  ' This sets the Admin label to disapear.
            MembersBtn.Visible = False  ' This sets the button to access the admin page (Members) to false, making it invisible.
            AddStaffBtn.Visible = False ' This sets the button to access the admin page (Add Staff) to false, making it invisible.
            ReportsBtn.Visible = False  ' This sets the button to access the admin page (Reports) to false, making it invisible.
            UserTypeLbl.Text = "User"   ' This sets the user type label to display User.
        Else ' If the user is a admin then.
            UserTypeLbl.Text = "Admin" ' Display the user type label as Admin, as the buttons are already displayed for them.
        End If ' End the IF Statement.

        If DarkTheme Then ' If DarkTheme is enabled from the global variable then.

        Else ' If the darktheme is not true.

        End If ' End the IF Statement.
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick ' This creates a private sub which runs on tick (every second)
        lblClock.Text = Format(strTime.Now) ' This Formats the clock text to the current time.
    End Sub ' End the sub.

    Private Sub ClockInBtn_Click_1(sender As Object, e As EventArgs) Handles ClockInBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New ClockInSubform) ' Opens the child form ClockIn.
    End Sub ' End the sub.

    Private Sub PayslipBtn_Click(sender As Object, e As EventArgs) Handles PayslipBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New PayslipSubform) ' Opens the child form Payslip.
    End Sub ' End the sub.

    Private Sub OptionsBtn_Click(sender As Object, e As EventArgs) Handles OptionsBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New OptionsSubforms) ' Opens the child form Options.
    End Sub ' End the sub.

    Private Sub MembersBtn_Click(sender As Object, e As EventArgs) Handles MembersBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New MembersSubform) ' Opens the child form Members.
    End Sub ' End the sub.

    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New AddStaffSubform) ' Opens the child form AddStaff.
    End Sub ' End the sub.

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click ' This creates a private sub which runs upon click.
        OpenChildForm(New ReportsSubform) ' Opens the child form Reports.
    End Sub ' End the sub.

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click ' This creates a private sub which runs upon click.
        frmSignInPage.Show() ' This loads the sign in page again.
        Me.Close() ' This hides the current form and subforms.
        Connection.Close() ' This closes the current connection but not the bridge to the database.
    End Sub ' End the sub

End Class ' End the class.