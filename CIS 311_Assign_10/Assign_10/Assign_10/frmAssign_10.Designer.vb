<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_10
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
        Me.ConClock1 = New conClock.conClock()
        Me.SuspendLayout()
        '
        'ConClock1
        '
        Me.ConClock1.Location = New System.Drawing.Point(115, 109)
        Me.ConClock1.Name = "ConClock1"
        Me.ConClock1.Size = New System.Drawing.Size(679, 626)
        Me.ConClock1.TabIndex = 0
        '
        'frmAssign_10
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 761)
        Me.Controls.Add(Me.ConClock1)
        Me.Name = "frmAssign_10"
        Me.Text = "Assignment 10"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ConClock1 As conClock.conClock
End Class
