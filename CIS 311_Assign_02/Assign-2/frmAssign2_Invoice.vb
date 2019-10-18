'------------------------------------------------------------
'-                File Name : frmAssign2_invoice.vb         - 
'-                Part of Project: Assign2                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/05/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the invoice form of Kustom Karz's     -
'- order, this is where you can order, close the app or     -
'- change the order if there was a mistake                  -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- (none)                                                   –
'------------------------------------------------------------
Imports System.ComponentModel
Public Class frmAssign2_Invoice
    '------------------------------------------------------------
    '-      Subprogram Name: frmAssign2_Invoice_Load            -
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
    Private Sub frmAssign2_Invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    '------------------------------------------------------------
    '-              Subprogram Name: cmdSubmit_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the submit button is  -
    '- clicked, it has a message box, telling you the order was -
    '- submitted and brings you to the order from with          -
    '- everything gone for the next customer                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub cmdSubmit_Click(sender As Object, e As EventArgs) Handles cmdSubmit.Click
        MessageBox.Show("Order submitted")
        Form1.txtName.Clear()
        Form1.rbnV_12.Checked = True
        Form1.lstType.Text = "Coupe"
        Form1.lstQTY.Text = "1"
        Form1.chkAC.Checked = False
        Form1.chkBT.Checked = False
        Form1.chkCDMP3.Checked = False
        Form1.chkEnPa.Checked = False
        Form1.chkGPS.Checked = False
        Form1.chkHeatedSeats.Checked = False
        Form1.chkLeatherSeats.Checked = False
        Form1.chkPremiumStereo.Checked = False
        Form1.chkRearDefrost.Checked = False
        Me.Visible = False
        Form1.Visible = True
    End Sub
    '------------------------------------------------------------
    '-              Subprogram Name: cmdChange_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the change button is  -
    '- clicked, it goes back to the orderform with everything   -
    '- still selected, making it easier to edit                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub cmdChange_Click(sender As Object, e As EventArgs) Handles cmdChange.Click
        Me.Visible = False
        Form1.Visible = True
    End Sub
    '------------------------------------------------------------
    '-              Subprogram Name: cmdExit_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the exit button is    -
    '- clicked, it asks if you really want to close, then closes-
    '- the entire app if yes is selected                        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub cmdExit_Click(sender As Object, e As EventArgs) Handles cmdExit.Click
        If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Kustom Kars Ordering System") = MsgBoxResult.Yes Then
            Application.ExitThread()
        ElseIf MsgBoxResult.No Then
            Me.Visible = True
        End If
    End Sub
    '------------------------------------------------------------
    '-      Subprogram Name: frmAssign2_Invoice_Closing         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/05/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the form is closed    -
    '- with the actual "x" button on the top of the form        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign2_Invoice_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If (Me.Visible = True) Then
            If MsgBox("Are you sure you want to quit?", MsgBoxStyle.YesNo, "Kustom Kars Ordering System") = MsgBoxResult.Yes Then
                Application.ExitThread()
            ElseIf MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub
End Class