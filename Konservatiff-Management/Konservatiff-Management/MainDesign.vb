Imports System.Web.UI.HtmlControls
Imports System.Xml
Imports FontAwesome.Sharp
Public Class MainDesign
    Sub OpenChildForm(childForm As Form)
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        User_Desktop_Panel.Controls.Add(childForm)
        User_Desktop_Panel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
        KMText.Text = "Konservatiff Management | " & childForm.Text

        If childForm.Text = "Clock In" Then
            lblClock.Hide()
        Else
            lblClock.Show()
        End If

    End Sub

    Private Sub MainDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New ClockInSubform)
        Timer1.Start()
        UsersNameLbl.Text = Username
        If Not AccessLevel Then
            AdminLabel.Visible = False
            MembersBtn.Visible = False
            AddStaffBtn.Visible = False
            ReportsBtn.Visible = False
            UserTypeLbl.Text = "User"
        Else
            UserTypeLbl.Text = "Admin"
        End If

        If DarkTheme Then
            User_Desktop_Panel.BackColor = Color.White
            Panel5.ForeColor = Color.Aqua
        Else

        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub
    Private Sub ClockInBtn_Click_1(sender As Object, e As EventArgs) Handles ClockInBtn.Click
        OpenChildForm(New ClockInSubform)
    End Sub

    Private Sub PayslipBtn_Click(sender As Object, e As EventArgs) Handles PayslipBtn.Click
        OpenChildForm(New PayslipSubform)
    End Sub

    Private Sub OptionsBtn_Click(sender As Object, e As EventArgs) Handles OptionsBtn.Click
        OpenChildForm(New OptionsSubforms)
    End Sub

    Private Sub MembersBtn_Click(sender As Object, e As EventArgs) Handles MembersBtn.Click
        OpenChildForm(New MembersSubform)
    End Sub

    Private Sub AddStaffBtn_Click(sender As Object, e As EventArgs) Handles AddStaffBtn.Click
        OpenChildForm(New AddStaffSubform)
    End Sub

    Private Sub ReportsBtn_Click(sender As Object, e As EventArgs) Handles ReportsBtn.Click
        OpenChildForm(New ReportsSubform)
    End Sub
    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Hide()
        Connection.Close()
        frmSignInPage.Show()
    End Sub
End Class