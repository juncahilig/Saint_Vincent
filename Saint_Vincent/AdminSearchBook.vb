Imports System.Data.OleDb

Public Class AdminSearchBook

    Dim dbConnection As New OleDbConnection
    Dim dbPath As String = Application.StartupPath & "\Database\SVBS_Library_System.mdb"
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; DATA SOURCE = " & dbPath
    Dim strSearchBy As String

    Private Function performQuery(ByVal connectionString As String, ByVal sqlCommand As String) As OleDb.OleDbDataReader
        Dim dbConnection As OleDbConnection
        Dim dbCommand As New OleDbCommand()
        Dim dbDataReader As OleDb.OleDbDataReader = Nothing

        Try
            dbConnection = New OleDbConnection(connectionString)
            dbCommand.CommandText = sqlCommand
            dbCommand.Connection = dbConnection
            dbConnection.Open()
            dbDataReader = dbCommand.ExecuteReader
            Return dbDataReader
            dbConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
        Return Nothing
    End Function

    Private Function performNonQuery(ByVal connectionString As String, ByVal sqlCommand As String) As Boolean
        Dim dbConnection As OleDbConnection
        Dim dbCommand As New OleDbCommand()

        Try
            dbConnection = New OleDbConnection(connectionString)
            dbCommand.CommandText = sqlCommand
            dbCommand.Connection = dbConnection
            dbConnection.Open()
            dbCommand.ExecuteNonQuery()
            dbConnection.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message, Me.Text, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End Try
        Return True
    End Function

    Private Sub dataGrid()

        Dim dataSet As New DataSet
        Dim dataTable As New DataTable
        dataSet.Tables.Add(dataTable)
        Dim dataAdapter As New OleDbDataAdapter

        dataAdapter = New OleDbDataAdapter("Select * FROM Book_Inventory WHERE " & lblSearchBy.Text & " LIKE('%" & txtAdminSearch.Text.ToUpper & "%') ORDER BY Book_Code", dbConnection)
        dataAdapter.Fill(dataTable)

        DataGridView1.DataSource = dataTable.DefaultView

    End Sub

    Private Sub SearchBookPage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dbConnection.ConnectionString = connectionString
        dbConnection.Open()
        dataGrid()

        strSearchBy = "Title"
        lblSearchBy.Text = "TITLE"
    End Sub

    Private Sub btnAuthor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAuthor.Click
        strSearchBy = "Author"
        lblSearchBy.Text = "AUTHOR"
    End Sub

    Private Sub btnKeyword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeyword.Click
        strSearchBy = "Keyword"
        lblSearchBy.Text = "KEYWORD"
    End Sub

    Private Sub btnTitle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTitle.Click
        strSearchBy = "Title"
        lblSearchBy.Text = "TITLE"
    End Sub

    Private Sub btnGoSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGoSearch.Click

        dataGrid()

    End Sub

    Private Sub btnBookInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInfo.Click
        AdminBookInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnModifyPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyPage.Click
        AdminModifyPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookInventory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInventory.Click
        AdminInventory.Show()
        Me.Hide()
    End Sub

    Private Sub btnTransaction_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTransaction.Click
        AdminTransactionPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click

    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click

    End Sub
End Class