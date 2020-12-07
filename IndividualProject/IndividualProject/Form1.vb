Public Class Form1
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Visible = False
        Form2.Visible = True
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Visible = False
        Form3.Visible = True
    End Sub

    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Voting registration system. The future is in your hand!", "About System", MessageBoxButtons.OK)
    End Sub
End Class
