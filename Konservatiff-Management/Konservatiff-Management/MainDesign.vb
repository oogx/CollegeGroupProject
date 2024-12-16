Imports System.Web.UI.HtmlControls
Imports FontAwesome.Sharp
Public Class MainDesign
    Dim currentChildForm As Form
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
    End Sub

    Private Sub MainDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        OpenChildForm(New ClockInSubform)
    End Sub

    Private Sub ClockInButton_Click(sender As Object, e As EventArgs)
        OpenChildForm(New ClockInSubform)
    End Sub

End Class