Public Class HomePage

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        UserSearchBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBookInfo_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInfo.Click
        UserBookInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnAdminPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdminPage.Click
        AdminPage.Show()
        Me.Hide()
    End Sub
End Class
