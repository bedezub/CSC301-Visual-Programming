'written by bedezub

Public Class Form1

    Dim count As Integer = 0
    Dim product(3) As Products

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        txt_prodName.Text = "Product Name"
        txt_prodPrice.Text = "Product Price"
        txt_prodPercent.Text = "Discount Percent"

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_goSubmit.Click
        product(0) = New Products
        product(1) = New Products
        product(2) = New Products

        product(count).setData(
            prodName:=String.Format(txt_prodName.Text),
            prodPrice:=Double.Parse(txt_prodPrice.Text),
            prodPercent:=Long.Parse(txt_prodPercent.Text)
            )
        If Double.Parse(txt_prodPercent.Text) > 0 Then
            If count = 1 Then
                txt_ptName.Text = product(1).getName
                txt_ptPrice.Text = product(1).getPrice
                txt_ptPercent.Text = product(1).getPercent
                txt_ptPriceAD.Text = product(1).calcDiscount
            ElseIf count = 2 Then
                txt_p3name.Text = product(2).getName
                txt_p3price.Text = product(2).getPrice
                txt_p3Percent.Text = product(2).getPercent
                txt_p3PriceAD.Text = product(2).calcDiscount
            Else
                txt_poName.Text = product(0).getName
                txt_poPrice.Text = product(0).getPrice
                txt_poPercent.Text = product(0).getPercent
                txt_poPriceAD.Text = product(0).calcDiscount
            End If
        Else
            MessageBox.Show("Please enter valid percentage", "Percentage Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        txt_prodName.Text = "Product Name"
        txt_prodPrice.Text = "Product Price"
        txt_prodPercent.Text = "Discount Percent"

        count += 1
        landingPage.Visible = True
        addProduct.Visible = False
        viewProduct.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_addProduct.Click
        landingPage.Visible = False
        addProduct.Visible = True
        viewProduct.Visible = False
    End Sub

    Private Sub btn_viewProduct_Click(sender As Object, e As EventArgs) Handles btn_viewProduct.Click
        landingPage.Visible = False
        addProduct.Visible = False
        viewProduct.Visible = True
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btn_goHome.Click
        landingPage.Visible = True
        addProduct.Visible = False
        viewProduct.Visible = False
    End Sub
    Private Sub prod_name_GotFocus(sender As Object, e As EventArgs) Handles txt_prodName.GotFocus
        sender.BackColor = Color.Gray
    End Sub

    Private Sub prod_name_LostFocus(sender As Object, e As EventArgs) Handles txt_prodName.LostFocus
        sender.BackColor = Color.White
    End Sub

End Class


Public Class Products

    Dim name As String
    Dim price As Double
    Dim percent As Long
    Dim priceDiscount As Double
    Public Sub New()
        name = ""
        price = 0.0
        percent = 0.0
    End Sub

    Public Sub setData(prodName As String, prodPrice As Double, prodPercent As Long)
        name = prodName
        price = prodPrice
        percent = prodPercent
    End Sub

    Public Function calcDiscount() As Double
        Return price - ((price * percent) / 100)
    End Function

    Public Function getName() As String
        Return name
    End Function

    Public Function getPrice() As Double
        Return price
    End Function

    Public Function getPercent() As Long
        Return percent
    End Function
End Class
