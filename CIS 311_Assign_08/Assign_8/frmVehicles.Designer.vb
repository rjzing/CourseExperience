<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmVehicles
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
        Me.lblVehicleInfo = New System.Windows.Forms.Label()
        Me.lblOwnerID = New System.Windows.Forms.Label()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblColor = New System.Windows.Forms.Label()
        Me.lblVIN = New System.Windows.Forms.Label()
        Me.txtMake = New System.Windows.Forms.TextBox()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtColor = New System.Windows.Forms.TextBox()
        Me.txtVIN = New System.Windows.Forms.TextBox()
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.pnlNavi = New System.Windows.Forms.Panel()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.pnlSubmit = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.txtYear = New System.Windows.Forms.TextBox()
        Me.txtVehicleID = New System.Windows.Forms.TextBox()
        Me.lblVehicleID = New System.Windows.Forms.Label()
        Me.pnlNavi.SuspendLayout()
        Me.pnlSubmit.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblVehicleInfo
        '
        Me.lblVehicleInfo.AutoSize = True
        Me.lblVehicleInfo.Location = New System.Drawing.Point(35, 50)
        Me.lblVehicleInfo.Name = "lblVehicleInfo"
        Me.lblVehicleInfo.Size = New System.Drawing.Size(291, 37)
        Me.lblVehicleInfo.TabIndex = 0
        Me.lblVehicleInfo.Text = "Vehicle Information"
        '
        'lblOwnerID
        '
        Me.lblOwnerID.AutoSize = True
        Me.lblOwnerID.Location = New System.Drawing.Point(953, 50)
        Me.lblOwnerID.Name = "lblOwnerID"
        Me.lblOwnerID.Size = New System.Drawing.Size(151, 37)
        Me.lblOwnerID.TabIndex = 1
        Me.lblOwnerID.Text = "Owner ID"
        '
        'lblMake
        '
        Me.lblMake.AutoSize = True
        Me.lblMake.Location = New System.Drawing.Point(35, 143)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(94, 37)
        Me.lblMake.TabIndex = 2
        Me.lblMake.Text = "Make"
        '
        'lblModel
        '
        Me.lblModel.AutoSize = True
        Me.lblModel.Location = New System.Drawing.Point(35, 242)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(103, 37)
        Me.lblModel.TabIndex = 3
        Me.lblModel.Text = "Model"
        '
        'lblColor
        '
        Me.lblColor.AutoSize = True
        Me.lblColor.Location = New System.Drawing.Point(44, 333)
        Me.lblColor.Name = "lblColor"
        Me.lblColor.Size = New System.Drawing.Size(94, 37)
        Me.lblColor.TabIndex = 4
        Me.lblColor.Text = "Color"
        '
        'lblVIN
        '
        Me.lblVIN.AutoSize = True
        Me.lblVIN.Location = New System.Drawing.Point(44, 508)
        Me.lblVIN.Name = "lblVIN"
        Me.lblVIN.Size = New System.Drawing.Size(71, 37)
        Me.lblVIN.TabIndex = 5
        Me.lblVIN.Text = "VIN"
        '
        'txtMake
        '
        Me.txtMake.Enabled = False
        Me.txtMake.Location = New System.Drawing.Point(223, 140)
        Me.txtMake.Name = "txtMake"
        Me.txtMake.Size = New System.Drawing.Size(549, 44)
        Me.txtMake.TabIndex = 6
        '
        'txtModel
        '
        Me.txtModel.Enabled = False
        Me.txtModel.Location = New System.Drawing.Point(223, 235)
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(549, 44)
        Me.txtModel.TabIndex = 7
        '
        'txtColor
        '
        Me.txtColor.Enabled = False
        Me.txtColor.Location = New System.Drawing.Point(223, 326)
        Me.txtColor.Name = "txtColor"
        Me.txtColor.Size = New System.Drawing.Size(549, 44)
        Me.txtColor.TabIndex = 8
        '
        'txtVIN
        '
        Me.txtVIN.Enabled = False
        Me.txtVIN.Location = New System.Drawing.Point(223, 501)
        Me.txtVIN.Name = "txtVIN"
        Me.txtVIN.Size = New System.Drawing.Size(549, 44)
        Me.txtVIN.TabIndex = 9
        '
        'txtOwnerID
        '
        Me.txtOwnerID.Location = New System.Drawing.Point(1173, 43)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.ReadOnly = True
        Me.txtOwnerID.Size = New System.Drawing.Size(85, 44)
        Me.txtOwnerID.TabIndex = 10
        '
        'pnlNavi
        '
        Me.pnlNavi.Controls.Add(Me.btnFirst)
        Me.pnlNavi.Controls.Add(Me.btnLast)
        Me.pnlNavi.Controls.Add(Me.btnUpdate)
        Me.pnlNavi.Controls.Add(Me.btnNext)
        Me.pnlNavi.Controls.Add(Me.btnPrevious)
        Me.pnlNavi.Controls.Add(Me.btnDelete)
        Me.pnlNavi.Controls.Add(Me.btnAdd)
        Me.pnlNavi.Location = New System.Drawing.Point(12, 602)
        Me.pnlNavi.Name = "pnlNavi"
        Me.pnlNavi.Size = New System.Drawing.Size(1666, 227)
        Me.pnlNavi.TabIndex = 19
        '
        'btnFirst
        '
        Me.btnFirst.Location = New System.Drawing.Point(40, 96)
        Me.btnFirst.Name = "btnFirst"
        Me.btnFirst.Size = New System.Drawing.Size(99, 74)
        Me.btnFirst.TabIndex = 11
        Me.btnFirst.Text = "<"
        Me.btnFirst.UseVisualStyleBackColor = True
        '
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(1497, 96)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(99, 74)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">"
        Me.btnLast.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(1025, 96)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(206, 74)
        Me.btnUpdate.TabIndex = 17
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1335, 96)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(99, 74)
        Me.btnNext.TabIndex = 13
        Me.btnNext.Text = ">>"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(195, 96)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(99, 74)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(705, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(206, 74)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(407, 96)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(206, 74)
        Me.btnAdd.TabIndex = 15
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'pnlSubmit
        '
        Me.pnlSubmit.Controls.Add(Me.btnCancel)
        Me.pnlSubmit.Controls.Add(Me.btnSave)
        Me.pnlSubmit.Location = New System.Drawing.Point(409, 874)
        Me.pnlSubmit.Name = "pnlSubmit"
        Me.pnlSubmit.Size = New System.Drawing.Size(824, 138)
        Me.pnlSubmit.TabIndex = 20
        Me.pnlSubmit.Visible = False
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(401, 31)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(206, 74)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(139, 31)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(206, 74)
        Me.btnSave.TabIndex = 20
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'lblYear
        '
        Me.lblYear.AutoSize = True
        Me.lblYear.Location = New System.Drawing.Point(44, 416)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(85, 37)
        Me.lblYear.TabIndex = 21
        Me.lblYear.Text = "Year"
        '
        'txtYear
        '
        Me.txtYear.Enabled = False
        Me.txtYear.Location = New System.Drawing.Point(223, 409)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(549, 44)
        Me.txtYear.TabIndex = 22
        '
        'txtVehicleID
        '
        Me.txtVehicleID.Location = New System.Drawing.Point(1173, 136)
        Me.txtVehicleID.Name = "txtVehicleID"
        Me.txtVehicleID.ReadOnly = True
        Me.txtVehicleID.Size = New System.Drawing.Size(85, 44)
        Me.txtVehicleID.TabIndex = 23
        '
        'lblVehicleID
        '
        Me.lblVehicleID.AutoSize = True
        Me.lblVehicleID.Location = New System.Drawing.Point(953, 139)
        Me.lblVehicleID.Name = "lblVehicleID"
        Me.lblVehicleID.Size = New System.Drawing.Size(161, 37)
        Me.lblVehicleID.TabIndex = 24
        Me.lblVehicleID.Text = "Vehicle ID"
        '
        'frmVehicles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1766, 1024)
        Me.Controls.Add(Me.lblVehicleID)
        Me.Controls.Add(Me.txtVehicleID)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.pnlSubmit)
        Me.Controls.Add(Me.pnlNavi)
        Me.Controls.Add(Me.txtOwnerID)
        Me.Controls.Add(Me.txtVIN)
        Me.Controls.Add(Me.txtColor)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.txtMake)
        Me.Controls.Add(Me.lblVIN)
        Me.Controls.Add(Me.lblColor)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblMake)
        Me.Controls.Add(Me.lblOwnerID)
        Me.Controls.Add(Me.lblVehicleInfo)
        Me.Name = "frmVehicles"
        Me.Text = "Vehicles"
        Me.pnlNavi.ResumeLayout(False)
        Me.pnlSubmit.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVehicleInfo As Label
    Friend WithEvents lblOwnerID As Label
    Friend WithEvents lblMake As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblColor As Label
    Friend WithEvents lblVIN As Label
    Friend WithEvents txtMake As TextBox
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtColor As TextBox
    Friend WithEvents txtVIN As TextBox
    Friend WithEvents txtOwnerID As TextBox
    Friend WithEvents pnlNavi As Panel
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents pnlSubmit As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents lblYear As Label
    Friend WithEvents txtYear As TextBox
    Friend WithEvents txtVehicleID As TextBox
    Friend WithEvents lblVehicleID As Label
End Class
