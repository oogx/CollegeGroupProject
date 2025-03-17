Imports FontAwesome.Sharp

Public Class MembersSubform
    Private WithEvents LoopTime As New Timer()
    Sub New()
        InitializeComponent()
        LoopTime.Interval = 10
        LoopTime.Start()
        For i As Integer = 1 To 10
            Dim btn As Guna.UI2.WinForms.Guna2Button = CType(Me.Controls.Find("R" & i & "Btn", True).FirstOrDefault(), Guna.UI2.WinForms.Guna2Button)
            If btn IsNot Nothing Then
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
            CurrentMemberID = btn.Tag.ToString()

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
                    btn.Tag = DataSet.Tables("Members").Rows(startIndex + intRow - 1).Item(0).ToString()
                    btn.Visible = True
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

    Private Sub BackupBtn_Click(sender As Object, e As EventArgs) Handles BackupBtn.Click
        Dim Excel As Object
        Dim Book As Object
        Dim CurrentExcelSheet As Object

        Excel = CreateObject("Excel.Application")
        Book = Excel.Workbooks.Add

        CurrentExcelSheet = Book.Worksheets(1)
        CurrentExcelSheet.Range("A1").Value = "MembersID"
        CurrentExcelSheet.Range("B1").Value = "Forename"
        CurrentExcelSheet.Range("C1").Value = "Surname"
        CurrentExcelSheet.Range("D1").Value = "TaxID"
        CurrentExcelSheet.Range("E1").Value = "NINo"
        CurrentExcelSheet.Range("F1").Value = "DoB"
        CurrentExcelSheet.Range("G1").Value = "MobileNo"
        CurrentExcelSheet.Range("H1").Value = "Email"
        CurrentExcelSheet.Range("I1").Value = "AdminStatus"
        CurrentExcelSheet.Range("J1").Value = "Password"
        CurrentExcelSheet.Range("K1").Value = "Sex"
        CurrentExcelSheet.Range("L1").Value = "DarkTheme"
        CurrentExcelSheet.Range("M1").Value = "Contrast"
        CurrentExcelSheet.Range("N1").Value = "TextSize"
        CurrentExcelSheet.Range("O1").Value = "PayRateID"

        For i = 0 To MaxRows - 1
            CurrentExcelSheet.Range("A" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(0)
            CurrentExcelSheet.Range("B" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(1)
            CurrentExcelSheet.Range("C" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(2)
            CurrentExcelSheet.Range("D" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(3)
            CurrentExcelSheet.Range("E" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(4)
            CurrentExcelSheet.Range("F" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(5).ToString
            CurrentExcelSheet.Range("G" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(6)
            CurrentExcelSheet.Range("H" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(7)
            CurrentExcelSheet.Range("I" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(8)
            CurrentExcelSheet.Range("J" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(9)
            CurrentExcelSheet.Range("K" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(10)
            CurrentExcelSheet.Range("L" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(11)
            CurrentExcelSheet.Range("M" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(12)
            CurrentExcelSheet.Range("N" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(13)
            CurrentExcelSheet.Range("O" & i + 2).Value = DataSet.Tables("Members").Rows(i).Item(14)
        Next

        Book.SaveAs(CurDir() + "\BackupDatabase")
        Excel.Quit

        MsgBox("Backup has been saved in the current directory.")
    End Sub

End Class