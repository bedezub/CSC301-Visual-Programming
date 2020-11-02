<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.landingPage = New System.Windows.Forms.Panel()
        Me.btn_viewProduct = New System.Windows.Forms.Button()
        Me.btn_addProduct = New System.Windows.Forms.Button()
        Me.addProduct = New System.Windows.Forms.Panel()
        Me.btn_goSubmit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.prod_percent = New System.Windows.Forms.TextBox()
        Me.prod_price = New System.Windows.Forms.TextBox()
        Me.prod_name = New System.Windows.Forms.TextBox()
        Me.viewProduct = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prodThree_priceAD = New System.Windows.Forms.TextBox()
        Me.prodThree_percent = New System.Windows.Forms.TextBox()
        Me.prodThree_price = New System.Windows.Forms.TextBox()
        Me.prodThree_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.prodTwo_priceAD = New System.Windows.Forms.TextBox()
        Me.prodTwo_percent = New System.Windows.Forms.TextBox()
        Me.prodTwo_price = New System.Windows.Forms.TextBox()
        Me.prodTwo_name = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.prodOne_priceAD = New System.Windows.Forms.TextBox()
        Me.prodOne_percent = New System.Windows.Forms.TextBox()
        Me.prodOne_price = New System.Windows.Forms.TextBox()
        Me.prodOne_name = New System.Windows.Forms.TextBox()
        Me.btn_goHome = New System.Windows.Forms.Button()
        Me.landingPage.SuspendLayout()
        Me.addProduct.SuspendLayout()
        Me.viewProduct.SuspendLayout()
        Me.SuspendLayout()
        '
        'landingPage
        '
        Me.landingPage.BackColor = System.Drawing.Color.Wheat
        Me.landingPage.Controls.Add(Me.btn_viewProduct)
        Me.landingPage.Controls.Add(Me.btn_addProduct)
        Me.landingPage.Location = New System.Drawing.Point(-2, -2)
        Me.landingPage.Name = "landingPage"
        Me.landingPage.Size = New System.Drawing.Size(788, 567)
        Me.landingPage.TabIndex = 0
        '
        'btn_viewProduct
        '
        Me.btn_viewProduct.Location = New System.Drawing.Point(299, 309)
        Me.btn_viewProduct.Name = "btn_viewProduct"
        Me.btn_viewProduct.Size = New System.Drawing.Size(157, 60)
        Me.btn_viewProduct.TabIndex = 1
        Me.btn_viewProduct.Text = "View Product"
        Me.btn_viewProduct.UseVisualStyleBackColor = True
        '
        'btn_addProduct
        '
        Me.btn_addProduct.Location = New System.Drawing.Point(299, 171)
        Me.btn_addProduct.Name = "btn_addProduct"
        Me.btn_addProduct.Size = New System.Drawing.Size(157, 60)
        Me.btn_addProduct.TabIndex = 0
        Me.btn_addProduct.Text = "Add Product"
        Me.btn_addProduct.UseVisualStyleBackColor = True
        '
        'addProduct
        '
        Me.addProduct.BackColor = System.Drawing.Color.PaleGreen
        Me.addProduct.Controls.Add(Me.btn_goSubmit)
        Me.addProduct.Controls.Add(Me.Label3)
        Me.addProduct.Controls.Add(Me.Label2)
        Me.addProduct.Controls.Add(Me.Label1)
        Me.addProduct.Controls.Add(Me.prod_percent)
        Me.addProduct.Controls.Add(Me.prod_price)
        Me.addProduct.Controls.Add(Me.prod_name)
        Me.addProduct.Location = New System.Drawing.Point(0, 0)
        Me.addProduct.Name = "addProduct"
        Me.addProduct.Size = New System.Drawing.Size(788, 567)
        Me.addProduct.TabIndex = 2
        '
        'btn_goSubmit
        '
        Me.btn_goSubmit.Location = New System.Drawing.Point(314, 354)
        Me.btn_goSubmit.Name = "btn_goSubmit"
        Me.btn_goSubmit.Size = New System.Drawing.Size(119, 42)
        Me.btn_goSubmit.TabIndex = 6
        Me.btn_goSubmit.Text = "Submit"
        Me.btn_goSubmit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(248, 232)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Discount Percent"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(244, 169)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Product Price"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(244, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Product Name"
        '
        'prod_percent
        '
        Me.prod_percent.Location = New System.Drawing.Point(247, 259)
        Me.prod_percent.Name = "prod_percent"
        Me.prod_percent.Size = New System.Drawing.Size(251, 20)
        Me.prod_percent.TabIndex = 2
        '
        'prod_price
        '
        Me.prod_price.Location = New System.Drawing.Point(247, 190)
        Me.prod_price.Name = "prod_price"
        Me.prod_price.Size = New System.Drawing.Size(251, 20)
        Me.prod_price.TabIndex = 1
        '
        'prod_name
        '
        Me.prod_name.ForeColor = System.Drawing.Color.Black
        Me.prod_name.Location = New System.Drawing.Point(247, 114)
        Me.prod_name.Name = "prod_name"
        Me.prod_name.Size = New System.Drawing.Size(251, 20)
        Me.prod_name.TabIndex = 0
        '
        'viewProduct
        '
        Me.viewProduct.BackColor = System.Drawing.Color.SkyBlue
        Me.viewProduct.Controls.Add(Me.Label6)
        Me.viewProduct.Controls.Add(Me.prodThree_priceAD)
        Me.viewProduct.Controls.Add(Me.prodThree_percent)
        Me.viewProduct.Controls.Add(Me.prodThree_price)
        Me.viewProduct.Controls.Add(Me.prodThree_name)
        Me.viewProduct.Controls.Add(Me.Label5)
        Me.viewProduct.Controls.Add(Me.prodTwo_priceAD)
        Me.viewProduct.Controls.Add(Me.prodTwo_percent)
        Me.viewProduct.Controls.Add(Me.prodTwo_price)
        Me.viewProduct.Controls.Add(Me.prodTwo_name)
        Me.viewProduct.Controls.Add(Me.Label4)
        Me.viewProduct.Controls.Add(Me.prodOne_priceAD)
        Me.viewProduct.Controls.Add(Me.prodOne_percent)
        Me.viewProduct.Controls.Add(Me.prodOne_price)
        Me.viewProduct.Controls.Add(Me.prodOne_name)
        Me.viewProduct.Controls.Add(Me.btn_goHome)
        Me.viewProduct.Location = New System.Drawing.Point(0, 0)
        Me.viewProduct.Name = "viewProduct"
        Me.viewProduct.Size = New System.Drawing.Size(787, 569)
        Me.viewProduct.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(605, 48)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Product 3"
        '
        'prodThree_priceAD
        '
        Me.prodThree_priceAD.Location = New System.Drawing.Point(543, 282)
        Me.prodThree_priceAD.Name = "prodThree_priceAD"
        Me.prodThree_priceAD.Size = New System.Drawing.Size(193, 20)
        Me.prodThree_priceAD.TabIndex = 14
        '
        'prodThree_percent
        '
        Me.prodThree_percent.Location = New System.Drawing.Point(543, 229)
        Me.prodThree_percent.Name = "prodThree_percent"
        Me.prodThree_percent.Size = New System.Drawing.Size(193, 20)
        Me.prodThree_percent.TabIndex = 13
        '
        'prodThree_price
        '
        Me.prodThree_price.Location = New System.Drawing.Point(543, 162)
        Me.prodThree_price.Name = "prodThree_price"
        Me.prodThree_price.Size = New System.Drawing.Size(193, 20)
        Me.prodThree_price.TabIndex = 12
        '
        'prodThree_name
        '
        Me.prodThree_name.Location = New System.Drawing.Point(543, 104)
        Me.prodThree_name.Name = "prodThree_name"
        Me.prodThree_name.Size = New System.Drawing.Size(193, 20)
        Me.prodThree_name.TabIndex = 11
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(359, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Product 2"
        '
        'prodTwo_priceAD
        '
        Me.prodTwo_priceAD.Location = New System.Drawing.Point(297, 282)
        Me.prodTwo_priceAD.Name = "prodTwo_priceAD"
        Me.prodTwo_priceAD.Size = New System.Drawing.Size(193, 20)
        Me.prodTwo_priceAD.TabIndex = 9
        '
        'prodTwo_percent
        '
        Me.prodTwo_percent.Location = New System.Drawing.Point(297, 229)
        Me.prodTwo_percent.Name = "prodTwo_percent"
        Me.prodTwo_percent.Size = New System.Drawing.Size(193, 20)
        Me.prodTwo_percent.TabIndex = 8
        '
        'prodTwo_price
        '
        Me.prodTwo_price.Location = New System.Drawing.Point(297, 162)
        Me.prodTwo_price.Name = "prodTwo_price"
        Me.prodTwo_price.Size = New System.Drawing.Size(193, 20)
        Me.prodTwo_price.TabIndex = 7
        '
        'prodTwo_name
        '
        Me.prodTwo_name.Location = New System.Drawing.Point(297, 104)
        Me.prodTwo_name.Name = "prodTwo_name"
        Me.prodTwo_name.Size = New System.Drawing.Size(193, 20)
        Me.prodTwo_name.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(110, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Product 1"
        '
        'prodOne_priceAD
        '
        Me.prodOne_priceAD.Location = New System.Drawing.Point(48, 282)
        Me.prodOne_priceAD.Name = "prodOne_priceAD"
        Me.prodOne_priceAD.Size = New System.Drawing.Size(193, 20)
        Me.prodOne_priceAD.TabIndex = 4
        '
        'prodOne_percent
        '
        Me.prodOne_percent.Location = New System.Drawing.Point(48, 229)
        Me.prodOne_percent.Name = "prodOne_percent"
        Me.prodOne_percent.Size = New System.Drawing.Size(193, 20)
        Me.prodOne_percent.TabIndex = 3
        '
        'prodOne_price
        '
        Me.prodOne_price.Location = New System.Drawing.Point(48, 162)
        Me.prodOne_price.Name = "prodOne_price"
        Me.prodOne_price.Size = New System.Drawing.Size(193, 20)
        Me.prodOne_price.TabIndex = 2
        '
        'prodOne_name
        '
        Me.prodOne_name.Location = New System.Drawing.Point(48, 104)
        Me.prodOne_name.Name = "prodOne_name"
        Me.prodOne_name.Size = New System.Drawing.Size(193, 20)
        Me.prodOne_name.TabIndex = 1
        '
        'btn_goHome
        '
        Me.btn_goHome.Location = New System.Drawing.Point(348, 457)
        Me.btn_goHome.Name = "btn_goHome"
        Me.btn_goHome.Size = New System.Drawing.Size(75, 23)
        Me.btn_goHome.TabIndex = 0
        Me.btn_goHome.Text = "Back"
        Me.btn_goHome.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.addProduct)
        Me.Controls.Add(Me.landingPage)
        Me.Controls.Add(Me.viewProduct)
        Me.Name = "Form1"
        Me.Text = "Product Calculator"
        Me.landingPage.ResumeLayout(False)
        Me.addProduct.ResumeLayout(False)
        Me.addProduct.PerformLayout()
        Me.viewProduct.ResumeLayout(False)
        Me.viewProduct.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents landingPage As Panel
    Friend WithEvents btn_viewProduct As Button
    Friend WithEvents btn_addProduct As Button
    Friend WithEvents addProduct As Panel
    Friend WithEvents prod_name As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents prod_percent As TextBox
    Friend WithEvents prod_price As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btn_goSubmit As Button
    Friend WithEvents viewProduct As Panel
    Friend WithEvents btn_goHome As Button
    Friend WithEvents prodOne_name As TextBox
    Friend WithEvents prodOne_percent As TextBox
    Friend WithEvents prodOne_price As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents prodOne_priceAD As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents prodThree_priceAD As TextBox
    Friend WithEvents prodThree_percent As TextBox
    Friend WithEvents prodThree_price As TextBox
    Friend WithEvents prodThree_name As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents prodTwo_priceAD As TextBox
    Friend WithEvents prodTwo_percent As TextBox
    Friend WithEvents prodTwo_price As TextBox
    Friend WithEvents prodTwo_name As TextBox
End Class
