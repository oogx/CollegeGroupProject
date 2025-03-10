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

    Private Sub excelbyCell()
        Dim oExcel As Object
        Dim oBook As Object
        Dim oSheet As Object

        'Start a new workbook in Excel
        oExcel = CreateObject("Excel.Application")
        oBook = oExcel.Workbooks.Add
        'Add data to cells of the first worksheet in the new workbook

        oSheet = oBook.Worksheets(1)

        'For i = 0 To 0
        'oSh'eet.Range("A1").Value = DataSet.Tables("Members").Rows(i).Item(0)
        'oSheet.Range("A2").Value = DataSet.Tables("Members").Rows(i).Item(1)
        'oSheet.Range("A3").Value = DataSet.Tables("Members").Rows(i).Item(2)
        'oSheet.Range("A4").Value = DataSet.Tables("Members").Rows(i).Item(3)
        'oSheet.Range("A5").Value = DataSet.Tables("Members").Rows(i).Item(4)
        'oSheet.Range("A6").Value = DataSet.Tables("Members").Rows(i).Item(5)
        'oSheet.Range("A7").Value = DataSet.Tables("Members").Rows(i).Item(6)
        'oSheet.Range("A8").Value = DataSet.Tables("Members").Rows(i).Item(7)
        'oSheet.Range("A9").Value = DataSet.Tables("Members").Rows(i).Item(8)
        'oSheet.Range("A10").Value = DataSet.Tables("Members").Rows(i).Item(9)
        'oSheet.Range("A11").Value = DataSet.Tables("Members").Rows(i).Item(10)
        'oSheet.Range("A12").Value = DataSet.Tables("Members").Rows(i).Item(11)
        'oSheet.Range("A13").Value = DataSet.Tables("Members").Rows(i).Item(12)
        'oSheet.Range("A14").Value = DataSet.Tables("Members").Rows(i).Item(13)
        'Next

        'Save the Workbook and Quit Excel
        oBook.SaveAs("N:\ICT\Student_Files\Q1044\PracticeSolution")
        oExcel.Quit

    End Sub

    Private Sub backupBtn_Click(sender As Object, e As EventArgs) Handles backupBtn.Click
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()
        SQL = "SELECT * FROM tblMembers"

        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)
        DataAdapt.Fill(DataSet, "Members")
        Connection.Close()

        MaxRows = DataSet.Tables("Members").Rows.Count
        CurrentRows = 0

        excelbyCell()
    End Sub
End Class