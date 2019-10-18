<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_04
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
        Me.btnCreateNewCust = New System.Windows.Forms.Button()
        Me.pnlNewCust = New System.Windows.Forms.Panel()
        Me.btnCancelCust = New System.Windows.Forms.Button()
        Me.btnSubmitCust = New System.Windows.Forms.Button()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtPhone = New System.Windows.Forms.MaskedTextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.pnlAddOrder = New System.Windows.Forms.Panel()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.txtCustID = New System.Windows.Forms.TextBox()
        Me.btnCancelOrder = New System.Windows.Forms.Button()
        Me.btnSubmitOrder = New System.Windows.Forms.Button()
        Me.lblQty = New System.Windows.Forms.Label()
        Me.txtQTY = New System.Windows.Forms.TextBox()
        Me.lblProdName = New System.Windows.Forms.Label()
        Me.txtProductName = New System.Windows.Forms.TextBox()
        Me.txtOrderTUID = New System.Windows.Forms.TextBox()
        Me.lblOrderID = New System.Windows.Forms.Label()
        Me.btnNewOrder = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnNewFile = New System.Windows.Forms.Button()
        Me.fdNewFile = New System.Windows.Forms.OpenFileDialog()
        Me.btnReports = New System.Windows.Forms.Button()
        Me.pnlNewCust.SuspendLayout()
        Me.pnlAddOrder.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreateNewCust
        '
        Me.btnCreateNewCust.Location = New System.Drawing.Point(12, 20)
        Me.btnCreateNewCust.Name = "btnCreateNewCust"
        Me.btnCreateNewCust.Size = New System.Drawing.Size(114, 39)
        Me.btnCreateNewCust.TabIndex = 0
        Me.btnCreateNewCust.Text = "Create Customer"
        Me.btnCreateNewCust.UseVisualStyleBackColor = True
        '
        'pnlNewCust
        '
        Me.pnlNewCust.Controls.Add(Me.btnCancelCust)
        Me.pnlNewCust.Controls.Add(Me.btnSubmitCust)
        Me.pnlNewCust.Controls.Add(Me.lblPhone)
        Me.pnlNewCust.Controls.Add(Me.lblName)
        Me.pnlNewCust.Controls.Add(Me.txtPhone)
        Me.pnlNewCust.Controls.Add(Me.txtName)
        Me.pnlNewCust.Location = New System.Drawing.Point(173, 12)
        Me.pnlNewCust.Name = "pnlNewCust"
        Me.pnlNewCust.Size = New System.Drawing.Size(240, 235)
        Me.pnlNewCust.TabIndex = 1
        '
        'btnCancelCust
        '
        Me.btnCancelCust.Location = New System.Drawing.Point(60, 183)
        Me.btnCancelCust.Name = "btnCancelCust"
        Me.btnCancelCust.Size = New System.Drawing.Size(114, 39)
        Me.btnCancelCust.TabIndex = 8
        Me.btnCancelCust.Text = "Cancel"
        Me.btnCancelCust.UseVisualStyleBackColor = True
        '
        'btnSubmitCust
        '
        Me.btnSubmitCust.Location = New System.Drawing.Point(60, 128)
        Me.btnSubmitCust.Name = "btnSubmitCust"
        Me.btnSubmitCust.Size = New System.Drawing.Size(114, 39)
        Me.btnSubmitCust.TabIndex = 7
        Me.btnSubmitCust.Text = "Submit"
        Me.btnSubmitCust.UseVisualStyleBackColor = True
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(124, 8)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(78, 13)
        Me.lblPhone.TabIndex = 3
        Me.lblPhone.Text = "Phone Number"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(9, 8)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(54, 13)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Full Name"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(127, 33)
        Me.txtPhone.Mask = "(999) 000-0000"
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(100, 20)
        Me.txtPhone.TabIndex = 6
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 33)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 20)
        Me.txtName.TabIndex = 5
        '
        'pnlAddOrder
        '
        Me.pnlAddOrder.Controls.Add(Me.lblCustID)
        Me.pnlAddOrder.Controls.Add(Me.txtCustID)
        Me.pnlAddOrder.Controls.Add(Me.btnCancelOrder)
        Me.pnlAddOrder.Controls.Add(Me.btnSubmitOrder)
        Me.pnlAddOrder.Controls.Add(Me.lblQty)
        Me.pnlAddOrder.Controls.Add(Me.txtQTY)
        Me.pnlAddOrder.Controls.Add(Me.lblProdName)
        Me.pnlAddOrder.Controls.Add(Me.txtProductName)
        Me.pnlAddOrder.Controls.Add(Me.txtOrderTUID)
        Me.pnlAddOrder.Controls.Add(Me.lblOrderID)
        Me.pnlAddOrder.Location = New System.Drawing.Point(433, 12)
        Me.pnlAddOrder.Name = "pnlAddOrder"
        Me.pnlAddOrder.Size = New System.Drawing.Size(240, 235)
        Me.pnlAddOrder.TabIndex = 2
        '
        'lblCustID
        '
        Me.lblCustID.AutoSize = True
        Me.lblCustID.Location = New System.Drawing.Point(9, 8)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(65, 13)
        Me.lblCustID.TabIndex = 11
        Me.lblCustID.Text = "Customer ID"
        '
        'txtCustID
        '
        Me.txtCustID.Location = New System.Drawing.Point(12, 33)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.Size = New System.Drawing.Size(100, 20)
        Me.txtCustID.TabIndex = 9
        '
        'btnCancelOrder
        '
        Me.btnCancelOrder.Location = New System.Drawing.Point(72, 183)
        Me.btnCancelOrder.Name = "btnCancelOrder"
        Me.btnCancelOrder.Size = New System.Drawing.Size(114, 39)
        Me.btnCancelOrder.TabIndex = 14
        Me.btnCancelOrder.Text = "Cancel"
        Me.btnCancelOrder.UseVisualStyleBackColor = True
        '
        'btnSubmitOrder
        '
        Me.btnSubmitOrder.Location = New System.Drawing.Point(72, 128)
        Me.btnSubmitOrder.Name = "btnSubmitOrder"
        Me.btnSubmitOrder.Size = New System.Drawing.Size(114, 39)
        Me.btnSubmitOrder.TabIndex = 13
        Me.btnSubmitOrder.Text = "Submit"
        Me.btnSubmitOrder.UseVisualStyleBackColor = True
        '
        'lblQty
        '
        Me.lblQty.AutoSize = True
        Me.lblQty.Location = New System.Drawing.Point(124, 61)
        Me.lblQty.Name = "lblQty"
        Me.lblQty.Size = New System.Drawing.Size(46, 13)
        Me.lblQty.TabIndex = 7
        Me.lblQty.Text = "Quantity"
        '
        'txtQTY
        '
        Me.txtQTY.Location = New System.Drawing.Point(127, 90)
        Me.txtQTY.Name = "txtQTY"
        Me.txtQTY.Size = New System.Drawing.Size(100, 20)
        Me.txtQTY.TabIndex = 12
        '
        'lblProdName
        '
        Me.lblProdName.AutoSize = True
        Me.lblProdName.Location = New System.Drawing.Point(9, 61)
        Me.lblProdName.Name = "lblProdName"
        Me.lblProdName.Size = New System.Drawing.Size(75, 13)
        Me.lblProdName.TabIndex = 5
        Me.lblProdName.Text = "Product Name"
        '
        'txtProductName
        '
        Me.txtProductName.Location = New System.Drawing.Point(12, 90)
        Me.txtProductName.Name = "txtProductName"
        Me.txtProductName.Size = New System.Drawing.Size(100, 20)
        Me.txtProductName.TabIndex = 11
        '
        'txtOrderTUID
        '
        Me.txtOrderTUID.Location = New System.Drawing.Point(127, 33)
        Me.txtOrderTUID.Name = "txtOrderTUID"
        Me.txtOrderTUID.Size = New System.Drawing.Size(100, 20)
        Me.txtOrderTUID.TabIndex = 10
        '
        'lblOrderID
        '
        Me.lblOrderID.AutoSize = True
        Me.lblOrderID.Location = New System.Drawing.Point(124, 8)
        Me.lblOrderID.Name = "lblOrderID"
        Me.lblOrderID.Size = New System.Drawing.Size(73, 13)
        Me.lblOrderID.TabIndex = 3
        Me.lblOrderID.Text = "Order Number"
        '
        'btnNewOrder
        '
        Me.btnNewOrder.Location = New System.Drawing.Point(12, 83)
        Me.btnNewOrder.Name = "btnNewOrder"
        Me.btnNewOrder.Size = New System.Drawing.Size(114, 39)
        Me.btnNewOrder.TabIndex = 1
        Me.btnNewOrder.Text = "New Order"
        Me.btnNewOrder.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(12, 140)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(114, 39)
        Me.btnReset.TabIndex = 2
        Me.btnReset.Text = "Reset Database"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnNewFile
        '
        Me.btnNewFile.Location = New System.Drawing.Point(12, 195)
        Me.btnNewFile.Name = "btnNewFile"
        Me.btnNewFile.Size = New System.Drawing.Size(114, 39)
        Me.btnNewFile.TabIndex = 3
        Me.btnNewFile.Text = "New Order File"
        Me.btnNewFile.UseVisualStyleBackColor = True
        '
        'fdNewFile
        '
        Me.fdNewFile.DefaultExt = "txt"
        Me.fdNewFile.FileName = "Orders.txt"
        Me.fdNewFile.Filter = ".txt|"
        Me.fdNewFile.FilterIndex = 0
        '
        'btnReports
        '
        Me.btnReports.Location = New System.Drawing.Point(12, 255)
        Me.btnReports.Name = "btnReports"
        Me.btnReports.Size = New System.Drawing.Size(114, 39)
        Me.btnReports.TabIndex = 4
        Me.btnReports.Text = "View Reports"
        Me.btnReports.UseVisualStyleBackColor = True
        '
        'frmAssign_04
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 310)
        Me.Controls.Add(Me.btnReports)
        Me.Controls.Add(Me.btnNewFile)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnNewOrder)
        Me.Controls.Add(Me.pnlAddOrder)
        Me.Controls.Add(Me.pnlNewCust)
        Me.Controls.Add(Me.btnCreateNewCust)
        Me.Name = "frmAssign_04"
        Me.Text = "Plastico Ordering System"
        Me.pnlNewCust.ResumeLayout(False)
        Me.pnlNewCust.PerformLayout()
        Me.pnlAddOrder.ResumeLayout(False)
        Me.pnlAddOrder.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnCreateNewCust As Button
    Friend WithEvents pnlNewCust As Panel
    Friend WithEvents btnCancelCust As Button
    Friend WithEvents btnSubmitCust As Button
    Friend WithEvents lblPhone As Label
    Friend WithEvents lblName As Label
    Friend WithEvents txtPhone As MaskedTextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents pnlAddOrder As Panel
    Friend WithEvents btnCancelOrder As Button
    Friend WithEvents btnSubmitOrder As Button
    Friend WithEvents lblQty As Label
    Friend WithEvents txtQTY As TextBox
    Friend WithEvents lblProdName As Label
    Friend WithEvents txtProductName As TextBox
    Friend WithEvents txtOrderTUID As TextBox
    Friend WithEvents lblOrderID As Label
    Friend WithEvents btnNewOrder As Button
    Friend WithEvents lblCustID As Label
    Friend WithEvents txtCustID As TextBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnNewFile As Button
    Friend WithEvents fdNewFile As OpenFileDialog
    Friend WithEvents btnReports As Button
End Class
