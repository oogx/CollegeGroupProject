Imports System.Threading

Public Class frmSignInPage
    Dim strTime As System.DateTime
    Private Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        While True
            lblClock.Text = Format(strTime.Now)
            Thread.Sleep(1000)
        End While
    End Sub

    Private Sub lblClock_Click(sender As Object, e As EventArgs) Handles lblClock.Click

    End Sub
End Class