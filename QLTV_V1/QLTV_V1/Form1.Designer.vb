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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReaderProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReadertRecordsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddReaderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReaderManagementToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ReaderProfileToolStripMenuItem, Me.ReadertRecordsToolStripMenuItem, Me.AboutToolStripMenuItem, Me.AboutToolStripMenuItem1})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(552, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(92, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ReaderProfileToolStripMenuItem
        '
        Me.ReaderProfileToolStripMenuItem.Name = "ReaderProfileToolStripMenuItem"
        Me.ReaderProfileToolStripMenuItem.Size = New System.Drawing.Size(90, 20)
        Me.ReaderProfileToolStripMenuItem.Text = "Management"
        '
        'ReadertRecordsToolStripMenuItem
        '
        Me.ReadertRecordsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddReaderToolStripMenuItem, Me.ReaderManagementToolStripMenuItem})
        Me.ReadertRecordsToolStripMenuItem.Name = "ReadertRecordsToolStripMenuItem"
        Me.ReadertRecordsToolStripMenuItem.Size = New System.Drawing.Size(97, 20)
        Me.ReadertRecordsToolStripMenuItem.Text = "Reader records"
        '
        'AddReaderToolStripMenuItem
        '
        Me.AddReaderToolStripMenuItem.Name = "AddReaderToolStripMenuItem"
        Me.AddReaderToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.AddReaderToolStripMenuItem.Text = "Add readers"
        '
        'ReaderManagementToolStripMenuItem
        '
        Me.ReaderManagementToolStripMenuItem.Name = "ReaderManagementToolStripMenuItem"
        Me.ReaderManagementToolStripMenuItem.Size = New System.Drawing.Size(184, 22)
        Me.ReaderManagementToolStripMenuItem.Text = "Reader management"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(113, 20)
        Me.AboutToolStripMenuItem.Text = "Employee records"
        '
        'AboutToolStripMenuItem1
        '
        Me.AboutToolStripMenuItem1.Name = "AboutToolStripMenuItem1"
        Me.AboutToolStripMenuItem1.Size = New System.Drawing.Size(52, 20)
        Me.AboutToolStripMenuItem1.Text = "About"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(552, 365)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Reader Management"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReaderProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReadertRecordsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddReaderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReaderManagementToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem1 As ToolStripMenuItem
End Class
