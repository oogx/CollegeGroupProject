Imports System.Web.UI.HtmlControls
Imports FontAwesome.Sharp
Public Class MainDesign
    Dim currentChildForm As Form
    Dim strTime As System.DateTime
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
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub
    Private Sub ClockInButton_Click_1(sender As Object, e As EventArgs) Handles ClockInButton.Click
        OpenChildForm(New ClockInSubform)
    End Sub

    Private Sub PayslipButton_Click(sender As Object, e As EventArgs) Handles PayslipButton.Click
        OpenChildForm(New PayslipSubform)
    End Sub
End Class