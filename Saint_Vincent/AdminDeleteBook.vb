﻿Imports System.Data.OleDb
Public Class AdminDeleteBook

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

    Private Sub btnAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBook.Click
        AdminAddBook.Show()
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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteChanges.Click
        Dim dbDataReader As OleDb.OleDbDataReader = Nothing
        Dim sqlCommand As String = "Select * from Book_Inventory WHERE Book_Code = '" & txtBookCode.Text & "'"

        dbDataReader = performQuery(connectionString, sqlCommand)
        If dbDataReader.HasRows Then
            sqlCommand = "DELETE FROM Book_Inventory WHERE Book_Code = '" & txtBookCode.Text & "'"
            If performNonQuery(connectionString, sqlCommand) Then
                MessageBox.Show("The Book is Successfully Removed!")
                Me.Show()
                Exit Sub
            Else
                MessageBox.Show("Unable to Remove Record")
                txtBookCode.Focus()
                Exit Sub
            End If
        Else
            MessageBox.Show("Book Code Not Found!")
            txtBookCode.Clear()
            txtBookCode.Focus()
        End If
    End Sub

    Private Sub txtBookCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBookCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False

            Dim dbDataReader As OleDb.OleDbDataReader = Nothing
            Dim sqlCommand As String = "Select * from book_inventory WHERE Book_code = '" & txtBookCode.Text & "'"

            dbDataReader = performQuery(connectionString, sqlCommand)
            If dbDataReader.HasRows Then
                While dbDataReader.Read
                    txtBookTitle.Text = dbDataReader("Title".ToString)
                    txtBookAuthor.Text = dbDataReader("Author".ToString)
                    txtBookISBN.Text = dbDataReader("ISBN".ToString)
                    txtBookPubYear.Text = dbDataReader("Publication_Year".ToString)
                    txtBookPublisher.Text = dbDataReader("Publisher".ToString)
                    txtBookLevel.Text = dbDataReader("Book_Level".ToString)
                    txtBookOnHand.Text = dbDataReader("On_Hand".ToString)
                    'btnBorrow Set to focus
                    btnDeleteChanges.Enabled = True
                    btnDeleteChanges.Focus()
                End While

            Else
                MessageBox.Show("Record not Found!")
                txtBookCode.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub txtBookCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtBookCode.KeyPress
        If e.KeyChar <> ControlChars.Back Then
            e.Handled = False
        End If
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Numbers only!", 0)
            txtBookCode.Focus()
        End If
    End Sub
End Class