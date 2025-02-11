Public Class Dropdown
    Private Sub CloseDropdownBtn_Click(sender As Object, e As EventArgs) Handles CloseDropdownBtn.Click
        Me.Hide()
        CloseDropdown = True
    End Sub
End Class