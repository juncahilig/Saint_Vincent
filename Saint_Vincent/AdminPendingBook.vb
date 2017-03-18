Public Class AdminPendingBook

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminModifyPage.Show()
        Me.Hide()
    End Sub

    Private Sub btnBorrowBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowBook.Click
        AdminBorrowBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnBook.Click
        AdminReturnBook.Show()
        Me.Hide()
    End Sub

End Class