'------------------------------------------------------------
'-                File Name : frmAssign_1.frm               - 
'-                Part of Project: Assign1                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 01/26/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application form where the   -
'- user will input an item's id, description, quantity, and -
'- unit price, in the specific given text boxes.            -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to interact with an inventory  -
'- record. They have the option to save the item's          -
'- information, to a .txt file once they close the form,    -
'- they can also cancel the add, clearing all               -
'- their work And showing a message box.                    - 
'- They also can scroll left To right And see all the       -
'- items that are entered Using Next/previous buttons. All  -
'- the controls are On one Single form, different buttons'  -
'- properties chanage With Each "mode". When scrolling,     -
'- the text boxes are In read only mode. If there Is no     -
'- file On original startup, the "add item mode" Is         -
'- triggered.                                               - 
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- file – The string I decided to call the i/o .txt file    –
'- inventories - holding array with inventory structure     - 
'- Inventory - structure with given properties              -
'- k – The index of the array inventories after read in     –
'- overAllIndex - keeps track of adding elements            -
'- pricePerUnit - price of unit when calculating price      -
'- qty - the quantity of an item                            -
'- streamReader - the file input reader                     -
'- streamWriter - the file writer                           -
'- totalInvPrice - calculated price in inventory            -
'- viewHolder - holds what item number is being viewed      - 
'------------------------------------------------------------

Imports System.ComponentModel

Public Class frmAssign_1
    Dim file As String = ("invItems.txt")
    Dim streamReader As System.IO.StreamReader
    Dim streamWriter As System.IO.StreamWriter
    Dim qTY As Double
    Dim pricePerUnit As Double
    Dim totalInvPrice As Double
    Dim overAllIndex = 0
    Dim k = -1
    Dim viewHolder = 0

    Structure Inventory
        Dim id As String
        Dim des As String
        Dim qty As Integer
        Dim pricePerUnit As Double
        Dim flatRate
    End Structure

    Dim inventories(0) As Inventory

    '------------------------------------------------------------
    '-                Subprogram Name: frmAssign_1_Load         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user loads the    -
    '- form                                                     –
    '------------------------------------------------------------
    '- Parameter Dictionary:               -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- data - the array's length of properties in inventories   -
    '- inventoryIn - count of indexes in array when read in     -
    '- line - keeps track of where the line needs to split      -
    '- m - the for loop iteration counter                       -
    '- tempData - an array that allows the lines to be split    -
    '------------------------------------------------------------
    Private Sub frmAssign_1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(file) Then         'checks if file exists, and reads in if so
            streamReader = System.IO.File.OpenText(file)

            Dim line As String
            Dim data(4) As String

            Dim tempData() As String = IO.File.ReadAllLines(file)
            For m As Integer = 0 To tempData.Count - 1
                ReDim Preserve inventories(m)
                line = tempData(m)
                data = line.Split(","c)

                inventories(m).id = data(0)
                inventories(m).des = data(1)
                inventories(m).qty = data(2)
                inventories(m).pricePerUnit = data(3)
                inventories(m).flatRate = data(4)
                overAllIndex += 1
            Next

            btnSave.Visible = False
            btnCancel.Visible = False
            btnNext.Visible = True
            btnPrevious.Visible = True
            btnCalc.Visible = True
            btnAddItem.Visible = True
            streamReader.Close()

            lblTotalPrice.Visible = False
            txtID.ReadOnly = True
            txtDes.ReadOnly = True
            txtQTY.ReadOnly = True
            txtUnitPrice.ReadOnly = True
            chkFlatPrice.Enabled = False

            k += 1
            viewHolder += 1

            Dim inventoryIn = (inventories.GetUpperBound(k) + 1)
            txtID.Text = inventories(k).id
            txtDes.Text = inventories(k).des
            txtQTY.Text = inventories(k).qty
            txtUnitPrice.Text = inventories(k).pricePerUnit
            chkFlatPrice.Checked = inventories(k).flatRate

            Me.Text = "Inventory System - Item " & viewHolder & "/" & inventoryIn

        Else                'add "mode" if no file is found
            Me.Text = "Inventory System - Add Item "

        End If
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnNext_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- the next button when viewing saved items                 -
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
        lblTotalPrice.Visible = False
        txtID.ReadOnly = True
        txtDes.ReadOnly = True
        txtQTY.ReadOnly = True
        txtUnitPrice.ReadOnly = True
        chkFlatPrice.Enabled = False

        Dim inventoryIn = (inventories.GetUpperBound(0) + 1)

        k += 1 'holds current index of which item is viewing, wanted to start at 1 so every sub starts default state

        If (k <= (inventories.GetUpperBound(0))) Then
            k += 0
            txtID.Text = inventories(k).id
            txtDes.Text = inventories(k).des
            txtQTY.Text = inventories(k).qty
            txtUnitPrice.Text = inventories(k).pricePerUnit
            chkFlatPrice.Checked = inventories(k).flatRate
            viewHolder += 1

        Else
            MessageBox.Show("No item on record")
            k -= 1 'decriments if there is no record, keeping correct index for next button click

        End If

        Me.Text = "Inventory System - Item " & viewHolder & "/" & inventoryIn
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnPrevious_Click        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- the previous button when viewing saved items             -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- inventoryIn - upperbound of array                        -
    '------------------------------------------------------------

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click
        lblTotalPrice.Visible = False
        txtID.ReadOnly = True
        txtDes.ReadOnly = True
        txtQTY.ReadOnly = True
        txtUnitPrice.ReadOnly = True
        chkFlatPrice.Enabled = False

        Dim inventoryIn = (inventories.GetUpperBound(0) + 1)

        k -= 1 'keeps the last next button click so it can go from 0 -> number of indexes

        If (k >= 0) Then
            k -= 0
            txtID.Text = inventories(k).id
            txtDes.Text = inventories(k).des
            txtQTY.Text = inventories(k).qty
            txtUnitPrice.Text = inventories(k).pricePerUnit
            chkFlatPrice.Checked = inventories(k).flatRate
            viewHolder -= 1

        Else
            MessageBox.Show("You cannot go past the first record")
            k += 1

        End If

        Me.Text = "Inventory System - Item " & viewHolder & "/" & inventoryIn

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnAddItem_Click         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- add button, appending the element to the last index      –
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnAddItem_Click(sender As Object, e As EventArgs) Handles btnAddItem.Click
        Me.Text = "Inventory System - Add Item "

        txtID.Clear()
        txtDes.Clear()
        txtQTY.Clear()
        txtUnitPrice.Clear()
        chkFlatPrice.Checked = False
        lblTotalPrice.Visible = False
        btnSave.Visible = True
        btnCancel.Visible = True
        btnNext.Visible = False
        btnPrevious.Visible = False
        btnCalc.Visible = True
        btnAddItem.Visible = False
        txtID.ReadOnly = False
        txtDes.ReadOnly = False
        txtQTY.ReadOnly = False
        txtUnitPrice.ReadOnly = False
        chkFlatPrice.Enabled = True

        k = -1
        viewHolder = 0

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnSave_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- save button                                              –
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
        lblTotalPrice.Visible = False

        ReDim Preserve inventories(overAllIndex)

        inventories(overAllIndex).id = txtID.Text
        inventories(overAllIndex).des = txtDes.Text
        inventories(overAllIndex).qty = txtQTY.Text
        inventories(overAllIndex).pricePerUnit = txtUnitPrice.Text
        inventories(overAllIndex).flatRate = chkFlatPrice.Checked

        txtID.Clear()
        txtDes.Clear()
        txtQTY.Clear()
        txtUnitPrice.Clear()
        chkFlatPrice.Checked = False
        overAllIndex += 1 'adds a new element spot to hold new information that was saved

        btnSave.Visible = False
        btnCancel.Visible = False
        btnNext.Visible = True
        btnPrevious.Visible = True
        btnCalc.Visible = True
        btnAddItem.Visible = True

        Me.Text = "Inventory System"

        k = -1
        viewHolder = 0
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnCancel_Click          -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- cancel button in add "mode" clearing every input and     -
    '- alerting the user they cancelled the addition            –
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
        MessageBox.Show("Item addition cancelled")

        lblTotalPrice.Visible = False
        txtID.Clear()
        txtDes.Clear()
        txtQTY.Clear()
        txtUnitPrice.Clear()
        chkFlatPrice.Checked = False

        btnSave.Visible = False
        btnCancel.Visible = False
        btnNext.Visible = True
        btnPrevious.Visible = True
        btnCalc.Visible = True
        btnAddItem.Visible = True

        Me.Text = "Inventory System"

        k = -1
        viewHolder = 0
    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: btnCalc_Click            -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user clicks the   -
    '- calculate button, calculating inventory's value on the   -
    '– fly                                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub btnCalc_Click(sender As Object, e As EventArgs) Handles btnCalc.Click

        lblTotalPrice.Visible = True

        If (chkFlatPrice.Checked = True) Then 'checks if flat rate check box is checked
            pricePerUnit = txtUnitPrice.Text
            lblTotalPrice.Text = "Price per unit, regardless of qty: $" & pricePerUnit

        ElseIf (IsNumeric(txtQTY.Text & txtUnitPrice.Text) = True) Then 'makes sure numbers are entered
            qTY = txtQTY.Text
            pricePerUnit = txtUnitPrice.Text
            totalInvPrice = qTY * pricePerUnit
            lblTotalPrice.Text = "Total Inventory Value on this item is: $" & totalInvPrice

        Else
            lblTotalPrice.Text = 0
            MessageBox.Show("Numbers not given, try again")
        End If

    End Sub

    '------------------------------------------------------------
    '-                Subprogram Name: frmAssign_1_Closed       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 01/26/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called whenever the user closes the   -
    '- form dumping and writing all info in the .txt file       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------

    Private Sub frmAssign_1_Closed(sender As Object, e As EventArgs) Handles Me.Closed

        overAllIndex -= 1 'up to this point, the array is indexed to start at 1, this allows the first item to write at index 0

        ReDim Preserve inventories(overAllIndex) 'preserves every item that was read in and entered in each session

        streamWriter = System.IO.File.CreateText(file)

        For index = 0 To inventories.GetUpperBound(0)
            streamWriter.Write(inventories(index).id & ",")
            streamWriter.Write(inventories(index).des & ",")
            streamWriter.Write(inventories(index).qty & ",")
            streamWriter.Write(inventories(index).pricePerUnit & ",")
            streamWriter.Write(inventories(index).flatRate)
            streamWriter.WriteLine()
        Next

        streamWriter.Close()
    End Sub

End Class