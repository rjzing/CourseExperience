<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_01_Child
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
        Me.rbnStandardMeal = New System.Windows.Forms.RadioButton()
        Me.rbnDeluxeMeal = New System.Windows.Forms.RadioButton()
        Me.grbMealType = New System.Windows.Forms.GroupBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtMiddleInitial = New System.Windows.Forms.TextBox()
        Me.lblMiddleInitial = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.mtxPhoneNumber = New System.Windows.Forms.MaskedTextBox()
        Me.lblPhoneNumber = New System.Windows.Forms.Label()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.lstTotals = New System.Windows.Forms.ListBox()
        Me.grbDiscount = New System.Windows.Forms.GroupBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.rbnPercentage = New System.Windows.Forms.RadioButton()
        Me.rbnDecimal = New System.Windows.Forms.RadioButton()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.grbMealType.SuspendLayout()
        Me.grbDiscount.SuspendLayout()
        Me.SuspendLayout()
        '
        'rbnStandardMeal
        '
        Me.rbnStandardMeal.AutoSize = True
        Me.rbnStandardMeal.Location = New System.Drawing.Point(23, 32)
        Me.rbnStandardMeal.Name = "rbnStandardMeal"
        Me.rbnStandardMeal.Size = New System.Drawing.Size(94, 17)
        Me.rbnStandardMeal.TabIndex = 4
        Me.rbnStandardMeal.Text = "Standard Meal"
        Me.rbnStandardMeal.UseVisualStyleBackColor = True
        '
        'rbnDeluxeMeal
        '
        Me.rbnDeluxeMeal.AutoSize = True
        Me.rbnDeluxeMeal.Location = New System.Drawing.Point(23, 66)
        Me.rbnDeluxeMeal.Name = "rbnDeluxeMeal"
        Me.rbnDeluxeMeal.Size = New System.Drawing.Size(84, 17)
        Me.rbnDeluxeMeal.TabIndex = 5
        Me.rbnDeluxeMeal.Text = "Deluxe Meal"
        Me.rbnDeluxeMeal.UseVisualStyleBackColor = True
        '
        'grbMealType
        '
        Me.grbMealType.Controls.Add(Me.rbnStandardMeal)
        Me.grbMealType.Controls.Add(Me.rbnDeluxeMeal)
        Me.grbMealType.Location = New System.Drawing.Point(27, 133)
        Me.grbMealType.Name = "grbMealType"
        Me.grbMealType.Size = New System.Drawing.Size(200, 100)
        Me.grbMealType.TabIndex = 50
        Me.grbMealType.TabStop = False
        Me.grbMealType.Text = "Meal Type"
        '
        'txtLastName
        '
        Me.txtLastName.Location = New System.Drawing.Point(386, 34)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 2
        '
        'lblLastName
        '
        Me.lblLastName.AutoSize = True
        Me.lblLastName.Location = New System.Drawing.Point(383, 9)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(58, 13)
        Me.lblLastName.TabIndex = 0
        Me.lblLastName.Text = "Last Name"
        '
        'txtMiddleInitial
        '
        Me.txtMiddleInitial.Location = New System.Drawing.Point(238, 34)
        Me.txtMiddleInitial.Name = "txtMiddleInitial"
        Me.txtMiddleInitial.Size = New System.Drawing.Size(30, 20)
        Me.txtMiddleInitial.TabIndex = 1
        '
        'lblMiddleInitial
        '
        Me.lblMiddleInitial.AutoSize = True
        Me.lblMiddleInitial.Location = New System.Drawing.Point(217, 9)
        Me.lblMiddleInitial.Name = "lblMiddleInitial"
        Me.lblMiddleInitial.Size = New System.Drawing.Size(65, 13)
        Me.lblMiddleInitial.TabIndex = 0
        Me.lblMiddleInitial.Text = "Middle Initial"
        '
        'txtFirstName
        '
        Me.txtFirstName.Location = New System.Drawing.Point(27, 34)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 0
        '
        'lblFirstName
        '
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.Location = New System.Drawing.Point(24, 9)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(57, 13)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name"
        '
        'mtxPhoneNumber
        '
        Me.mtxPhoneNumber.Location = New System.Drawing.Point(27, 92)
        Me.mtxPhoneNumber.Mask = "(999) 000-0000"
        Me.mtxPhoneNumber.Name = "mtxPhoneNumber"
        Me.mtxPhoneNumber.Size = New System.Drawing.Size(100, 20)
        Me.mtxPhoneNumber.TabIndex = 3
        '
        'lblPhoneNumber
        '
        Me.lblPhoneNumber.AutoSize = True
        Me.lblPhoneNumber.Location = New System.Drawing.Point(24, 66)
        Me.lblPhoneNumber.Name = "lblPhoneNumber"
        Me.lblPhoneNumber.Size = New System.Drawing.Size(78, 13)
        Me.lblPhoneNumber.TabIndex = 10
        Me.lblPhoneNumber.Text = "Phone Number"
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(233, 152)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(46, 13)
        Me.lblQuantity.TabIndex = 12
        Me.lblQuantity.Text = "Quantity"
        '
        'lstTotals
        '
        Me.lstTotals.Enabled = False
        Me.lstTotals.FormattingEnabled = True
        Me.lstTotals.Location = New System.Drawing.Point(77, 315)
        Me.lstTotals.Name = "lstTotals"
        Me.lstTotals.Size = New System.Drawing.Size(357, 199)
        Me.lstTotals.TabIndex = 13
        Me.lstTotals.TabStop = False
        Me.lstTotals.Visible = False
        '
        'grbDiscount
        '
        Me.grbDiscount.Controls.Add(Me.txtDiscount)
        Me.grbDiscount.Controls.Add(Me.rbnPercentage)
        Me.grbDiscount.Controls.Add(Me.rbnDecimal)
        Me.grbDiscount.Location = New System.Drawing.Point(286, 133)
        Me.grbDiscount.Name = "grbDiscount"
        Me.grbDiscount.Size = New System.Drawing.Size(200, 100)
        Me.grbDiscount.TabIndex = 50
        Me.grbDiscount.TabStop = False
        Me.grbDiscount.Text = "Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.Location = New System.Drawing.Point(23, 19)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(30, 20)
        Me.txtDiscount.TabIndex = 7
        '
        'rbnPercentage
        '
        Me.rbnPercentage.AutoSize = True
        Me.rbnPercentage.Location = New System.Drawing.Point(23, 49)
        Me.rbnPercentage.Name = "rbnPercentage"
        Me.rbnPercentage.Size = New System.Drawing.Size(80, 17)
        Me.rbnPercentage.TabIndex = 8
        Me.rbnPercentage.Text = "Percentage"
        Me.rbnPercentage.UseVisualStyleBackColor = True
        '
        'rbnDecimal
        '
        Me.rbnDecimal.AutoSize = True
        Me.rbnDecimal.Location = New System.Drawing.Point(23, 74)
        Me.rbnDecimal.Name = "rbnDecimal"
        Me.rbnDecimal.Size = New System.Drawing.Size(63, 17)
        Me.rbnDecimal.TabIndex = 8
        Me.rbnDecimal.Text = "Decimal"
        Me.rbnDecimal.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(27, 261)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(95, 23)
        Me.btnReset.TabIndex = 9
        Me.btnReset.Text = "Reset Form"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(391, 261)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(95, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate Totals"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(238, 179)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(30, 20)
        Me.txtQuantity.TabIndex = 6
        '
        'frmAssign_01_Child
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 520)
        Me.Controls.Add(Me.txtQuantity)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.grbDiscount)
        Me.Controls.Add(Me.lstTotals)
        Me.Controls.Add(Me.lblQuantity)
        Me.Controls.Add(Me.lblPhoneNumber)
        Me.Controls.Add(Me.mtxPhoneNumber)
        Me.Controls.Add(Me.lblFirstName)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.lblMiddleInitial)
        Me.Controls.Add(Me.txtMiddleInitial)
        Me.Controls.Add(Me.lblLastName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.grbMealType)
        Me.Name = "frmAssign_01_Child"
        Me.Text = "Big J Catering Order Form"
        Me.grbMealType.ResumeLayout(False)
        Me.grbMealType.PerformLayout()
        Me.grbDiscount.ResumeLayout(False)
        Me.grbDiscount.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rbnStandardMeal As RadioButton
    Friend WithEvents rbnDeluxeMeal As RadioButton
    Friend WithEvents grbMealType As GroupBox
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents txtMiddleInitial As TextBox
    Friend WithEvents lblMiddleInitial As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblFirstName As Label
    Friend WithEvents mtxPhoneNumber As MaskedTextBox
    Friend WithEvents lblPhoneNumber As Label
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lstTotals As ListBox
    Friend WithEvents grbDiscount As GroupBox
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents rbnPercentage As RadioButton
    Friend WithEvents rbnDecimal As RadioButton
    Friend WithEvents btnReset As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtQuantity As TextBox
End Class
