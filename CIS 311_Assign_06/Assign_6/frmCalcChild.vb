'------------------------------------------------------------
'-               File Name : frmCalcChild.vb                - 
'-                Part of Project: Assign6                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 03/21/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the mdi child source code             -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to create new mdi children to  -
'- convert values from binary, decimal, or hex. This is the -
'- bulk code, which actually allows the user to input values-
'- in binary, decimal, or hex; it then converts the value   -
'- in the other 2 bases that weren't entered. It allows the -
'- user to perform logical operations AND, OR, XOR on the 2 -
'- values and NOT value 1. The results are added to their   -
'- respective result boxes.                                 -
'------------------------------------------------------------
'- Class/Global Variable Dictionary:                        -
'- gintTxtBoxClick - holds the int value of textbox clicked -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmCalcChild
    Dim gintTxtBoxClick As Integer = 0

    '------------------------------------------------------------
    '-            Subprogram Name: calcChild_Load               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the default 0 values to the result -
    '- at load time                                             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub calcChild_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtResBin.Text = StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " " & StrDup(4, "0") & " "
        txtResDec.Text = 0
        txtResHex.Text = 0
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal1Bin_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal1Bin_Click(sender As Object, e As EventArgs) Handles txtVal1Bin.Click
        Call clearVal1()
        gintTxtBoxClick = 0
        Call binBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal2Bin_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal2Bin_Click(sender As Object, e As EventArgs) Handles txtVal2Bin.Click
        Call clearVal2()
        gintTxtBoxClick = 1
        Call binBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal1Dec_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal1Dec_Click(sender As Object, e As EventArgs) Handles txtVal1Dec.Click
        Call clearVal1()
        gintTxtBoxClick = 2
        Call decBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal2Dec_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal2Dec_Click(sender As Object, e As EventArgs) Handles txtVal2Dec.Click
        Call clearVal2()
        gintTxtBoxClick = 3
        Call decBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal1Hex_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal1Hex_Click(sender As Object, e As EventArgs) Handles txtVal1Hex.Click
        Call clearVal1()
        gintTxtBoxClick = 4
        Call hexBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtVal2Hex_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick   -
    '- to keep track of what text box should hold the user's    -
    '- input from the onscreen keyboard                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtVal2Hex_Click(sender As Object, e As EventArgs) Handles txtVal2Hex.Click
        Call clearVal2()
        gintTxtBoxClick = 5
        Call hexBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtResBin_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick.  -
    '- In this case, the user cannot enter values to the result -
    '- text boxes, so I made an error messagebox associated with-
    '- gintTxtBoxClick = 6 saying nothing can be inputed        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtResBin_Click(sender As Object, e As EventArgs) Handles txtResBin.Click
        gintTxtBoxClick = 6
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtResDec_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick.  -
    '- In this case, the user cannot enter values to the result -
    '- text boxes, so I made an error messagebox associated with-
    '- gintTxtBoxClick = 6 saying nothing can be inputed        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtResDec_Click(sender As Object, e As EventArgs) Handles txtResDec.Click
        gintTxtBoxClick = 6
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: txtResHex_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the int value to gintTxtBoxClick.  -
    '- In this case, the user cannot enter values to the result -
    '- text boxes, so I made an error messagebox associated with-
    '- gintTxtBoxClick = 6 saying nothing can be inputed        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub txtResHex_Click(sender As Object, e As EventArgs) Handles txtResHex.Click
        gintTxtBoxClick = 6
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn0_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 0 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If (gintTxtBoxClick = 0) Then
            If (txtVal1Bin.TextLength <= 32) Then
                txtVal1Bin.AppendText(0)
            Else
                MessageBox.Show("Max length passed")
            End If
        ElseIf (gintTxtBoxClick = 1) Then
            If (txtVal2Bin.TextLength <= 32) Then
                txtVal2Bin.AppendText(0)
            Else
                MessageBox.Show("Max length passed")
            End If
        ElseIf (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(0)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(0)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(0)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(0)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn1_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 1 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If (gintTxtBoxClick = 0) Then
            If (txtVal1Bin.TextLength <= 32) Then
                txtVal1Bin.AppendText(1)
            Else
                MessageBox.Show("Max length reached")
            End If
        ElseIf (gintTxtBoxClick = 1) Then
            If (txtVal2Bin.TextLength <= 32) Then
                txtVal2Bin.AppendText(1)
            Else
                MessageBox.Show("Max length reached")
            End If
        ElseIf (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(1)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(1)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(1)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(1)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn2_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 2 to the respective text-
    '- box, using gintTxtBoxClick, since binary is 0 & 1, the   -
    '- text box no longer takes a value                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(2)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(2)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(2)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(2)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn3_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 3 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(3)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(3)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(3)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(3)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn4_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 4 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(4)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(4)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(4)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(4)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn5_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 5 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(5)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(5)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(5)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(5)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn6_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 6 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(6)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(6)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(6)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(6)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn7_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 7 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(7)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(7)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(7)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(7)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn8_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 8 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(8)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(8)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(8)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(8)
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn9_Click                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the number 9 to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If (gintTxtBoxClick = 2) Then
            txtVal1Dec.AppendText(9)
        ElseIf (gintTxtBoxClick = 3) Then
            txtVal2Dec.AppendText(9)
        ElseIf (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText(9)
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText(9)
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexA_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter A to the respective text-
    '- box, using gintTxtBoxClick, since A is only valid for hex-
    '- it's only adding to the hex text boxes                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexA_Click(sender As Object, e As EventArgs) Handles btnHexA.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("A")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("A")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexB_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter B to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexB_Click(sender As Object, e As EventArgs) Handles btnHexB.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("B")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("B")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexC_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter C to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexC_Click(sender As Object, e As EventArgs) Handles btnHexC.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("C")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("C")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexD_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter D to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexD_Click(sender As Object, e As EventArgs) Handles btnHexD.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("D")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("D")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexE_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter E to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexE_Click(sender As Object, e As EventArgs) Handles btnHexE.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("E")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("E")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnHexF_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds the letter F to the respective text-
    '- box, using gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnHexF_Click(sender As Object, e As EventArgs) Handles btnHexF.Click
        If (gintTxtBoxClick = 4) Then
            txtVal1Hex.AppendText("F")
        ElseIf (gintTxtBoxClick = 5) Then
            txtVal2Hex.AppendText("F")
        End If
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnClearVal1_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all value 1 text boxes, and      -
    '- and disables all buttons until a new text box is clicked -
    '- and resets gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearVal1_Click(sender As Object, e As EventArgs) Handles btnClearVal1.Click
        gintTxtBoxClick = 0
        Call clearVal1()
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnClearVal2_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all value 2 text boxes, and      -
    '- and disables all buttons until a new text box is clicked -
    '- and resets gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearVal2_Click(sender As Object, e As EventArgs) Handles btnClearVal2.Click
        gintTxtBoxClick = 0
        Call clearVal2()
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnClearRes_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all results text boxes, and      -
    '- and disables all buttons until a new text box is clicked -
    '- and resets gintTxtBoxClick                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearRes_Click(sender As Object, e As EventArgs) Handles btnClearRes.Click
        gintTxtBoxClick = 0
        Call clearRes()
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-          Subprogram Name: btnClearAllVal_Click           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all text boxes, and              -
    '- and disables all buttons until a new text box is clicked -
    '- and resets gintTxtBoxClick. I added this to be more user -
    '- friendly                                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnClearAllVal_Click(sender As Object, e As EventArgs) Handles btnClearAllVal.Click
        gintTxtBoxClick = 0
        Call clearRes()
        Call clearVal2()
        Call clearVal1()
        Call clearAllBtns()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: btnConvert_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the actual converting, using       -
    '- gintTxtBoxClick, it calls the proper functions to convert-
    '- all numbers in the right base compared to what text box  -
    '- was last clicked                                         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Call clearAllBtns()
        If (gintTxtBoxClick = 6) Then
            MessageBox.Show("Cannnot type anything in the result boxes")
        Else
            If (gintTxtBoxClick = 0) Then
                If (txtVal1Bin.TextLength < 32) Then
                    MessageBox.Show("Input 32 bits for value 1 in binary")
                Else
                    txtVal1Dec.Text = funConvertFromBin(txtVal1Bin.Text)
                    txtVal1Hex.Text = Hex(txtVal1Dec.Text)
                    txtVal1Bin.Clear()
                    txtVal1Bin.Text = funConvertToBin(txtVal1Dec.Text)
                End If
            ElseIf (gintTxtBoxClick = 1) Then
                If (txtVal2Bin.TextLength < 32) Then
                    MessageBox.Show("Input 32 bits for value 1 in binary")
                Else
                    txtVal2Dec.Text = funConvertFromBin(txtVal2Bin.Text)
                    txtVal2Hex.Text = Hex(txtVal2Dec.Text)
                    txtVal2Bin.Clear()
                    txtVal2Bin.Text = funConvertToBin(txtVal2Dec.Text)
                End If
            End If
            If (gintTxtBoxClick = 2) Then
                If (txtVal1Dec.Text = Nothing) Then
                    MessageBox.Show("Enter value 1 as decimal")
                Else
                    txtVal1Hex.Text = Hex(txtVal1Dec.Text)
                    txtVal1Bin.Text = funConvertToBin(txtVal1Dec.Text)
                End If
            ElseIf (gintTxtBoxClick = 3) Then
                If (txtVal2Dec.Text = Nothing) Then
                    MessageBox.Show("Enter value 2 as decimal")
                Else
                    txtVal2Hex.Text = Hex(txtVal2Dec.Text)
                    txtVal2Bin.Text = funConvertToBin(txtVal2Dec.Text)
                End If
            End If
            If (gintTxtBoxClick = 4) Then
                If (txtVal1Hex.Text = Nothing) Then
                    MessageBox.Show("Enter value 1 as hex")
                Else
                    txtVal1Dec.Text = Convert.ToInt64(txtVal1Hex.Text, 16)
                    txtVal1Bin.Text = funConvertToBin(txtVal1Dec.Text)
                End If
            ElseIf (gintTxtBoxClick = 5) Then
                If (txtVal2Hex.Text = Nothing) Then
                    MessageBox.Show("Enter value 2 as hex")
                Else
                    txtVal2Dec.Text = Convert.ToInt64(txtVal2Hex.Text, 16)
                    txtVal2Bin.Text = funConvertToBin(txtVal2Dec.Text)
                End If
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btnAnd_Click                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the logical function AND, it checks-
    '- if the values are both converted, then it outputs the    -
    '- functions result in the results text boxes               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAnd_Click(sender As Object, e As EventArgs) Handles btnAnd.Click
        Call clearRes()
        If (txtVal1Bin.Text = Nothing Or txtVal2Bin.Text = Nothing Or txtVal1Dec.Text = Nothing Or txtVal2Dec.Text = Nothing Or txtVal1Hex.Text = Nothing Or txtVal2Hex.Text = Nothing) Then
            MessageBox.Show("Make sure to convert both values")
        Else
            txtResDec.Text = txtVal1Dec.Text And txtVal2Dec.Text
            txtResHex.Text = Hex(txtResDec.Text)
            txtResBin.Text = funConvertToBin(txtResDec.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnOr_Click                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the logical function OR, it checks -
    '- if the values are both converted, then it outputs the    -
    '- functions result in the results text boxes               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnOr_Click(sender As Object, e As EventArgs) Handles btnOr.Click
        Call clearRes()
        If (txtVal1Bin.Text = Nothing Or txtVal2Bin.Text = Nothing Or txtVal1Dec.Text = Nothing Or txtVal2Dec.Text = Nothing Or txtVal1Hex.Text = Nothing Or txtVal2Hex.Text = Nothing) Then
            MessageBox.Show("Make sure to convert both values")
        Else
            txtResDec.Text = txtVal1Dec.Text Or txtVal2Dec.Text
            txtResHex.Text = Hex(txtResDec.Text)
            txtResBin.Text = funConvertToBin(txtResDec.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnXor_Click               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the logical function XOR, it checks-
    '- if the values are both converted, then it outputs the    -
    '- functions result in the results text boxes               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnXor_Click(sender As Object, e As EventArgs) Handles btnXor.Click
        Call clearRes()
        If (txtVal1Bin.Text = Nothing Or txtVal2Bin.Text = Nothing Or txtVal1Dec.Text = Nothing Or txtVal2Dec.Text = Nothing Or txtVal1Hex.Text = Nothing Or txtVal2Hex.Text = Nothing) Then
            MessageBox.Show("Make sure to convert both values")

        Else
            txtResDec.Text = txtVal1Dec.Text Xor txtVal2Dec.Text
            txtResHex.Text = Hex(txtResDec.Text)
            txtResBin.Text = funConvertToBin(txtResDec.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: btnNotVal1_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the logical function NOT on value 1-
    '- making sure value 1 is converted then outputting the     -
    '- result to the results' text boxes                        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnNotVal1_Click(sender As Object, e As EventArgs) Handles btnNotVal1.Click
        Call clearRes()
        If (txtVal1Bin.Text = Nothing Or txtVal1Dec.Text = Nothing Or txtVal1Hex.Text = Nothing) Then
            MessageBox.Show("Make sure to convert value 1")
        Else
            txtResDec.Text = Not txtVal1Dec.Text
            txtResHex.Text = Hex(txtResDec.Text)
            txtResBin.Text = funConvertToBin(txtResDec.Text)
        End If
    End Sub

    '------------------------------------------------------------
    '-              Function Name: funConvertToBin              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function takes a decimal value and converts it to   -
    '- binary, using a for loop, outputting 32 bits             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- decToConvert - brings the decimal value passed that needs-
    '- to be converted to binary                                -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- int4Bit - keeps track of bits, spacing between every 4th -
    '-      bit                                                 -
    '- strBinConverted - the string value of the binary, after  -
    '-      conversion                                          -  
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- String – value of converted binary 32 bit number         -
    '------------------------------------------------------------
    Function funConvertToBin(decToConvert)
        Dim int4Bit = -1
        Dim strBinConverted As String
        For intPowerOn As Int64 = 31 To 0 Step -1
            int4Bit += 1
            If (int4Bit Mod 4 = 0) Then
                strBinConverted &= " "
            End If
            If ((Int64.Parse(decToConvert) And (2 ^ intPowerOn)) >= 1) Then
                strBinConverted &= "1"
            Else
                strBinConverted &= "0"
            End If
        Next
        Return strBinConverted
    End Function

    '------------------------------------------------------------
    '-             Function Name: funConvertFromBin             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function takes a 32 bit binary number and convertes -
    '- it to decimal                                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- intToConvert - the 32 bit binary number to convert to dec-
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- decConverted - the holder of the decimal value           -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Int – value of decimal after conversion                  -
    '------------------------------------------------------------
    Function funConvertFromBin(intToConvert)
        Dim decConverted As Long = Convert.ToInt64(intToConvert, 2)
        Return decConverted
    End Function

    '------------------------------------------------------------
    '-               Subprogram Name: clearVal1                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all value 1s' text boxes         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub clearVal1()
        txtVal1Bin.Clear()
        txtVal1Dec.Clear()
        txtVal1Hex.Clear()
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: clearVal2                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all value 2s' text boxes         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub clearVal2()
        txtVal2Bin.Clear()
        txtVal2Dec.Clear()
        txtVal2Hex.Clear()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: clearRes                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program clears all results' text boxes          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub clearRes()
        txtResBin.Clear()
        txtResDec.Clear()
        txtResHex.Clear()
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: binBtns                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program enables binary buttons (0 & 1)          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub binBtns()
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnHexA.Enabled = False
        btnHexB.Enabled = False
        btnHexC.Enabled = False
        btnHexD.Enabled = False
        btnHexE.Enabled = False
        btnHexF.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: binBtns                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program enables decimal buttons (0-9)           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub decBtns()
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnHexA.Enabled = False
        btnHexB.Enabled = False
        btnHexC.Enabled = False
        btnHexD.Enabled = False
        btnHexE.Enabled = False
        btnHexF.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: binBtns                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program enables all buttons (0-9 & A-F)         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub hexBtns()
        btn0.Enabled = True
        btn1.Enabled = True
        btn2.Enabled = True
        btn3.Enabled = True
        btn4.Enabled = True
        btn5.Enabled = True
        btn6.Enabled = True
        btn7.Enabled = True
        btn8.Enabled = True
        btn9.Enabled = True
        btnHexA.Enabled = True
        btnHexB.Enabled = True
        btnHexC.Enabled = True
        btnHexD.Enabled = True
        btnHexE.Enabled = True
        btnHexF.Enabled = True
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: clearAllBtns             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program disables all buttons (0-9 & A-F)        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub clearAllBtns()
        btn0.Enabled = False
        btn1.Enabled = False
        btn2.Enabled = False
        btn3.Enabled = False
        btn4.Enabled = False
        btn5.Enabled = False
        btn6.Enabled = False
        btn7.Enabled = False
        btn8.Enabled = False
        btn9.Enabled = False
        btnHexA.Enabled = False
        btnHexB.Enabled = False
        btnHexC.Enabled = False
        btnHexD.Enabled = False
        btnHexE.Enabled = False
        btnHexF.Enabled = False
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: calcChild_Closing            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program makes sure all values are cleared, if   -
    '- not, the user is able to keep working on that form or    -
    '- close it without reviewing. It will do this for all      -
    '- current children forms                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub calcChild_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (txtVal1Bin.Text = Nothing And txtVal1Dec.Text = Nothing And txtVal1Hex.Text = Nothing And txtVal2Bin.Text = Nothing And txtVal2Dec.Text = Nothing And txtVal2Hex.Text = Nothing) Then
            e.Cancel = False
            My.Application.intFormCount -= 1
        Else
            Me.Focus()
            If MsgBox(Me.Name & " still has values entered, are you sure you want to quit?", MsgBoxStyle.YesNo, "Conversion Calculator") = MsgBoxResult.Yes Then
                e.Cancel = False
            ElseIf MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class