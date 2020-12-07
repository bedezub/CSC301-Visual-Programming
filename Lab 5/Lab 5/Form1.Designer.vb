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
        Me.SuspendLayout()
        '
        'Form1
        '
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Name = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColorToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblTitle As Label
    Friend WithEvents btnRegister As Button
    Friend WithEvents btnLogin As Button
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SaveProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents GenerateQRCodeToolStripMenuItem As ToolStripMenuItem
End Class
