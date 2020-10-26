Imports System.Runtime.CompilerServices

Public Class Form1

    Dim count As Integer = 0
    Dim product(3) As Products

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub FlowLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub addProduct_Paint(sender As Object, e As PaintEventArgs) Handles addProduct.Paint

    End Sub
    Private Sub viewProduct_Paint(sender As Object, e As PaintEventArgs) Handles viewProduct.Paint

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_goSubmit.Click
        product(0) = New Products
        product(1) = New Products
        product(2) = New Products

        product(count).setData(
            prodName:=String.Format(prod_name.Text),
            prodPrice:=Double.Parse(prod_price.Text),
            prodPercent:=Long.Parse(prod_percent.Text)
            )

        If count = 1 Then
            prodTwo_name.Text = product(1).getName
            prodTwo_price.Text = product(1).getPrice
            prodTwo_percent.Text = product(1).getPercent
            prodTwo_priceAD.Text = product(1).calcDiscount
        ElseIf count = 2 Then
            prodThree_name.Text = product(2).getName
            prodThree_price.Text = product(2).getPrice
            prodThree_percent.Text = product(2).getPercent
            prodThree_priceAD.Text = product(2).calcDiscount
        Else
            prodOne_name.Text = product(0).getName
            prodOne_price.Text = product(0).getPrice
            prodOne_percent.Text = product(0).getPercent
            prodOne_priceAD.Text = product(0).calcDiscount
        End If

        prod_name.Text = ""
        prod_price.Text = ""
        prod_percent.Text = ""

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
    Private Sub prod_name_TextChanged(sender As Object, e As EventArgs) Handles prod_name.TextChanged

    End Sub

    Private Sub prod_price_TextChanged(sender As Object, e As EventArgs) Handles prod_price.TextChanged

    End Sub

    Private Sub prod_percent_TextChanged(sender As Object, e As EventArgs) Handles prod_percent.TextChanged

    End Sub

    Private Sub landingPage_Paint(sender As Object, e As PaintEventArgs) Handles landingPage.Paint

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
