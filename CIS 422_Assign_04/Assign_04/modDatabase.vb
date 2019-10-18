'------------------------------------------------------------
'-              File Name : modDatabase.vb                  - 
'-              Part of Project: Assign_04                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 10/23/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains source code to populate all tables in -
'- the database, reads order file in to populate the order  -
'- to product table, heavy lifting to dispatch the proper   -
'- order to the right assembley area, and also creates lists-
'- that can be accessed through out the rest of the program -
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
'- CurrentInventory - list of current inventory after orders-
'- FullOrderTime- holds each order and how long it will take-
'- OfInvenChange- how much inventory is used in all orders  -
'- OrderTable - holds assembley area and end time           -
'- ProductIDInOrder - all prod ids in each order            -
'- ConnString - db connection string                        -
'- DBName - db's name                                       -
'- DBPath - db's path                                       -
'- NewFileName - if user uses a different order file        -
'- OriginalFileName - default order file name               -
'- ServerName - local computer's server name                -
'- listOfBOM - all products BOM                             -
'- listOfCustomers - all customers in table                 -
'- InitialInventory - initial inventory before orders       -
'- InvenChange - how much inventory is spoken in all orders -
'- NewInventory- how much inventory is left after all orders-
'- Orders - order numbers                                   -
'- OrdersWithProdTUID - order number with product id        -
'- OrdersWithTime - each items time with quantity ordered   -
'- Prods - all products made by plastico                    -
'- orderList - orders with custid included                  -
'- orderTableList - holds all orders with assem area with   -
'-      start/end times                                     -
'------------------------------------------------------------

Imports System.Data.SqlClient

Structure OrdersToProduct
    Public custNumber As String
    Public orderNumber As String
    Public itemName As String
    Public quantity As String
End Structure

Structure OrdersWithTime
    Public intOrderID As Int32
    Public intProdID As Int32
    Public intAssemTime As Int32
    Public intQTYOrdered As Int32
    Public intTotalTime As Int32
End Structure

Structure OrderTable
    Public intTUID As Int32
    Public intCustomer_TUID As Int32
    Public intAssembley_Area As Int32
    Public dtOrder_Start_Time As DateTime
    Public dtOrder_End_Time As DateTime
End Structure

Structure OrdersWithProdTUID
    Public intOrderNumber As Int32
    Public intProductTUID As Int32
    Public intQTY As Int32
End Structure

Structure ProductsWithBOM
    Public intProdTUID As Int32
    Public intInvenTUID As Int32
    Public intQTYInProduct As Int32
End Structure

Structure OrdersBOM
    Public intInvenTUID As Int32
    Public intQTY As Int32
End Structure

Structure Inventory
    Public intInventory_TUID As Int32
    Public strInventory_Name As String
    Public intQty_On_Hand As Int32
End Structure

Structure InitalInventory
    Public intInventory_TUID As Int32
    Public strInventory_Name As String
    Public intQty_On_Hand As Int32
End Structure

Structure Products
    Public intTUID As Int32
    Public strProductName As String
    Public intAssemTime As Int32
End Structure

Structure Customers
    Public intTUID As Int32
    Public strName As String
    Public phoneNumber As String
End Structure
Module modDatabase
    Public dicCurrentInventory As New Dictionary(Of Int32, Inventory)
    Public dicFullOrderTime As New Dictionary(Of Int32, Int32)
    Public dicOfInvenChange As New Dictionary(Of Int32, Int32)
    Public dicOrderTable As New Dictionary(Of Int32, DateTime)
    Public dicProductIDInOrder As New Dictionary(Of Int32, List(Of Int32))
    Public gstrConnString = "SERVER=" & gstrServerName & ";DATABASE=" &
                gstrDBName & ";Integrated Security=SSPI;AttachDbFileName=" &
                gstrDBPath
    Public Const gstrDBName As String = "Plastico"
    Public gstrDBPath As String = My.Application.Info.DirectoryPath & "\" & gstrDBName & ".mdf"
    Public gstrNewFileName As String
    Public Const gstrOriginalFileName = "Orders.txt"
    Public Const gstrServerName As String = "(localdb)\MSSQLLocalDB"
    Public listOfBOM As New List(Of ProductsWithBOM)
    Public listOfCustomers As New List(Of Customers)
    Public listOfInitialInventory As New List(Of InitalInventory)
    Public listOFInvenChange As New List(Of OrdersBOM)
    Public listOfNewInventory As New List(Of Inventory)
    Public listOfOrders As New List(Of Int32)
    Public listOfOrdersWithProdTUID As New List(Of OrdersWithProdTUID)
    Public listOfOrdersWithTime As New List(Of OrdersWithTime)
    Public listOfProds As New List(Of Products)
    Public orderList As New List(Of OrdersToProduct)
    Public orderTableList As New List(Of OrderTable)

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program creates the database if the file is not -
    '- found and then calls the populate all table sub          -
    '------------------------------------------------------------
    Sub MakeDatabase()
        Dim strConn As String
        strConn = gstrConnString
        Call CreateDatabase(strConn)
        Call PopulateAllTables(True)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program creates the database and all tables     -
    '------------------------------------------------------------
    Sub CreateDatabase(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd As SqlCommand
        Dim strSQLCmd As String
        DBConn = New SqlConnection("Server=" & gstrServerName)
        strSQLCmd = "CREATE DATABASE " & gstrDBName & " On " &
            "(NAME = '" & gstrDBName & "', " &
            "FILENAME = '" & gstrDBPath & "')"
        DBCmd = New SqlCommand(strSQLCmd, DBConn)
        Try
            DBConn.Open()
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Database: " & gstrDBName & "has been created", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Database: " & gstrDBName & "Could not be created. Program will now terminate", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
            frmAssign_04.Close()
        End Try
        If (DBConn.State = ConnectionState.Open) Then
            DBConn.Close()
        End If
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "CREATE TABLE Inventory_Table (" &
            "TUID int PRIMARY KEY, " &
            "Inventory_Name varchar(50), " &
            "Quantity_On_Hand int)"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Inventory Table created")
        Catch ex As Exception
            MessageBox.Show("Inventory Table already exists")
        End Try
        DBCmd.CommandText = "CREATE TABLE Product_Table (" &
        "TUID int PRIMARY KEY, " &
        "Product_Name varchar(50), " &
        "Assembley_Time int)"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Product Table created")
        Catch ex As Exception
            MessageBox.Show("Product Table already exists")
        End Try
        DBCmd.CommandText = "CREATE TABLE BOM_Table (" &
        "TUID int PRIMARY KEY, " &
        "Product_TUID int, " &
        "Inventory_TUID int, " &
        "Quantity_Required_In_Build int)"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("BOM Table created")
        Catch ex As Exception
            MessageBox.Show("BOM Table already exists")
        End Try
        DBCmd.CommandText = "CREATE TABLE Order_Table (" &
        "TUID int PRIMARY KEY, " &
        "Customer_TUID int, " &
        "Assembley_Area int, " &
        "Order_Start_Date_Time smalldatetime," &
        "Order_End_Date_Time smalldatetime)"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Order Table created")
        Catch ex As Exception
            MessageBox.Show("Order Table already exists")
        End Try
        DBCmd.CommandText = "CREATE TABLE Order_To_Product_Table (" &
        "TUID int PRIMARY KEY, " &
        "Order_TUID int, " &
        "Product_TUID int, " &
        "Quantity_Ordered int)"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Order To Product Table created")
        Catch ex As Exception
            MessageBox.Show("Order To Product Table already exists")
        End Try
        DBCmd.CommandText = "CREATE TABLE Customer_Table (" &
        "TUID int PRIMARY KEY, " &
        "Customer_Name varchar(50), " &
        "Phone_Number varchar(50))"
        DBCmd.Connection = DBConn
        Try
            DBCmd.ExecuteNonQuery()
            MessageBox.Show("Customer Table created")
        Catch ex As Exception
            MessageBox.Show("Customer To Product Table already exists")
        End Try
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program deletes all rows from a specific table  -
    '------------------------------------------------------------
    Sub CleanOutTable(ByVal strConn As String, ByVal strTableName As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "DELETE FROM " & strTableName
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program cleans out all the lists (in case of    -
    '- file chane) then deletes all rows from all tables and    -
    '- then calls each function to populate each table with     -
    '- initial values                                           -
    '------------------------------------------------------------
    Sub PopulateAllTables(ByVal defaultFile As Boolean)
        Dim strConn As String = gstrConnString
        dicProductIDInOrder.Clear()
        listOfOrders.Clear()
        listOfOrdersWithTime.Clear()
        dicFullOrderTime.Clear()
        orderList.Clear()
        orderTableList.Clear()
        dicOrderTable.Clear()
        listOfOrdersWithProdTUID.Clear()
        listOfBOM.Clear()
        listOFInvenChange.Clear()
        dicOfInvenChange.Clear()
        dicCurrentInventory.Clear()
        listOfNewInventory.Clear()
        listOfProds.Clear()
        listOfCustomers.Clear()
        Call CleanOutTable(strConn, "Inventory_Table")
        Call CleanOutTable(strConn, "Product_Table")
        Call CleanOutTable(strConn, "BOM_Table")
        Call CleanOutTable(strConn, "Order_Table")
        Call CleanOutTable(strConn, "Order_To_Product_Table")
        Call CleanOutTable(strConn, "Customer_Table")
        MessageBox.Show("Deleted all rows in all tables")
        Call PopulateInventoryTable(strConn)
        Call PopulateProductTable(strConn)
        Call PopulateBOMTable(strConn)
        If (defaultFile = True) Then
            Call PopulateOrderToProductTable(strConn, gstrOriginalFileName)
        ElseIf (defaultFile = False) Then
            Call PopulateOrderToProductTable(strConn, gstrNewFileName)
        End If
        Call PopulateCustomerTable(strConn)
        MessageBox.Show("Populated all tables")
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populates the inventory to the initial  -
    '- values and calls the populateinitialinventory list to be -
    '- able to see how much the inventory changes with all the  -
    '- orders                                                   -
    '------------------------------------------------------------
    Sub PopulateInventoryTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
            "VALUES('1', 'Tops', '1000')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
        "VALUES('2', 'Legs', '1500')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
        "VALUES('3', 'Fasteners', '5000')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
        "VALUES('4', 'Short Sides', '1500')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
        "VALUES('5', 'Long Sides', '1500')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Inventory_Table (TUID, Inventory_Name, Quantity_On_Hand) " &
       "VALUES('6', 'Wheels', '2000')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        listOfInitialInventory.Clear()
        Call LoadInitalInventory(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populate the product table              -
    '------------------------------------------------------------
    Sub PopulateProductTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "INSERT INTO Product_Table (TUID, Product_Name, Assembley_Time) " &
        "VALUES('1', 'Table', '10')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Product_Table (TUID, Product_Name, Assembley_Time) " &
        "VALUES('2', 'Wagon', '20')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Product_Table (TUID, Product_Name, Assembley_Time) " &
        "VALUES('3', 'Skateboard', '5')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Product_Table (TUID, Product_Name, Assembley_Time) " &
        "VALUES('4', 'Chair', '15')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        Call AddProductsToList(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populates the BOM for each product made -
    '------------------------------------------------------------
    Sub PopulateBOMTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        'table
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('1', '1', '1', '1')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('2', '1', '2', '4')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('3', '1', '3', '4')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        'wagon
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('4', '2', '1', '1')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('5', '2', '6', '8')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('6', '2', '3', '8')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('7', '2', '5', '2')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('8', '2', '4', '2')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        'skateboard
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('9', '3', '5', '1')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('10', '3', '6', '4')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('11', '3', '3', '4')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        'chair
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('12', '4', '1', '1')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('13', '4', '4', '1')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('14', '4', '2', '4')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO BOM_Table (TUID, Product_TUID, Inventory_TUID, Quantity_Required_In_Build) " &
        "VALUES('15', '4', '3', '6')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populates the customer table with the   -
    '- initial batch of customers to satisfy the default order  -
    '- file                                                     -
    '------------------------------------------------------------
    Sub PopulateCustomerTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('104', 'Jack W', '(586) 111-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('117', 'Will B', '(586) 222-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('102', 'Jane K', '(586) 333-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('109', 'Chris P Bacon', '(586) 444-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('107', 'Bill F', '(586) 555-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('154', 'Brandon J', '(586) 667-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('143', 'Sam O', '(586) 777-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('119', 'Sarah B', '(586) 888-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('137', 'Morgan A', '(586) 999-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('147', 'Jim G', '(586) 000-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('132', 'Mary G', '(586) 001-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBCmd.CommandText = "INSERT INTO Customer_Table (TUID, Customer_Name, Phone_Number) " &
        "VALUES('133', 'Sydney G', '(586) 010-1234')"
        DBCmd.Connection = DBConn
        DBCmd.ExecuteNonQuery()
        DBConn.Close()
        Call UpdateCustList(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program reads in the file that will be used to  -
    '- populate the ordertoproduct table                        -
    '------------------------------------------------------------
    Sub PopulateOrderToProductTable(ByVal strConn As String, ByVal file As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        Dim streamReader As System.IO.StreamReader
        Dim intTUIDCount As Int32 = 0
        Dim intProductTUID As Int32
        If System.IO.File.Exists(file) Then
            streamReader = System.IO.File.OpenText(file)
            Dim line As String
            Dim data(3) As String
            Dim tempData() As String = IO.File.ReadAllLines(file)
            For intLine As Integer = 0 To tempData.Count - 1
                line = tempData(intLine)
                data = line.Split(vbTab & "c")
                Dim tempOrder As OrdersToProduct
                tempOrder.custNumber = data(0)
                tempOrder.orderNumber = data(1)
                tempOrder.itemName = data(2)
                tempOrder.quantity = data(3)
                orderList.Add(tempOrder)
            Next
        End If
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        For Each order As OrdersToProduct In orderList
            intTUIDCount += 1
            DBCmd.CommandText = "SELECT TUID FROM Product_Table WHERE Product_Name ='" & order.itemName & "'"
            DBCmd.Connection = DBConn
            intProductTUID = DBCmd.ExecuteScalar
            DBCmd.CommandText = "INSERT INTO Order_To_Product_Table (TUID, Order_TUID, Product_TUID, Quantity_Ordered) " &
            "VALUES('" & intTUIDCount & "', '" & order.orderNumber & "', '" & intProductTUID & "', '" & order.quantity & "')"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()
            Dim tempOrder As New OrdersWithProdTUID With {
            .intProductTUID = intProductTUID,
            .intOrderNumber = order.orderNumber,
            .intQTY = order.quantity
            }
            listOfOrdersWithProdTUID.Add(tempOrder)
        Next
        DBConn.Close()
        Call PopulateOrderList(strConn)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program is an intermediate step between the     -
    '- ordertable and ordertoproduct table, it populates the    -
    '- lists that will be used to figure out each order's full  -
    '- production time                                          -
    '------------------------------------------------------------
    Sub PopulateOrderList(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        Dim intCurrentTime As Int32
        Dim intTotalTime As Int32
        Dim intTemp As Int32
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT DISTINCT Order_TUID FROM Order_To_Product_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "Orders")
        For Each orders In genDS.Tables(0).AsEnumerable
            intTemp = orders.Field(Of Int32)("Order_TUID")
            listOfOrders.Add(intTemp)
        Next
        genDS.Reset()
        DBGenAdapt.Dispose()
        strDBCommand = "SELECT Product_Table.TUID, Product_Table.Assembley_Time, Order_To_Product_Table.Quantity_Ordered, Order_To_Product_Table.Order_TUID " &
            "FROM Product_Table INNER JOIN Order_To_Product_Table ON Product_Table.TUID = Order_To_Product_Table.Product_TUID"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "ProdID")
        For Each orders In genDS.Tables(0).AsEnumerable
            Dim currentOrder As New OrdersWithTime With {
                .intOrderID = orders(3),
                .intProdID = orders(0),
                .intAssemTime = orders(1),
                .intQTYOrdered = orders(2),
                .intTotalTime = orders(1) * orders(2)
            }
            listOfOrdersWithTime.Add(currentOrder)
        Next
        For Each currentOrder In listOfOrdersWithTime
            If (dicFullOrderTime.ContainsKey(currentOrder.intOrderID)) Then
                intCurrentTime = dicFullOrderTime.Item(currentOrder.intOrderID)
                intTotalTime = currentOrder.intTotalTime + intCurrentTime
                dicFullOrderTime.Remove(currentOrder.intOrderID)
                dicFullOrderTime.Add(currentOrder.intOrderID, intTotalTime)
            Else
                dicFullOrderTime.Add(currentOrder.intOrderID, currentOrder.intTotalTime)
            End If
        Next
        DBConn.Close()
        Call PopulateOrderTable(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populates the order table with all      -
    '- calculations to figure out which assembley area which    -
    '- orders will be filled at and also their start and end    -
    '- times and then it populates the ordertable with all the  -
    '- proper information                                       - 
    '------------------------------------------------------------
    Sub PopulateOrderTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd = New SqlCommand
        Dim TUID As Int32 = 0
        Dim intCustID As Int32
        Dim intAssemArea As Int32 = 0
        Dim dtStart As DateTime
        Dim dtEnd As DateTime
        Dim dblFullOrderTime As Double
        Dim intOrderNumber As Int32
        Dim dtCurrentOpenAssem As DateTime
        Dim dtNextAssem As DateTime
        Dim intCount As Int32
        Dim intNextAssemArea As Int32
        Dim intOrderOn As Int32
        Dim testCustID As Int32
        Dim intTestOrderNum As Int32
        Dim intTesttime As Double
        Dim dtTeststart As DateTime
        Dim dtTestend As DateTime
        dtStart = DateTime.Today.AddDays(1)
        For intIndex = 0 To 4
            TUID += 1
            intAssemArea += 1
            dblFullOrderTime = dicFullOrderTime.Values(intIndex)
            intOrderNumber = dicFullOrderTime.Keys(intIndex)
            dtEnd = dtStart.Add(TimeSpan.FromMinutes(dblFullOrderTime))
            For Each order In orderList
                If (order.orderNumber = intOrderNumber) Then
                    intCustID = order.custNumber
                End If
            Next
            Dim currentOrder As New OrderTable With {
                .intTUID = TUID,
                .intCustomer_TUID = intCustID,
                .intAssembley_Area = intAssemArea,
                .dtOrder_Start_Time = dtStart,
                .dtOrder_End_Time = dtEnd
            }
            orderTableList.Add(currentOrder)
            dicOrderTable.Add(intAssemArea, currentOrder.dtOrder_End_Time)
        Next
        For intIndex = 5 To dicFullOrderTime.Count - 1
            intCount = 0
            intOrderOn = 0
            For Each nextOrder In dicOrderTable
                intCount += 1
                dtNextAssem = nextOrder.Value
                If (dtNextAssem < dtCurrentOpenAssem Or intCount = 1) Then
                    dtCurrentOpenAssem = nextOrder.Value
                    intNextAssemArea = nextOrder.Key
                Else
                End If
            Next
            intOrderOn = intIndex
            dicOrderTable.Remove(intNextAssemArea)
            intTestOrderNum = dicFullOrderTime.Keys.ElementAt(intOrderOn)
            intTesttime = dicFullOrderTime.Values.ElementAt(intOrderOn)
            dtTeststart = dtCurrentOpenAssem
            dtTestend = dtTeststart.Add(TimeSpan.FromMinutes(intTesttime))
            For Each order In orderList
                If (order.orderNumber = intTestOrderNum) Then
                    testCustID = order.custNumber
                End If
            Next
            TUID += 1
            Dim nextCurrentOrder As New OrderTable With {
                    .intTUID = TUID,
                    .intCustomer_TUID = testCustID,
                    .intAssembley_Area = intNextAssemArea,
                    .dtOrder_Start_Time = dtTeststart,
                    .dtOrder_End_Time = dtTestend
                }
            orderTableList.Add(nextCurrentOrder)
            dicOrderTable.Add(intNextAssemArea, nextCurrentOrder.dtOrder_End_Time)
        Next
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        For Each orderToSendToDB In orderTableList
            TUID = orderToSendToDB.intTUID
            intCustID = orderToSendToDB.intCustomer_TUID
            intAssemArea = orderToSendToDB.intAssembley_Area
            dtStart = orderToSendToDB.dtOrder_Start_Time
            dtEnd = orderToSendToDB.dtOrder_End_Time
            DBCmd.CommandText = "INSERT INTO Order_Table (TUID, Customer_TUID, Assembley_Area, Order_Start_Date_Time, Order_End_Date_Time) " &
        "VALUES('" & TUID & "', '" & intCustID & "', '" & intAssemArea & "', '" & dtStart & "', '" & dtEnd & "')"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()
        Next
        DBConn.Close()
        Call ChangeInInventory(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds all products plastico makes to a   -
    '- list which will be a helper function in creating a new   -
    '- order through the GUI                                    -
    '------------------------------------------------------------
    Sub AddProductsToList(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT TUID, Product_Name, Assembley_Time " &
            "FROM Product_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "prods")
        For Each products In genDS.Tables(0).AsEnumerable
            Dim currentProduct As New Products With {
                .intTUID = products(0),
                .strProductName = products(1).ToString().ToUpper,
                .intAssemTime = products(2)
            }
            listOfProds.Add(currentProduct)
        Next
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program adds all customers from the customer    -
    '- table and populates the list that will be used for       -
    '- checking if a customer exists to place an order and also -
    '- keeps the list up to date if the user creates a new      -
    '- customer to the customertable through the GUI            -
    '------------------------------------------------------------
    Sub UpdateCustList(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        Dim strDBCommand As String
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT TUID, Customer_Name, Phone_Number " &
            "FROM Customer_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "custs")
        For Each customers In genDS.Tables(0).AsEnumerable
            Dim currentCust As New Customers With {
                .intTUID = customers(0),
                .strName = customers(1),
                .phoneNumber = customers(2)
            }
            listOfCustomers.Add(currentCust)
        Next
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program populates a list with the initial values-
    '- for the inventory for reporting how much orders used up  -
    '- the inventory                                            -
    '------------------------------------------------------------
    Sub LoadInitalInventory(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim strDBCommand As String
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS = New DataSet
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT * FROM Inventory_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "Inventory")
        For Each inventory In genDS.Tables(0).AsEnumerable
            Dim currentInventory As New InitalInventory With {
               .intInventory_TUID = inventory(0),
               .strInventory_Name = inventory(1),
               .intQty_On_Hand = inventory(2)
           }
            listOfInitialInventory.Add(currentInventory)
        Next
        DBConn.Close()
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program calculates how much the inventory       -
    '- changes with all the orders that are placed              -
    '------------------------------------------------------------
    Sub ChangeInInventory(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim strDBCommand As String
        Dim DBGenAdapt As SqlDataAdapter
        Dim genDS As New DataSet
        Dim intInvenQTY As New Int32
        Dim intCurrentQTY As New Int32
        Dim intOverallQTY As New Int32
        dicOfInvenChange.Clear()
        listOFInvenChange.Clear()
        listOfBOM.Clear()
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT Product_TUID, Inventory_TUID,  Quantity_Required_In_Build " &
            "FROM BOM_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "ProdID")
        For Each orders In genDS.Tables(0).AsEnumerable
            Dim currentOrder As New ProductsWithBOM With {
                .intProdTUID = orders(0),
                .intInvenTUID = orders(1),
                .intQTYInProduct = orders(2)
            }
            listOfBOM.Add(currentOrder)
        Next
        DBConn.Close()
        For Each order In listOfOrdersWithProdTUID
            For Each BOM In listOfBOM
                If (order.intProductTUID = BOM.intProdTUID) Then
                    intInvenQTY = order.intQTY * BOM.intQTYInProduct
                    Dim currentProd As New OrdersBOM With {
                    .intInvenTUID = BOM.intInvenTUID,
                    .intQTY = intInvenQTY
                    }
                    listOFInvenChange.Add(currentProd)
                End If
            Next
        Next
        For Each inven In listOFInvenChange
            If (dicOfInvenChange.ContainsKey(inven.intInvenTUID)) Then
                intCurrentQTY = dicOfInvenChange.Item(inven.intInvenTUID)
                intOverallQTY = inven.intQTY + intCurrentQTY
                dicOfInvenChange.Remove(inven.intInvenTUID)
                dicOfInvenChange.Add(inven.intInvenTUID, intOverallQTY)
            Else
                dicOfInvenChange.Add(inven.intInvenTUID, inven.intQTY)
            End If
        Next
        Call UpdateInventoryTable(gstrConnString)
    End Sub

    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program writes the new quantity on hand to the  -
    '- inventory table after orders are complete                -
    '------------------------------------------------------------
    Sub UpdateInventoryTable(ByVal strConn As String)
        Dim DBConn As SqlConnection
        Dim DBCmd As New SqlCommand
        Dim strDBCommand As String
        Dim DBGenAdapt As New SqlDataAdapter
        Dim genDS As New DataSet
        Dim intNewTotal As Int32
        Dim intCurrentID As Int32
        listOfNewInventory.Clear()
        dicCurrentInventory.Clear()
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        strDBCommand = "SELECT TUID, Inventory_Name, Quantity_On_Hand " &
            "FROM Inventory_Table"
        DBGenAdapt = New SqlDataAdapter(strDBCommand, strConn)
        DBGenAdapt.Fill(genDS, "ProdID")
        For Each orders In genDS.Tables(0).AsEnumerable
            Dim currentInventory As New Inventory With {
                .intInventory_TUID = orders(0),
                .strInventory_Name = orders(1),
                .intQty_On_Hand = orders(2)
            }
            dicCurrentInventory.Add(currentInventory.intInventory_TUID, currentInventory)
        Next
        DBConn.Close()
        For Each inventoryChange In dicOfInvenChange
            For Each inventoryCurrent In dicCurrentInventory
                If (inventoryChange.Key = inventoryCurrent.Key) Then
                    intCurrentID = inventoryChange.Key
                    intNewTotal = dicCurrentInventory.Item(intCurrentID).intQty_On_Hand - dicOfInvenChange.Item(intCurrentID)
                    Dim tempInventory As New Inventory With {
                    .intInventory_TUID = intCurrentID,
                    .strInventory_Name = dicCurrentInventory.Item(intCurrentID).strInventory_Name,
                    .intQty_On_Hand = intNewTotal
                    }
                    listOfNewInventory.Add(tempInventory)
                End If
            Next
        Next
        DBConn = New SqlConnection(strConn)
        DBConn.Open()
        For Each inventoryOn In listOfNewInventory
            DBCmd.CommandText = "UPDATE Inventory_Table " &
            "SET Quantity_On_Hand = '" & inventoryOn.intQty_On_Hand & "'" &
            "WHERE TUID = '" & inventoryOn.intInventory_TUID & "'"
            DBCmd.Connection = DBConn
            DBCmd.ExecuteNonQuery()
        Next
        DBConn.Close()
    End Sub
End Module