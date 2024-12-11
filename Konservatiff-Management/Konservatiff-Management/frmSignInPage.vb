Imports System.Threading

Public Class frmSignInPage

    Public Sub frmSignInPage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000 ' 1000ms = 1 second
        Timer1.Start() ' Start the timer
    End Sub
    Dim strTime As System.DateTime
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblClock.Text = Format(strTime.Now)
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles payrollTxtBx.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        frmClockPage.Show()
    End Sub

    Private Sub passTxtBx_TextChanged(sender As Object, e As EventArgs) Handles passTxtBx.TextChanged
    End Sub
End Class