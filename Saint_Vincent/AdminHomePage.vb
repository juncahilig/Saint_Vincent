Public Class AdminHomePage

    Private Sub btnBookInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBookInfo.Click
        AdminBookInfo.Show()
        Me.Hide()
    End Sub

    Private Sub btnSearchBook_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearchBook.Click
        AdminSearchBook.Show()
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

    Private Sub btnChangePassword_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePassword.Click
        AdminChangePassword.Show()
        Me.Hide()
    End Sub

    Private Sub btnLogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogout.Click
        HomePage.Show()
        Me.Hide()
    End Sub
End Class