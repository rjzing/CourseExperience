'------------------------------------------------------------
'-                File Name : frmVehicles.vb                - 
'-                Part of Project: Assign 8                 -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 04/04/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the form that allows the user to add, -
'- update and delete records from the dbo.Vehicles, using   -
'- the dbo.Owners' id, connecting it to that specific owner -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to see vehicle information that-
'- is connected to the dbo.Owners. It allows the user to see-
'- the current owner's vehicles, with read only text boxes  -
'- add to the vehicles, delete the vehicle record or update -
'- the current owner's vehicles.                            -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- autosConn - connection to the autos database             -
'- DBAdaptVehicle - data adaptor to dbo.Vehicles            -
'- dsVehicles - dataset containing current vehicle records  -
'- gintSave - keeps track if the owner is adding or updating-
'-      current record                                      -
'- strCONNECTION - constant holding the connection to db    -
'- strDBNAME - the db name                                  -
'- strDBPATH - the path to the db                           -
'- strSERVERNAME - the name of the server where the db is   -
'-      located                                             -
'------------------------------------------------------------
Imports System.Data.SqlClient
Imports System.ComponentModel

Public Class frmVehicles
    Const strDBNAME As String = "Autos"
    Const strSERVERNAME As String = "(localdb)\MSSQLLocalDB"
    Dim strDBPATH As String = My.Application.Info.DirectoryPath & "\" & strDBNAME & ".mdf"
    Dim strCONNECTION As String = "SERVER=" & strSERVERNAME & ";DATABASE=" & strDBNAME &
        ";Integrated Security=SSPI;AttachDbFileName=" & strDBPATH
    Dim autosConn As New SqlConnection(strCONNECTION)
    Dim DBAdaptVehicle As SqlDataAdapter
    Dim dsVehicles As New DataSet
    Dim gintSave As Integer = 0

    '------------------------------------------------------------
    '-           Subprogram Name: frmVehicles_Load              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads, adding all-
    '- binded information from dbo.Vehicles                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- SQLCmd -the current sql command that needs to be executed-
    '------------------------------------------------------------
    Private Sub frmVehicles_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strSQLCmd As String
        autosConn.Open()
        pnlNavi.Visible = True
        pnlSubmit.Visible = False
        strSQLCmd = "Select * From Vehicles WHERE OwnerID ='" & frmAssign_8.txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        txtVehicleID.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.TUID"))
        txtOwnerID.Text = frmAssign_8.txtOwnerID.Text
        txtMake.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.Make"))
        txtModel.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.Model"))
        txtColor.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.Color"))
        txtYear.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.ModelYear"))
        txtVIN.DataBindings.Add(New Binding("Text", dsVehicles, "Vehicles.VIN"))
        strSQLCmd = "Select * From Vehicles Where OwnerID = '" & txtOwnerID.Text & "'"
        autosConn.Close()
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnNext_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the next  -
    '- button. It loads all binded vehicle info from the current-
    '- owners vehicles                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        BindingContext(dsVehicles, "Vehicles").Position = (BindingContext(dsVehicles, "Vehicles").Position + 1)
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: btnPrevious_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the       -
    '- previous button. It loads all binded vehicle info from   -
    '- the current owners vehicles                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        BindingContext(dsVehicles, "Vehicles").Position = (BindingContext(dsVehicles, "Vehicles").Position - 1)
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btnLast_Click               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the last  -
    '- button. It loads all binded vehicle info from the current-
    '- owners vehicles                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        BindingContext(dsVehicles, "Vehicles").Position = dsVehicles.Tables("Vehicles").Rows.Count - 1
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btnFirst_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the first -
    '- button. It loads all binded vehicle info from the current-
    '- owners vehicles                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        BindingContext(dsVehicles, "Vehicles").Position = 0
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnAdd_Click               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the add   -
    '- button. It calls the clear text boxes sub along with the -
    '- unlock text boxes sub. It also calls the sub that finds  -
    '- the max TUID to properly incriment the vehicle id number -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        gintSave = 0
        Call unlockTxtBxs()
        Call clearOutTxtBxs()
        txtVehicleID.Text = maxTUID()
    End Sub

    '------------------------------------------------------------
    '-                 Subprogram Name: saveAdd                 -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the add   -
    '- button. This actually adds the new info to dbo.Vehicles  -
    '- by creating a new connection to the db, then inserting   -
    '- it to the db, using the sql command                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the insert sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub saveAdd()
        Dim dbConnection As SqlConnection
        Dim dbCommand As SqlCommand = New SqlCommand
        If (txtModel.Text = Nothing Or txtMake.Text = Nothing Or txtColor.Text = Nothing Or txtYear.Text = Nothing Or txtVIN.Text = Nothing) Then
            Call refreshTxtBxs()
        Else
            dbConnection = New SqlConnection(strCONNECTION)
            dbConnection.Open()
            dbCommand.CommandText = "INSERT INTO Vehicles (TUID, OwnerID, Make, Model, ModelYear, Color, VIN) VALUES ('" &
            txtVehicleID.Text & "','" & txtOwnerID.Text & "','" & txtMake.Text & "','" & txtModel.Text & "','" &
            txtYear.Text.ToString() & "','" & txtColor.Text & "','" & txtVIN.Text &
             "')"
            dbCommand.Connection = dbConnection
            dbCommand.ExecuteNonQuery()
            dbConnection.Close()
            Call refreshTxtBxs()
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnDelete_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the delete-
    '- button. It uses a msgbx to ask the user if they are sure -
    '- they do, then it calls the delete sub if they want to    -
    '- delete the record                                        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If (txtVehicleID.Text = Nothing) Then
            MessageBox.Show("Nothing to delete")
        Else
            If MsgBox("Are you sure you want to delete this vehicle?", MsgBoxStyle.YesNo, "Delete Vehicle") = MsgBoxResult.Yes Then
                Call deleteVehicle()
            ElseIf MsgBoxResult.No Then
            End If
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: deleteVehicle               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the delete-
    '- button. This actually deletes the current vehicle from db-
    '- by creating a new connection to the db, then deleting    -
    '- it from the db, using the sql command                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the delete sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub deleteVehicle()
        Dim dbConnection As SqlConnection
        Dim dbCommand As SqlCommand = New SqlCommand
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dbCommand.CommandText = "DELETE FROM Vehicles WHERE TUID = '" & txtVehicleID.Text & "'"
        dbCommand.Connection = dbConnection
        dbCommand.ExecuteNonQuery()
        Call refreshTxtBxs()
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnUpdate_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the update-
    '- button. It checks to see if there is info to update, then-
    '- allows the user to update the record                     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        If (txtVehicleID.Text = Nothing) Then
            MessageBox.Show("Nothing to update")
        Else
            Call unlockTxtBxs()
            gintSave = 1
        End If
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: updateVehicle               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the update-
    '- button. This actually updates the current vehicle from db-
    '- by creating a new connection to the db, then updating    -
    '- it from the db, using the sql command                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the delete sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub updateVehicle()
        Dim DBConnection As SqlConnection
        Dim dbcCommand As SqlCommand = New SqlCommand
        DBConnection = New SqlConnection(strCONNECTION)
        DBConnection.Open()
        dbcCommand.CommandText = "UPDATE Vehicles Set Make = '" & txtMake.Text & "', Model = '" &
            txtModel.Text & "'," & "ModelYear ='" & txtYear.Text & "'," & "Color ='" &
            txtColor.Text & "'," & "VIN= '" & txtVIN.Text & "'" &
            "WHERE TUID = " & txtVehicleID.Text
        dbcCommand.Connection = DBConnection
        dbcCommand.ExecuteNonQuery()
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnSave_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the save  -
    '- button. It either calls the update or addVehicle sub     -
    '- depending which button the user clicked                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If (gintSave = 0) Then
            Call saveAdd()
        ElseIf (gintSave = 1) Then
            Call updateVehicle()
        Else
        End If
        Call lockTxtBxs()
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btnCancel_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the cancel-
    '- button. It calls the refreshTxtBxs and lockTxtBxs or     -
    '- nothing, keeping it on the new record or goes to the     -
    '- entry.                                                   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If (gintSave = 0 And txtMake.Text = Nothing Or txtModel.Text = Nothing Or
            txtYear.Text = Nothing Or txtColor.Text = Nothing Or txtVIN.Text = Nothing) Then
            Call refreshTxtBxs()
        Else
        End If
        Call lockTxtBxs()
    End Sub

    '------------------------------------------------------------
    '-                  Function Name: maxTUID                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the add   -
    '- button. It finds the max TUID and return it + 1, to make -
    '- sure there are no keys having the same number            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the max sql command                          -
    '- dbConnection - reconnects to the db to excute command    -
    '- maxTUIDEntry - the current max TUID                      -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Int – maxTUID + 1                                        -
    '------------------------------------------------------------
    Function maxTUID()
        Dim dbConnection As SqlConnection
        Dim dbCommand As SqlCommand = New SqlCommand
        Dim maxTUIDEntry As Integer = 0
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dbCommand.CommandText = "SELECT Max(TUID) FROM Vehicles"
        dbCommand.Connection = dbConnection
        maxTUIDEntry = dbCommand.ExecuteScalar
        dbConnection.Close()
        maxTUIDEntry += 1
        Return maxTUIDEntry
    End Function

    '------------------------------------------------------------
    '-              Subprogram Name: refreshTxtBxs              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the text boxes need to be -
    '- refreshed, adding the proper entry to the text boxes     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the select sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub refreshTxtBxs()
        Dim dbConnection As SqlConnection
        Dim dbCommand As String
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dsVehicles.Clear()
        dbCommand = "Select * From Vehicles Where OwnerID = '" & txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(dbCommand, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dbConnection.Close()
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: unlockTxtBxs              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the text boxes can be     -
    '- changed                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub unlockTxtBxs()
        txtMake.Enabled = True
        txtModel.Enabled = True
        txtColor.Enabled = True
        txtYear.Enabled = True
        txtVIN.Enabled = True
        pnlNavi.Visible = False
        pnlSubmit.Visible = True
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: lockTxtBxs                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the text boxes can't be   -
    '- changed                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub lockTxtBxs()
        txtMake.Enabled = False
        txtModel.Enabled = False
        txtColor.Enabled = False
        txtYear.Enabled = False
        txtVIN.Enabled = False
        pnlSubmit.Visible = False
        pnlNavi.Visible = True
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: clearOutTxtBxs              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the text boxes need to be -
    '- cleared                                                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub clearOutTxtBxs()
        txtMake.Clear()
        txtModel.Clear()
        txtColor.Clear()
        txtYear.Clear()
        txtVIN.Clear()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: frmVehicles_Closing           -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form is closing which -
    '- refreshes the main form, showing the updated info in the -
    '- dgv thats on the main form                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- currentID - keeps the right ID to select on the main form-
    '------------------------------------------------------------
    Private Sub frmVehicles_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Dim currentID As String = txtOwnerID.Text
        Call frmAssign_8.refreshDGV(currentID)
        frmAssign_8.Show()
    End Sub
End Class