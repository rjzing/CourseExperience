<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_7
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
        Me.lstDishes = New System.Windows.Forms.ListBox()
        Me.lblAllDishes = New System.Windows.Forms.Label()
        Me.btnAddNewDish = New System.Windows.Forms.Button()
        Me.txtNewDish = New System.Windows.Forms.TextBox()
        Me.lblPreppedItems = New System.Windows.Forms.Label()
        Me.lstSelectedDishPreppedItems = New System.Windows.Forms.ListBox()
        Me.lblAllPreppedItems = New System.Windows.Forms.Label()
        Me.lstAllPreppedItems = New System.Windows.Forms.ListBox()
        Me.btnAddNewPreppedItems = New System.Windows.Forms.Button()
        Me.txtNewPreppedItem = New System.Windows.Forms.TextBox()
        Me.lblRawIngri = New System.Windows.Forms.Label()
        Me.lstSelectedDishRawIngredients = New System.Windows.Forms.ListBox()
        Me.lblAllIngri = New System.Windows.Forms.Label()
        Me.lstAllRawIngridents = New System.Windows.Forms.ListBox()
        Me.btnAddNewRawIngredients = New System.Windows.Forms.Button()
        Me.txtNewRawIngredient = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'lstDishes
        '
        Me.lstDishes.FormattingEnabled = True
        Me.lstDishes.ItemHeight = 37
        Me.lstDishes.Location = New System.Drawing.Point(76, 71)
        Me.lstDishes.Name = "lstDishes"
        Me.lstDishes.Size = New System.Drawing.Size(1625, 152)
        Me.lstDishes.TabIndex = 2
        '
        'lblAllDishes
        '
        Me.lblAllDishes.AutoSize = True
        Me.lblAllDishes.Location = New System.Drawing.Point(67, 20)
        Me.lblAllDishes.Name = "lblAllDishes"
        Me.lblAllDishes.Size = New System.Drawing.Size(250, 37)
        Me.lblAllDishes.TabIndex = 3
        Me.lblAllDishes.Text = "List of all Dishes"
        '
        'btnAddNewDish
        '
        Me.btnAddNewDish.Enabled = False
        Me.btnAddNewDish.Location = New System.Drawing.Point(865, 242)
        Me.btnAddNewDish.Name = "btnAddNewDish"
        Me.btnAddNewDish.Size = New System.Drawing.Size(257, 125)
        Me.btnAddNewDish.TabIndex = 5
        Me.btnAddNewDish.Text = "Add New Dish"
        Me.btnAddNewDish.UseVisualStyleBackColor = True
        '
        'txtNewDish
        '
        Me.txtNewDish.Location = New System.Drawing.Point(1140, 285)
        Me.txtNewDish.Name = "txtNewDish"
        Me.txtNewDish.Size = New System.Drawing.Size(558, 44)
        Me.txtNewDish.TabIndex = 6
        '
        'lblPreppedItems
        '
        Me.lblPreppedItems.AutoSize = True
        Me.lblPreppedItems.Location = New System.Drawing.Point(67, 390)
        Me.lblPreppedItems.Name = "lblPreppedItems"
        Me.lblPreppedItems.Size = New System.Drawing.Size(461, 37)
        Me.lblPreppedItems.TabIndex = 7
        Me.lblPreppedItems.Text = "Prepped Items in Selected Dish"
        '
        'lstSelectedDishPreppedItems
        '
        Me.lstSelectedDishPreppedItems.FormattingEnabled = True
        Me.lstSelectedDishPreppedItems.ItemHeight = 37
        Me.lstSelectedDishPreppedItems.Location = New System.Drawing.Point(76, 450)
        Me.lstSelectedDishPreppedItems.Name = "lstSelectedDishPreppedItems"
        Me.lstSelectedDishPreppedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSelectedDishPreppedItems.Size = New System.Drawing.Size(454, 189)
        Me.lstSelectedDishPreppedItems.TabIndex = 8
        '
        'lblAllPreppedItems
        '
        Me.lblAllPreppedItems.AutoSize = True
        Me.lblAllPreppedItems.Location = New System.Drawing.Point(858, 390)
        Me.lblAllPreppedItems.Name = "lblAllPreppedItems"
        Me.lblAllPreppedItems.Size = New System.Drawing.Size(359, 37)
        Me.lblAllPreppedItems.TabIndex = 9
        Me.lblAllPreppedItems.Text = "List of all Prepped Items"
        '
        'lstAllPreppedItems
        '
        Me.lstAllPreppedItems.FormattingEnabled = True
        Me.lstAllPreppedItems.ItemHeight = 37
        Me.lstAllPreppedItems.Location = New System.Drawing.Point(865, 450)
        Me.lstAllPreppedItems.Name = "lstAllPreppedItems"
        Me.lstAllPreppedItems.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAllPreppedItems.Size = New System.Drawing.Size(454, 189)
        Me.lstAllPreppedItems.TabIndex = 10
        '
        'btnAddNewPreppedItems
        '
        Me.btnAddNewPreppedItems.Enabled = False
        Me.btnAddNewPreppedItems.Location = New System.Drawing.Point(865, 669)
        Me.btnAddNewPreppedItems.Name = "btnAddNewPreppedItems"
        Me.btnAddNewPreppedItems.Size = New System.Drawing.Size(257, 125)
        Me.btnAddNewPreppedItems.TabIndex = 11
        Me.btnAddNewPreppedItems.Text = "Add New Prepped Item"
        Me.btnAddNewPreppedItems.UseVisualStyleBackColor = True
        '
        'txtNewPreppedItem
        '
        Me.txtNewPreppedItem.Location = New System.Drawing.Point(1140, 709)
        Me.txtNewPreppedItem.Name = "txtNewPreppedItem"
        Me.txtNewPreppedItem.Size = New System.Drawing.Size(558, 44)
        Me.txtNewPreppedItem.TabIndex = 12
        '
        'lblRawIngri
        '
        Me.lblRawIngri.AutoSize = True
        Me.lblRawIngri.Location = New System.Drawing.Point(67, 837)
        Me.lblRawIngri.Name = "lblRawIngri"
        Me.lblRawIngri.Size = New System.Drawing.Size(610, 37)
        Me.lblRawIngri.TabIndex = 13
        Me.lblRawIngri.Text = "Raw Ingredients in Selected Prepped Item"
        '
        'lstSelectedDishRawIngredients
        '
        Me.lstSelectedDishRawIngredients.FormattingEnabled = True
        Me.lstSelectedDishRawIngredients.ItemHeight = 37
        Me.lstSelectedDishRawIngredients.Location = New System.Drawing.Point(76, 891)
        Me.lstSelectedDishRawIngredients.Name = "lstSelectedDishRawIngredients"
        Me.lstSelectedDishRawIngredients.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstSelectedDishRawIngredients.Size = New System.Drawing.Size(454, 189)
        Me.lstSelectedDishRawIngredients.TabIndex = 14
        '
        'lblAllIngri
        '
        Me.lblAllIngri.AutoSize = True
        Me.lblAllIngri.Location = New System.Drawing.Point(858, 837)
        Me.lblAllIngri.Name = "lblAllIngri"
        Me.lblAllIngri.Size = New System.Drawing.Size(382, 37)
        Me.lblAllIngri.TabIndex = 15
        Me.lblAllIngri.Text = "List of all Raw Ingredients"
        '
        'lstAllRawIngridents
        '
        Me.lstAllRawIngridents.FormattingEnabled = True
        Me.lstAllRawIngridents.ItemHeight = 37
        Me.lstAllRawIngridents.Location = New System.Drawing.Point(865, 891)
        Me.lstAllRawIngridents.Name = "lstAllRawIngridents"
        Me.lstAllRawIngridents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAllRawIngridents.Size = New System.Drawing.Size(454, 189)
        Me.lstAllRawIngridents.TabIndex = 16
        '
        'btnAddNewRawIngredients
        '
        Me.btnAddNewRawIngredients.Enabled = False
        Me.btnAddNewRawIngredients.Location = New System.Drawing.Point(865, 1107)
        Me.btnAddNewRawIngredients.Name = "btnAddNewRawIngredients"
        Me.btnAddNewRawIngredients.Size = New System.Drawing.Size(257, 125)
        Me.btnAddNewRawIngredients.TabIndex = 17
        Me.btnAddNewRawIngredients.Text = "Add New Raw Ing"
        Me.btnAddNewRawIngredients.UseVisualStyleBackColor = True
        '
        'txtNewRawIngredient
        '
        Me.txtNewRawIngredient.Location = New System.Drawing.Point(1140, 1150)
        Me.txtNewRawIngredient.Name = "txtNewRawIngredient"
        Me.txtNewRawIngredient.Size = New System.Drawing.Size(558, 44)
        Me.txtNewRawIngredient.TabIndex = 18
        '
        'frmAssign_7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1786, 1329)
        Me.Controls.Add(Me.txtNewRawIngredient)
        Me.Controls.Add(Me.btnAddNewRawIngredients)
        Me.Controls.Add(Me.lstAllRawIngridents)
        Me.Controls.Add(Me.lblAllIngri)
        Me.Controls.Add(Me.lstSelectedDishRawIngredients)
        Me.Controls.Add(Me.lblRawIngri)
        Me.Controls.Add(Me.txtNewPreppedItem)
        Me.Controls.Add(Me.btnAddNewPreppedItems)
        Me.Controls.Add(Me.lstAllPreppedItems)
        Me.Controls.Add(Me.lblAllPreppedItems)
        Me.Controls.Add(Me.lstSelectedDishPreppedItems)
        Me.Controls.Add(Me.lblPreppedItems)
        Me.Controls.Add(Me.txtNewDish)
        Me.Controls.Add(Me.btnAddNewDish)
        Me.Controls.Add(Me.lblAllDishes)
        Me.Controls.Add(Me.lstDishes)
        Me.Name = "frmAssign_7"
        Me.Text = "Chez SouSad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lstDishes As ListBox
    Friend WithEvents lblAllDishes As Label
    Friend WithEvents btnAddNewDish As Button
    Friend WithEvents txtNewDish As TextBox
    Friend WithEvents lblPreppedItems As Label
    Friend WithEvents lstSelectedDishPreppedItems As ListBox
    Friend WithEvents lblAllPreppedItems As Label
    Friend WithEvents lstAllPreppedItems As ListBox
    Friend WithEvents btnAddNewPreppedItems As Button
    Friend WithEvents txtNewPreppedItem As TextBox
    Friend WithEvents lblRawIngri As Label
    Friend WithEvents lstSelectedDishRawIngredients As ListBox
    Friend WithEvents lblAllIngri As Label
    Friend WithEvents lstAllRawIngridents As ListBox
    Friend WithEvents btnAddNewRawIngredients As Button
    Friend WithEvents txtNewRawIngredient As TextBox
End Class
