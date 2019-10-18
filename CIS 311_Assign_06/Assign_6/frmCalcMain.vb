'------------------------------------------------------------
'-              File Name : frmCalcMain.vb                  - 
'-                Part of Project: Assign6                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 03/21/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the mdi parent source code            -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to create new mdi children to  -
'- convert values from binary, decimal, or hex. It has a    -
'- menustrip that allows the users to create new mdi        -
'- children, exit the whole program, it shows the current   -
'- children that the user has open, they can control if the -
'- mdi layout should be tile or cascade, and also has an    -
'- about us form showing a description of the program. The  -
'- parent can only be closed when all the children are      -
'- cleared and closed.                                      -
'------------------------------------------------------------
'- Class/Global Variable Dictionary:(None)                  -
'------------------------------------------------------------
Imports System.ComponentModel

Public Class frmCalcMain
    '------------------------------------------------------------
    '-            Subprogram Name: mnuNew_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to create a new child.  -
    '- It names the new child using a count variable that shows -
    '- the user how many children have been created             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- frmNewCalcFrm - the new child form                       -
    '------------------------------------------------------------
    Private Sub mnuNew_Click(sender As Object, e As EventArgs) Handles mnuNew.Click
        Dim frmNewCalcFrm = New frmCalcChild
        My.Application.intFormCount += 1
        frmNewCalcFrm.Name = "Calculator" & "-" & Trim(CStr(My.Application.intFormCount))
        frmNewCalcFrm.Text = frmNewCalcFrm.Name
        frmNewCalcFrm.MdiParent = Me
        frmNewCalcFrm.Show()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuAbout_Click                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to open the About Us    -
    '- form.                                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- frmNewAboutForm - the new About Us form                  -
    '------------------------------------------------------------
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim frmNewAboutForm As frmAboutUs = New frmAboutUs
        frmNewAboutForm.Show()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuCascade_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to control which mdi    -
    '- layout they want, in this case it is the default cascade -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuCascade_Click(sender As Object, e As EventArgs) Handles mnuCascade.Click
        LayoutMdi(MdiLayout.Cascade)
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuTile_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to control which mdi    -
    '- layout they want, in this case it is the tile layout     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuTile_Click(sender As Object, e As EventArgs) Handles mnuTile.Click
        LayoutMdi(MdiLayout.TileVertical)
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuExit_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 03/21/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to exit the main form   -
    '- it strobes through each child form, just like the "X"    -
    '- button does to close.                                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub
End Class