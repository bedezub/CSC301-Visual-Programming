Public Class Form3
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If (validateForm()) Then
            Me.Visible = False
            Form4.Visible = True
        End If
    End Sub

    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Function validateForm()
        Dim strArr() As String
        Dim str As String

        If (txtEmail.Text IsNot Nothing AndAlso txtPassword IsNot Nothing) Then
            Dim Read As System.IO.StreamReader
            Read = My.Computer.FileSystem.OpenTextFileReader("User.txt")

            Do Until Read.EndOfStream
                str = Read.ReadLine
                strArr = str.Split("-")
                If (strArr(0) = txtEmail.Text And strArr(1) = txtPassword.Text) Then
                    Return True
                Else
                    MessageBox.Show("Invalid username or password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return False
                End If
            Loop
        Else
            MessageBox.Show("Please fill up all the required form", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Function
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