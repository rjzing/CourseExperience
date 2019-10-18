'------------------------------------------------------------
'-            File Name : frmAssign_01_Child.vb             - 
'-              Part of Project: Assign_01                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 09/06/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the mdi child source code             -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to create new mdi children to  -
'- input first name, last name, middle inital, quantity,    -
'- if there is any type of discount and what meal type the  -
'- user wants for their order                               -
'------------------------------------------------------------
'- Class/Global Variable Dictionary:                        -
'- (None)                                                   -
'------------------------------------------------------------
Public Class frmAssign_01_Child
    '------------------------------------------------------------
    '-          Subprogram Name: frmAssign_01_Child_Load        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program calls the clear values when a new child -
    '- is created by the parent                                 -          
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign_01_Child_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call clrVals()
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: mtxPhoneNumber_LostFocus        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the masked text box loses-
    '- focus, verifying that the mask is complete, if not it    -
    '- will keep the calculate button disabled and not let the  -
    '- user leave the control until the mask is validated       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mtxPhoneNumber_LostFocus(sender As Object, e As EventArgs) Handles mtxPhoneNumber.LostFocus
        If (mtxPhoneNumber.MaskCompleted = False) Then
            mtxPhoneNumber.Focus()
            btnCalculate.Enabled = False
        Else
            btnCalculate.Enabled = True
        End If
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: btnCalculate_Click           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when user hits calculate, it  -
    '- first checks if the quantity is a double, if not it will -
    '- prompt the user it is not a number, then it calls the sub-
    '- program to actually calculate all the order information  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dblQuantity - place holder to check if qty is a number   -
    '------------------------------------------------------------
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblQuantity As Double
        lstTotals.Visible = False
        If (txtLastName.Text = "" Or txtFirstName.Text = "" Or txtMiddleInitial.Text = "") Then
            MessageBox.Show("Please Fill Out All Fields")
            mtxPhoneNumber.ResetText()
        ElseIf Double.TryParse(txtQuantity.Text, dblQuantity) Then
            Call calc()
        Else
            MessageBox.Show("Please Enter a Number In The Quantity Text Box")
        End If
    End Sub

    '------------------------------------------------------------
    '-                  Subprogram Name: calc                   -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user hits the calc   -
    '- button, it calculates all the total order information    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- bolDiscount - bool to say if there is a discount needed  -
    '- dblDecimalPercent - converts percent to decimal value    -
    '- dblDiscount - place holder if discount is a number       -
    '- dblDiscountAmount - overall disount amount               -
    '- dblDiscountSubTotal - subtotal after discount is applied -
    '- dblQuantity - holds the qtytext entered by the user      -
    '- dblSubTotal - sub total if no discount is applied        -
    '- dblTaxAmount - tax money value                           -
    '- dblTotal - grand total after everything                  -
    '- strMealType - holds what meal type is selected           -
    '------------------------------------------------------------
    Public Sub calc()
        Dim bolDiscount As Boolean = False
        Dim dblDecimalPercent As Double
        Dim dblDiscount As Double
        Dim dblDiscountAmount As Double
        Dim dblDiscountSubTotal As Double
        Dim dblQuantity As Double
        Dim dblSubTotal As Double
        Dim dblTaxAmount As Double
        Dim dblTotal As Double
        Dim strMealType As String = ""
        dblQuantity = txtQuantity.Text
        If (rbnStandardMeal.Checked = True) Then
            dblSubTotal = dblQuantity * 8.5
            strMealType = "Standard"
            If Double.TryParse(txtDiscount.Text, dblDiscount) Then
                bolDiscount = True
                If (rbnDecimal.Checked = True) Then
                    dblDiscountAmount = dblSubTotal * txtDiscount.Text
                    dblDiscountSubTotal = dblSubTotal - (dblDiscountAmount)
                ElseIf (rbnPercentage.Checked = True) Then
                    dblDecimalPercent = txtDiscount.Text * 0.01
                    dblDiscountAmount = dblSubTotal * dblDecimalPercent
                    dblDiscountSubTotal = dblSubTotal - (dblDiscountAmount)
                End If
            End If
        ElseIf (rbnDeluxeMeal.Checked = True) Then
            dblSubTotal = dblQuantity * 10.0
            strMealType = "Deluxe"
            If Double.TryParse(txtDiscount.Text, dblDiscount) Then
                bolDiscount = True
                If (rbnDecimal.Checked = True) Then
                    dblDiscountAmount = dblSubTotal * txtDiscount.Text
                    dblDiscountSubTotal = dblSubTotal - (dblDiscountAmount)
                ElseIf (rbnPercentage.Checked = True) Then
                    dblDecimalPercent = txtDiscount.Text * 0.01
                    dblDiscountAmount = dblSubTotal * dblDecimalPercent
                    dblDiscountSubTotal = dblSubTotal - (dblDiscountAmount)
                End If
            End If
        End If
        If (rbnPercentage.Checked = False And rbnDecimal.Checked = False And rbnStandardMeal.Checked = True) Then
            dblDiscountSubTotal = dblSubTotal
        ElseIf (rbnPercentage.Checked = False And rbnDecimal.Checked = False And rbnDeluxeMeal.Checked = True) Then
            dblDiscountSubTotal = dblSubTotal
        End If
        If (txtDiscount.Text <> "" And rbnDecimal.Checked = False And rbnPercentage.Checked = False) Then
            MessageBox.Show("You Have Entered A Discount Without Selecting A Discount Type")
        Else
            dblTaxAmount = dblDiscountSubTotal * 0.06
            dblTotal = (dblTaxAmount) + dblDiscountSubTotal
            Call writeTotals(strMealType, dblQuantity, Math.Round(dblSubTotal, 2), Math.Round(dblDiscountSubTotal, 2), Math.Round(dblDiscountAmount, 2), Math.Round(dblTaxAmount, 2), Math.Round(dblTotal, 2), bolDiscount)
        End If
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: writeTotals               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called after all calculations are    -
    '- done and writes those values to the listbox with invoice -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- bolDiscount - bool to say if there is a discount needed  -
    '- dblDecimalPercent - converts percent to decimal value    -
    '- dblDiscount - place holder if discount is a number       -
    '- dblDiscountAmount - overall disount amount               -
    '- dblDiscountSubTotal - subtotal after discount is applied -
    '- dblQuantity - holds the qtytext entered by the user      -
    '- dblSubTotal - sub total if no discount is applied        -
    '- dblTaxAmount - tax money value                           -
    '- dblTotal - grand total after everything                  -
    '- strMealType - holds what meal type is selected           -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub writeTotals(strMealType As String, dblQuantity As Double, dblSubTotal As Double, dblDiscountSubTotal As Double, dblDiscountAmount As Double, dblTaxAmount As Double, dblTotal As Double, bolDiscount As Boolean)
        lstTotals.Items.Clear()
        lstTotals.Visible = True
        lstTotals.Items.Add(StrDup(57, "="))
        lstTotals.Items.Add(vbTab & vbTab & vbTab & "Big J Catering")
        lstTotals.Items.Add(StrDup(57, "="))
        lstTotals.Items.Add("Customer: " & vbTab & txtLastName.Text & ", " & txtFirstName.Text & ", " & txtMiddleInitial.Text)
        lstTotals.Items.Add("Phone Number: " & vbTab & mtxPhoneNumber.Text)
        lstTotals.Items.Add(vbTab & StrDup(80, "-"))
        lstTotals.Items.Add("Meal Type: " & strMealType & " at " & dblQuantity & " Dishes")
        lstTotals.Items.Add(vbTab & StrDup(80, "-"))
        If (bolDiscount = True) Then
            lstTotals.Items.Add("Sub Total Before Discount: " & vbTab & dblSubTotal.ToString("c"))
            lstTotals.Items.Add("Discount Amount: " & vbTab & vbTab & dblDiscountAmount.ToString("c"))
            lstTotals.Items.Add("Sub Total After Discount: " & vbTab & dblDiscountSubTotal.ToString("c"))
            lstTotals.Items.Add("Tax: " & vbTab & vbTab & vbTab & dblTaxAmount.ToString("c"))
            lstTotals.Items.Add(vbTab & StrDup(80, "-"))
            lstTotals.Items.Add("Order Total: " & vbTab & vbTab & dblTotal.ToString("c"))
        Else
            lstTotals.Items.Add("Sub Total: " & vbTab & dblDiscountSubTotal.ToString("c"))
            lstTotals.Items.Add("Tax: " & vbTab & vbTab & dblTaxAmount.ToString("c"))
            lstTotals.Items.Add(vbTab & StrDup(80, "-"))
            lstTotals.Items.Add("Order Total: " & vbTab & dblTotal.ToString("c"))
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnReset_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when user hits reset, calling -
    '- the clrVals subprogram clearing the form                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dblQuantity - place holder to check if qty is a number   -
    '------------------------------------------------------------
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call clrVals()
    End Sub

    '------------------------------------------------------------
    '-                 Subprogram Name: clrVals                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user creates a new   -
    '- child and also hits the reset values button, clearing all-
    '- inputs on the orderform                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- frmNewOrderFrm - the new child form                      -
    '------------------------------------------------------------
    Public Sub clrVals()
        rbnStandardMeal.Checked = True
        btnCalculate.Enabled = False
        lstTotals.Visible = False
        txtDiscount.Text = ""
        txtFirstName.Text = ""
        txtLastName.Text = ""
        txtQuantity.Text = ""
        txtMiddleInitial.Text = ""
        lstTotals.ResetText()
        mtxPhoneNumber.ResetText()
        rbnDecimal.Checked = False
        rbnPercentage.Checked = False
    End Sub
End Class