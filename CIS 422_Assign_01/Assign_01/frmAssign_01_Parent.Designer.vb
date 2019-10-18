<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_01_Parent
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
        Me.mnsMain = New System.Windows.Forms.MenuStrip()
        Me.smiFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuNew = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiWindow = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCascade = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnsMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'mnsMain
        '
        Me.mnsMain.ImageScalingSize = New System.Drawing.Size(40, 40)
        Me.mnsMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiFile, Me.smiWindow, Me.HelpToolStripMenuItem})
        Me.mnsMain.Location = New System.Drawing.Point(0, 0)
        Me.mnsMain.MdiWindowListItem = Me.smiWindow
        Me.mnsMain.Name = "mnsMain"
        Me.mnsMain.Size = New System.Drawing.Size(887, 24)
        Me.mnsMain.TabIndex = 1
        Me.mnsMain.Text = "MenuStrip1"
        '
        'smiFile
        '
        Me.smiFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuNew, Me.mnuExit})
        Me.smiFile.Name = "smiFile"
        Me.smiFile.Size = New System.Drawing.Size(37, 20)
        Me.smiFile.Text = "&File"
        '
        'mnuNew
        '
        Me.mnuNew.Name = "mnuNew"
        Me.mnuNew.Size = New System.Drawing.Size(98, 22)
        Me.mnuNew.Text = "&New"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(98, 22)
        Me.mnuExit.Text = "&Exit"
        '
        'smiWindow
        '
        Me.smiWindow.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTile, Me.mnuCascade})
        Me.smiWindow.Name = "smiWindow"
        Me.smiWindow.Size = New System.Drawing.Size(63, 20)
        Me.smiWindow.Text = "&Window"
        '
        'mnuTile
        '
        Me.mnuTile.Name = "mnuTile"
        Me.mnuTile.Size = New System.Drawing.Size(170, 22)
        Me.mnuTile.Text = "Tile Windows"
        '
        'mnuCascade
        '
        Me.mnuCascade.Name = "mnuCascade"
        Me.mnuCascade.Size = New System.Drawing.Size(170, 22)
        Me.mnuCascade.Text = "Cascade Windows"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HelpToolStripMenuItem.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(107, 22)
        Me.mnuAbout.Text = "&About"
        '
        'frmAssign_01_Parent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(887, 605)
        Me.Controls.Add(Me.mnsMain)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnsMain
        Me.Name = "frmAssign_01_Parent"
        Me.Text = "Big J Catering "
        Me.mnsMain.ResumeLayout(False)
        Me.mnsMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents mnsMain As MenuStrip
    Friend WithEvents smiFile As ToolStripMenuItem
    Friend WithEvents mnuNew As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
    Friend WithEvents smiWindow As ToolStripMenuItem
    Friend WithEvents mnuTile As ToolStripMenuItem
    Friend WithEvents mnuCascade As ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
End Class
