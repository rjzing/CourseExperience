<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conClock
    Inherits System.Windows.Forms.UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Me.btn24Hour = New System.Windows.Forms.Button()
        Me.btnRegTime = New System.Windows.Forms.Button()
        Me.btnLong = New System.Windows.Forms.Button()
        Me.btnShort = New System.Windows.Forms.Button()
        Me.tmeTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'btn24Hour
        '
        Me.btn24Hour.Location = New System.Drawing.Point(364, 276)
        Me.btn24Hour.Name = "btn24Hour"
        Me.btn24Hour.Size = New System.Drawing.Size(283, 92)
        Me.btn24Hour.TabIndex = 1
        Me.btn24Hour.Text = "Military Time"
        Me.btn24Hour.UseVisualStyleBackColor = True
        '
        'btnRegTime
        '
        Me.btnRegTime.Location = New System.Drawing.Point(28, 276)
        Me.btnRegTime.Name = "btnRegTime"
        Me.btnRegTime.Size = New System.Drawing.Size(283, 92)
        Me.btnRegTime.TabIndex = 0
        Me.btnRegTime.Text = "Regular Time"
        Me.btnRegTime.UseVisualStyleBackColor = True
        '
        'btnLong
        '
        Me.btnLong.Location = New System.Drawing.Point(28, 429)
        Me.btnLong.Name = "btnLong"
        Me.btnLong.Size = New System.Drawing.Size(283, 92)
        Me.btnLong.TabIndex = 2
        Me.btnLong.Text = "Long Date"
        Me.btnLong.UseVisualStyleBackColor = True
        '
        'btnShort
        '
        Me.btnShort.Location = New System.Drawing.Point(364, 429)
        Me.btnShort.Name = "btnShort"
        Me.btnShort.Size = New System.Drawing.Size(283, 92)
        Me.btnShort.TabIndex = 3
        Me.btnShort.Text = "Short Date"
        Me.btnShort.UseVisualStyleBackColor = True
        '
        'tmeTimer
        '
        Me.tmeTimer.Enabled = True
        Me.tmeTimer.Interval = 1000
        '
        'conClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.btnShort)
        Me.Controls.Add(Me.btnLong)
        Me.Controls.Add(Me.btnRegTime)
        Me.Controls.Add(Me.btn24Hour)
        Me.Name = "conClock"
        Me.Size = New System.Drawing.Size(676, 587)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn24Hour As Button
    Friend WithEvents btnRegTime As Button
    Friend WithEvents btnLong As Button
    Friend WithEvents btnShort As Button
    Friend WithEvents tmeTimer As Timer
End Class
