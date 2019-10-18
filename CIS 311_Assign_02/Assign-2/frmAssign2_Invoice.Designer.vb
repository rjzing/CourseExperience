<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign2_Invoice
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
        Me.cmdChange = New System.Windows.Forms.Button()
        Me.cmdSubmit = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lstInvoice = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(47, 1167)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(245, 70)
        Me.cmdChange.TabIndex = 1
        Me.cmdChange.Text = "Change Order"
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'cmdSubmit
        '
        Me.cmdSubmit.Location = New System.Drawing.Point(582, 1167)
        Me.cmdSubmit.Name = "cmdSubmit"
        Me.cmdSubmit.Size = New System.Drawing.Size(245, 70)
        Me.cmdSubmit.TabIndex = 0
        Me.cmdSubmit.Text = "Submit Order"
        Me.cmdSubmit.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(1181, 1167)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(245, 70)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lstInvoice
        '
        Me.lstInvoice.FormattingEnabled = True
        Me.lstInvoice.ItemHeight = 37
        Me.lstInvoice.Location = New System.Drawing.Point(47, 12)
        Me.lstInvoice.Name = "lstInvoice"
        Me.lstInvoice.Size = New System.Drawing.Size(1379, 1114)
        Me.lstInvoice.TabIndex = 3
        '
        'frmAssign2_Invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1519, 1261)
        Me.Controls.Add(Me.lstInvoice)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdSubmit)
        Me.Controls.Add(Me.cmdChange)
        Me.Name = "frmAssign2_Invoice"
        Me.Text = "Kustom Karz Invoice"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdChange As Button
    Friend WithEvents cmdSubmit As Button
    Friend WithEvents cmdExit As Button
    Friend WithEvents lstInvoice As ListBox
End Class
