Public Class MembersSubform
    Public MaxRows As Integer
    Public curRow As Integer
    Public con As New OleDb.OleDbConnection
    Public ds As New DataSet
    Public da As OleDb.OleDbDataAdapter
    Public sql As String
    Private WithEvents LoopTime As New Timer()

    Sub New()
        InitializeComponent()
        LoopTime.Interval = 10
        LoopTime.Start()
        For i As Integer = 1 To 10
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & i & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
            If btn IsNot Nothing Then
                btn.Tag = i
                AddHandler btn.Click, AddressOf MemberButton_Click
            End If
        Next
    End Sub

    Sub OpenChildForm(childForm As Form)
        currentChildForm = childForm
        childForm.TopLevel = False
        childForm.FormBorderStyle = FormBorderStyle.None
        childForm.Dock = DockStyle.Fill
        Dropdown_Panel.Controls.Add(childForm)
        Dropdown_Panel.Tag = childForm
        childForm.BringToFront()
        childForm.Show()
    End Sub

    Private Sub LoopTime_Tick(sender As Object, e As EventArgs) Handles LoopTime.Tick
        If CloseDropdown Then
            Dropdown_Panel.Visible = False
            CloseDropdown = False
        End If
    End Sub

    Private Sub MemberButton_Click(sender As Object, e As EventArgs)
        Dim btn As Guna.UI2.WinForms.Guna2Button = CType(sender, Guna.UI2.WinForms.Guna2Button)
        If btn IsNot Nothing Then
            Dropdown_Panel.Visible = True
            OpenChildForm(New Dropdown)
            CurrentMemberID = CInt(btn.Tag)
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        con.Open()

        sql = "SELECT * FROM tblMembers"
        da = New OleDb.OleDbDataAdapter(sql, con)
        da.Fill(ds, "Members")
        MaxRows = ds.Tables("Members").Rows.Count
        con.Close()
        CurrentPage = 1
        Call NavigateRecords()
    End Sub

    Private Sub NavigateRecords()
        Dim intRow, intCol As Integer
        Dim strLbl As Label

        intRow = 0
        intCol = 0
        'getting the no. of pages from the amount of rows.
        MaxPages = (MaxRows / 10)
        MaxPages = Math.Ceiling(MaxPages)
        'setting the page counter.
        pageCountLbl.Text = ("Page " & CurrentPage & " of " & MaxPages)

        For intRow = 1 To 10
            For intCol = 1 To 7
                ' Find the label control by its name
                strLbl = CType(Me.Controls("R" & intRow & "C" & intCol), Label)

                If intRow - 1 < ds.Tables("Members").Rows.Count Then
                    ' Update the label's text with the corresponding row and col data
                    strLbl.Text = ds.Tables("Members").Rows(intRow - 1).Item(intCol - 1).ToString()
                    Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & intRow & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
                    btn.Visible = True
                Else
                    ' Fill the label with a single space if the row doesn't exist
                    strLbl.Text = " "
                    Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & intRow & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
                    btn.Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub PreviousPageBtn_Click(sender As Object, e As EventArgs) Handles PreviousPageBtn.Click
        If CurrentPage = 1 Then
            MsgBox("You cannot go less than page 1.")
        Else
            CurrentPage -= 1
            Call NavigateRecords()
        End If
    End Sub

    Private Sub NextPageBtn_Click(sender As Object, e As EventArgs) Handles NextPageBtn.Click
        If CurrentPage <> MaxPages - 1 Then
            MsgBox("You have reached the max page")
        Else
            CurrentPage += 1
            Call NavigateRecords()
        End If
    End Sub

End Class