Public Class AdminTransactionPage

    Private Sub btnBorrowBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBorrowBook.Click
        AdminBorrowBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnReturnBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReturnBook.Click
        AdminReturnBook.Show()
        Me.Hide()
    End Sub

    Private Sub btnBack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBack.Click
        AdminHomePage.Show()
        Me.Hide()
    End Sub

    Private Sub btnPendingBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPendingBook.Click
        AdminPendingBook.Show()
        Me.Hide()
    End Sub
End Class