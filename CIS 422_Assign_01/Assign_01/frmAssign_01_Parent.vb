'------------------------------------------------------------
'-           File Name : frmAssign_01_Parent.vb             - 
'-              Part of Project: Assign_01                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 09/06/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the mdi parent source code            -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to create new mdi children that-
'- the user can fill out for desired catering meals. The    -
'- parent has a menustrip with the normal options a mdi     -
'- parent should have                                       -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- (None)                                                   -
'------------------------------------------------------------
Imports System.ComponentModel
Public Class frmAssign_01_Parent
    '------------------------------------------------------------
    '-        Subprogram Name: frmAssign_01_Parent_Load         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the parent is loaded for -
    '- the first time, that calls the newForm sub, loading a new-
    '- child right away so the user doesnt have to hit file+ new-
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign_01_Parent_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call newForm()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: mnuNew_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program calls the newForm sub that creates a new-
    '- child                                                    -
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
        Call newForm()
    End Sub

    '------------------------------------------------------------
    '-                 Subprogram Name: newForm                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user creates a new   -
    '- child. It names the new child using a count variable     -
    '- that shows the user how many children have been created  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- frmNewOrderFrm - the new child form                      -
    '------------------------------------------------------------
    Public Sub newForm()
        Dim frmNewOrderFrm = New frmAssign_01_Child
        My.Application.intFormCount += 1
        frmNewOrderFrm.Name = "Big J Catering Order Form" & "-" & Trim(CStr(My.Application.intFormCount))
        frmNewOrderFrm.Text = frmNewOrderFrm.Name
        frmNewOrderFrm.MdiParent = Me
        frmNewOrderFrm.Show()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuCascade_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
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
    '-                Written On: 09/06/2018                    -
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
    '-           Subprogram Name: mnuAbout_Click                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
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
    '- frmAboutUs - the new About Us form                       -
    '------------------------------------------------------------
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        Dim frmAboutUs = New frmAboutUs
        frmAboutUs.Show()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: mnuExit_Click                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows the user to exit the main form.  -
    '- It ultimatley calls the closing event, acting just like  -
    '- closing it with the "X" in the right upper corner        -
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

    '------------------------------------------------------------
    '-       Subprogram Name: frmAssign_01_Parent_Closing       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 09/06/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program asks the user if they are sure they want-
    '- to close the app, if they click no, it stops the form    -
    '- closing, if yes is selected, it closes the app           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the CancelEventArgs object sent to the routine -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub frmAssign_01_Parent_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        e.Cancel = False
        If MsgBox("Are You Sure You Want To Exit?", MsgBoxStyle.YesNo, "Big J Catering") = MsgBoxResult.Yes Then
            e.Cancel = False
        ElseIf MsgBoxResult.No Then
            e.Cancel = True
        End If
    End Sub

End Class