<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.grbDriveTrain = New System.Windows.Forms.GroupBox()
        Me.rbnElectric = New System.Windows.Forms.RadioButton()
        Me.rbnHybrid = New System.Windows.Forms.RadioButton()
        Me.rbnV_4 = New System.Windows.Forms.RadioButton()
        Me.rbnV_6 = New System.Windows.Forms.RadioButton()
        Me.rbnV_8 = New System.Windows.Forms.RadioButton()
        Me.rbnV_12 = New System.Windows.Forms.RadioButton()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblType = New System.Windows.Forms.Label()
        Me.lblQTY = New System.Windows.Forms.Label()
        Me.grbOptions = New System.Windows.Forms.GroupBox()
        Me.chkEnPa = New System.Windows.Forms.CheckBox()
        Me.chkCDMP3 = New System.Windows.Forms.CheckBox()
        Me.chkRearDefrost = New System.Windows.Forms.CheckBox()
        Me.chkGPS = New System.Windows.Forms.CheckBox()
        Me.chkPremiumStereo = New System.Windows.Forms.CheckBox()
        Me.chkHeatedSeats = New System.Windows.Forms.CheckBox()
        Me.chkBT = New System.Windows.Forms.CheckBox()
        Me.chkAC = New System.Windows.Forms.CheckBox()
        Me.chkLeatherSeats = New System.Windows.Forms.CheckBox()
        Me.cmdPlaceOrder = New System.Windows.Forms.Button()
        Me.lstType = New System.Windows.Forms.ListBox()
        Me.lstQTY = New System.Windows.Forms.ListBox()
        Me.grbDriveTrain.SuspendLayout()
        Me.grbOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbDriveTrain
        '
        Me.grbDriveTrain.Controls.Add(Me.rbnElectric)
        Me.grbDriveTrain.Controls.Add(Me.rbnHybrid)
        Me.grbDriveTrain.Controls.Add(Me.rbnV_4)
        Me.grbDriveTrain.Controls.Add(Me.rbnV_6)
        Me.grbDriveTrain.Controls.Add(Me.rbnV_8)
        Me.grbDriveTrain.Controls.Add(Me.rbnV_12)
        Me.grbDriveTrain.Location = New System.Drawing.Point(103, 254)
        Me.grbDriveTrain.Name = "grbDriveTrain"
        Me.grbDriveTrain.Size = New System.Drawing.Size(1277, 146)
        Me.grbDriveTrain.TabIndex = 3
        Me.grbDriveTrain.TabStop = False
        Me.grbDriveTrain.Text = "Drive Train Selection:"
        '
        'rbnElectric
        '
        Me.rbnElectric.AutoSize = True
        Me.rbnElectric.Location = New System.Drawing.Point(1054, 66)
        Me.rbnElectric.Name = "rbnElectric"
        Me.rbnElectric.Size = New System.Drawing.Size(165, 41)
        Me.rbnElectric.TabIndex = 6
        Me.rbnElectric.TabStop = True
        Me.rbnElectric.Text = "Electric"
        Me.rbnElectric.UseVisualStyleBackColor = True
        '
        'rbnHybrid
        '
        Me.rbnHybrid.AutoSize = True
        Me.rbnHybrid.Location = New System.Drawing.Point(814, 66)
        Me.rbnHybrid.Name = "rbnHybrid"
        Me.rbnHybrid.Size = New System.Drawing.Size(153, 41)
        Me.rbnHybrid.TabIndex = 5
        Me.rbnHybrid.TabStop = True
        Me.rbnHybrid.Text = "Hybrid"
        Me.rbnHybrid.UseVisualStyleBackColor = True
        '
        'rbnV_4
        '
        Me.rbnV_4.AutoSize = True
        Me.rbnV_4.Location = New System.Drawing.Point(619, 66)
        Me.rbnV_4.Name = "rbnV_4"
        Me.rbnV_4.Size = New System.Drawing.Size(111, 41)
        Me.rbnV_4.TabIndex = 4
        Me.rbnV_4.TabStop = True
        Me.rbnV_4.Text = "V-4"
        Me.rbnV_4.UseVisualStyleBackColor = True
        '
        'rbnV_6
        '
        Me.rbnV_6.AutoSize = True
        Me.rbnV_6.Location = New System.Drawing.Point(406, 66)
        Me.rbnV_6.Name = "rbnV_6"
        Me.rbnV_6.Size = New System.Drawing.Size(111, 41)
        Me.rbnV_6.TabIndex = 3
        Me.rbnV_6.TabStop = True
        Me.rbnV_6.Text = "V-6"
        Me.rbnV_6.UseVisualStyleBackColor = True
        '
        'rbnV_8
        '
        Me.rbnV_8.AutoSize = True
        Me.rbnV_8.Location = New System.Drawing.Point(219, 66)
        Me.rbnV_8.Name = "rbnV_8"
        Me.rbnV_8.Size = New System.Drawing.Size(111, 41)
        Me.rbnV_8.TabIndex = 2
        Me.rbnV_8.TabStop = True
        Me.rbnV_8.Text = "V-8"
        Me.rbnV_8.UseVisualStyleBackColor = True
        '
        'rbnV_12
        '
        Me.rbnV_12.AutoSize = True
        Me.rbnV_12.Location = New System.Drawing.Point(19, 66)
        Me.rbnV_12.Name = "rbnV_12"
        Me.rbnV_12.Size = New System.Drawing.Size(127, 41)
        Me.rbnV_12.TabIndex = 1
        Me.rbnV_12.TabStop = True
        Me.rbnV_12.Text = "V-12"
        Me.rbnV_12.UseVisualStyleBackColor = True
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(96, 37)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(269, 37)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Customer Name: "
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(362, 37)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(1018, 44)
        Me.txtName.TabIndex = 0
        '
        'lblType
        '
        Me.lblType.AutoSize = True
        Me.lblType.Location = New System.Drawing.Point(181, 160)
        Me.lblType.Name = "lblType"
        Me.lblType.Size = New System.Drawing.Size(157, 37)
        Me.lblType.TabIndex = 4
        Me.lblType.Text = "Car Type:"
        '
        'lblQTY
        '
        Me.lblQTY.AutoSize = True
        Me.lblQTY.Location = New System.Drawing.Point(1073, 155)
        Me.lblQTY.Name = "lblQTY"
        Me.lblQTY.Size = New System.Drawing.Size(145, 37)
        Me.lblQTY.TabIndex = 6
        Me.lblQTY.Text = "Quantity:"
        '
        'grbOptions
        '
        Me.grbOptions.Controls.Add(Me.chkEnPa)
        Me.grbOptions.Controls.Add(Me.chkCDMP3)
        Me.grbOptions.Controls.Add(Me.chkRearDefrost)
        Me.grbOptions.Controls.Add(Me.chkGPS)
        Me.grbOptions.Controls.Add(Me.chkPremiumStereo)
        Me.grbOptions.Controls.Add(Me.chkHeatedSeats)
        Me.grbOptions.Controls.Add(Me.chkBT)
        Me.grbOptions.Controls.Add(Me.chkAC)
        Me.grbOptions.Controls.Add(Me.chkLeatherSeats)
        Me.grbOptions.Location = New System.Drawing.Point(103, 423)
        Me.grbOptions.Name = "grbOptions"
        Me.grbOptions.Size = New System.Drawing.Size(1277, 501)
        Me.grbOptions.TabIndex = 7
        Me.grbOptions.TabStop = False
        Me.grbOptions.Text = "Options:"
        '
        'chkEnPa
        '
        Me.chkEnPa.AutoSize = True
        Me.chkEnPa.Location = New System.Drawing.Point(835, 322)
        Me.chkEnPa.Name = "chkEnPa"
        Me.chkEnPa.Size = New System.Drawing.Size(395, 41)
        Me.chkEnPa.TabIndex = 12
        Me.chkEnPa.Text = "Entertainment Package"
        Me.chkEnPa.UseVisualStyleBackColor = True
        '
        'chkCDMP3
        '
        Me.chkCDMP3.AutoSize = True
        Me.chkCDMP3.Location = New System.Drawing.Point(406, 322)
        Me.chkCDMP3.Name = "chkCDMP3"
        Me.chkCDMP3.Size = New System.Drawing.Size(354, 41)
        Me.chkCDMP3.TabIndex = 11
        Me.chkCDMP3.Text = "CD/MP3 Connection"
        Me.chkCDMP3.UseVisualStyleBackColor = True
        '
        'chkRearDefrost
        '
        Me.chkRearDefrost.AutoSize = True
        Me.chkRearDefrost.Location = New System.Drawing.Point(19, 322)
        Me.chkRearDefrost.Name = "chkRearDefrost"
        Me.chkRearDefrost.Size = New System.Drawing.Size(271, 41)
        Me.chkRearDefrost.TabIndex = 10
        Me.chkRearDefrost.Text = "Rear Defroster"
        Me.chkRearDefrost.UseVisualStyleBackColor = True
        '
        'chkGPS
        '
        Me.chkGPS.AutoSize = True
        Me.chkGPS.Location = New System.Drawing.Point(835, 207)
        Me.chkGPS.Name = "chkGPS"
        Me.chkGPS.Size = New System.Drawing.Size(130, 41)
        Me.chkGPS.TabIndex = 9
        Me.chkGPS.Text = "GPS"
        Me.chkGPS.UseVisualStyleBackColor = True
        '
        'chkPremiumStereo
        '
        Me.chkPremiumStereo.AutoSize = True
        Me.chkPremiumStereo.Location = New System.Drawing.Point(406, 207)
        Me.chkPremiumStereo.Name = "chkPremiumStereo"
        Me.chkPremiumStereo.Size = New System.Drawing.Size(293, 41)
        Me.chkPremiumStereo.TabIndex = 8
        Me.chkPremiumStereo.Text = "Premium Stereo"
        Me.chkPremiumStereo.UseVisualStyleBackColor = True
        '
        'chkHeatedSeats
        '
        Me.chkHeatedSeats.AutoSize = True
        Me.chkHeatedSeats.Location = New System.Drawing.Point(19, 207)
        Me.chkHeatedSeats.Name = "chkHeatedSeats"
        Me.chkHeatedSeats.Size = New System.Drawing.Size(255, 41)
        Me.chkHeatedSeats.TabIndex = 7
        Me.chkHeatedSeats.Text = "Heated Seats"
        Me.chkHeatedSeats.UseVisualStyleBackColor = True
        '
        'chkBT
        '
        Me.chkBT.AutoSize = True
        Me.chkBT.Location = New System.Drawing.Point(835, 87)
        Me.chkBT.Name = "chkBT"
        Me.chkBT.Size = New System.Drawing.Size(198, 41)
        Me.chkBT.TabIndex = 6
        Me.chkBT.Text = "Bluetooth"
        Me.chkBT.UseVisualStyleBackColor = True
        '
        'chkAC
        '
        Me.chkAC.AutoSize = True
        Me.chkAC.Location = New System.Drawing.Point(406, 87)
        Me.chkAC.Name = "chkAC"
        Me.chkAC.Size = New System.Drawing.Size(291, 41)
        Me.chkAC.TabIndex = 5
        Me.chkAC.Text = "Air Conditioning"
        Me.chkAC.UseVisualStyleBackColor = True
        '
        'chkLeatherSeats
        '
        Me.chkLeatherSeats.AutoSize = True
        Me.chkLeatherSeats.Location = New System.Drawing.Point(19, 87)
        Me.chkLeatherSeats.Name = "chkLeatherSeats"
        Me.chkLeatherSeats.Size = New System.Drawing.Size(261, 41)
        Me.chkLeatherSeats.TabIndex = 4
        Me.chkLeatherSeats.Text = "Leather Seats"
        Me.chkLeatherSeats.UseVisualStyleBackColor = True
        '
        'cmdPlaceOrder
        '
        Me.cmdPlaceOrder.Location = New System.Drawing.Point(402, 961)
        Me.cmdPlaceOrder.Name = "cmdPlaceOrder"
        Me.cmdPlaceOrder.Size = New System.Drawing.Size(431, 86)
        Me.cmdPlaceOrder.TabIndex = 13
        Me.cmdPlaceOrder.Text = "Place Car(s) Order"
        Me.cmdPlaceOrder.UseVisualStyleBackColor = True
        '
        'lstType
        '
        Me.lstType.AllowDrop = True
        Me.lstType.FormattingEnabled = True
        Me.lstType.ItemHeight = 37
        Me.lstType.Items.AddRange(New Object() {"Coupe", "Sedan", "Luxury", "Sports Edition", "SUV"})
        Me.lstType.Location = New System.Drawing.Point(362, 160)
        Me.lstType.Name = "lstType"
        Me.lstType.Size = New System.Drawing.Size(278, 78)
        Me.lstType.TabIndex = 2
        '
        'lstQTY
        '
        Me.lstQTY.AllowDrop = True
        Me.lstQTY.ItemHeight = 37
        Me.lstQTY.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "15", "20", "25", "30", "35", "40", "45", "50"})
        Me.lstQTY.Location = New System.Drawing.Point(1248, 160)
        Me.lstQTY.Name = "lstQTY"
        Me.lstQTY.Size = New System.Drawing.Size(132, 78)
        Me.lstQTY.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(19.0!, 37.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1478, 1126)
        Me.Controls.Add(Me.lstQTY)
        Me.Controls.Add(Me.lstType)
        Me.Controls.Add(Me.cmdPlaceOrder)
        Me.Controls.Add(Me.grbOptions)
        Me.Controls.Add(Me.lblQTY)
        Me.Controls.Add(Me.lblType)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.grbDriveTrain)
        Me.Name = "Form1"
        Me.Text = "Kustom Karz Order Form"
        Me.grbDriveTrain.ResumeLayout(False)
        Me.grbDriveTrain.PerformLayout()
        Me.grbOptions.ResumeLayout(False)
        Me.grbOptions.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grbDriveTrain As GroupBox
    Friend WithEvents rbnElectric As RadioButton
    Friend WithEvents rbnHybrid As RadioButton
    Friend WithEvents rbnV_4 As RadioButton
    Friend WithEvents rbnV_6 As RadioButton
    Friend WithEvents rbnV_8 As RadioButton
    Friend WithEvents rbnV_12 As RadioButton
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblType As Label
    Friend WithEvents lblQTY As Label
    Friend WithEvents grbOptions As GroupBox
    Friend WithEvents chkEnPa As CheckBox
    Friend WithEvents chkCDMP3 As CheckBox
    Friend WithEvents chkRearDefrost As CheckBox
    Friend WithEvents chkGPS As CheckBox
    Friend WithEvents chkPremiumStereo As CheckBox
    Friend WithEvents chkHeatedSeats As CheckBox
    Friend WithEvents chkBT As CheckBox
    Friend WithEvents chkAC As CheckBox
    Friend WithEvents chkLeatherSeats As CheckBox
    Friend WithEvents cmdPlaceOrder As Button

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Friend WithEvents lstType As ListBox
    Friend WithEvents lstQTY As ListBox
End Class
