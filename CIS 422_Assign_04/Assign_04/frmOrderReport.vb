'------------------------------------------------------------
'-             File Name : frmOrderReport.vb                - 
'-              Part of Project: Assign_04                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 10/23/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the source code for the report GUI and-
'- all the events to show the user all types of reports     -
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
'- lstCusts - all customers in the db                       -
'------------------------------------------------------------

Imports System.Data.SqlClient

Structure OrdersWithCusts
    Public Property intCustTUID As Int32
    Public Property strCustName As String
    Public Property intAssemArea As Int32
    Public Property dtStartTime As DateTime
    Public Property dtEndTime As DateTime
End Structure

Structure CustomersReport
    Public Property intTUID As Int32
    Public Property strCustName As String
    Public Property strPhoneNumber As String
End Structure

Structure InventoryReport
    Public Property intTUID As Int32
    Public Property strInvenName As String
    Public Property intinitialQTY As Int32
    Public Property intCurrentQTY As Int32
End Structure

Structure OrderToProducts
    Public Property strCustName As String
    Public Property intOrderTUID As Int32
    Public Property strProductName As String
    Public Property intQuantityOrdered As Int32
End Structure
Public Class frmOrderReport
    Dim lstCusts As New List(Of CustomersReport)

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the GUI loads and loads  -
    '- customer list and the dgv with the order table info      -
    '------------------------------------------------------------
    Private Sub frmOrderReport_Load(sender As Object, e As EventArgs) Handles Me.Load
        Call LoadOrdersWithCusts(gstrConnString)
        Call LoadCustsList(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user clicks to show  -
    '- the reports of the order table                           -
    '------------------------------------------------------------
    Private Sub btnCustsWithOrders_Click(sender As Object, e As EventArgs) Handles btnCustsWithOrders.Click
        Call LoadOrdersWithCusts(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user clicks to show  -
    '- all the customers in the db                              -
    '------------------------------------------------------------
    Private Sub btnCustomers_Click(sender As Object, e As EventArgs) Handles btnCustomers.Click
        Call LoadCustomersReport()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the user wants to see the-
    '- inventory report, showing initial inventory values and   -
    '- the current inventory with all orders factored in        -
    '------------------------------------------------------------
    Private Sub btnInventory_Click(sender As Object, e As EventArgs) Handles btnInventory.Click
        Call LoadInventory(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called when the wants to show the    -
    '- order to product report, showing the customer, order num,-
    '- the product ordered and the quantity they ordered        -
    '------------------------------------------------------------
    Private Sub btnOrderToProds_Click(sender As Object, e As EventArgs) Handles btnOrderToProds.Click
        Call LoadOrdersToProds(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is does the heavy lifting of when the   -
    '- user wants to see the orders with customer, the assembley-
    '- area in charge of the order, and the start/end times of  -
    '- the order                                                -
    '------------------------------------------------------------
    Sub LoadOrdersWithCusts(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        Dim strCusts As String = "Customer_Table"
        Dim strOrders As String = "Order_Table"
        Dim lstOrdersWithCusts As New List(Of OrdersWithCusts)
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT " & strCusts & ".TUID, " & strCusts & ".Customer_Name, " & strOrders & ".Assembley_Area, " &
            strOrders & ".Order_Start_Date_Time, " & strOrders & ".Order_End_Date_Time " &
            "FROM " & strCusts & " INNER JOIN " & strOrders & " ON " & strCusts & ".TUID = " & strOrders & ".Customer_TUID"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "CustsAndOrders")
        For Each customers In genDS.Tables(0).AsEnumerable
            Dim currentOrder As New OrdersWithCusts With {
                .intCustTUID = customers(0),
                .strCustName = customers(1),
                .intAssemArea = customers(2),
                .dtStartTime = customers(3),
                .dtEndTime = customers(4)
            }
            lstOrdersWithCusts.Add(currentOrder)
        Next
        DBConn.Close()
        dgvReport.DataSource = lstOrdersWithCusts
        dgvReport.RowHeadersVisible = False
        dgvReport.Columns("intCustTUID").HeaderText = "Customer ID"
        dgvReport.Columns("strCustName").HeaderText = "Customer Name"
        dgvReport.Columns("intAssemArea").HeaderText = "Assembley Area"
        dgvReport.Columns("dtStartTime").HeaderText = "Order Start Time"
        dgvReport.Columns("dtEndTime").HeaderText = "Order End Time"
        dgvReport.AutoResizeColumns()
        dgvReport.Refresh()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program loads the customer list so it can be    -
    '- used with the report of the order table and the order to -
    '- product table, making it more friendly using the customer-
    '- name instead of only showing the customer TUID           -
    '------------------------------------------------------------
    Sub LoadCustsList(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        lstCusts.Clear()
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT * FROM Customer_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "Custs")
        For Each customers In genDS.Tables(0).AsEnumerable
            Dim currentCust As New CustomersReport With {
                .intTUID = customers(0),
                .strCustName = customers(1),
                .strPhoneNumber = customers(2)
            }
            lstCusts.Add(currentCust)
        Next
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is called to display the contents of the-
    '- customer list                                            -
    '------------------------------------------------------------
    Sub LoadCustomersReport()
        Call LoadCustsList(gstrConnString)
        dgvReport.DataSource = lstCusts
        dgvReport.RowHeadersVisible = False
        dgvReport.Columns("intTUID").HeaderText = "Customer ID"
        dgvReport.Columns("strCustName").HeaderText = "Customer Name"
        dgvReport.Columns("strPhoneNumber").HeaderText = "Customer Phone Number"
        dgvReport.AutoResizeColumns()
        dgvReport.Refresh()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the heavy lifting when the user    -
    '- wants to see the inventory report and then loads the dgv -
    '- with the intial inventory quantity on hand and the new   -
    '- quantity after all the orders are filled                 - 
    '------------------------------------------------------------
    Sub LoadInventory(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        Dim lstInventory As New List(Of InventoryReport)
        lstInventory.Clear()
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT * FROM Inventory_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "Custs")
        For Each intialInven In listOfInitialInventory
            For Each inventory In genDS.Tables(0).AsEnumerable
                If (intialInven.intInventory_TUID = inventory(0)) Then
                    Dim currentInven As New InventoryReport With {
                    .intTUID = inventory(0),
                    .strInvenName = inventory(1),
                    .intinitialQTY = intialInven.intQty_On_Hand,
                    .intCurrentQTY = inventory(2)
                    }
                    lstInventory.Add(currentInven)
                End If
            Next
        Next
        DBConn.Close()
        dgvReport.DataSource = lstInventory
        dgvReport.RowHeadersVisible = False
        dgvReport.Columns("intTUID").HeaderText = "Inventory ID"
        dgvReport.Columns("strInvenName").HeaderText = "Inventory Product Name"
        dgvReport.Columns("intinitialQTY").HeaderText = "Initial Quantity"
        dgvReport.Columns("intCurrentQTY").HeaderText = "Current Quantity"
        dgvReport.AutoResizeColumns()
        dgvReport.Refresh()
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program does the heavy lifting when the user    -
    '- wants to see the orders to product report, showing the   -
    '- customer name, the order number, the product name, and   -
    '- quantity ordered of each product                         -
    '------------------------------------------------------------
    Sub LoadOrdersToProds(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As New SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        Dim strProduct As String = "Product_Table"
        Dim strOrdersToProd As String = "Order_To_Product_Table"
        Dim lstOrdersToProduct As New List(Of OrderToProducts)
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT " & strOrdersToProd & ".Order_TUID, " & strProduct & ".Product_Name, " & strOrdersToProd & ".Quantity_Ordered FROM " & strProduct & " INNER JOIN " & strOrdersToProd & " ON " & strProduct & ".TUID = " & strOrdersToProd & ".Product_TUID"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "Orders")
        For Each orders In genDS.Tables(0).AsEnumerable
            For Each orderInList In orderList
                If (orderInList.orderNumber = orders(0)) Then
                    For Each cust In lstCusts
                        If (cust.intTUID = orderInList.custNumber) Then
                            Dim currentProd As New OrderToProducts With {
                            .strCustName = cust.strCustName,
                            .intOrderTUID = orders(0),
                            .strProductName = orders(1),
                            .intQuantityOrdered = orders(2)
                            }
                            lstOrdersToProduct.Add(currentProd)
                        End If
                    Next
                End If
            Next
        Next
        DBConn.Close()
        dgvReport.DataSource = lstOrdersToProduct
        dgvReport.RowHeadersVisible = False
        dgvReport.Columns("strCustName").HeaderText = "Customer Name"
        dgvReport.Columns("intOrderTUID").HeaderText = "Order ID"
        dgvReport.Columns("strProductName").HeaderText = "Product Name"
        dgvReport.Columns("intQuantityOrdered").HeaderText = "Quantity Ordered"
        dgvReport.AutoResizeColumns()
        dgvReport.Refresh()
    End Sub
End Class