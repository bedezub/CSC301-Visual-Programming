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
        Me.chkLubeJob = New System.Windows.Forms.CheckBox()
        Me.chkOilChange = New System.Windows.Forms.CheckBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chkTransmission = New System.Windows.Forms.CheckBox()
        Me.chkRadiator = New System.Windows.Forms.CheckBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.chkTireRotation = New System.Windows.Forms.CheckBox()
        Me.chkMuffler = New System.Windows.Forms.CheckBox()
        Me.chkInspection = New System.Windows.Forms.CheckBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtLabor = New System.Windows.Forms.TextBox()
        Me.txtPart = New System.Windows.Forms.TextBox()
        Me.Summary = New System.Windows.Forms.GroupBox()
        Me.txtTotalPrice = New System.Windows.Forms.TextBox()
        Me.txtTaxPrice = New System.Windows.Forms.TextBox()
        Me.txtPartPrice = New System.Windows.Forms.TextBox()
        Me.txtServicePrice = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCalcTotal = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
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
        Me.GroupBox1.Controls.Add(Me.chkLubeJob)
        Me.GroupBox1.Controls.Add(Me.chkOilChange)
        Me.GroupBox1.Location = New System.Drawing.Point(152, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(220, 199)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Oil And Lube"
        '
        'chkLubeJob
        '
        Me.chkLubeJob.AutoSize = True
        Me.chkLubeJob.Location = New System.Drawing.Point(32, 91)
        Me.chkLubeJob.Name = "chkLubeJob"
        Me.chkLubeJob.Size = New System.Drawing.Size(111, 17)
        Me.chkLubeJob.TabIndex = 1
        Me.chkLubeJob.Text = "Lube Job - RM63 "
        Me.chkLubeJob.UseVisualStyleBackColor = True
        '
        'chkOilChange
        '
        Me.chkOilChange.AutoSize = True
        Me.chkOilChange.Location = New System.Drawing.Point(32, 55)
        Me.chkOilChange.Name = "chkOilChange"
        Me.chkOilChange.Size = New System.Drawing.Size(116, 17)
        Me.chkOilChange.TabIndex = 0
        Me.chkOilChange.Text = "Oil Change - RM91"
        Me.chkOilChange.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkTransmission)
        Me.GroupBox2.Controls.Add(Me.chkRadiator)
        Me.GroupBox2.Location = New System.Drawing.Point(416, 91)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(319, 199)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Flushes"
        '
        'chkTransmission
        '
        Me.chkTransmission.AutoSize = True
        Me.chkTransmission.Location = New System.Drawing.Point(30, 91)
        Me.chkTransmission.Name = "chkTransmission"
        Me.chkTransmission.Size = New System.Drawing.Size(159, 17)
        Me.chkTransmission.TabIndex = 3
        Me.chkTransmission.Text = "Transmission Flush - RM280"
        Me.chkTransmission.UseVisualStyleBackColor = True
        '
        'chkRadiator
        '
        Me.chkRadiator.AutoSize = True
        Me.chkRadiator.Location = New System.Drawing.Point(32, 55)
        Me.chkRadiator.Name = "chkRadiator"
        Me.chkRadiator.Size = New System.Drawing.Size(138, 17)
        Me.chkRadiator.TabIndex = 2
        Me.chkRadiator.Text = "Radiator Flush - RM105"
        Me.chkRadiator.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkTireRotation)
        Me.GroupBox3.Controls.Add(Me.chkMuffler)
        Me.GroupBox3.Controls.Add(Me.chkInspection)
        Me.GroupBox3.Location = New System.Drawing.Point(152, 316)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(220, 145)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Misc"
        '
        'chkTireRotation
        '
        Me.chkTireRotation.AutoSize = True
        Me.chkTireRotation.Location = New System.Drawing.Point(32, 94)
        Me.chkTireRotation.Name = "chkTireRotation"
        Me.chkTireRotation.Size = New System.Drawing.Size(125, 17)
        Me.chkTireRotation.TabIndex = 7
        Me.chkTireRotation.Text = "Tire Rotation - RM70"
        Me.chkTireRotation.UseVisualStyleBackColor = True
        '
        'chkMuffler
        '
        Me.chkMuffler.AutoSize = True
        Me.chkMuffler.Location = New System.Drawing.Point(32, 60)
        Me.chkMuffler.Name = "chkMuffler"
        Me.chkMuffler.Size = New System.Drawing.Size(163, 17)
        Me.chkMuffler.TabIndex = 5
        Me.chkMuffler.Text = "Muffler replacement - RM350"
        Me.chkMuffler.UseVisualStyleBackColor = True
        '
        'chkInspection
        '
        Me.chkInspection.AutoSize = True
        Me.chkInspection.Location = New System.Drawing.Point(32, 28)
        Me.chkInspection.Name = "chkInspection"
        Me.chkInspection.Size = New System.Drawing.Size(113, 17)
        Me.chkInspection.TabIndex = 6
        Me.chkInspection.Text = "Inspection - RM52"
        Me.chkInspection.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.txtLabor)
        Me.GroupBox4.Controls.Add(Me.txtPart)
        Me.GroupBox4.Location = New System.Drawing.Point(416, 316)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(319, 145)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Part And Labor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 41)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(26, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Part"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(34, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Labor"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(202, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "(RM70 per hour)"
        '
        'txtLabor
        '
        Me.txtLabor.Location = New System.Drawing.Point(96, 78)
        Me.txtLabor.Name = "txtLabor"
        Me.txtLabor.Size = New System.Drawing.Size(100, 20)
        Me.txtLabor.TabIndex = 1
        '
        'txtPart
        '
        Me.txtPart.Location = New System.Drawing.Point(96, 38)
        Me.txtPart.Name = "txtPart"
        Me.txtPart.Size = New System.Drawing.Size(100, 20)
        Me.txtPart.TabIndex = 0
        '
        'Summary
        '
        Me.Summary.Controls.Add(Me.txtTotalPrice)
        Me.Summary.Controls.Add(Me.txtTaxPrice)
        Me.Summary.Controls.Add(Me.txtPartPrice)
        Me.Summary.Controls.Add(Me.txtServicePrice)
        Me.Summary.Controls.Add(Me.Label7)
        Me.Summary.Controls.Add(Me.Label6)
        Me.Summary.Controls.Add(Me.Label5)
        Me.Summary.Controls.Add(Me.Label4)
        Me.Summary.Location = New System.Drawing.Point(786, 91)
        Me.Summary.Name = "Summary"
        Me.Summary.Size = New System.Drawing.Size(347, 199)
        Me.Summary.TabIndex = 4
        Me.Summary.TabStop = False
        Me.Summary.Text = "Summary"
        '
        'txtTotalPrice
        '
        Me.txtTotalPrice.Location = New System.Drawing.Point(144, 149)
        Me.txtTotalPrice.Name = "txtTotalPrice"
        Me.txtTotalPrice.Size = New System.Drawing.Size(158, 20)
        Me.txtTotalPrice.TabIndex = 12
        '
        'txtTaxPrice
        '
        Me.txtTaxPrice.Location = New System.Drawing.Point(144, 114)
        Me.txtTaxPrice.Name = "txtTaxPrice"
        Me.txtTaxPrice.Size = New System.Drawing.Size(158, 20)
        Me.txtTaxPrice.TabIndex = 11
        '
        'txtPartPrice
        '
        Me.txtPartPrice.Location = New System.Drawing.Point(144, 80)
        Me.txtPartPrice.Name = "txtPartPrice"
        Me.txtPartPrice.Size = New System.Drawing.Size(158, 20)
        Me.txtPartPrice.TabIndex = 10
        '
        'txtServicePrice
        '
        Me.txtServicePrice.BackColor = System.Drawing.SystemColors.Window
        Me.txtServicePrice.Location = New System.Drawing.Point(144, 43)
        Me.txtServicePrice.Name = "txtServicePrice"
        Me.txtServicePrice.Size = New System.Drawing.Size(158, 20)
        Me.txtServicePrice.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 149)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Total Fees"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 13)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Tax (on Parts)"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(93, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Part"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Services labor"
        '
        'btnCalcTotal
        '
        Me.btnCalcTotal.Location = New System.Drawing.Point(786, 421)
        Me.btnCalcTotal.Name = "btnCalcTotal"
        Me.btnCalcTotal.Size = New System.Drawing.Size(103, 40)
        Me.btnCalcTotal.TabIndex = 5
        Me.btnCalcTotal.Text = "Calculate Total"
        Me.btnCalcTotal.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(915, 421)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(90, 40)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(1041, 421)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(92, 40)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
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
        Me.RedToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.RedToolStripMenuItem.Text = "Red"
        '
        'BlueToolStripMenuItem
        '
        Me.BlueToolStripMenuItem.Name = "BlueToolStripMenuItem"
        Me.BlueToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.BlueToolStripMenuItem.Text = "Blue"
        '
        'WhiteToolStripMenuItem
        '
        Me.WhiteToolStripMenuItem.Name = "WhiteToolStripMenuItem"
        Me.WhiteToolStripMenuItem.Size = New System.Drawing.Size(105, 22)
        Me.WhiteToolStripMenuItem.Text = "White"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalcTotal)
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
    Friend WithEvents chkOilChange As CheckBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Summary As GroupBox
    Friend WithEvents btnCalcTotal As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkLubeJob As CheckBox
    Friend WithEvents chkTransmission As CheckBox
    Friend WithEvents chkRadiator As CheckBox
    Friend WithEvents chkTireRotation As CheckBox
    Friend WithEvents chkMuffler As CheckBox
    Friend WithEvents chkInspection As CheckBox
    Friend WithEvents txtLabor As TextBox
    Friend WithEvents txtPart As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtTotalPrice As TextBox
    Friend WithEvents txtTaxPrice As TextBox
    Friend WithEvents txtPartPrice As TextBox
    Friend WithEvents txtServicePrice As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents RedToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BlueToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WhiteToolStripMenuItem As ToolStripMenuItem
End Class
