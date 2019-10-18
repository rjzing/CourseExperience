<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrderReport
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
        Me.dgvReport = New System.Windows.Forms.DataGridView()
        Me.btnCustsWithOrders = New System.Windows.Forms.Button()
        Me.btnCustomers = New System.Windows.Forms.Button()
        Me.btnInventory = New System.Windows.Forms.Button()
        Me.btnOrderToProds = New System.Windows.Forms.Button()
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvReport
        '
        Me.dgvReport.AllowUserToAddRows = False
        Me.dgvReport.AllowUserToDeleteRows = False
        Me.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvReport.Location = New System.Drawing.Point(47, 12)
        Me.dgvReport.Name = "dgvReport"
        Me.dgvReport.ReadOnly = True
        Me.dgvReport.Size = New System.Drawing.Size(547, 346)
        Me.dgvReport.TabIndex = 0
        Me.dgvReport.TabStop = False
        '
        'btnCustsWithOrders
        '
        Me.btnCustsWithOrders.Location = New System.Drawing.Point(47, 429)
        Me.btnCustsWithOrders.Name = "btnCustsWithOrders"
        Me.btnCustsWithOrders.Size = New System.Drawing.Size(122, 48)
        Me.btnCustsWithOrders.TabIndex = 0
        Me.btnCustsWithOrders.Text = "Orders Start/End Times"
        Me.btnCustsWithOrders.UseVisualStyleBackColor = True
        '
        'btnCustomers
        '
        Me.btnCustomers.Location = New System.Drawing.Point(191, 429)
        Me.btnCustomers.Name = "btnCustomers"
        Me.btnCustomers.Size = New System.Drawing.Size(122, 48)
        Me.btnCustomers.TabIndex = 1
        Me.btnCustomers.Text = "Customers"
        Me.btnCustomers.UseVisualStyleBackColor = True
        '
        'btnInventory
        '
        Me.btnInventory.Location = New System.Drawing.Point(329, 429)
        Me.btnInventory.Name = "btnInventory"
        Me.btnInventory.Size = New System.Drawing.Size(122, 48)
        Me.btnInventory.TabIndex = 2
        Me.btnInventory.Text = "Inventory"
        Me.btnInventory.UseVisualStyleBackColor = True
        '
        'btnOrderToProds
        '
        Me.btnOrderToProds.Location = New System.Drawing.Point(472, 429)
        Me.btnOrderToProds.Name = "btnOrderToProds"
        Me.btnOrderToProds.Size = New System.Drawing.Size(122, 48)
        Me.btnOrderToProds.TabIndex = 3
        Me.btnOrderToProds.Text = "Order To Products"
        Me.btnOrderToProds.UseVisualStyleBackColor = True
        '
        'frmOrderReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(654, 525)
        Me.Controls.Add(Me.btnOrderToProds)
        Me.Controls.Add(Me.btnInventory)
        Me.Controls.Add(Me.btnCustomers)
        Me.Controls.Add(Me.btnCustsWithOrders)
        Me.Controls.Add(Me.dgvReport)
        Me.Name = "frmOrderReport"
        Me.Text = "Plastico Order Reports"
        CType(Me.dgvReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvReport As DataGridView
    Friend WithEvents btnCustsWithOrders As Button
    Friend WithEvents btnCustomers As Button
    Friend WithEvents btnInventory As Button
    Friend WithEvents btnOrderToProds As Button
End Class
