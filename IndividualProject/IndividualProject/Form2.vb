Public Class Form2
    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click

        pnlRegister.Visible = True
        pnlSuccessful.Visible = False

        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        Dim campus As String
        Dim type As String
        Dim file As System.IO.StreamWriter

        If (validateForm()) Then
            If (optAlorGajah.Checked = True) Then
                campus = "Alor Gajah"
            ElseIf (optJasin.Checked = True) Then
                campus = "Jasin"
            ElseIf (optBandar.Checked = True) Then
                campus = "Bandar"
            End If

            If (chkCandidate.Checked = True) Then
                type = "Candidate"
            Else
                type = "Voter"
            End If

            file = My.Computer.FileSystem.OpenTextFileWriter("User.txt", True)
            file.WriteLine(txtEmail.Text + "-" + txtPassword.Text + "-" + txtStudID.Text + "-" + campus + "-" + type)
            file.Close()

            pnlRegister.Visible = False
            pnlSuccessful.Visible = True
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlRegister.Visible = True
        pnlSuccessful.Visible = False
    End Sub

    Private Function validateForm()
        If (
            txtEmail.Text IsNot Nothing AndAlso
            txtPassword.Text IsNot Nothing AndAlso
            txtStudID.Text IsNot Nothing AndAlso
            (chkCandidate.Checked = True Or
            chkVoter.Checked = True) AndAlso
            (optAlorGajah.Checked = True Or
            optBandar.Checked = True Or
            optJasin.Checked = True)
            ) Then
            Return True
        Else
            MessageBox.Show("Please fill up all the required form", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs)
        ColorDialog1.ShowDialog()
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FontDialog1.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        MessageBox.Show("Voting registration system. The future is in your hand!", "About System", MessageBoxButtons.OK)
    End Sub
End Class