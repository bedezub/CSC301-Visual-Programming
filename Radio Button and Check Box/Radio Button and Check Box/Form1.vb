Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Kita ada dua: Radiobutton, Checkbox
        'RadioButton saya assign (name) sebagai male dan female 
        'Untuk check user click yang mana, kita akan guna if statement
        'Dan value dia akan disimpan dalam either male.Checked atau female.Checked
        'Untuk CheckBox pun sama :) value dia akan disimpan dalam blabla.Checked

        'RadioButton saya recommend guna If ElseIF
        'CheckBox kita guna multiple IF sebab user boleh pilih more than 1

        If male.Checked Then
            MessageBox.Show("Salam brader")
        ElseIf female.Checked Then
            MessageBox.Show("Hyeee cik adik")
        End If

        If reading.Checked Then
            MessageBox.Show("Woww suka membaca!!")
        End If

        If singing.Checked Then
            MessageBox.Show("Jom karokkk!!")
        End If

        If sleeping.Checked Then
            MessageBox.Show("Halo halo dah bangun ke tu")
        End If
    End Sub
End Class
