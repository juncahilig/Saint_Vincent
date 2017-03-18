Public Class HomePage

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Enabled = True Then
            Me.Hide()
            AdminPage.Show()
        End If
    End Sub
End Class
