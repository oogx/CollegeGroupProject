Public Class frmClockPage
    Public Sub frmClockPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' 1000ms = 1 second
        Timer1.Start() ' Start the timer
    End Sub
    Dim strTime As System.DateTime
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub

    Private Sub lblSignIn_Click(sender As Object, e As EventArgs) Handles lblSignIn.Click

    End Sub

    Private Sub lblSignInDot_Click(sender As Object, e As EventArgs) Handles lblSignInDot.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class