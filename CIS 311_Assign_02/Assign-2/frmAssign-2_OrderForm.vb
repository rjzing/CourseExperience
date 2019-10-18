'------------------------------------------------------------
'-                File Name : frmAssign-2_OrderForm.vb      - 
'-                Part of Project: Assign2                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/05/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user will input their names and choose options to add to -
'- fleet vehicles from Kustom Karz and submit their order   -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to interact with an orderform  -
'- and choose a form factor, quantity, drivetrain, and      -
'- options for their fleet of cars manufactured by Kustom   -
'- Karz and they can change their order after viewing their -
'- invoice if they made a mistake. The user can only exit   - 
'- the application from the invoice form. Since there is    -
'- only one button on the main order form everything is     -
'- controled from that button's click event.                - 
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- (None)                                                   –
'------------------------------------------------------------
Imports System.ComponentModel
Public Class Form1
    '------------------------------------------------------------
    '-         Subprogram Name: frmAssign2_Form1_Load           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is only used once, when the form         -
    '- actually loads in for the first time                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign2_Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rbnV_12.Checked = True
        lstType.Text = "Coupe"
        lstQTY.Text = "1"
    End Sub
    '------------------------------------------------------------
    '-             Subprogram Name: cmdPlaceOrder_Click         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- button to "place" order from the original form           –
    '------------------------------------------------------------
    '- Parameter Dictionary:               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dblDriveTrainTotal - total of drivetrain selected        - 
    '- dblOptionTotal - total price of options selected         -
    '- dblPerVehicle - price per single vehicle                 -
    '- dblQTY - the quantity selected                           -
    '- dblTotalOptions - the number of options selected         -
    '- dblTotalPrice - the grand total of order                 -
    '- dblTypeCost - form factor selected price                 -
    '- intArrOptionCounter - number of items in array of options-
    '- strArrOption - array of options selected                 -
    '- strCusName - the customer's name                         -
    '- strDrivetrainSelected - the name of drivetrain selected  -
    '- strHeaderLine - string with format of header line        -
    '- strLineSplit - string with the format of spliting lines  -
    '------------------------------------------------------------
    Private Sub cmdPlaceOrder_Click(sender As Object, e As EventArgs) Handles cmdPlaceOrder.Click
        Dim strCusName As String
        Dim dblQTY As Double
        Dim dblTypeCost As Double
        Dim dblTotalPrice As Double
        Dim dblOptionTotal As Double
        Dim dblTotalOptions As Double
        Dim dblDriveTrainTotal As Double
        Dim dblPerVehicle As Double
        Dim strArrOption(0) As String
        Dim intArrOptionCounter As Integer = -1
        Dim strDrivetrainSelected As String
        Dim strHeaderLine As String = "======================================================================="
        Dim strLineSplit As String = "--------------------------------------------------------------------"
        'end of declaring local variables
        Me.Visible = False
        strCusName = txtName.Text
        'start of if statements for form factor selected
        If (lstType.Text = "Coupe") Then
            dblTypeCost = 10000
        ElseIf (lstType.Text = "Sedan") Then
            dblTypeCost = 17000
        ElseIf (lstType.Text = "Luxury") Then
            dblTypeCost = 20000
        ElseIf (lstType.Text = "Sports Edition") Then
            dblTypeCost = 25000
        ElseIf (lstType.Text = "SUV") Then
            dblTypeCost = 27000
        End If
        'start of drivetrain if statements
        If (rbnV_12.Checked = True) Then
            dblDriveTrainTotal = 7500
            strDrivetrainSelected = "V-12"
        ElseIf (rbnV_8.Checked = True) Then
            dblDriveTrainTotal = 2500
            strDrivetrainSelected = "V-8"
        ElseIf (rbnV_6.Checked = True) Then
            dblDriveTrainTotal = 1000
            strDrivetrainSelected = "V-6"
        ElseIf (rbnV_4.Checked = True) Then
            dblDriveTrainTotal = 500
            strDrivetrainSelected = "V-4"
        ElseIf (rbnHybrid.Checked = True) Then
            dblDriveTrainTotal = 3000
            strDrivetrainSelected = "Hybrid"
        ElseIf (rbnElectric.Checked = True) Then
            dblDriveTrainTotal = 6000
            strDrivetrainSelected = "Electric"
        End If
        'start of if statements for options 
        If (chkLeatherSeats.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Leather Seats"
        End If
        If (chkAC.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Air Conditioning"
        End If
        If (chkBT.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Bluetooth"
        End If
        If (chkHeatedSeats.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Heated Seats"
        End If
        If (chkPremiumStereo.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Premium Stereo"
        End If
        If (chkGPS.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "GPS"
        End If
        If (chkRearDefrost.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Rear Defroster"
        End If
        If (chkCDMP3.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "CD/MP3 Connection"
        End If
        If (chkEnPa.Checked = True) Then
            dblTotalOptions += 1
            intArrOptionCounter += 1
            ReDim Preserve strArrOption(intArrOptionCounter)
            strArrOption(intArrOptionCounter) = "Entertainment Package"
        End If
        'end of if all if statements, start of final calculations and formating invoice 
        dblQTY = CInt(lstQTY.Text)
        dblOptionTotal = dblTotalOptions * 750
        frmAssign2_Invoice.lstInvoice.Items.Add(strHeaderLine)
        frmAssign2_Invoice.lstInvoice.Items.Add(vbTab & vbTab & vbTab & "         " & "Kustom Kars Order")
        frmAssign2_Invoice.lstInvoice.Items.Add(strHeaderLine)
        frmAssign2_Invoice.lstInvoice.Items.Add("Kustomer Name " & strCusName)
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        frmAssign2_Invoice.lstInvoice.Items.Add("There will be " & dblQTY & " car(s) Kustom built")
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        frmAssign2_Invoice.lstInvoice.Items.Add("Form Factor Selected: " & lstType.Text & " Price: " & FormatCurrency(dblTypeCost))
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        frmAssign2_Invoice.lstInvoice.Items.Add("Drivetrain selected: " & strDrivetrainSelected & " at " & FormatCurrency(dblDriveTrainTotal))
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        frmAssign2_Invoice.lstInvoice.Items.Add("Here are your options that you selected")

        For intPrintCounter As Integer = 0 To strArrOption.GetUpperBound(0)
            frmAssign2_Invoice.lstInvoice.Items.Add(vbTab & strArrOption(intPrintCounter))
        Next

        frmAssign2_Invoice.lstInvoice.Items.Add(dblTotalOptions & " options selected at a total of: " & FormatCurrency(dblOptionTotal))
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        frmAssign2_Invoice.lstInvoice.Items.Add("")
        dblPerVehicle = (dblOptionTotal + dblTypeCost + dblDriveTrainTotal)
        frmAssign2_Invoice.lstInvoice.Items.Add("Per vehicle total: " & vbTab & FormatCurrency(dblPerVehicle))
        frmAssign2_Invoice.lstInvoice.Items.Add(strLineSplit)
        dblTotalPrice = (dblPerVehicle * dblQTY)
        frmAssign2_Invoice.lstInvoice.Items.Add("Quantity ordered: " & vbTab & dblQTY)
        frmAssign2_Invoice.lstInvoice.Items.Add(strLineSplit)
        frmAssign2_Invoice.lstInvoice.Items.Add("Grand total: " & vbTab & FormatCurrency(dblTotalPrice))
        frmAssign2_Invoice.lstInvoice.Items.Add(strHeaderLine)
        frmAssign2_Invoice.ShowDialog()
        frmAssign2_Invoice.lstInvoice.Items.Clear()
    End Sub
    '------------------------------------------------------------
    '-                Subprogram Name: Form1_Closing            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the form is tried to  -
    '- be closed which doesn't allow it to actually be closed   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = True
        MessageBox.Show("Cannot close application from this screen, you can only exit from invoice screen")
    End Sub

End Class