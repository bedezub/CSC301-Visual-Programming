<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GenerateQRCodeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.grpCampus = New System.Windows.Forms.GroupBox()
        Me.optBandar = New System.Windows.Forms.RadioButton()
        Me.optJasin = New System.Windows.Forms.RadioButton()
        Me.optAlorGajah = New System.Windows.Forms.RadioButton()
        Me.grpType = New System.Windows.Forms.GroupBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.pnlSuccessful = New System.Windows.Forms.Panel()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.MenuStrip1.SuspendLayout()
        Me.grpCampus.SuspendLayout()
        Me.grpType.SuspendLayout()
        Me.pnlSuccessful.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.ProfileToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1265, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.W), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(138, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FontToolStripMenuItem, Me.ColorToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "&Edit"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.EditProfileToolStripMenuItem, Me.SaveProfileToolStripMenuItem, Me.GenerateQRCodeToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'EditProfileToolStripMenuItem
        '
        Me.EditProfileToolStripMenuItem.Name = "EditProfileToolStripMenuItem"
        Me.EditProfileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.EditProfileToolStripMenuItem.Text = "Edit Profile"
        '
        'SaveProfileToolStripMenuItem
        '
        Me.SaveProfileToolStripMenuItem.Name = "SaveProfileToolStripMenuItem"
        Me.SaveProfileToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.SaveProfileToolStripMenuItem.Text = "Save Profile"
        '
        'GenerateQRCodeToolStripMenuItem
        '
        Me.GenerateQRCodeToolStripMenuItem.Name = "GenerateQRCodeToolStripMenuItem"
        Me.GenerateQRCodeToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.GenerateQRCodeToolStripMenuItem.Text = "Generate QR Code"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(621, 164)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(508, 37)
        Me.txtEmail.TabIndex = 2
        '
        'txtStudID
        '
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(621, 320)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(508, 37)
        Me.txtStudID.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(621, 477)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Size = New System.Drawing.Size(508, 37)
        Me.txtPassword.TabIndex = 4
        '
        'grpCampus
        '
        Me.grpCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.grpCampus.Controls.Add(Me.optBandar)
        Me.grpCampus.Controls.Add(Me.optJasin)
        Me.grpCampus.Controls.Add(Me.optAlorGajah)
        Me.grpCampus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grpCampus.ForeColor = System.Drawing.Color.White
        Me.grpCampus.Location = New System.Drawing.Point(102, 204)
        Me.grpCampus.Name = "grpCampus"
        Me.grpCampus.Size = New System.Drawing.Size(241, 134)
        Me.grpCampus.TabIndex = 5
        Me.grpCampus.TabStop = False
        Me.grpCampus.Text = "Campus"
        '
        'optBandar
        '
        Me.optBandar.AutoSize = True
        Me.optBandar.Location = New System.Drawing.Point(26, 96)
        Me.optBandar.Name = "optBandar"
        Me.optBandar.Size = New System.Drawing.Size(138, 17)
        Me.optBandar.TabIndex = 2
        Me.optBandar.TabStop = True
        Me.optBandar.Text = "Kampus Bandar Melaka"
        Me.optBandar.UseVisualStyleBackColor = True
        '
        'optJasin
        '
        Me.optJasin.AutoSize = True
        Me.optJasin.Location = New System.Drawing.Point(26, 63)
        Me.optJasin.Name = "optJasin"
        Me.optJasin.Size = New System.Drawing.Size(90, 17)
        Me.optJasin.TabIndex = 1
        Me.optJasin.TabStop = True
        Me.optJasin.Text = "Kampus Jasin"
        Me.optJasin.UseVisualStyleBackColor = True
        '
        'optAlorGajah
        '
        Me.optAlorGajah.AutoSize = True
        Me.optAlorGajah.Location = New System.Drawing.Point(26, 31)
        Me.optAlorGajah.Name = "optAlorGajah"
        Me.optAlorGajah.Size = New System.Drawing.Size(115, 17)
        Me.optAlorGajah.TabIndex = 0
        Me.optAlorGajah.TabStop = True
        Me.optAlorGajah.Text = "Kampus Alor Gajah"
        Me.optAlorGajah.UseVisualStyleBackColor = True
        '
        'grpType
        '
        Me.grpType.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.grpType.Controls.Add(Me.CheckBox2)
        Me.grpType.Controls.Add(Me.CheckBox1)
        Me.grpType.ForeColor = System.Drawing.Color.White
        Me.grpType.Location = New System.Drawing.Point(102, 382)
        Me.grpType.Name = "grpType"
        Me.grpType.Size = New System.Drawing.Size(241, 132)
        Me.grpType.TabIndex = 6
        Me.grpType.TabStop = False
        Me.grpType.Text = "Type"
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(26, 80)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(51, 17)
        Me.CheckBox2.TabIndex = 1
        Me.CheckBox2.Text = "Voter"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(26, 44)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(74, 17)
        Me.CheckBox1.TabIndex = 0
        Me.CheckBox1.Text = "Candidate"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnSubmit.FlatAppearance.BorderSize = 0
        Me.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSubmit.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.ForeColor = System.Drawing.Color.White
        Me.btnSubmit.Location = New System.Drawing.Point(962, 569)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(149, 76)
        Me.btnSubmit.TabIndex = 7
        Me.btnSubmit.Text = "Submit"
        Me.btnSubmit.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(712, 569)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(146, 76)
        Me.btnReturn.TabIndex = 8
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'pnlSuccessful
        '
        Me.pnlSuccessful.BackgroundImage = Global.Lab_5.My.Resources.Resources.Registration_Sucessful
        Me.pnlSuccessful.Controls.Add(Me.btnReturn2)
        Me.pnlSuccessful.Location = New System.Drawing.Point(0, 0)
        Me.pnlSuccessful.Name = "pnlSuccessful"
        Me.pnlSuccessful.Size = New System.Drawing.Size(1265, 682)
        Me.pnlSuccessful.TabIndex = 9
        '
        'btnReturn2
        '
        Me.btnReturn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnReturn2.FlatAppearance.BorderSize = 0
        Me.btnReturn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn2.ForeColor = System.Drawing.Color.White
        Me.btnReturn2.Location = New System.Drawing.Point(569, 529)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(146, 76)
        Me.btnReturn2.TabIndex = 10
        Me.btnReturn2.Text = "Return"
        Me.btnReturn2.UseVisualStyleBackColor = False
        '
        'pnlRegister
        '
        Me.pnlRegister.BackgroundImage = Global.Lab_5.My.Resources.Resources.Register_Page1
        Me.pnlRegister.Controls.Add(Me.btnReturn)
        Me.pnlRegister.Controls.Add(Me.btnSubmit)
        Me.pnlRegister.Controls.Add(Me.txtPassword)
        Me.pnlRegister.Controls.Add(Me.txtStudID)
        Me.pnlRegister.Controls.Add(Me.txtEmail)
        Me.pnlRegister.Controls.Add(Me.MenuStrip1)
        Me.pnlRegister.Controls.Add(Me.grpCampus)
        Me.pnlRegister.Controls.Add(Me.grpType)
        Me.pnlRegister.Location = New System.Drawing.Point(0, 0)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(1265, 705)
        Me.pnlRegister.TabIndex = 11
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Lab_5.My.Resources.Resources.Register_Page1
        Me.ClientSize = New System.Drawing.Size(1264, 705)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlSuccessful)
        Me.Name = "Form2"
        Me.Text = "UiTM Voting System"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.grpCampus.ResumeLayout(False)
        Me.grpCampus.PerformLayout()
        Me.grpType.ResumeLayout(False)
        Me.grpType.PerformLayout()
        Me.pnlSuccessful.ResumeLayout(False)
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateQRCodeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents grpCampus As GroupBox
    Friend WithEvents optBandar As RadioButton
    Friend WithEvents optJasin As RadioButton
    Friend WithEvents optAlorGajah As RadioButton
    Friend WithEvents grpType As GroupBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents pnlSuccessful As Panel
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents pnlRegister As Panel
End Class
