Public Class OptionsSubforms
    Private Sub OptionsSubforms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        darkThemeCheckBx.Checked = DarkTheme
        highContrastCheckBx.Checked = Contrast
        setTextSizeTxtBx.Text = TextSize
    End Sub


End Class