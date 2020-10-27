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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Gender = New System.Windows.Forms.GroupBox()
        Me.male = New System.Windows.Forms.RadioButton()
        Me.female = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.reading = New System.Windows.Forms.CheckBox()
        Me.singing = New System.Windows.Forms.CheckBox()
        Me.sleeping = New System.Windows.Forms.CheckBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Gender.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Coral
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.Gender)
        Me.Panel1.Location = New System.Drawing.Point(3, 1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 446)
        Me.Panel1.TabIndex = 0
        '
        'Gender
        '
        Me.Gender.Controls.Add(Me.female)
        Me.Gender.Controls.Add(Me.male)
        Me.Gender.Location = New System.Drawing.Point(172, 54)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(173, 161)
        Me.Gender.TabIndex = 1
        Me.Gender.TabStop = False
        Me.Gender.Text = "Gender"
        '
        'male
        '
        Me.male.AutoSize = True
        Me.male.Location = New System.Drawing.Point(26, 37)
        Me.male.Name = "male"
        Me.male.Size = New System.Drawing.Size(48, 17)
        Me.male.TabIndex = 0
        Me.male.TabStop = True
        Me.male.Text = "Male"
        Me.male.UseVisualStyleBackColor = True
        '
        'female
        '
        Me.female.AutoSize = True
        Me.female.Location = New System.Drawing.Point(26, 78)
        Me.female.Name = "female"
        Me.female.Size = New System.Drawing.Size(59, 17)
        Me.female.TabIndex = 1
        Me.female.TabStop = True
        Me.female.Text = "Female"
        Me.female.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sleeping)
        Me.GroupBox1.Controls.Add(Me.singing)
        Me.GroupBox1.Controls.Add(Me.reading)
        Me.GroupBox1.Location = New System.Drawing.Point(443, 54)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(173, 161)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Hobbies"
        '
        'reading
        '
        Me.reading.AutoSize = True
        Me.reading.Location = New System.Drawing.Point(27, 38)
        Me.reading.Name = "reading"
        Me.reading.Size = New System.Drawing.Size(66, 17)
        Me.reading.TabIndex = 0
        Me.reading.Text = "Reading"
        Me.reading.UseVisualStyleBackColor = True
        '
        'singing
        '
        Me.singing.AutoSize = True
        Me.singing.Location = New System.Drawing.Point(27, 79)
        Me.singing.Name = "singing"
        Me.singing.Size = New System.Drawing.Size(61, 17)
        Me.singing.TabIndex = 1
        Me.singing.Text = "Singing"
        Me.singing.UseVisualStyleBackColor = True
        '
        'sleeping
        '
        Me.sleeping.AutoSize = True
        Me.sleeping.Location = New System.Drawing.Point(27, 122)
        Me.sleeping.Name = "sleeping"
        Me.sleeping.Size = New System.Drawing.Size(67, 17)
        Me.sleeping.TabIndex = 2
        Me.sleeping.Text = "Sleeping"
        Me.sleeping.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(358, 348)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Gender.ResumeLayout(False)
        Me.Gender.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Gender As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents sleeping As CheckBox
    Friend WithEvents singing As CheckBox
    Friend WithEvents reading As CheckBox
    Friend WithEvents female As RadioButton
    Friend WithEvents male As RadioButton
End Class
