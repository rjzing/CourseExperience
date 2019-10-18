<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmClient
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
        Me.txtLog = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.btnStartClient = New System.Windows.Forms.Button()
        Me.btnStopClient = New System.Windows.Forms.Button()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.btnP8 = New System.Windows.Forms.Button()
        Me.btnP7 = New System.Windows.Forms.Button()
        Me.btnP6 = New System.Windows.Forms.Button()
        Me.btnP5 = New System.Windows.Forms.Button()
        Me.btnP4 = New System.Windows.Forms.Button()
        Me.btnP3 = New System.Windows.Forms.Button()
        Me.btnP2 = New System.Windows.Forms.Button()
        Me.btnP1 = New System.Windows.Forms.Button()
        Me.btnP0 = New System.Windows.Forms.Button()
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.pnlBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(73, 690)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(1907, 320)
        Me.txtLog.TabIndex = 1
        Me.txtLog.TabStop = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(1630, 316)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(76, 37)
        Me.lblPort.TabIndex = 0
        Me.lblPort.Text = "Port"
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(1744, 313)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(236, 44)
        Me.txtPort.TabIndex = 4
        Me.txtPort.TabStop = False
        '
        'btnStartClient
        '
        Me.btnStartClient.Location = New System.Drawing.Point(1667, 408)
        Me.btnStartClient.Name = "btnStartClient"
        Me.btnStartClient.Size = New System.Drawing.Size(313, 71)
        Me.btnStartClient.TabIndex = 1
        Me.btnStartClient.Text = "Start Connection"
        Me.btnStartClient.UseVisualStyleBackColor = True
        '
        'btnStopClient
        '
        Me.btnStopClient.Location = New System.Drawing.Point(1667, 524)
        Me.btnStopClient.Name = "btnStopClient"
        Me.btnStopClient.Size = New System.Drawing.Size(313, 71)
        Me.btnStopClient.TabIndex = 6
        Me.btnStopClient.Text = "End Connection"
        Me.btnStopClient.UseVisualStyleBackColor = True
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(1744, 181)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(236, 44)
        Me.txtAddress.TabIndex = 7
        Me.txtAddress.TabStop = False
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(1571, 181)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(135, 37)
        Me.lblAddress.TabIndex = 0
        Me.lblAddress.Text = "Address"
        '
        'btnP8
        '
        Me.btnP8.Location = New System.Drawing.Point(407, 395)
        Me.btnP8.Name = "btnP8"
        Me.btnP8.Size = New System.Drawing.Size(130, 112)
        Me.btnP8.TabIndex = 10
        Me.btnP8.Tag = ""
        Me.btnP8.UseVisualStyleBackColor = True
        '
        'btnP7
        '
        Me.btnP7.Location = New System.Drawing.Point(228, 395)
        Me.btnP7.Name = "btnP7"
        Me.btnP7.Size = New System.Drawing.Size(130, 112)
        Me.btnP7.TabIndex = 9
        Me.btnP7.Tag = ""
        Me.btnP7.UseVisualStyleBackColor = True
        '
        'btnP6
        '
        Me.btnP6.Location = New System.Drawing.Point(54, 395)
        Me.btnP6.Name = "btnP6"
        Me.btnP6.Size = New System.Drawing.Size(130, 112)
        Me.btnP6.TabIndex = 8
        Me.btnP6.Tag = ""
        Me.btnP6.UseVisualStyleBackColor = True
        '
        'btnP5
        '
        Me.btnP5.Location = New System.Drawing.Point(407, 227)
        Me.btnP5.Name = "btnP5"
        Me.btnP5.Size = New System.Drawing.Size(130, 112)
        Me.btnP5.TabIndex = 7
        Me.btnP5.Tag = ""
        Me.btnP5.UseVisualStyleBackColor = True
        '
        'btnP4
        '
        Me.btnP4.Location = New System.Drawing.Point(228, 227)
        Me.btnP4.Name = "btnP4"
        Me.btnP4.Size = New System.Drawing.Size(130, 112)
        Me.btnP4.TabIndex = 6
        Me.btnP4.Tag = ""
        Me.btnP4.UseVisualStyleBackColor = True
        '
        'btnP3
        '
        Me.btnP3.Location = New System.Drawing.Point(54, 227)
        Me.btnP3.Name = "btnP3"
        Me.btnP3.Size = New System.Drawing.Size(130, 112)
        Me.btnP3.TabIndex = 5
        Me.btnP3.Tag = ""
        Me.btnP3.UseVisualStyleBackColor = True
        '
        'btnP2
        '
        Me.btnP2.Location = New System.Drawing.Point(407, 58)
        Me.btnP2.Name = "btnP2"
        Me.btnP2.Size = New System.Drawing.Size(130, 112)
        Me.btnP2.TabIndex = 4
        Me.btnP2.Tag = ""
        Me.btnP2.UseVisualStyleBackColor = True
        '
        'btnP1
        '
        Me.btnP1.Location = New System.Drawing.Point(228, 58)
        Me.btnP1.Name = "btnP1"
        Me.btnP1.Size = New System.Drawing.Size(130, 112)
        Me.btnP1.TabIndex = 3
        Me.btnP1.Tag = ""
        Me.btnP1.UseVisualStyleBackColor = True
        '
        'btnP0
        '
        Me.btnP0.Location = New System.Drawing.Point(54, 58)
        Me.btnP0.Name = "btnP0"
        Me.btnP0.Size = New System.Drawing.Size(130, 112)
        Me.btnP0.TabIndex = 2
        Me.btnP0.Tag = ""
        Me.btnP0.UseVisualStyleBackColor = True
        '
        'pnlBoard
        '
        Me.pnlBoard.Controls.Add(Me.btnP8)
        Me.pnlBoard.Controls.Add(Me.btnP7)
        Me.pnlBoard.Controls.Add(Me.btnP6)
        Me.pnlBoard.Controls.Add(Me.btnP5)
        Me.pnlBoard.Controls.Add(Me.btnP4)
        Me.pnlBoard.Controls.Add(Me.btnP3)
        Me.pnlBoard.Controls.Add(Me.btnP2)
        Me.pnlBoard.Controls.Add(Me.btnP1)
        Me.pnlBoard.Controls.Add(Me.btnP0)
        Me.pnlBoard.Controls.Add(Me.ShapeContainer2)
        Me.pnlBoard.Location = New System.Drawing.Point(112, 36)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(605, 591)
        Me.pnlBoard.TabIndex = 33
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(1115, 566)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 37)
        Me.lblWinner.TabIndex = 34
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 20
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 598
        Me.LineShape3.X2 = 2
        Me.LineShape3.Y1 = 195
        Me.LineShape3.Y2 = 196
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape2, Me.LineShape1, Me.LineShape3})
        Me.ShapeContainer2.Size = New System.Drawing.Size(605, 591)
        Me.ShapeContainer2.TabIndex = 11
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 20
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 599
        Me.LineShape1.X2 = 3
        Me.LineShape1.Y1 = 370
        Me.LineShape1.Y2 = 371
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 20
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 207
        Me.LineShape2.X2 = 205
        Me.LineShape2.Y1 = 19
        Me.LineShape2.Y2 = 556
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 20
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 387
        Me.LineShape4.X2 = 385
        Me.LineShape4.Y1 = 21
        Me.LineShape4.Y2 = 558
        '
        'frmClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2049, 1104)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.pnlBoard)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.btnStopClient)
        Me.Controls.Add(Me.btnStartClient)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "frmClient"
        Me.Text = "Client - Tic Tac Toe"
        Me.pnlBoard.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents txtPort As TextBox
    Friend WithEvents btnStartClient As Button
    Friend WithEvents btnStopClient As Button
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents btnP8 As Button
    Friend WithEvents btnP7 As Button
    Friend WithEvents btnP6 As Button
    Friend WithEvents btnP5 As Button
    Friend WithEvents btnP4 As Button
    Friend WithEvents btnP3 As Button
    Friend WithEvents btnP2 As Button
    Friend WithEvents btnP1 As Button
    Friend WithEvents btnP0 As Button
    Friend WithEvents pnlBoard As Panel
    Friend WithEvents lblWinner As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
End Class
