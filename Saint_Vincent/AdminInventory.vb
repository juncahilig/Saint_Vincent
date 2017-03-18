Imports System.Data.OleDb
Public Class AdminInventory
    Dim dbConnection As New OleDbConnection
    Dim dbPath As String = Application.StartupPath & "\Database\SVBS_Library_System.mdb"
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; DATA SOURCE = " & dbPath

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        AdminSearchBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInfo.Click
        AdminBookInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnModifyPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyPage.Click
        AdminModifyPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        AdminTransactionPage.Show()
        Me.Hide()
    End Sub

    Private Sub dataGrid()

        Dim dataSet As New DataSet
        Dim dataTable As New DataTable
        dataSet.Tables.Add(dataTable)
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("SELECT Book_Code, Title, Author, ISBN, Publisher, Publication_Year, Book_Level, On_Hand FROM Book_Inventory ORDER BY Book_Level", dbConnection)
        dataAdapter.Fill(dataTable)

        DataGridView1.DataSource = dataTable.DefaultView

    End Sub

    Private Sub AdminInventory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbConnection.ConnectionString = connectionString
        dbConnection.Open()
        dataGrid()
    End Sub
End Class