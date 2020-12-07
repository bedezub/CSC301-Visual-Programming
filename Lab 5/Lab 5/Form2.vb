Public Class Form2
    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click
        pnlSuccessful.Hide()
        Me.Hide()
        Form1.Show()
    End Sub
End Class