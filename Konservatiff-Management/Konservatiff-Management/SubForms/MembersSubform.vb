Public Class MembersSubform
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
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblMembers"
        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)

        If DataSet.Tables.Contains("Members") Then
            DataSet.Tables("Members").Clear()
        End If

        DataAdapt.Fill(DataSet, "Members")
        MaxRows = DataSet.Tables("Members").Rows.Count
        Connection.Close()
        CurrentPage = 1
        Call NavigateRecords()
    End Sub



    Private Sub NavigateRecords()
        Dim intRow, intCol As Integer
        Dim strLbl As Label
        Dim startIndex As Integer = (CurrentPage - 1) * 10

        MaxPages = Math.Ceiling(MaxRows / 10.0)
        pageCountLbl.Text = "Page " & CurrentPage & " of " & MaxPages

        For intRow = 1 To 10
            For intCol = 1 To 7
                strLbl = CType(Me.Controls("R" & intRow & "C" & intCol), Label)

                If startIndex + intRow - 1 < DataSet.Tables("Members").Rows.Count Then
                    strLbl.Text = DataSet.Tables("Members").Rows(startIndex + intRow - 1).Item(intCol - 1).ToString()
                    Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & intRow & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
                    btn.Visible = True
                    btn.Tag = startIndex + intRow
                Else
                    strLbl.Text = " "
                    Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & intRow & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
                    btn.Visible = False
                End If
            Next
        Next
    End Sub

    Private Sub PreviousPageBtn_Click(sender As Object, e As EventArgs) Handles PreviousPageBtn.Click
        If Not CurrentPage = 1 Then
            CurrentPage -= 1
            Call NavigateRecords()
        End If
    End Sub

    Private Sub NextPageBtn_Click(sender As Object, e As EventArgs) Handles NextPageBtn.Click
        If Not CurrentPage = MaxPages Then
            CurrentPage += 1
            Call NavigateRecords()
        End If
    End Sub
End Class