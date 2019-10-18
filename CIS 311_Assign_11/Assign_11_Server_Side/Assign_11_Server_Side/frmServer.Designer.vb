<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmServer
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
        Me.txtPort = New System.Windows.Forms.TextBox()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.btnStartServer = New System.Windows.Forms.Button()
        Me.btnStopServer = New System.Windows.Forms.Button()
        Me.gbxPlayer = New System.Windows.Forms.GroupBox()
        Me.rbtnO = New System.Windows.Forms.RadioButton()
        Me.rbtnX = New System.Windows.Forms.RadioButton()
        Me.gbxFirst = New System.Windows.Forms.GroupBox()
        Me.rbtnOFirst = New System.Windows.Forms.RadioButton()
        Me.rbtnXFirst = New System.Windows.Forms.RadioButton()
        Me.btnSubmitStart = New System.Windows.Forms.Button()
        Me.pnlSetUp = New System.Windows.Forms.Panel()
        Me.lblWinner = New System.Windows.Forms.Label()
        Me.btnP0 = New System.Windows.Forms.Button()
        Me.btnP1 = New System.Windows.Forms.Button()
        Me.btnP2 = New System.Windows.Forms.Button()
        Me.btnP3 = New System.Windows.Forms.Button()
        Me.btnP4 = New System.Windows.Forms.Button()
        Me.btnP5 = New System.Windows.Forms.Button()
        Me.btnP6 = New System.Windows.Forms.Button()
        Me.btnP7 = New System.Windows.Forms.Button()
        Me.btnP8 = New System.Windows.Forms.Button()
        Me.pnlBoard = New System.Windows.Forms.Panel()
        Me.LineShape1 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.ShapeContainer2 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.LineShape2 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape3 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.LineShape4 = New Microsoft.VisualBasic.PowerPacks.LineShape()
        Me.gbxPlayer.SuspendLayout()
        Me.gbxFirst.SuspendLayout()
        Me.pnlSetUp.SuspendLayout()
        Me.pnlBoard.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLog
        '
        Me.txtLog.Location = New System.Drawing.Point(24, 611)
        Me.txtLog.Multiline = True
        Me.txtLog.Name = "txtLog"
        Me.txtLog.ReadOnly = True
        Me.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtLog.Size = New System.Drawing.Size(1744, 320)
        Me.txtLog.TabIndex = 0
        Me.txtLog.TabStop = False
        '
        'txtPort
        '
        Me.txtPort.Location = New System.Drawing.Point(1532, 185)
        Me.txtPort.Name = "txtPort"
        Me.txtPort.Size = New System.Drawing.Size(236, 44)
        Me.txtPort.TabIndex = 0
        Me.txtPort.TabStop = False
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Location = New System.Drawing.Point(1421, 188)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(76, 37)
        Me.lblPort.TabIndex = 0
        Me.lblPort.Text = "Port"
        '
        'btnStartServer
        '
        Me.btnStartServer.Location = New System.Drawing.Point(1455, 275)
        Me.btnStartServer.Name = "btnStartServer"
        Me.btnStartServer.Size = New System.Drawing.Size(313, 71)
        Me.btnStartServer.TabIndex = 1
        Me.btnStartServer.Text = "Start Connection"
        Me.btnStartServer.UseVisualStyleBackColor = True
        '
        'btnStopServer
        '
        Me.btnStopServer.Location = New System.Drawing.Point(1455, 375)
        Me.btnStopServer.Name = "btnStopServer"
        Me.btnStopServer.Size = New System.Drawing.Size(313, 71)
        Me.btnStopServer.TabIndex = 11
        Me.btnStopServer.Text = "End Connection"
        Me.btnStopServer.UseVisualStyleBackColor = True
        '
        'gbxPlayer
        '
        Me.gbxPlayer.Controls.Add(Me.rbtnO)
        Me.gbxPlayer.Controls.Add(Me.rbtnX)
        Me.gbxPlayer.Location = New System.Drawing.Point(73, 28)
        Me.gbxPlayer.Name = "gbxPlayer"
        Me.gbxPlayer.Size = New System.Drawing.Size(383, 151)
        Me.gbxPlayer.TabIndex = 11
        Me.gbxPlayer.TabStop = False
        Me.gbxPlayer.Text = "Player"
        '
        'rbtnO
        '
        Me.rbtnO.AutoSize = True
        Me.rbtnO.Location = New System.Drawing.Point(239, 71)
        Me.rbtnO.Name = "rbtnO"
        Me.rbtnO.Size = New System.Drawing.Size(86, 41)
        Me.rbtnO.TabIndex = 0
        Me.rbtnO.Text = "O"
        Me.rbtnO.UseVisualStyleBackColor = True
        '
        'rbtnX
        '
        Me.rbtnX.AutoSize = True
        Me.rbtnX.Location = New System.Drawing.Point(43, 71)
        Me.rbtnX.Name = "rbtnX"
        Me.rbtnX.Size = New System.Drawing.Size(82, 41)
        Me.rbtnX.TabIndex = 0
        Me.rbtnX.Text = "X"
        Me.rbtnX.UseVisualStyleBackColor = True
        '
        'gbxFirst
        '
        Me.gbxFirst.Controls.Add(Me.rbtnOFirst)
        Me.gbxFirst.Controls.Add(Me.rbtnXFirst)
        Me.gbxFirst.Location = New System.Drawing.Point(73, 233)
        Me.gbxFirst.Name = "gbxFirst"
        Me.gbxFirst.Size = New System.Drawing.Size(383, 151)
        Me.gbxFirst.TabIndex = 12
        Me.gbxFirst.TabStop = False
        Me.gbxFirst.Text = "First Move"
        '
        'rbtnOFirst
        '
        Me.rbtnOFirst.AutoSize = True
        Me.rbtnOFirst.Location = New System.Drawing.Point(239, 66)
        Me.rbtnOFirst.Name = "rbtnOFirst"
        Me.rbtnOFirst.Size = New System.Drawing.Size(86, 41)
        Me.rbtnOFirst.TabIndex = 0
        Me.rbtnOFirst.Text = "O"
        Me.rbtnOFirst.UseVisualStyleBackColor = True
        '
        'rbtnXFirst
        '
        Me.rbtnXFirst.AutoSize = True
        Me.rbtnXFirst.Location = New System.Drawing.Point(43, 66)
        Me.rbtnXFirst.Name = "rbtnXFirst"
        Me.rbtnXFirst.Size = New System.Drawing.Size(82, 41)
        Me.rbtnXFirst.TabIndex = 0
        Me.rbtnXFirst.Text = "X"
        Me.rbtnXFirst.UseVisualStyleBackColor = True
        '
        'btnSubmitStart
        '
        Me.btnSubmitStart.Location = New System.Drawing.Point(116, 431)
        Me.btnSubmitStart.Name = "btnSubmitStart"
        Me.btnSubmitStart.Size = New System.Drawing.Size(282, 71)
        Me.btnSubmitStart.TabIndex = 13
        Me.btnSubmitStart.Text = "Submit"
        Me.btnSubmitStart.UseVisualStyleBackColor = True
        '
        'pnlSetUp
        '
        Me.pnlSetUp.Controls.Add(Me.gbxPlayer)
        Me.pnlSetUp.Controls.Add(Me.btnSubmitStart)
        Me.pnlSetUp.Controls.Add(Me.gbxFirst)
        Me.pnlSetUp.Location = New System.Drawing.Point(812, 37)
        Me.pnlSetUp.Name = "pnlSetUp"
        Me.pnlSetUp.Size = New System.Drawing.Size(564, 533)
        Me.pnlSetUp.TabIndex = 14
        '
        'lblWinner
        '
        Me.lblWinner.AutoSize = True
        Me.lblWinner.Location = New System.Drawing.Point(1482, 517)
        Me.lblWinner.Name = "lblWinner"
        Me.lblWinner.Size = New System.Drawing.Size(0, 37)
        Me.lblWinner.TabIndex = 35
        '
        'btnP0
        '
        Me.btnP0.Location = New System.Drawing.Point(51, 50)
        Me.btnP0.Name = "btnP0"
        Me.btnP0.Size = New System.Drawing.Size(130, 112)
        Me.btnP0.TabIndex = 2
        Me.btnP0.Tag = ""
        Me.btnP0.UseVisualStyleBackColor = True
        '
        'btnP1
        '
        Me.btnP1.Location = New System.Drawing.Point(225, 50)
        Me.btnP1.Name = "btnP1"
        Me.btnP1.Size = New System.Drawing.Size(130, 112)
        Me.btnP1.TabIndex = 3
        Me.btnP1.Tag = ""
        Me.btnP1.UseVisualStyleBackColor = True
        '
        'btnP2
        '
        Me.btnP2.Location = New System.Drawing.Point(402, 50)
        Me.btnP2.Name = "btnP2"
        Me.btnP2.Size = New System.Drawing.Size(130, 112)
        Me.btnP2.TabIndex = 4
        Me.btnP2.Tag = ""
        Me.btnP2.UseVisualStyleBackColor = True
        '
        'btnP3
        '
        Me.btnP3.Location = New System.Drawing.Point(51, 219)
        Me.btnP3.Name = "btnP3"
        Me.btnP3.Size = New System.Drawing.Size(130, 112)
        Me.btnP3.TabIndex = 5
        Me.btnP3.Tag = ""
        Me.btnP3.UseVisualStyleBackColor = True
        '
        'btnP4
        '
        Me.btnP4.Location = New System.Drawing.Point(225, 219)
        Me.btnP4.Name = "btnP4"
        Me.btnP4.Size = New System.Drawing.Size(130, 112)
        Me.btnP4.TabIndex = 6
        Me.btnP4.Tag = ""
        Me.btnP4.UseVisualStyleBackColor = True
        '
        'btnP5
        '
        Me.btnP5.Location = New System.Drawing.Point(402, 218)
        Me.btnP5.Name = "btnP5"
        Me.btnP5.Size = New System.Drawing.Size(130, 112)
        Me.btnP5.TabIndex = 7
        Me.btnP5.Tag = ""
        Me.btnP5.UseVisualStyleBackColor = True
        '
        'btnP6
        '
        Me.btnP6.Location = New System.Drawing.Point(51, 387)
        Me.btnP6.Name = "btnP6"
        Me.btnP6.Size = New System.Drawing.Size(130, 112)
        Me.btnP6.TabIndex = 8
        Me.btnP6.Tag = ""
        Me.btnP6.UseVisualStyleBackColor = True
        '
        'btnP7
        '
        Me.btnP7.Location = New System.Drawing.Point(225, 387)
        Me.btnP7.Name = "btnP7"
        Me.btnP7.Size = New System.Drawing.Size(130, 112)
        Me.btnP7.TabIndex = 9
        Me.btnP7.Tag = ""
        Me.btnP7.UseVisualStyleBackColor = True
        '
        'btnP8
        '
        Me.btnP8.Location = New System.Drawing.Point(402, 387)
        Me.btnP8.Name = "btnP8"
        Me.btnP8.Size = New System.Drawing.Size(130, 112)
        Me.btnP8.TabIndex = 10
        Me.btnP8.Tag = ""
        Me.btnP8.UseVisualStyleBackColor = True
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
        Me.pnlBoard.Location = New System.Drawing.Point(54, 16)
        Me.pnlBoard.Name = "pnlBoard"
        Me.pnlBoard.Size = New System.Drawing.Size(606, 554)
        Me.pnlBoard.TabIndex = 24
        '
        'LineShape1
        '
        Me.LineShape1.BorderWidth = 20
        Me.LineShape1.Name = "LineShape1"
        Me.LineShape1.X1 = 205
        Me.LineShape1.X2 = 203
        Me.LineShape1.Y1 = 9
        Me.LineShape1.Y2 = 546
        '
        'ShapeContainer2
        '
        Me.ShapeContainer2.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer2.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer2.Name = "ShapeContainer2"
        Me.ShapeContainer2.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.LineShape4, Me.LineShape3, Me.LineShape2, Me.LineShape1})
        Me.ShapeContainer2.Size = New System.Drawing.Size(606, 554)
        Me.ShapeContainer2.TabIndex = 11
        Me.ShapeContainer2.TabStop = False
        '
        'LineShape2
        '
        Me.LineShape2.BorderWidth = 20
        Me.LineShape2.Name = "LineShape2"
        Me.LineShape2.X1 = 380
        Me.LineShape2.X2 = 378
        Me.LineShape2.Y1 = 11
        Me.LineShape2.Y2 = 548
        '
        'LineShape3
        '
        Me.LineShape3.BorderWidth = 20
        Me.LineShape3.Name = "LineShape3"
        Me.LineShape3.X1 = 602
        Me.LineShape3.X2 = 6
        Me.LineShape3.Y1 = 358
        Me.LineShape3.Y2 = 359
        '
        'LineShape4
        '
        Me.LineShape4.BorderWidth = 20
        Me.LineShape4.Name = "LineShape4"
        Me.LineShape4.X1 = 599
        Me.LineShape4.X2 = 3
        Me.LineShape4.Y1 = 189
        Me.LineShape4.Y2 = 190
        '
        'frmServer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1814, 978)
        Me.Controls.Add(Me.lblWinner)
        Me.Controls.Add(Me.pnlBoard)
        Me.Controls.Add(Me.pnlSetUp)
        Me.Controls.Add(Me.btnStopServer)
        Me.Controls.Add(Me.btnStartServer)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.txtPort)
        Me.Controls.Add(Me.txtLog)
        Me.Name = "frmServer"
        Me.Text = "Server - Tic Tac Toe"
        Me.gbxPlayer.ResumeLayout(False)
        Me.gbxPlayer.PerformLayout()
        Me.gbxFirst.ResumeLayout(False)
        Me.gbxFirst.PerformLayout()
        Me.pnlSetUp.ResumeLayout(False)
        Me.pnlBoard.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtLog As TextBox
    Friend WithEvents txtPort As TextBox
    Friend WithEvents lblPort As Label
    Friend WithEvents btnStartServer As Button
    Friend WithEvents btnStopServer As Button
    Friend WithEvents gbxPlayer As GroupBox
    Friend WithEvents rbtnO As RadioButton
    Friend WithEvents rbtnX As RadioButton
    Friend WithEvents gbxFirst As GroupBox
    Friend WithEvents rbtnOFirst As RadioButton
    Friend WithEvents rbtnXFirst As RadioButton
    Friend WithEvents btnSubmitStart As Button
    Friend WithEvents pnlSetUp As Panel
    Friend WithEvents btnP0 As Button
    Friend WithEvents btnP1 As Button
    Friend WithEvents btnP2 As Button
    Friend WithEvents btnP3 As Button
    Friend WithEvents btnP4 As Button
    Friend WithEvents btnP5 As Button
    Friend WithEvents btnP6 As Button
    Friend WithEvents btnP7 As Button
    Friend WithEvents btnP8 As Button
    Friend WithEvents pnlBoard As Panel
    Friend WithEvents lblWinner As Label
    Friend WithEvents ShapeContainer2 As PowerPacks.ShapeContainer
    Friend WithEvents LineShape4 As PowerPacks.LineShape
    Friend WithEvents LineShape3 As PowerPacks.LineShape
    Friend WithEvents LineShape2 As PowerPacks.LineShape
    Friend WithEvents LineShape1 As PowerPacks.LineShape
End Class
