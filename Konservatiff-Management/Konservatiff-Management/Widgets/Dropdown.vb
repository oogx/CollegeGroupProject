Public Class Dropdown
    Private Sub CloseDropdownBtn_Click(sender As Object, e As EventArgs) Handles CloseDropdownBtn.Click
        Me.Hide()
        CloseDropdown = True
    End Sub
    Sub OpenChildForm(childForm As Form) ' Creating a Sub called OpenChildForm which has a parameter which is passed called childForm which is a Form.
        currentChildForm = childForm ' Declaring a currentchildForm as the passed paremeter.
        childForm.TopLevel = False ' Setting the childform as not the top most form, this would mess up things yano.
        childForm.FormBorderStyle = FormBorderStyle.None ' Setting the childform to have no border.
        childForm.Dock = DockStyle.Fill ' This sets the dockstyle to fill.
        User_Desktop_Panel.Controls.Add(childForm) ' This actually populates the childform making it appear on the current main page.
        User_Desktop_Panel.Tag = childForm ' This sets the tag of the main panel to the childform
        childForm.BringToFront() ' Instead of setting the childform to topmost it brings it to the front of the other panel so meshes dont collide.
        childForm.Show() ' This then shows the child form.
        KMText.Text = "Konservatiff Management | Members Options " ' This changes the text on the main form to insert what the child form text is.
    End Sub ' Ending the current OpenChildForm sub.
    Private Sub ChangeInformationBtn_Click(sender As Object, e As EventArgs) Handles ChangeInformationBtn.Click
        OpenChildForm(New ChangeInformation) ' Opens the widget change information.
    End Sub

    Private Sub ViewShiftsBtn_Click(sender As Object, e As EventArgs) Handles ViewShiftsBtn.Click
        OpenChildForm(New ViewShifts) 'Opens the widget to view shifts.
    End Sub

    Private Sub DeleteMemberBtn_Click(sender As Object, e As EventArgs) Handles DeleteMemberBtn.Click
        If MessageBox.Show("Want to delete it?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.No Then
            MsgBox("Operation cancelled!")
            Exit Sub
        ElseIf DialogResult.Yes Then

        End If
    End Sub

    Private Sub EmailPayslipBtn_Click(sender As Object, e As EventArgs) Handles EmailPayslipBtn.Click
        OpenChildForm(New EmailPayslip)
    End Sub

    Private Sub PDFPayslipBtn_Click(sender As Object, e As EventArgs) Handles PDFPayslipBtn.Click
        OpenChildForm(New ViewPayslip)
    End Sub
End Class