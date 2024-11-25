Imports System.Threading

Public Class frmSignInPage

    Private Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' 1000ms = 1 second
        Timer1.Start() ' Start the timer
    End Sub
    Dim strTime As System.DateTime
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub
End Class