'------------------------------------------------------------
'-             File Name : frmAssign_04.vb                  - 
'-              Part of Project: Assign_04                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 10/23/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the source code for the GUI and all   -
'- events that can be caused by the GUI                     -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to interact with the database  -
'- called Plastico. Plastico is a manufacturing company that-
'- makes plastic products. This program is an order dispatch-
'- system for plastico which allows the user to create an   -
'- order through the GUI, create new customers, reset the   -
'- database to starting orders info, it also allows the user-
'- to use a new order file through the fileopen dialog, and -
'- also shows reports on all info in the database           -
'------------------------------------------------------------
'- Class/Global Variable Dictionary:                        -
'- (None)                                                   -
'------------------------------------------------------------

Imports System.Data.SqlClient
Imports System.IO

Public Class frmAssign_04

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the GUI loads and hides  -
    '- all the pannels that will be visible once the user clicks-
    '- on what they want to do                                  -
    '------------------------------------------------------------
    Private Sub frmAssign_04_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call ClosePannels()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to create -
    '- a new customer, it shows the right pannels and makes sure-
    '- the fields are all cleared                               -
    '------------------------------------------------------------
    Private Sub btnCreateNewCust_Click(sender As Object, e As EventArgs) Handles btnCreateNewCust.Click
        pnlNewCust.Visible = True
        pnlAddOrder.Visible = False
        txtName.Text = ""
        txtPhone.Text = ""
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user decides to not  -
    '- submit the new customer to the db                        -
    '------------------------------------------------------------
    Private Sub btnCancelCust_Click(sender As Object, e As EventArgs) Handles btnCancelCust.Click
        Call ClosePannels()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to submit -
    '- the new customer to the customer table and makes sure    -
    '- there is data entered in the fields                      -
    '------------------------------------------------------------
    Private Sub btnSubmitCust_Click(sender As Object, e As EventArgs) Handles btnSubmitCust.Click
        If (txtName.Text <> "" And txtPhone.Text <> "(   )    -") Then
            Call InsertCust(gstrConnString)
        End If
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to create -
    '- a new order, it shows the create order pannel and all the-
    '- values are all cleared for the user to input info        -
    '------------------------------------------------------------
    Private Sub btnNewOrder_Click(sender As Object, e As EventArgs) Handles btnNewOrder.Click
        txtCustID.Text = ""
        txtOrderTUID.Text = ""
        txtProductName.Text = ""
        txtQTY.Text = ""
        pnlNewCust.Visible = False
        pnlAddOrder.Visible = True
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user decides they    -
    '- want to cancel adding the order to the db                -
    '------------------------------------------------------------
    Private Sub btnCancelOrder_Click(sender As Object, e As EventArgs) Handles btnCancelOrder.Click
        ClosePannels()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user hits submit to  -
    '- adding a new order, it calls the sub to verify all info  -
    '- is correct in the fields                                 -
    '------------------------------------------------------------
    Private Sub btnSubmitOrder_Click(sender As Object, e As EventArgs) Handles btnSubmitOrder.Click
        Call VerifyOrder()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to reset  -
    '- the database to a clean version using the default order  -
    '- file                                                     -
    '------------------------------------------------------------
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Call PopulateAllTables(True)
        Call ClosePannels()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to use a  -
    '- new order file, it verifies the file chosen was a .txt   -
    '- and then calls the populate all table sub but uses the   -
    '- file the user clicked on                                 -
    '------------------------------------------------------------
    Private Sub btnNewFile_Click(sender As Object, e As EventArgs) Handles btnNewFile.Click
        Dim strExtension As String
        Call ClosePannels()
        fdNewFile.ShowDialog()
        gstrNewFileName = fdNewFile.FileName
        strExtension = Path.GetExtension(gstrNewFileName)
        If (strExtension = ".txt") Then
            Call PopulateAllTables(False)
        Else
            MessageBox.Show("Only .txt files accepted")
        End If
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to view   -
    '- reports of the current db and shows the new form that has-
    '- a dgv that shows all important reports                   -
    '------------------------------------------------------------
    Private Sub btnReports_Click(sender As Object, e As EventArgs) Handles btnReports.Click
        Call ClosePannels()
        frmOrderReport.Show()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user submits the new -
    '- customer to the db, this does the actual inserting into  -
    '- the db                                                   -
    '------------------------------------------------------------
    Sub InsertCust(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        Dim intTUID As Int32
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "SELECT MAX(TUID) FROM Customer_Table"
        DBCmd.Connection = DBConn
        intTUID = DBCmd.ExecuteScalar + 1
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('" & intTUID & "', '" & txtName.Text & "', '" & txtPhone.Text & "')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        Call ClosePannels()
        Call UpdateCustList(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user submits the new -
    '- order, it verifies that all proper formats are given, the-
    '- customer exists, the order number has not been used and  -
    '- checks that the product exists and the quantity is a     -
    '- number to make sure the program doesnt do math on bad    -
    '- data                                                     -
    '------------------------------------------------------------
    Sub VerifyOrder()
        Dim strUpperName As String
        Dim bolGoodName As Boolean = False
        Dim bolGoodCust As Boolean = False
        Dim bolGoodOrderNum As Boolean = False
        Dim bolOrderNum As Boolean = False
        Dim bolGoodQTY As Boolean = False
        Dim intNum As Int32
        Dim strInputOrderNum As String
        Dim strQTYInput As String
        Dim strCustID As String
        Dim intProdID As Int32
        Dim intProdTime As Int32
        Dim strProdName As String = ""
        strCustID = txtCustID.Text
        If (Integer.TryParse(strCustID, intNum) = True) Then
            For Each cust In listOfCustomers
                If (txtCustID.Text = cust.intTUID) Then
                    bolGoodCust = True
                End If
            Next
        End If
        If (bolGoodCust = False) Then
            MessageBox.Show("Customer does not exist, please enter valid customer")
        End If
        strInputOrderNum = txtOrderTUID.Text
        If (Integer.TryParse(strInputOrderNum, intNum) = True) Then
            bolOrderNum = True
        End If
        If (bolOrderNum = False) Then
            MessageBox.Show("Enter valid order number")
        End If
        Try
            For Each order In orderList
                If (bolOrderNum = True And (txtOrderTUID.Text = order.orderNumber)) Then
                    bolGoodOrderNum = False
                    Exit Try
                Else
                    bolGoodOrderNum = True
                End If
            Next
        Finally
        End Try
        If (bolGoodOrderNum = False) Then
            MessageBox.Show("Order number already exists, enter valid order number")
        End If
        strUpperName = txtProductName.Text.ToUpper
        For Each prod In listOfProds
            If (strUpperName = prod.strProductName) Then
                bolGoodName = True
                intProdID = prod.intTUID
                intProdTime = prod.intAssemTime
                strProdName = prod.strProductName
            End If
        Next
        If (bolGoodName = False) Then
            MessageBox.Show("Product does not exist, please enter valid product name")
        End If
        strQTYInput = txtQTY.Text
        If (Integer.TryParse(strQTYInput, intNum) = True) Then
            bolGoodQTY = True
        End If
        If (bolGoodQTY = False) Then
            MessageBox.Show("Enter valid quantity")
        End If
        If (bolGoodCust = True And bolGoodName = True And bolGoodOrderNum = True And bolGoodQTY = True And bolOrderNum = True) Then
            Call AddOrder(gstrConnString, intProdID, intProdTime, strProdName)
            Call ClosePannels()
        End If
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is does the heavy lifting of inserting  -
    '- the new order to the order to product table and does all -
    '- the math required to add it to the order table and then  -
    '- adds it to the list to make sure the reports are up to   -
    '- data even when the user adds an order through the GUI    -
    '------------------------------------------------------------
    Sub AddOrder(ByVal strConn As String, prodID As Int32, assemTime As Int32, prodName As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        Dim intOrder_To_Prod_TUID As Int32
        Dim intOrder_TUID As Int32
        Dim dtCurrentOpenAssem As DateTime
        Dim dtNextAssem As DateTime
        Dim dtStartTime As DateTime
        Dim dtEndTime As DateTime
        Dim intCount As Int32 = 0
        Dim intNextAssemArea As Int32
        Dim intOrderTime As Int32 = txtQTY.Text * assemTime
        listOfOrdersWithProdTUID.Clear()
        dicOfInvenChange.Clear()
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "SELECT MAX(TUID) FROM Order_To_Product_Table"
        DBCmd.Connection = DBConn
        intOrder_To_Prod_TUID = DBCmd.ExecuteScalar + 1
        DBCmd.CommandText = "INSERT INTO Order_To_Product_Table (TUID, Order_TUID, Product_TUID, Quantity_Ordered) " &
        "VALUES('" & intOrder_To_Prod_TUID & "', '" & txtOrderTUID.Text & "', '" & prodID & "', '" & txtQTY.Text & "')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        For Each nextorder In dicOrderTable
            intCount += 1
            dtNextAssem = nextorder.Value
            If (dtNextAssem < dtCurrentOpenAssem Or intCount = 1) Then
                dtCurrentOpenAssem = nextorder.Value
                intNextAssemArea = nextorder.Key
            End If
        Next
        dicOrderTable.Remove(intNextAssemArea)
        dtStartTime = dtCurrentOpenAssem
        dtEndTime = dtCurrentOpenAssem.Add(TimeSpan.FromMinutes(intOrderTime))
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "SELECT MAX(TUID) FROM Order_Table"
        DBCmd.Connection = DBConn
        intOrder_TUID = DBCmd.ExecuteScalar + 1
        DBCmd.CommandText = "INSERT INTO Order_Table (TUID, Customer_TUID, Assembley_Area, Order_Start_Date_Time, Order_End_Date_Time) " &
        "VALUES('" & intOrder_TUID & "', '" & txtCustID.Text & "', '" & intNextAssemArea & "', '" & dtStartTime & "', '" & dtEndTime & "')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        Dim order As New OrdersToProduct With {
            .custNumber = txtCustID.Text,
            .orderNumber = txtOrderTUID.Text,
            .itemName = prodName,
            .quantity = txtQTY.Text
        }
        orderList.Add(order)
        Dim nextCurrentOrder As New OrderTable With {
                    .intTUID = intOrder_TUID,
                    .intCustomer_TUID = txtCustID.Text,
                    .intAssembley_Area = intNextAssemArea,
                    .dtOrder_Start_Time = dtStartTime,
                    .dtOrder_End_Time = dtEndTime
        }
        orderTableList.Add(nextCurrentOrder)
        dicOrderTable.Add(intNextAssemArea, nextCurrentOrder.dtOrder_End_Time)
        Dim tempOrder As New OrdersWithProdTUID With {
            .intProductTUID = prodID,
            .intOrderNumber = txtOrderTUID.Text,
            .intQTY = txtQTY.Text
        }
        listOfOrdersWithProdTUID.Add(tempOrder)
        Call ChangeInInventory(gstrConnString)
        Call ClosePannels()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub clears out all text boxes then makes sure the   -
    '- pannels are closed                                       -
    '------------------------------------------------------------
    Sub ClosePannels()
        txtName.Text = ""
        txtPhone.Text = ""
        txtCustID.Text = ""
        txtOrderTUID.Text = ""
        txtProductName.Text = ""
        txtQTY.Text = ""
        pnlNewCust.Visible = False
        pnlAddOrder.Visible = False
    End Sub
End Class