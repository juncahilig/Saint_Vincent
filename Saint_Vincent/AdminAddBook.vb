Imports System.Data.OleDb
Public Class AdminAddBook

    Dim dbPath As String = Application.StartupPath & "\Database\SVBS_Library_System.mdb"
    Dim connectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0; DATA SOURCE = " & dbPath

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

    Private Sub btnDeleteBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBook.Click
        AdminDeleteBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnModifyBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyBook.Click
        AdminModifyBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminModifyPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnAddChanges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddChanges.Click
        Dim dbDataReader As OleDb.OleDbDataReader = Nothing
        Dim sqlCommand As String = "SELECT * FROM Book_Inventory WHERE Book_Code = '" & txtBookCode.Text & "'"

        dbDataReader = performQuery(connectionString, sqlCommand)

        If dbDataReader.HasRows Then
            MessageBox.Show("Book Already Exist!")
            'txtBookCode.Focus()
            'txtBookCode.Clear()
            'txtBookTitle.Clear()
            'txtBookAuthor.Clear()
            'txtBookOnHand.Clear()
            Exit Sub

        Else
            sqlCommand = "INSERT INTO Book_Inventory(Book_Code, Title, Author, ISBN, Publisher, Publication_Year, Book_Level, On_Hand) VALUES('" & txtBookCode.Text & "', '" & txtBookTitle.Text.ToUpper & "', '" & txtBookAuthor.Text.ToUpper & "', '" & txtBookISBN.Text & "', '" & txtPublisher.Text.ToUpper & "', '" & txtPubYear.Text & "','" & cmbBookLevel.SelectedItem & "', '" & txtBookOnHand.Text & "')"
            If performNonQuery(connectionString, sqlCommand) Then
                MessageBox.Show("Successfully Added!")
                Me.Hide()
                AdminModifyPage.Show()
                'txtBookCode.Clear()
                'txtBookTitle.Clear()
                'txtBookAuthor.Clear()
                'txtBookOnHand.Clear()
                Exit Sub

            Else
                MessageBox.Show("Unable to Save New Record!")
                Me.Hide()
                AdminModifyPage.Show()
            End If
        End If
    End Sub

    Private Sub txtBookCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookCode.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Numbers only!", 0)
            txtBookCode.Focus()
        End If
    End Sub
End Class