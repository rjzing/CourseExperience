<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_8
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
        Me.lblOwnerInfo = New System.Windows.Forms.Label()
        Me.lblOwnerName = New System.Windows.Forms.Label()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtOwnerFName = New System.Windows.Forms.TextBox()
        Me.txtStreetAddress = New System.Windows.Forms.TextBox()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.txtOwnerLName = New System.Windows.Forms.TextBox()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.txtZipCode = New System.Windows.Forms.TextBox()
        Me.txtOwnerID = New System.Windows.Forms.TextBox()
        Me.btnFirst = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnLast = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.pnlNavi = New System.Windows.Forms.Panel()
        Me.pnlSubmit = New System.Windows.Forms.Panel()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.dgvVehicles = New System.Windows.Forms.DataGridView()
        Me.btnVehicles = New System.Windows.Forms.Button()
        Me.pnlNavi.SuspendLayout()
        Me.pnlSubmit.SuspendLayout()
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOwnerInfo
        '
        Me.lblOwnerInfo.AutoSize = True
        Me.lblOwnerInfo.Location = New System.Drawing.Point(27, 44)
        Me.lblOwnerInfo.Name = "lblOwnerInfo"
        Me.lblOwnerInfo.Size = New System.Drawing.Size(281, 37)
        Me.lblOwnerInfo.TabIndex = 0
        Me.lblOwnerInfo.Text = "Owner Information"
        '
        'lblOwnerName
        '
        Me.lblOwnerName.AutoSize = True
        Me.lblOwnerName.Location = New System.Drawing.Point(83, 109)
        Me.lblOwnerName.Name = "lblOwnerName"
        Me.lblOwnerName.Size = New System.Drawing.Size(103, 37)
        Me.lblOwnerName.TabIndex = 1
        Me.lblOwnerName.Text = "Name"
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(83, 199)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(135, 37)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(1359, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 37)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "ID Number"
        '
        'txtOwnerFName
        '
        Me.txtOwnerFName.Enabled = False
        Me.txtOwnerFName.Location = New System.Drawing.Point(245, 102)
        Me.txtOwnerFName.Name = "txtOwnerFName"
        Me.txtOwnerFName.Size = New System.Drawing.Size(327, 44)
        Me.txtOwnerFName.TabIndex = 4
        '
        'txtStreetAddress
        '
        Me.txtStreetAddress.Enabled = False
        Me.txtStreetAddress.Location = New System.Drawing.Point(245, 192)
        Me.txtStreetAddress.Name = "txtStreetAddress"
        Me.txtStreetAddress.Size = New System.Drawing.Size(327, 44)
        Me.txtStreetAddress.TabIndex = 5
        '
        'txtCity
        '
        Me.txtCity.Enabled = False
        Me.txtCity.Location = New System.Drawing.Point(245, 270)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(327, 44)
        Me.txtCity.TabIndex = 6
        '
        'txtOwnerLName
        '
        Me.txtOwnerLName.Enabled = False
        Me.txtOwnerLName.Location = New System.Drawing.Point(645, 102)
        Me.txtOwnerLName.Name = "txtOwnerLName"
        Me.txtOwnerLName.Size = New System.Drawing.Size(327, 44)
        Me.txtOwnerLName.TabIndex = 7
        '
        'txtState
        '
        Me.txtState.Enabled = False
        Me.txtState.Location = New System.Drawing.Point(645, 270)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(91, 44)
        Me.txtState.TabIndex = 8
        '
        'txtZipCode
        '
        Me.txtZipCode.Enabled = False
        Me.txtZipCode.Location = New System.Drawing.Point(791, 270)
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(199, 44)
        Me.txtZipCode.TabIndex = 9
        '
        'txtOwnerID
        '
        Me.txtOwnerID.Location = New System.Drawing.Point(1547, 102)
        Me.txtOwnerID.Name = "txtOwnerID"
        Me.txtOwnerID.ReadOnly = True
        Me.txtOwnerID.Size = New System.Drawing.Size(91, 44)
        Me.txtOwnerID.TabIndex = 10
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
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(195, 96)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(99, 74)
        Me.btnPrevious.TabIndex = 12
        Me.btnPrevious.Text = "<<"
        Me.btnPrevious.UseVisualStyleBackColor = True
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
        'btnLast
        '
        Me.btnLast.Location = New System.Drawing.Point(1497, 96)
        Me.btnLast.Name = "btnLast"
        Me.btnLast.Size = New System.Drawing.Size(99, 74)
        Me.btnLast.TabIndex = 14
        Me.btnLast.Text = ">"
        Me.btnLast.UseVisualStyleBackColor = True
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
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(705, 96)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(206, 74)
        Me.btnDelete.TabIndex = 16
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
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
        'pnlNavi
        '
        Me.pnlNavi.Controls.Add(Me.btnFirst)
        Me.pnlNavi.Controls.Add(Me.btnLast)
        Me.pnlNavi.Controls.Add(Me.btnUpdate)
        Me.pnlNavi.Controls.Add(Me.btnNext)
        Me.pnlNavi.Controls.Add(Me.btnPrevious)
        Me.pnlNavi.Controls.Add(Me.btnDelete)
        Me.pnlNavi.Controls.Add(Me.btnAdd)
        Me.pnlNavi.Location = New System.Drawing.Point(140, 342)
        Me.pnlNavi.Name = "pnlNavi"
        Me.pnlNavi.Size = New System.Drawing.Size(1666, 227)
        Me.pnlNavi.TabIndex = 18
        '
        'pnlSubmit
        '
        Me.pnlSubmit.Controls.Add(Me.btnCancel)
        Me.pnlSubmit.Controls.Add(Me.btnSave)
        Me.pnlSubmit.Location = New System.Drawing.Point(546, 598)
        Me.pnlSubmit.Name = "pnlSubmit"
        Me.pnlSubmit.Size = New System.Drawing.Size(824, 138)
        Me.pnlSubmit.TabIndex = 19
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
        'dgvVehicles
        '
        Me.dgvVehicles.AllowUserToAddRows = False
        Me.dgvVehicles.AllowUserToDeleteRows = False
        Me.dgvVehicles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvVehicles.Location = New System.Drawing.Point(47, 751)
        Me.dgvVehicles.Name = "dgvVehicles"
        Me.dgvVehicles.ReadOnly = True
        Me.dgvVehicles.RowTemplate.Height = 46
        Me.dgvVehicles.Size = New System.Drawing.Size(1804, 684)
        Me.dgvVehicles.TabIndex = 19
        '
        'btnVehicles
        '
        Me.btnVehicles.Location = New System.Drawing.Point(791, 1509)
        Me.btnVehicles.Name = "btnVehicles"
        Me.btnVehicles.Size = New System.Drawing.Size(308, 74)
        Me.btnVehicles.TabIndex = 21
        Me.btnVehicles.Text = "Update Vehicles"
        Me.btnVehicles.UseVisualStyleBackColor = True
        '
        'frmAssign_8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1914, 1697)
        Me.Controls.Add(Me.btnVehicles)
        Me.Controls.Add(Me.pnlSubmit)
        Me.Controls.Add(Me.dgvVehicles)
        Me.Controls.Add(Me.pnlNavi)
        Me.Controls.Add(Me.txtOwnerID)
        Me.Controls.Add(Me.txtZipCode)
        Me.Controls.Add(Me.txtState)
        Me.Controls.Add(Me.txtOwnerLName)
        Me.Controls.Add(Me.txtCity)
        Me.Controls.Add(Me.txtStreetAddress)
        Me.Controls.Add(Me.txtOwnerFName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.lblOwnerName)
        Me.Controls.Add(Me.lblOwnerInfo)
        Me.Name = "frmAssign_8"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cars & Owners"
        Me.pnlNavi.ResumeLayout(False)
        Me.pnlSubmit.ResumeLayout(False)
        CType(Me.dgvVehicles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOwnerInfo As Label
    Friend WithEvents lblOwnerName As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtOwnerFName As TextBox
    Friend WithEvents txtStreetAddress As TextBox
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtOwnerLName As TextBox
    Friend WithEvents txtState As TextBox
    Friend WithEvents txtZipCode As TextBox
    Friend WithEvents btnFirst As Button
    Friend WithEvents btnPrevious As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnLast As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents pnlNavi As Panel
    Friend WithEvents pnlSubmit As Panel
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvVehicles As DataGridView
    Public WithEvents txtOwnerID As TextBox
    Friend WithEvents btnVehicles As Button
End Class
