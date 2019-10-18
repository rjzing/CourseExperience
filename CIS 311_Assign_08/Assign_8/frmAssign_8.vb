'------------------------------------------------------------
'-                File Name : frmVehicles.vb                - 
'-                Part of Project: Assign 8                 -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 04/04/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main form that show the current   -
'- owner information and loads the dgv that holds the       -
'- owner's vehicle information                              -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to see vehicle information that-
'- is connected to the dbo.Owners. It allows the user to see-
'- the current owner's vehicles, in the dgv and shows the   -
'- owner's information in the text boxes. The user can add, -
'- delete or update the owner info                          -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- autosConn - connection to the autos database             -
'- DBAdaptOwners - data adapter to dbo.Owners               -
'- DBAdaptVehicle - data adapter to dbo.Vehicles            -
'- dsOwners - dataset that contains the owner info          -
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

Public Class frmAssign_8
    Dim dsOwners As New DataSet
    Dim dsVehicles As New DataSet
    Const strDBNAME As String = "Autos"
    Const strSERVERNAME As String = "(localdb)\MSSQLLocalDB"
    Dim strDBPATH As String = My.Application.Info.DirectoryPath & "\" & strDBNAME & ".mdf"
    Dim strCONNECTION As String = "SERVER=" & strSERVERNAME & ";DATABASE=" & strDBNAME &
        ";Integrated Security=SSPI;AttachDbFileName=" & strDBPATH
    Dim autosConn As New SqlConnection(strCONNECTION)
    Dim DBAdaptOwners As SqlDataAdapter
    Dim DBAdaptVehicle As SqlDataAdapter
    Dim gintSave As Integer = 0

    '------------------------------------------------------------
    '-           Subprogram Name: frmAssign_8_Load              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the form loads, adding all-
    '- binded information from dbo.Owners and the current       -
    '- selected owner's vehicle info                            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- SQLCmd -the current sql command that needs to be executed-
    '------------------------------------------------------------
    Private Sub frmAssign_8_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim strSQLCmd As String
        pnlNavi.Visible = True
        pnlSubmit.Visible = False
        autosConn.Open()
        strSQLCmd = "Select * From Owners"
        DBAdaptOwners = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptOwners.Fill(dsOwners, "Owners")
        txtOwnerID.DataBindings.Add(New Binding("Text", dsOwners, "Owners.TUID"))
        txtOwnerFName.DataBindings.Add(New Binding("Text", dsOwners, "Owners.FirstName"))
        txtOwnerLName.DataBindings.Add(New Binding("Text", dsOwners, "Owners.LastName"))
        txtStreetAddress.DataBindings.Add(New Binding("Text", dsOwners, "Owners.StreetAddress"))
        txtCity.DataBindings.Add(New Binding("Text", dsOwners, "Owners.City"))
        txtState.DataBindings.Add(New Binding("Text", dsOwners, "Owners.State"))
        txtZipCode.DataBindings.Add(New Binding("Text", dsOwners, "Owners.ZipCode"))
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" & txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
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
    '- button. It loads all binded owner info from the current  -
    '- owners and their specific vehicles                       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        autosConn.Open()
        Dim strSQLCmd As String
        dsVehicles.Clear()
        BindingContext(dsOwners, "Owners").Position = (BindingContext(dsOwners, "Owners").Position + 1)
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        autosConn.Close()
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
    '- the current owners vehicles and owner info               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        autosConn.Open()
        Dim strSQLCmd As String
        dsVehicles.Clear()
        BindingContext(dsOwners, "Owners").Position = (BindingContext(dsOwners, "Owners").Position - 1)
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        autosConn.Close()
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
    '- button. It loads all binded vehicle info from            -
    '- the current owners vehicles and owner info               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Private Sub btnLast_Click(sender As Object, e As EventArgs) Handles btnLast.Click
        autosConn.Open()
        Dim strSQLCmd As String
        dsVehicles.Clear()
        BindingContext(dsOwners, "Owners").Position = dsOwners.Tables("Owners").Rows.Count - 1
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        autosConn.Close()
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
    '- button. It loads all binded vehicle info from            -
    '- the current owners vehicles and owner info               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Private Sub btnFirst_Click(sender As Object, e As EventArgs) Handles btnFirst.Click
        Dim strSQLCmd As String
        autosConn.Open()
        dsVehicles.Clear()
        BindingContext(dsOwners, "Owners").Position = 0
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        autosConn.Close()
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
    '- the max TUID to properly incriment the owner id number   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Dim strSQLCmd As String
        gintSave = 0
        Call unlockTxtBxs()
        Call clearOutTxtBxs()
        dsVehicles.Clear()
        autosConn.Open()
        txtOwnerID.Text = maxTUID()
        strSQLCmd = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
                    txtOwnerID.Text & "'"
        DBAdaptVehicle = New SqlDataAdapter(strSQLCmd, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        autosConn.Close()
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
    '- button. This actually adds the new info to dbo.Owners    -
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
    '- strSQLCmd - the select sql command to load proper vehicle-
    '-      info connected to current owner                     -
    '------------------------------------------------------------
    Sub saveAdd()
        Dim dbConnection As SqlConnection
        Dim dbCommand As SqlCommand = New SqlCommand
        Dim strSQLCommand As String
        If (txtOwnerFName.Text = Nothing Or txtOwnerLName.Text = Nothing Or
            txtStreetAddress.Text = Nothing Or txtCity.Text = Nothing Or txtState.Text = Nothing Or
            txtZipCode.Text = Nothing) Then
            Call refreshDGV()
        Else
            dgvVehicles.Refresh()
            dbConnection = New SqlConnection(strCONNECTION)
            dbConnection.Open()
            dbCommand.CommandText = "INSERT INTO Owners (TUID, FirstName, LastName, StreetAddress, City, State, Zipcode) VALUES ('" &
            txtOwnerID.Text & "','" & txtOwnerFName.Text & "','" & txtOwnerLName.Text & "','" & txtStreetAddress.Text & "','" &
            txtCity.Text & "','" & txtState.Text & "','" & txtZipCode.Text &
             "')"
            dbCommand.Connection = dbConnection
            dbCommand.ExecuteNonQuery()
            dsOwners.Clear()
            strSQLCommand = "Select * From Owners ORDER BY TUID ASC"
            DBAdaptOwners = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptOwners.Fill(dsOwners, "Owners")
            strSQLCommand = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            txtOwnerID.Text & "'"
            DBAdaptVehicle = New SqlDataAdapter(strSQLCommand, strCONNECTION)
            DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
            dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
            dgvVehicles.Refresh()
            dbConnection.Close()
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
        If MsgBox("Are you sure you want to delete this owner?", MsgBoxStyle.YesNo, "Delete Owner") = MsgBoxResult.Yes Then
            Call deleteRecord()
        ElseIf MsgBoxResult.No Then
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: deleterecord              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the delete-
    '- button. This actually deletes the current owner from db  -
    '- by creating a new connection to the db, then deleting    -
    '- it from the db, using the sql command. It also deletes   -
    '- the associated vehicle info                              -
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
    Sub deleteRecord()
        Dim DBConnection As SqlConnection
        Dim dbcCommand As SqlCommand = New SqlCommand
        DBConnection = New SqlConnection(strCONNECTION)
        DBConnection.Open()
        dbcCommand.CommandText = "DELETE FROM Owners WHERE TUID = '" & txtOwnerID.Text & "'"
        dbcCommand.Connection = DBConnection
        dbcCommand.ExecuteNonQuery()
        dbcCommand.CommandText = "DELETE FROM Vehicles WHERE OwnerID = '" & txtOwnerID.Text & "'"
        dbcCommand.Connection = DBConnection
        dbcCommand.ExecuteNonQuery()
        DBConnection.Close()
        Call refreshDGV()
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
    '- button.                                                  -
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
        Call unlockTxtBxs()
        gintSave = 1
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
    '- button. This actually updates the current owner from db  -
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
    Sub updateOwner()
        Dim dbConnection As SqlConnection
        Dim dbCommand As SqlCommand = New SqlCommand
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dbCommand.CommandText = "UPDATE Owners Set FirstName = '" & txtOwnerFName.Text & "', LastName = '" &
            txtOwnerLName.Text & "'," & "StreetAddress ='" & txtStreetAddress.Text & "'," & "City ='" &
            txtCity.Text & "'," & "State= '" & txtState.Text & "'," & "ZipCode ='" & txtZipCode.Text &
            "'WHERE TUID = " & txtOwnerID.Text
        dbCommand.Connection = dbConnection
        dbCommand.ExecuteNonQuery()
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
    '- button. It either calls the update or addOwner sub       -
    '- depending which button the user clicked. It also calls   -
    '- the refreshDGV sub                                       -
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
            Call updateOwner()
            Call refreshDGV(txtOwnerID.Text)
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
    '- button. It calls the refreshDGV and lockTxtBxs or nothing-
    '- keeping it on the new record or goes to the entry        -
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
        If (gintSave = 0 And txtOwnerFName.Text = Nothing Or txtOwnerLName.Text = Nothing Or
            txtStreetAddress.Text = Nothing Or txtCity.Text = Nothing Or txtState.Text = Nothing Or
            txtZipCode.Text = Nothing) Then
            Call refreshDGV()
        Else
        End If
        Call lockTxtBxs()
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: btnVehicles_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the user clicks the update-
    '- vehicle button. It makes this form invisble and shows the-
    '- vehicle form that allows the user to update vehicle info -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnVehicles_Click(sender As Object, e As EventArgs) Handles btnVehicles.Click
        frmVehicles.Show()
        Me.Visible = False
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
        dbCommand.CommandText = "SELECT Max(TUID) FROM Owners"
        dbCommand.Connection = dbConnection
        maxTUIDEntry = dbCommand.ExecuteScalar
        dbConnection.Close()
        maxTUIDEntry += 1
        Return maxTUIDEntry
    End Function

    '------------------------------------------------------------
    '-               Subprogram Name: refreshDGV                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the dgv needs to be       -
    '- refreshed, adding the proper entry to the dgv            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the select sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub refreshDGV()
        Dim dbConnection As SqlConnection
        Dim dbCommand As String
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dsVehicles.Clear()
        dsOwners.Clear()
        dbCommand = "Select * From Owners ORDER BY TUID ASC"
        DBAdaptOwners = New SqlDataAdapter(dbCommand, strCONNECTION)
        DBAdaptOwners.Fill(dsOwners, "Owners")
        dbCommand = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
            1 & "'"
        DBAdaptVehicle = New SqlDataAdapter(dbCommand, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
        dbConnection.Close()
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: refreshDGV                -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/04/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when the dgv needs to be       -
    '- refreshed, adding the proper entry to the dgv            -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- currentID - the current owner id                         -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- dbCommand - the select sql command                       -
    '- dbConnection - reconnects to the db to excute command    -
    '------------------------------------------------------------
    Sub refreshDGV(currentID)
        Dim dbConnection As SqlConnection
        Dim dbCommand As String
        dsVehicles.Clear()
        dbConnection = New SqlConnection(strCONNECTION)
        dbConnection.Open()
        dbCommand = "Select Make, Model, Color, ModelYear, VIN From Vehicles Where OwnerID = '" &
        currentID & "'"
        DBAdaptVehicle = New SqlDataAdapter(dbCommand, strCONNECTION)
        DBAdaptVehicle.Fill(dsVehicles, "Vehicles")
        dgvVehicles.DataSource = dsVehicles.Tables("Vehicles")
        dgvVehicles.Refresh()
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
        txtCity.Enabled = True
        txtOwnerFName.Enabled = True
        txtOwnerLName.Enabled = True
        txtState.Enabled = True
        txtStreetAddress.Enabled = True
        txtZipCode.Enabled = True
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
        txtCity.Enabled = False
        txtOwnerFName.Enabled = False
        txtOwnerLName.Enabled = False
        txtState.Enabled = False
        txtStreetAddress.Enabled = False
        txtZipCode.Enabled = False
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
        txtOwnerFName.Clear()
        txtOwnerLName.Clear()
        txtStreetAddress.Clear()
        txtCity.Clear()
        txtState.Clear()
        txtZipCode.Clear()
    End Sub
End Class