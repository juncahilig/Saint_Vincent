Imports System.Data.OleDb
Public Class AdminReturnBook
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

    Private Sub txtBookCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBookCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False

            Dim dbDataReader As OleDb.OleDbDataReader = Nothing
            Dim sqlCommand As String = "Select * from book_inventory WHERE Book_code = '" & txtBookCode.Text & "'"

            dbDataReader = performQuery(connectionString, sqlCommand)
            If dbDataReader.HasRows Then
                While dbDataReader.Read
                    txtTitle.Text = dbDataReader("Title".ToString)
                    txtStudentNum.Enabled = True
                    'txtStudentNum set to focus
                    txtStudentNum.Focus()
                End While

            Else
                MessageBox.Show("Record not Found!")
                txtBookCode.Focus()
                txtBookCode.Clear()
                txtTitle.Clear()
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

    Private Sub txtStudentNum_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtStudentNum.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.Handled = False

            Dim dbDataReader As OleDb.OleDbDataReader = Nothing
            Dim sqlCommand As String = "Select * from stud_info WHERE Book_Code = '" & txtBookCode.Text & "' AND SN = '" & txtStudentNum.Text & "'"

            dbDataReader = performQuery(connectionString, sqlCommand)
            If dbDataReader.HasRows Then
                While dbDataReader.Read
                    txtLastName.Text = dbDataReader("Last_Name".ToString)
                    txtFirstName.Text = dbDataReader("First_Name".ToString)
                    btnReturn.Enabled = True
                    btnReturn.Focus()
                End While

            Else
                MessageBox.Show("Record not Found!")
                txtStudentNum.Focus()
                txtLastName.Clear()
                txtFirstName.Clear()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btnBorrowBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowBook.Click
        AdminBorrowBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnChanges.Click
        Dim dbDataReader As OleDb.OleDbDataReader = Nothing
        Dim sqlCommand As String = "Select * from Stud_Info WHERE SN = '" & txtBookCode.Text & "'"

        dbDataReader = performQuery(connectionString, sqlCommand)
        If dbDataReader.HasRows Then
            sqlCommand = "UPDATE stud_info SET Book_Code = 'NONE', Title = 'NONE', Pending_Book = 'NONE'"
            Dim sqlCommand1 As String = "UPDATE book_inventory SET On_Hand =  '" & Val(frmBorrowBook.txtOnHand.Text) + 0 & "'  WHERE Book_Code = '" & frmBorrowBook.txtBookCode.Text & "'"
            performNonQuery(connectionString, sqlCommand1)
            If performNonQuery(connectionString, sqlCommand) Then
                MessageBox.Show("Book is Successfully Returned!")
                Me.Hide()
                'frmAdmin.Show()
                'txtBookCode.Clear()
                'txtTitle.Clear()
                'txtStudentNum.Clear()
                'txtLastName.Clear()
                'txtFirstName.Clear()
                Exit Sub
            Else
                MessageBox.Show("Unable to Modify New Record!")
                Exit Sub
            End If

        Else
            MessageBox.Show("No Record Found")
        End If
    End Sub
    Private Sub txtStudentNum_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtStudentNum.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = True
            MsgBox("Numbers only!", 0)
        End If
    End Sub
End Class