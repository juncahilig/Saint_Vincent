Public Class AdminModifyPage

    Private Sub btnAddBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddBook.Click
        AdminAddBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnDeleteBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteBook.Click
        AdminDeleteBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnModifyBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnModifyBook.Click
        AdminModifyBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminHomePage.Show()
        Me.Hide()
    End Sub
End Class