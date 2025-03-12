Imports FontAwesome.Sharp

Public Class AddStaffSubform
    Dim Max As Integer
    Function GetNewData()
        Connection.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=database.accdb"
        Connection.Open()

        SQL = "SELECT * FROM tblMembers"
        DataAdapt = New OleDb.OleDbDataAdapter(SQL, Connection)
        DataAdapt.Fill(DataSet, "Members")
        Max = DataSet.Tables("Members").Rows.Count
        Connection.Close()
        CurrentPage = 1
    End Function

    Private Sub AddStaffSubform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetNewData()
    End Sub

    Private Sub addBtn_Click(sender As Object, e As EventArgs) Handles addBtn.Click
        Dim CommandBuilder As New OleDb.OleDbCommandBuilder(DataAdapt)

        Dim NewRow As DataRow
        CommandBuilder.QuotePrefix = "["
        CommandBuilder.QuoteSuffix = "]"

        NewRow = DataSet.Tables("Members").NewRow()
        Max = Max + 1
        NewRow.Item("MemberID") = Max
        NewRow.Item("Forename") = fNameTxtBx.Text
        NewRow.Item("Surname") = sNameTxtBx.Text
        NewRow.Item("MobileNo") = mobNoTxtBx.Text
        NewRow.Item("Email") = emailTxtBx.Text
        NewRow.Item("NINo") = niNoTxtBx.Text

        NewRow.Item("TaxID") = 0
        NewRow.Item("DoB") = Date.Now
        NewRow.Item("AdminStatus") = False
        NewRow.Item("Password") = "0"
        NewRow.Item("Sex") = ""
        NewRow.Item("DarkTheme") = False
        NewRow.Item("Contrast") = False
        NewRow.Item("TextSize") = "50"
        NewRow.Item("PayRateID") = "1"


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