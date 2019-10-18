<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAssign_4
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
        Me.lblAllDishes = New System.Windows.Forms.Label()
        Me.lstDishes = New System.Windows.Forms.ListBox()
        Me.lblPreppedItems = New System.Windows.Forms.Label()
        Me.lstSelectedDishPreppedItems = New System.Windows.Forms.ListBox()
        Me.btnAddNewDish = New System.Windows.Forms.Button()
        Me.txtNewDish = New System.Windows.Forms.TextBox()
        Me.lblAllPreppedItems = New System.Windows.Forms.Label()
        Me.lstAllPreppedItems = New System.Windows.Forms.ListBox()
        Me.btnLeftPreppedItems = New System.Windows.Forms.Button()
        Me.btnRightPreppedItems = New System.Windows.Forms.Button()
        Me.btnAddNewPreppedItems = New System.Windows.Forms.Button()
        Me.txtNewPreppedItem = New System.Windows.Forms.TextBox()
        Me.lblRawIngri = New System.Windows.Forms.Label()
        Me.lstSelectedDishRawIngredients = New System.Windows.Forms.ListBox()
        Me.lblAllIngri = New System.Windows.Forms.Label()
        Me.lstAllRawIngridents = New System.Windows.Forms.ListBox()
        Me.btnAddNewRawIngredients = New System.Windows.Forms.Button()
        Me.txtNewRawIngredient = New System.Windows.Forms.TextBox()
        Me.btnLeftRawIngredients = New System.Windows.Forms.Button()
        Me.btnRightRawIngredients = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAllDishes
        '
        Me.lblAllDishes.AutoSize = True
        Me.lblAllDishes.Location = New System.Drawing.Point(55, 42)
        Me.lblAllDishes.Name = "lblAllDishes"
        Me.lblAllDishes.Size = New System.Drawing.Size(250, 37)
        Me.lblAllDishes.TabIndex = 0
        Me.lblAllDishes.Text = "List of all Dishes"
        '
        'lstDishes
        '
        Me.lstDishes.FormattingEnabled = True
        Me.lstDishes.ItemHeight = 37
        Me.lstDishes.Location = New System.Drawing.Point(62, 82)
        Me.lstDishes.Name = "lstDishes"
        Me.lstDishes.Size = New System.Drawing.Size(1625, 152)
        Me.lstDishes.TabIndex = 1
        '
        'lblPreppedItems
        '
        Me.lblPreppedItems.AutoSize = True
        Me.lblPreppedItems.Location = New System.Drawing.Point(55, 417)
        Me.lblPreppedItems.Name = "lblPreppedItems"
        Me.lblPreppedItems.Size = New System.Drawing.Size(461, 37)
        Me.lblPreppedItems.TabIndex = 2
        Me.lblPreppedItems.Text = "Prepped Items in Selected Dish"
        '
        'lstSelectedDishPreppedItems
        '
        Me.lstSelectedDishPreppedItems.FormattingEnabled = True
        Me.lstSelectedDishPreppedItems.ItemHeight = 37
        Me.lstSelectedDishPreppedItems.Location = New System.Drawing.Point(62, 477)
        Me.lstSelectedDishPreppedItems.Name = "lstSelectedDishPreppedItems"
        Me.lstSelectedDishPreppedItems.Size = New System.Drawing.Size(454, 189)
        Me.lstSelectedDishPreppedItems.TabIndex = 3
        '
        'btnAddNewDish
        '
        Me.btnAddNewDish.Enabled = False
        Me.btnAddNewDish.Location = New System.Drawing.Point(866, 275)
        Me.btnAddNewDish.Name = "btnAddNewDish"
        Me.btnAddNewDish.Size = New System.Drawing.Size(256, 126)
        Me.btnAddNewDish.TabIndex = 4
        Me.btnAddNewDish.Text = "Add New Dish"
        Me.btnAddNewDish.UseVisualStyleBackColor = True
        '
        'txtNewDish
        '
        Me.txtNewDish.Location = New System.Drawing.Point(1137, 317)
        Me.txtNewDish.Name = "txtNewDish"
        Me.txtNewDish.Size = New System.Drawing.Size(559, 44)
        Me.txtNewDish.TabIndex = 5
        '
        'lblAllPreppedItems
        '
        Me.lblAllPreppedItems.AutoSize = True
        Me.lblAllPreppedItems.Location = New System.Drawing.Point(859, 417)
        Me.lblAllPreppedItems.Name = "lblAllPreppedItems"
        Me.lblAllPreppedItems.Size = New System.Drawing.Size(359, 37)
        Me.lblAllPreppedItems.TabIndex = 6
        Me.lblAllPreppedItems.Text = "List of all Prepped Items"
        '
        'lstAllPreppedItems
        '
        Me.lstAllPreppedItems.FormattingEnabled = True
        Me.lstAllPreppedItems.ItemHeight = 37
        Me.lstAllPreppedItems.Location = New System.Drawing.Point(866, 468)
        Me.lstAllPreppedItems.MultiColumn = True
        Me.lstAllPreppedItems.Name = "lstAllPreppedItems"
        Me.lstAllPreppedItems.Size = New System.Drawing.Size(454, 189)
        Me.lstAllPreppedItems.TabIndex = 7
        '
        'btnLeftPreppedItems
        '
        Me.btnLeftPreppedItems.Location = New System.Drawing.Point(609, 477)
        Me.btnLeftPreppedItems.Name = "btnLeftPreppedItems"
        Me.btnLeftPreppedItems.Size = New System.Drawing.Size(157, 58)
        Me.btnLeftPreppedItems.TabIndex = 8
        Me.btnLeftPreppedItems.Text = "<--"
        Me.btnLeftPreppedItems.UseVisualStyleBackColor = True
        '
        'btnRightPreppedItems
        '
        Me.btnRightPreppedItems.Location = New System.Drawing.Point(609, 608)
        Me.btnRightPreppedItems.Name = "btnRightPreppedItems"
        Me.btnRightPreppedItems.Size = New System.Drawing.Size(157, 58)
        Me.btnRightPreppedItems.TabIndex = 9
        Me.btnRightPreppedItems.Text = "-->"
        Me.btnRightPreppedItems.UseVisualStyleBackColor = True
        '
        'btnAddNewPreppedItems
        '
        Me.btnAddNewPreppedItems.Enabled = False
        Me.btnAddNewPreppedItems.Location = New System.Drawing.Point(866, 697)
        Me.btnAddNewPreppedItems.Name = "btnAddNewPreppedItems"
        Me.btnAddNewPreppedItems.Size = New System.Drawing.Size(256, 126)
        Me.btnAddNewPreppedItems.TabIndex = 10
        Me.btnAddNewPreppedItems.Text = "Add New Prepped Item"
        Me.btnAddNewPreppedItems.UseVisualStyleBackColor = True
        '
        'txtNewPreppedItem
        '
        Me.txtNewPreppedItem.Location = New System.Drawing.Point(1137, 739)
        Me.txtNewPreppedItem.Name = "txtNewPreppedItem"
        Me.txtNewPreppedItem.Size = New System.Drawing.Size(559, 44)
        Me.txtNewPreppedItem.TabIndex = 11
        '
        'lblRawIngri
        '
        Me.lblRawIngri.AutoSize = True
        Me.lblRawIngri.Location = New System.Drawing.Point(55, 860)
        Me.lblRawIngri.Name = "lblRawIngri"
        Me.lblRawIngri.Size = New System.Drawing.Size(610, 37)
        Me.lblRawIngri.TabIndex = 12
        Me.lblRawIngri.Text = "Raw Ingredients in Selected Prepped Item"
        '
        'lstSelectedDishRawIngredients
        '
        Me.lstSelectedDishRawIngredients.FormattingEnabled = True
        Me.lstSelectedDishRawIngredients.ItemHeight = 37
        Me.lstSelectedDishRawIngredients.Location = New System.Drawing.Point(62, 919)
        Me.lstSelectedDishRawIngredients.Name = "lstSelectedDishRawIngredients"
        Me.lstSelectedDishRawIngredients.Size = New System.Drawing.Size(454, 189)
        Me.lstSelectedDishRawIngredients.TabIndex = 13
        '
        'lblAllIngri
        '
        Me.lblAllIngri.AutoSize = True
        Me.lblAllIngri.Location = New System.Drawing.Point(859, 860)
        Me.lblAllIngri.Name = "lblAllIngri"
        Me.lblAllIngri.Size = New System.Drawing.Size(382, 37)
        Me.lblAllIngri.TabIndex = 14
        Me.lblAllIngri.Text = "List of all Raw Ingredients"
        '
        'lstAllRawIngridents
        '
        Me.lstAllRawIngridents.FormattingEnabled = True
        Me.lstAllRawIngridents.ItemHeight = 37
        Me.lstAllRawIngridents.Location = New System.Drawing.Point(866, 919)
        Me.lstAllRawIngridents.Name = "lstAllRawIngridents"
        Me.lstAllRawIngridents.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstAllRawIngridents.Size = New System.Drawing.Size(454, 189)
        Me.lstAllRawIngridents.TabIndex = 15
        '
        'btnAddNewRawIngredients
        '
        Me.btnAddNewRawIngredients.Enabled = False
        Me.btnAddNewRawIngredients.Location = New System.Drawing.Point(866, 1128)
        Me.btnAddNewRawIngredients.Name = "btnAddNewRawIngredients"
        Me.btnAddNewRawIngredients.Size = New System.Drawing.Size(221, 126)
        Me.btnAddNewRawIngredients.TabIndex = 16
        Me.btnAddNewRawIngredients.Text = "Add New Raw Ing"
        Me.btnAddNewRawIngredients.UseVisualStyleBackColor = True
        '
        'txtNewRawIngredient
        '
        Me.txtNewRawIngredient.Location = New System.Drawing.Point(1137, 1170)
        Me.txtNewRawIngredient.Name = "txtNewRawIngredient"
        Me.txtNewRawIngredient.Size = New System.Drawing.Size(559, 44)
        Me.txtNewRawIngredient.TabIndex = 17
        '
        'btnLeftRawIngredients
        '
        Me.btnLeftRawIngredients.Location = New System.Drawing.Point(609, 919)
        Me.btnLeftRawIngredients.Name = "btnLeftRawIngredients"
        Me.btnLeftRawIngredients.Size = New System.Drawing.Size(157, 58)
        Me.btnLeftRawIngredients.TabIndex = 18
        Me.btnLeftRawIngredients.Text = "<--"
        Me.btnLeftRawIngredients.UseVisualStyleBackColor = True
        '
        'btnRightRawIngredients
        '
        Me.btnRightRawIngredients.Location = New System.Drawing.Point(609, 1050)
        Me.btnRightRawIngredients.Name = "btnRightRawIngredients"
        Me.btnRightRawIngredients.Size = New System.Drawing.Size(157, 58)
        Me.btnRightRawIngredients.TabIndex = 19
        Me.btnRightRawIngredients.Text = "-->"
        Me.btnRightRawIngredients.UseVisualStyleBackColor = True
        '
        'frmAssign_4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1753, 1392)
        Me.Controls.Add(Me.btnRightRawIngredients)
        Me.Controls.Add(Me.btnLeftRawIngredients)
        Me.Controls.Add(Me.txtNewRawIngredient)
        Me.Controls.Add(Me.btnAddNewRawIngredients)
        Me.Controls.Add(Me.lstAllRawIngridents)
        Me.Controls.Add(Me.lblAllIngri)
        Me.Controls.Add(Me.lstSelectedDishRawIngredients)
        Me.Controls.Add(Me.lblRawIngri)
        Me.Controls.Add(Me.txtNewPreppedItem)
        Me.Controls.Add(Me.btnAddNewPreppedItems)
        Me.Controls.Add(Me.btnRightPreppedItems)
        Me.Controls.Add(Me.btnLeftPreppedItems)
        Me.Controls.Add(Me.lstAllPreppedItems)
        Me.Controls.Add(Me.lblAllPreppedItems)
        Me.Controls.Add(Me.txtNewDish)
        Me.Controls.Add(Me.btnAddNewDish)
        Me.Controls.Add(Me.lstSelectedDishPreppedItems)
        Me.Controls.Add(Me.lblPreppedItems)
        Me.Controls.Add(Me.lstDishes)
        Me.Controls.Add(Me.lblAllDishes)
        Me.Name = "frmAssign_4"
        Me.Text = "Chez SouSad"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAllDishes As Label
    Friend WithEvents lstDishes As ListBox
    Friend WithEvents lblPreppedItems As Label
    Friend WithEvents lstSelectedDishPreppedItems As ListBox
    Friend WithEvents btnAddNewDish As Button
    Friend WithEvents txtNewDish As TextBox
    Friend WithEvents lblAllPreppedItems As Label
    Friend WithEvents lstAllPreppedItems As ListBox
    Friend WithEvents btnLeftPreppedItems As Button
    Friend WithEvents btnRightPreppedItems As Button
    Friend WithEvents btnAddNewPreppedItems As Button
    Friend WithEvents txtNewPreppedItem As TextBox
    Friend WithEvents lblRawIngri As Label
    Friend WithEvents lstSelectedDishRawIngredients As ListBox
    Friend WithEvents lblAllIngri As Label
    Friend WithEvents lstAllRawIngridents As ListBox
    Friend WithEvents btnAddNewRawIngredients As Button
    Friend WithEvents txtNewRawIngredient As TextBox
    Friend WithEvents btnLeftRawIngredients As Button
    Friend WithEvents btnRightRawIngredients As Button
End Class
