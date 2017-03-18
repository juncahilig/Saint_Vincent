Public Class AdminPage
    Dim strUserName As String
    Dim strPassword As String
    Dim bytUNCtr As Byte = 0
    Dim bytPWCtr As Byte = 0

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        strUserName = txtUserName.Text
        strPassword = txtPassword.Text

        If bytUNCtr <= 5 Then
            MsgBox("Please enter at least 6 characters", 0)
            txtUserName.Clear()
            txtUserName.Focus()

        ElseIf bytPWCtr <= 5 Then
            MsgBox("Please enter at least 6 characters", 0)
            txtPassword.Clear()
            txtPassword.Focus()
        ElseIf strUserName = My.Settings.UserName And strPassword = My.Settings.Password Then
            Me.Hide()
            AdminHomePage.Show()
        Else
            MsgBox("Please enter the correct information above", 0)
            txtUserName.Clear()
            txtPassword.Clear()
            txtUserName.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = True
            MsgBox("Letters only", 0)
            txtUserName.Focus()
        Else
            e.Handled = False
            bytUNCtr = bytUNCtr + 1
        End If
    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If Char.IsSeparator(e.KeyChar) Then
            e.Handled = True
        Else
            e.Handled = False
            bytPWCtr = bytPWCtr + 1
        End If
    End Sub

    Private Sub btnHomePage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHomePage.Click
        HomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        UserSearchBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInfo.Click
        UserBookInfo.Show()
        Me.Hide()
    End Sub
End Class