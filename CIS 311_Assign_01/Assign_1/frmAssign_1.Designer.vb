<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAssign_1
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
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblDes = New System.Windows.Forms.Label()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.lblUnitPrice = New System.Windows.Forms.Label()
        Me.lblFlatRate = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtDes = New System.Windows.Forms.TextBox()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.txtUnitPrice = New System.Windows.Forms.TextBox()
        Me.chkFlatPrice = New System.Windows.Forms.CheckBox()
        Me.btnCalc = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblTotalPrice = New System.Windows.Forms.Label()
        Me.btnAddItem = New System.Windows.Forms.Button()
        Me.btnNext = New System.Windows.Forms.Button()
        Me.btnPrevious = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(83, 67)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(66, 37)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID: "
        '
        'lblDes
        '
        Me.lblDes.AutoSize = True
        Me.lblDes.Location = New System.Drawing.Point(822, 67)
        Me.lblDes.Name = "lblDes"
        Me.lblDes.Size = New System.Drawing.Size(195, 37)
        Me.lblDes.TabIndex = 1
        Me.lblDes.Text = "Description: "
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.Location = New System.Drawing.Point(45, 189)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(154, 37)
        Me.lblQTY.TabIndex = 2
        Me.lblQTY.Text = "Quantity: "
        '
        'lblUnitPrice
        '
        Me.lblUnitPrice.AutoSize = True
        Me.lblUnitPrice.Location = New System.Drawing.Point(822, 189)
        Me.lblUnitPrice.Name = "lblUnitPrice"
        Me.lblUnitPrice.Size = New System.Drawing.Size(231, 37)
        Me.lblUnitPrice.TabIndex = 3
        Me.lblUnitPrice.Text = "Per Unit Price: "
        '
        'lblFlatRate
        '
        Me.lblFlatRate.AutoSize = True
        Me.lblFlatRate.Location = New System.Drawing.Point(1040, 315)
        Me.lblFlatRate.Name = "lblFlatRate"
        Me.lblFlatRate.Size = New System.Drawing.Size(0, 37)
        Me.lblFlatRate.TabIndex = 4
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(221, 60)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(401, 44)
        Me.txtID.TabIndex = 5
        '
        'txtDes
        '
        Me.txtDes.Location = New System.Drawing.Point(1047, 60)
        Me.txtDes.Name = "txtDes"
        Me.txtDes.Size = New System.Drawing.Size(401, 44)
        Me.txtDes.TabIndex = 6
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(221, 182)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(401, 44)
        Me.txtQTY.TabIndex = 7
        '
        'txtUnitPrice
        '
        Me.txtUnitPrice.Location = New System.Drawing.Point(1047, 182)
        Me.txtUnitPrice.Name = "txtUnitPrice"
        Me.txtUnitPrice.Size = New System.Drawing.Size(401, 44)
        Me.txtUnitPrice.TabIndex = 8
        '
        'chkFlatPrice
        '
        Me.chkFlatPrice.AutoSize = True
        Me.chkFlatPrice.Location = New System.Drawing.Point(952, 297)
        Me.chkFlatPrice.Name = "chkFlatPrice"
        Me.chkFlatPrice.Size = New System.Drawing.Size(496, 41)
        Me.chkFlatPrice.TabIndex = 9
        Me.chkFlatPrice.Text = "Flat Price Regradless of QTY?"
        Me.chkFlatPrice.UseVisualStyleBackColor = True
        '
        'btnCalc
        '
        Me.btnCalc.Location = New System.Drawing.Point(142, 427)
        Me.btnCalc.Name = "btnCalc"
        Me.btnCalc.Size = New System.Drawing.Size(1227, 100)
        Me.btnCalc.TabIndex = 10
        Me.btnCalc.Text = "Calculate Inventory Item Value"
        Me.btnCalc.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(142, 609)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(392, 100)
        Me.btnSave.TabIndex = 11
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(977, 609)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(392, 100)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblTotalPrice
        '
        Me.lblTotalPrice.AutoSize = True
        Me.lblTotalPrice.Location = New System.Drawing.Point(135, 370)
        Me.lblTotalPrice.Name = "lblTotalPrice"
        Me.lblTotalPrice.Size = New System.Drawing.Size(0, 37)
        Me.lblTotalPrice.TabIndex = 13
        Me.lblTotalPrice.Visible = False
        '
        'btnAddItem
        '
        Me.btnAddItem.Location = New System.Drawing.Point(343, 609)
        Me.btnAddItem.Name = "btnAddItem"
        Me.btnAddItem.Size = New System.Drawing.Size(839, 100)
        Me.btnAddItem.TabIndex = 14
        Me.btnAddItem.Text = "Add New Inventory Item"
        Me.btnAddItem.UseVisualStyleBackColor = True
        Me.btnAddItem.Visible = False
        '
        'btnNext
        '
        Me.btnNext.Location = New System.Drawing.Point(1208, 609)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(161, 100)
        Me.btnNext.TabIndex = 15
        Me.btnNext.Text = "> >"
        Me.btnNext.UseVisualStyleBackColor = True
        Me.btnNext.Visible = False
        '
        'btnPrevious
        '
        Me.btnPrevious.Location = New System.Drawing.Point(142, 609)
        Me.btnPrevious.Name = "btnPrevious"
        Me.btnPrevious.Size = New System.Drawing.Size(164, 100)
        Me.btnPrevious.TabIndex = 16
        Me.btnPrevious.Text = "< <"
        Me.btnPrevious.UseVisualStyleBackColor = True
        Me.btnPrevious.Visible = False
        '
        'frmAssign_1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1502, 818)
        Me.Controls.Add(Me.btnPrevious)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.btnAddItem)
        Me.Controls.Add(Me.lblTotalPrice)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnCalc)
        Me.Controls.Add(Me.chkFlatPrice)
        Me.Controls.Add(Me.txtUnitPrice)
        Me.Controls.Add(Me.txtQTY)
        Me.Controls.Add(Me.txtDes)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblFlatRate)
        Me.Controls.Add(Me.lblUnitPrice)
        Me.Controls.Add(Me.lblQTY)
        Me.Controls.Add(Me.lblDes)
        Me.Controls.Add(Me.lblID)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmAssign_1"
        Me.Text = "Inventory System"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblID As Label
    Friend WithEvents lblDes As Label
    Friend WithEvents lblQTY As Label
    Friend WithEvents lblUnitPrice As Label
    Friend WithEvents lblFlatRate As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtDes As TextBox
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents txtUnitPrice As TextBox
    Friend WithEvents chkFlatPrice As CheckBox
    Friend WithEvents btnCalc As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblTotalPrice As Label
    Friend WithEvents btnAddItem As Button
    Friend WithEvents btnNext As Button
    Friend WithEvents btnPrevious As Button
End Class
