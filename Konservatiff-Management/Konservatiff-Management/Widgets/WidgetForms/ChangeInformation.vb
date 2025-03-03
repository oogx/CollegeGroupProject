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

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        OpenChildForm(New MembersSubform) ' This changes the page back to the members subform.
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Guna2ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Guna2ComboBox1.SelectedIndexChanged

    End Sub
End Class