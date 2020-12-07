<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.pnlSuccessful = New System.Windows.Forms.Panel()
        Me.btnReturn2 = New System.Windows.Forms.Button()
        Me.pnlRegister = New System.Windows.Forms.Panel()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.btnReturn = New System.Windows.Forms.Button()
        Me.btnRegister = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkVoter = New System.Windows.Forms.CheckBox()
        Me.chkCandidate = New System.Windows.Forms.CheckBox()
        Me.grpCampus = New System.Windows.Forms.GroupBox()
        Me.optBandar = New System.Windows.Forms.RadioButton()
        Me.optJasin = New System.Windows.Forms.RadioButton()
        Me.optAlorGajah = New System.Windows.Forms.RadioButton()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SignOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.pnlSuccessful.SuspendLayout()
        Me.pnlRegister.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.grpCampus.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlSuccessful
        '
        Me.pnlSuccessful.BackgroundImage = Global.IndividualProject.My.Resources.Resources.Registration_Sucessful
        Me.pnlSuccessful.Controls.Add(Me.btnReturn2)
        Me.pnlSuccessful.Location = New System.Drawing.Point(-9, 23)
        Me.pnlSuccessful.Name = "pnlSuccessful"
        Me.pnlSuccessful.Size = New System.Drawing.Size(1280, 720)
        Me.pnlSuccessful.TabIndex = 4
        '
        'btnReturn2
        '
        Me.btnReturn2.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnReturn2.FlatAppearance.BorderSize = 0
        Me.btnReturn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn2.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn2.ForeColor = System.Drawing.Color.White
        Me.btnReturn2.Location = New System.Drawing.Point(561, 531)
        Me.btnReturn2.Name = "btnReturn2"
        Me.btnReturn2.Size = New System.Drawing.Size(159, 72)
        Me.btnReturn2.TabIndex = 4
        Me.btnReturn2.Text = "Return"
        Me.btnReturn2.UseVisualStyleBackColor = False
        '
        'pnlRegister
        '
        Me.pnlRegister.BackgroundImage = Global.IndividualProject.My.Resources.Resources.Register_Page
        Me.pnlRegister.Controls.Add(Me.MenuStrip1)
        Me.pnlRegister.Controls.Add(Me.txtPassword)
        Me.pnlRegister.Controls.Add(Me.txtStudID)
        Me.pnlRegister.Controls.Add(Me.txtEmail)
        Me.pnlRegister.Controls.Add(Me.btnReturn)
        Me.pnlRegister.Controls.Add(Me.btnRegister)
        Me.pnlRegister.Controls.Add(Me.GroupBox1)
        Me.pnlRegister.Controls.Add(Me.grpCampus)
        Me.pnlRegister.Location = New System.Drawing.Point(-8, -1)
        Me.pnlRegister.Name = "pnlRegister"
        Me.pnlRegister.Size = New System.Drawing.Size(1280, 738)
        Me.pnlRegister.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(624, 482)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(497, 31)
        Me.txtPassword.TabIndex = 6
        '
        'txtStudID
        '
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(624, 320)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(497, 31)
        Me.txtStudID.TabIndex = 5
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(624, 165)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(497, 31)
        Me.txtEmail.TabIndex = 4
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(708, 571)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(159, 72)
        Me.btnReturn.TabIndex = 3
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'btnRegister
        '
        Me.btnRegister.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnRegister.FlatAppearance.BorderSize = 0
        Me.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRegister.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRegister.ForeColor = System.Drawing.Color.Transparent
        Me.btnRegister.Location = New System.Drawing.Point(962, 571)
        Me.btnRegister.Name = "btnRegister"
        Me.btnRegister.Size = New System.Drawing.Size(159, 72)
        Me.btnRegister.TabIndex = 2
        Me.btnRegister.Text = "Submit"
        Me.btnRegister.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkVoter)
        Me.GroupBox1.Controls.Add(Me.chkCandidate)
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(102, 400)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(239, 130)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Type"
        '
        'chkVoter
        '
        Me.chkVoter.AutoSize = True
        Me.chkVoter.Location = New System.Drawing.Point(28, 82)
        Me.chkVoter.Name = "chkVoter"
        Me.chkVoter.Size = New System.Drawing.Size(51, 17)
        Me.chkVoter.TabIndex = 1
        Me.chkVoter.Text = "Voter"
        Me.chkVoter.UseVisualStyleBackColor = True
        '
        'chkCandidate
        '
        Me.chkCandidate.AutoSize = True
        Me.chkCandidate.Location = New System.Drawing.Point(28, 42)
        Me.chkCandidate.Name = "chkCandidate"
        Me.chkCandidate.Size = New System.Drawing.Size(74, 17)
        Me.chkCandidate.TabIndex = 0
        Me.chkCandidate.Text = "Candidate"
        Me.chkCandidate.UseVisualStyleBackColor = True
        '
        'grpCampus
        '
        Me.grpCampus.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.grpCampus.Controls.Add(Me.optBandar)
        Me.grpCampus.Controls.Add(Me.optJasin)
        Me.grpCampus.Controls.Add(Me.optAlorGajah)
        Me.grpCampus.ForeColor = System.Drawing.Color.White
        Me.grpCampus.Location = New System.Drawing.Point(102, 221)
        Me.grpCampus.Name = "grpCampus"
        Me.grpCampus.Size = New System.Drawing.Size(239, 130)
        Me.grpCampus.TabIndex = 0
        Me.grpCampus.TabStop = False
        Me.grpCampus.Text = "Campus"
        '
        'optBandar
        '
        Me.optBandar.AutoSize = True
        Me.optBandar.Location = New System.Drawing.Point(28, 64)
        Me.optBandar.Name = "optBandar"
        Me.optBandar.Size = New System.Drawing.Size(97, 17)
        Me.optBandar.TabIndex = 2
        Me.optBandar.TabStop = True
        Me.optBandar.Text = "Bandar Melaka"
        Me.optBandar.UseVisualStyleBackColor = True
        '
        'optJasin
        '
        Me.optJasin.AutoSize = True
        Me.optJasin.Location = New System.Drawing.Point(28, 94)
        Me.optJasin.Name = "optJasin"
        Me.optJasin.Size = New System.Drawing.Size(49, 17)
        Me.optJasin.TabIndex = 1
        Me.optJasin.TabStop = True
        Me.optJasin.Text = "Jasin"
        Me.optJasin.UseVisualStyleBackColor = True
        '
        'optAlorGajah
        '
        Me.optAlorGajah.AutoSize = True
        Me.optAlorGajah.Location = New System.Drawing.Point(28, 35)
        Me.optAlorGajah.Name = "optAlorGajah"
        Me.optAlorGajah.Size = New System.Drawing.Size(74, 17)
        Me.optAlorGajah.TabIndex = 0
        Me.optAlorGajah.TabStop = True
        Me.optAlorGajah.Text = "Alor Gajah"
        Me.optAlorGajah.UseVisualStyleBackColor = True
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1280, 24)
        Me.MenuStrip1.TabIndex = 7
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem, Me.ProfileToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "&File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ViewProfileToolStripMenuItem, Me.SignOutToolStripMenuItem})
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(134, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'ViewProfileToolStripMenuItem
        '
        Me.ViewProfileToolStripMenuItem.Name = "ViewProfileToolStripMenuItem"
        Me.ViewProfileToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.ViewProfileToolStripMenuItem.Text = "View Profile"
        '
        'SignOutToolStripMenuItem
        '
        Me.SignOutToolStripMenuItem.Name = "SignOutToolStripMenuItem"
        Me.SignOutToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.SignOutToolStripMenuItem.Text = "Sign Out"
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ColorToolStripMenuItem, Me.FontToolStripMenuItem})
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(39, 20)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'ColorToolStripMenuItem
        '
        Me.ColorToolStripMenuItem.Name = "ColorToolStripMenuItem"
        Me.ColorToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.ColorToolStripMenuItem.Text = "Color"
        '
        'FontToolStripMenuItem
        '
        Me.FontToolStripMenuItem.Name = "FontToolStripMenuItem"
        Me.FontToolStripMenuItem.Size = New System.Drawing.Size(103, 22)
        Me.FontToolStripMenuItem.Text = "Font"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(107, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 725)
        Me.Controls.Add(Me.pnlRegister)
        Me.Controls.Add(Me.pnlSuccessful)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UiTM Voting System"
        Me.pnlSuccessful.ResumeLayout(False)
        Me.pnlRegister.ResumeLayout(False)
        Me.pnlRegister.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.grpCampus.ResumeLayout(False)
        Me.grpCampus.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnlRegister As Panel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents chkVoter As CheckBox
    Friend WithEvents chkCandidate As CheckBox
    Friend WithEvents grpCampus As GroupBox
    Friend WithEvents optBandar As RadioButton
    Friend WithEvents optJasin As RadioButton
    Friend WithEvents optAlorGajah As RadioButton
    Friend WithEvents btnReturn As Button
    Friend WithEvents btnRegister As Button
    Friend WithEvents pnlSuccessful As Panel
    Friend WithEvents btnReturn2 As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SignOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
End Class
