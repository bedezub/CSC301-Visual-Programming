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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lube_job = New System.Windows.Forms.CheckBox()
        Me.oil_change = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.transmission = New System.Windows.Forms.CheckBox()
        Me.radiator = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.tire_rotation = New System.Windows.Forms.CheckBox()
        Me.muffler = New System.Windows.Forms.CheckBox()
        Me.inspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.labor = New System.Windows.Forms.TextBox()
        Me.part = New System.Windows.Forms.TextBox()
        Me.Summary = New System.Windows.Forms.GroupBox()
        Me.total_fees = New System.Windows.Forms.TextBox()
        Me.tax_price = New System.Windows.Forms.TextBox()
        Me.part_price = New System.Windows.Forms.TextBox()
        Me.service_price = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.RedToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BlueToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WhiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Summary.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lube_job)
        Me.GroupBox1.Controls.Add(Me.oil_change)
        Me.GroupBox1.Location = New System.Drawing.Point(58, 45)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 100)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil And Lube"
        '
        'lube_job
        '
        Me.lube_job.AutoSize = True
        Me.lube_job.Location = New System.Drawing.Point(34, 59)
        Me.lube_job.Name = "lube_job"
        Me.lube_job.Size = New System.Drawing.Size(111, 17)
        Me.lube_job.TabIndex = 1
        Me.lube_job.Text = "Lube Job - RM63 "
        Me.lube_job.UseVisualStyleBackColor = True
        '
        'oil_change
        '
        Me.oil_change.AutoSize = True
        Me.oil_change.Location = New System.Drawing.Point(34, 32)
        Me.oil_change.Name = "oil_change"
        Me.oil_change.Size = New System.Drawing.Size(116, 17)
        Me.oil_change.TabIndex = 0
        Me.oil_change.Text = "Oil Change - RM91"
        Me.oil_change.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.transmission)
        Me.GroupBox2.Controls.Add(Me.radiator)
        Me.GroupBox2.Location = New System.Drawing.Point(335, 45)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 100)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'transmission
        '
        Me.transmission.AutoSize = True
        Me.transmission.Location = New System.Drawing.Point(32, 59)
        Me.transmission.Name = "transmission"
        Me.transmission.Size = New System.Drawing.Size(159, 17)
        Me.transmission.TabIndex = 3
        Me.transmission.Text = "Transmission Flush - RM280"
        Me.transmission.UseVisualStyleBackColor = True
        '
        'radiator
        '
        Me.radiator.AutoSize = True
        Me.radiator.Location = New System.Drawing.Point(32, 32)
        Me.radiator.Name = "radiator"
        Me.radiator.Size = New System.Drawing.Size(138, 17)
        Me.radiator.TabIndex = 2
        Me.radiator.Text = "Radiator Flush - RM105"
        Me.radiator.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tire_rotation)
        Me.GroupBox3.Controls.Add(Me.muffler)
        Me.GroupBox3.Controls.Add(Me.inspection)
        Me.GroupBox3.Location = New System.Drawing.Point(58, 167)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 109)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'tire_rotation
        '
        Me.tire_rotation.AutoSize = True
        Me.tire_rotation.Location = New System.Drawing.Point(32, 77)
        Me.tire_rotation.Name = "tire_rotation"
        Me.tire_rotation.Size = New System.Drawing.Size(125, 17)
        Me.tire_rotation.TabIndex = 7
        Me.tire_rotation.Text = "Tire Rotation - RM70"
        Me.tire_rotation.UseVisualStyleBackColor = True
        '
        'muffler
        '
        Me.muffler.AutoSize = True
        Me.muffler.Location = New System.Drawing.Point(32, 53)
        Me.muffler.Name = "muffler"
        Me.muffler.Size = New System.Drawing.Size(163, 17)
        Me.muffler.TabIndex = 5
        Me.muffler.Text = "Muffler replacement - RM350"
        Me.muffler.UseVisualStyleBackColor = True
        '
        'inspection
        '
        Me.inspection.AutoSize = True
        Me.inspection.Location = New System.Drawing.Point(32, 28)
        Me.inspection.Name = "inspection"
        Me.inspection.Size = New System.Drawing.Size(113, 17)
        Me.inspection.TabIndex = 6
        Me.inspection.Text = "Inspection - RM52"
        Me.inspection.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.labor)
        Me.GroupBox4.Controls.Add(Me.part)
        Me.GroupBox4.Location = New System.Drawing.Point(335, 176)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(319, 100)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Part And Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(29, 31)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Part"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(204, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(RM70 per hour)"
        '
        'labor
        '
        Me.labor.Location = New System.Drawing.Point(98, 54)
        Me.labor.Name = "labor"
        Me.labor.Size = New System.Drawing.Size(100, 20)
        Me.labor.TabIndex = 1
        '
        'part
        '
        Me.part.Location = New System.Drawing.Point(98, 28)
        Me.part.Name = "part"
        Me.part.Size = New System.Drawing.Size(100, 20)
        Me.part.TabIndex = 0
        '
        'Summary
        '
        Me.Summary.Controls.Add(Me.total_fees)
        Me.Summary.Controls.Add(Me.tax_price)
        Me.Summary.Controls.Add(Me.part_price)
        Me.Summary.Controls.Add(Me.service_price)
        Me.Summary.Controls.Add(Me.Label7)
        Me.Summary.Controls.Add(Me.Label6)
        Me.Summary.Controls.Add(Me.Label5)
        Me.Summary.Controls.Add(Me.Label4)
        Me.Summary.Location = New System.Drawing.Point(58, 294)
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(596, 199)
        Me.Summary.TabIndex = 4
        Me.Summary.TabStop = False
        Me.Summary.Text = "Summary"
        '
        'total_fees
        '
        Me.total_fees.Location = New System.Drawing.Point(277, 151)
        Me.total_fees.Name = "total_fees"
        Me.total_fees.Size = New System.Drawing.Size(158, 20)
        Me.total_fees.TabIndex = 12
        '
        'tax_price
        '
        Me.tax_price.Location = New System.Drawing.Point(277, 116)
        Me.tax_price.Name = "tax_price"
        Me.tax_price.Size = New System.Drawing.Size(158, 20)
        Me.tax_price.TabIndex = 11
        '
        'part_price
        '
        Me.part_price.Location = New System.Drawing.Point(277, 82)
        Me.part_price.Name = "part_price"
        Me.part_price.Size = New System.Drawing.Size(158, 20)
        Me.part_price.TabIndex = 10
        '
        'service_price
        '
        Me.service_price.BackColor = System.Drawing.SystemColors.Window
        Me.service_price.Location = New System.Drawing.Point(277, 45)
        Me.service_price.Name = "service_price"
        Me.service_price.Size = New System.Drawing.Size(158, 20)
        Me.service_price.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(196, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Fees"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(179, 116)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tax (on Parts)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(226, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Part"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(179, 48)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Services labor"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(209, 524)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calculate Total"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(344, 524)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(451, 524)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 7
        Me.Button3.Text = "Exit"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(721, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RedToolStripMenuItem, Me.BlueToolStripMenuItem, Me.WhiteToolStripMenuItem})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(48, 20)
        Me.ToolStripMenuItem1.Text = "Color"
        '
        'RedToolStripMenuItem
        '
        Me.RedToolStripMenuItem.Name = "RedToolStripMenuItem"
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(721, 581)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Summary)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Azwan's Automotive"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Summary.ResumeLayout(False)
        Me.Summary.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents oil_change As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Summary As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents lube_job As CheckBox
    Friend WithEvents transmission As CheckBox
    Friend WithEvents radiator As CheckBox
    Friend WithEvents tire_rotation As CheckBox
    Friend WithEvents muffler As CheckBox
    Friend WithEvents inspection As CheckBox
    Friend WithEvents labor As TextBox
    Friend WithEvents part As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents total_fees As TextBox
    Friend WithEvents tax_price As TextBox
    Friend WithEvents part_price As TextBox
    Friend WithEvents service_price As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
End Class
