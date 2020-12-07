Public Class Form1

    ''Navigation 
    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click
        Me.Hide()
        Form2.ShowDialog()
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Me.Hide()
        Form3.ShowDialog()
    End Sub

    ''Menu Level Configuration

    'Adjust System Level Font
    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        lblTitle.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)
    End Sub

    'Adjust System Level Color
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        lblTitle.ForeColor = ColorDialog1.Color
    End Sub


End Class
