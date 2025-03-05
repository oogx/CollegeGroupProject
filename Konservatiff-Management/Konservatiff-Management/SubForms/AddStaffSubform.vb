Imports FontAwesome.Sharp

Public Class AddStaffSubform
    Function GetNewData()
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblMembers"
        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)
        DataAdapt.Fill(DataSet, "Members")
        MaxRows = DataSet.Tables("Members").Rows.Count
        Connection.Close()
    End Function
    Private Sub AddStaffSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetNewData()
    End Sub
    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim ComBuild As New OleDb.OleDbCommandBuilder(DataAdapt)
        Dim NewRow As DataRow

        NewRow = DataSet.Tables("Members").NewRow()
        NewRow.Item("MemberID") = (MaxRows + 1)
        NewRow.Item("Forename") = fNameTxtBx.Text
        NewRow.Item("Surname") = sNameTxtBx.Text
        NewRow.Item("MobileNo") = mobNoTxtBx.Text
        NewRow.Item("Email") = emailTxtBx.Text
        NewRow.Item("NINo") = niNoTxtBx.Text
        DataSet.Tables("Members").Rows.Add(NewRow)

        DataAdapt.Update(DataSet, "Members")
        MsgBox("Added New Staff.")
        GetNewData()
    End Sub

    Private Sub clearBtn_Click(sender As Object, e As EventArgs) Handles clearBtn.Click
        fNameTxtBx.Text = ""
        sNameTxtBx.Text = ""
        mobNoTxtBx.Text = ""
        emailTxtBx.Text = ""
        niNoTxtBx.Text = ""
    End Sub


End Class