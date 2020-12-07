<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.picQR = New System.Windows.Forms.PictureBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtCampus = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReturn = New System.Windows.Forms.Button()
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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.Panel1.SuspendLayout()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = Global.IndividualProject.My.Resources.Resources.My_Profile
        Me.Panel1.Controls.Add(Me.picQR)
        Me.Panel1.Controls.Add(Me.txtPassword)
        Me.Panel1.Controls.Add(Me.txtCampus)
        Me.Panel1.Controls.Add(Me.txtEmail)
        Me.Panel1.Controls.Add(Me.txtStudID)
        Me.Panel1.Controls.Add(Me.btnExit)
        Me.Panel1.Controls.Add(Me.btnReturn)
        Me.Panel1.Location = New System.Drawing.Point(-7, -24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1280, 720)
        Me.Panel1.TabIndex = 0
        '
        'picQR
        '
        Me.picQR.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.picQR.Location = New System.Drawing.Point(90, 389)
        Me.picQR.Name = "picQR"
        Me.picQR.Size = New System.Drawing.Size(200, 200)
        Me.picQR.TabIndex = 13
        Me.picQR.TabStop = False
        '
        'txtPassword
        '
        Me.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(733, 558)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(381, 34)
        Me.txtPassword.TabIndex = 12
        '
        'txtCampus
        '
        Me.txtCampus.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCampus.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCampus.Location = New System.Drawing.Point(733, 476)
        Me.txtCampus.Name = "txtCampus"
        Me.txtCampus.Size = New System.Drawing.Size(381, 34)
        Me.txtCampus.TabIndex = 11
        '
        'txtEmail
        '
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(733, 389)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(381, 34)
        Me.txtEmail.TabIndex = 10
        '
        'txtStudID
        '
        Me.txtStudID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(733, 306)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(381, 34)
        Me.txtStudID.TabIndex = 6
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnExit.FlatAppearance.BorderSize = 0
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.White
        Me.btnExit.Location = New System.Drawing.Point(994, 89)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 72)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReturn
        '
        Me.btnReturn.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(71, Byte), Integer), CType(CType(105, Byte), Integer))
        Me.btnReturn.FlatAppearance.BorderSize = 0
        Me.btnReturn.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReturn.Font = New System.Drawing.Font("Franklin Gothic Heavy", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReturn.ForeColor = System.Drawing.Color.White
        Me.btnReturn.Location = New System.Drawing.Point(746, 89)
        Me.btnReturn.Name = "btnReturn"
        Me.btnReturn.Size = New System.Drawing.Size(159, 72)
        Me.btnReturn.TabIndex = 4
        Me.btnReturn.Text = "Return"
        Me.btnReturn.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EditToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 24)
        Me.MenuStrip1.TabIndex = 14
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
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UiTM Voting System"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.picQR, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReturn As Button
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents txtCampus As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtStudID As TextBox
    Friend WithEvents picQR As PictureBox
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
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents FontDialog1 As FontDialog
End Class
