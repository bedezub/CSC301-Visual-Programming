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
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ColorDialog2 = New System.Windows.Forms.ColorDialog()
        Me.pbox_background = New System.Windows.Forms.PictureBox()
        Me.txt_helloWorld = New System.Windows.Forms.TextBox()
        CType(Me.pbox_background, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pbox_background
        '
        Me.pbox_background.Image = Global.Lab_1___zubquzaini.My.Resources.Resources.Untitled_design
        Me.pbox_background.Location = New System.Drawing.Point(-1, -3)
        Me.pbox_background.Name = "pbox_background"
        Me.pbox_background.Size = New System.Drawing.Size(1280, 720)
        Me.pbox_background.TabIndex = 1
        Me.pbox_background.TabStop = False
        '
        'txt_helloWorld
        '
        Me.txt_helloWorld.BackColor = System.Drawing.Color.BlanchedAlmond
        Me.txt_helloWorld.Font = New System.Drawing.Font("Consolas", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_helloWorld.Location = New System.Drawing.Point(362, 247)
        Me.txt_helloWorld.Multiline = True
        Me.txt_helloWorld.Name = "txt_helloWorld"
        Me.txt_helloWorld.Size = New System.Drawing.Size(577, 245)
        Me.txt_helloWorld.TabIndex = 2
        Me.txt_helloWorld.Text = "Hello world is a beginning of every programming adventure - zubquzaini"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.txt_helloWorld)
        Me.Controls.Add(Me.pbox_background)
        Me.Name = "Form1"
        Me.Text = "Lab 1 - Zubli Quzaini"
        CType(Me.pbox_background, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents ColorDialog2 As ColorDialog
    Friend WithEvents pbox_background As PictureBox
    Friend WithEvents txt_helloWorld As TextBox
End Class
