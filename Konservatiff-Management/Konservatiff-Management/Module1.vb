Module Module1
    Public Connection As New OleDb.OleDbConnection
    Public SQL As String
    Public DataSet As New DataSet
    Public DataAdapt As OleDb.OleDbDataAdapter
    Public CurrentRows As Integer
    Public MaxRows As Integer
    Public strTime As System.DateTime

    Public currentChildForm As Form
    Public CurrentLevel As Int64

    Public Username As String
End Module
