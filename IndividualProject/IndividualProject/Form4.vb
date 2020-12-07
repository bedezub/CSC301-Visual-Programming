Imports QRCoder

Public Class Form4
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim strArr() As String
        Dim str As String

        Dim Read As System.IO.StreamReader
        Read = My.Computer.FileSystem.OpenTextFileReader("User.txt")

        Do Until Read.EndOfStream
            str = Read.ReadLine
            strArr = str.Split("-")
            txtStudID.Text = strArr(2)
            txtEmail.Text = strArr(0)
            txtPassword.Text = strArr(1)
            txtCampus.Text = strArr(3)
        Loop

        Dim gen As New QRCodeGenerator
        Dim data = gen.CreateQrCode(txtEmail.Text, QRCodeGenerator.ECCLevel.Q)
        Dim code As New QRCode(data)
        picQR.Image = code.GetGraphic(6)
    End Sub
    Private Sub ColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        txtEmail.ForeColor = ColorDialog1.Color
        txtCampus.ForeColor = ColorDialog1.Color
        txtPassword.ForeColor = ColorDialog1.Color
        txtStudID.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub FontToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FontToolStripMenuItem.Click
        FontDialog1.ShowDialog()
        txtEmail.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)
        txtCampus.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)
        txtPassword.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)
        txtStudID.Font = New Font(FontDialog1.Font.Name, FontDialog1.Font.Size, FontDialog1.Font.Style)
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("Voting registration system. The future is in your hand!", "About System", MessageBoxButtons.OK)
    End Sub
End Class