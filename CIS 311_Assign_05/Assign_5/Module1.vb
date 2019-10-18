'------------------------------------------------------------
'-                 File Name : Module1.vb                   - 
'-                Part of Project: Assign5                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/28/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application module where the -
'- user will type in a file pathname to a .txt file and the -
'- program analyzes the books titles, prices, qtys,         -
'- and the value of inventory at the book level             -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to type a path name to read a  -
'- .txt file with books' info and analyze the inventory     -
'- items if they want.                                      -
'------------------------------------------------------------
'- Class/Global Variable Dictionary:                        -
'- intQty – class variable the holds a books qty            -
'- lstBooks - list class container                          -
'- sngInventoryTotal - holds the extended value of each book-
'- sngPrice - holds the unit price of each book             -
'- strCategory - holds the books category                   -
'- strTitle - holds the books title                         -
'------------------------------------------------------------
Public Class clsBooks
    Public strCategory As String
    Public intQty As Integer
    Public sngPrice As Single
    Public strTitle As String
    Public sngInventoryTotal As Single

    '------------------------------------------------------------
    '-                Subprogram Name: New                      -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows a new blank instance of clsBooks -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New()
    End Sub

    '------------------------------------------------------------
    '-               Subprogram Name: New                       -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program allows a new populated instance of      -
    '- clsBooks                                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- Category - passes the category variable to the new book  –
    '- Price - passes the price variable in                     -
    '- QTY - passes the qty in                                  -
    '- Title - passes the title in
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Sub New(ByVal Category As String, ByVal QTY As Integer, ByVal Price As Single, ByVal Title As String)
        Me.strCategory = Category
        Me.intQty = QTY
        Me.sngPrice = Price
        Me.strTitle = Title
        Me.sngInventoryTotal = QTY * Price
    End Sub

    '------------------------------------------------------------
    '-        Subprogram Name: toString                         -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub program overwrites the toString method for      -
    '- clsBooks                                                 -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Public Overrides Function ToString() As String
        Return String.Format("Title: {0}, Cate: {1}, QTY: {2}, Unit Cost: {3}, Extended Cost: {4}", strTitle, strCategory, intQty, sngPrice, sngInventoryTotal)
    End Function
End Class

Module Module1
    Public lstBooks As New List(Of clsBooks)
    '------------------------------------------------------------
    '-                     Sub Main                             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub holds the main sub                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- GoodFilePath - used to loop if bad pathname is inputed   -
    '- data - holds the txt as the .txt file is read in         -
    '- line - holds the line of the .txt file                   - 
    '- streamReader - the .txt file reader                      -
    '- strFileName - holds the pathname the user inputs         -
    '- strReadIn - array that holds the books' read in info     -
    '------------------------------------------------------------
    Sub Main()
        Dim strFileName As String
        Dim streamReader As System.IO.StreamReader
        Dim strReadIn() As String
        Dim bolGoodFilePath As Boolean = False
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.BackgroundColor = ConsoleColor.White
        Console.Title = "Books 'R' Us: Inventory System"
        Console.Clear()
        Console.WriteLine("Input file path")
        strFileName = Console.ReadLine()
        Do While (bolGoodFilePath = False)
            If (System.IO.File.Exists(strFileName) = True) Then
                bolGoodFilePath = True
                streamReader = System.IO.File.OpenText(strFileName)
                strReadIn = IO.File.ReadAllLines(strFileName)
                Dim line As String
                Dim data(3) As String
                For intCounter = 0 To strReadIn.Count - 1
                    line = strReadIn(intCounter)
                    data = line.Split(" ", 4, StringSplitOptions.None)

                    lstBooks.Add(New clsBooks(data(0), data(1), data(2), data(3)))

                Next
                Call fnPrintInvenReport()
                Console.WriteLine()
                Call fnPrintInvenValue()
                Console.WriteLine()
                Call sbCateStats()
                Console.WriteLine()
                Call sbOverAllStats()
            Else
                bolGoodFilePath = False
                Console.WriteLine("Input actual file path")
                strFileName = Console.ReadLine()
            End If
        Loop
        Console.WriteLine()
        Console.WriteLine("Press enter to end program")
        Console.ReadLine()
    End Sub

    '------------------------------------------------------------
    '-         Subprogram Name: fnPrintInvenReport              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when sub main calls it to print-
    '- the inventory report in alpha order                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- alphaBooks - object that holds books in alpha order      -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Object – alphaBooks after query is done                  -
    '------------------------------------------------------------
    Function fnPrintInvenReport()
        Dim alphaBooks As Object
        Console.WriteLine(StrDup(45, " ") & "Books 'R' Us")
        Console.WriteLine(StrDup(40, " ") & "*** Inventory Report ***")
        Console.WriteLine(StrDup(30, " ") & StrDup(45, "-"))
        Console.WriteLine()
        Console.WriteLine(StrDup(5, " ") & "Title" & vbTab & vbTab & vbTab & "Category" & vbTab & "Quantity" & vbTab & "Unit Cost" & vbTab & "Extended Cost")
        Console.WriteLine(StrDup(25, "-") & vbTab & StrDup(8, "-") & vbTab & StrDup(8, "-") & vbTab & StrDup(9, "-") & vbTab & StrDup(13, "-"))
        alphaBooks = From books In lstBooks
                     Order By books.strTitle Ascending
                     Select String.Format("{0,-30}{1,6}{2,16}{3,19}{4,19}", books.strTitle, books.strCategory, books.intQty, (books.sngPrice).ToString("f2"), (books.sngInventoryTotal).ToString("f2"))
        For Each book In alphaBooks
            Console.WriteLine(book)
        Next
        Return alphaBooks
    End Function

    '------------------------------------------------------------
    '-          Subprogram Name: fnPrintInvenValue              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when sub main calls it to print-
    '- the inventory values overall range                       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- booksInRange - object that holds books range extended    -
    '-      values                                              -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- Object – each query object once complete                 -
    '------------------------------------------------------------
    Function fnPrintInvenValue()
        Dim booksInRange As Object
        Console.WriteLine(StrDup(75, "-"))
        Console.WriteLine(StrDup(5, " ") & "Total Inventory Value (Quantity * Unit Price) Statistics")
        Console.WriteLine(StrDup(75, "-"))
        Console.WriteLine("The books between $0.00 - 50.00 are:")
        Console.WriteLine()
        booksInRange = From books In lstBooks
                       Where books.sngInventoryTotal <= 50.0
                       Order By books.sngInventoryTotal Ascending
                       Select String.Format("{0,-30}{1,15}", books.strTitle, books.sngInventoryTotal.ToString("c"))
        For Each book In booksInRange
            Console.WriteLine(vbTab & book)
        Next
        Console.WriteLine()
        Console.WriteLine("The books between $50.00 - 100.00 are:")
        Console.WriteLine()
        booksInRange = From books In lstBooks
                       Where books.sngInventoryTotal > 50.0 And books.sngInventoryTotal <= 100
                       Order By books.sngInventoryTotal Ascending
                       Select String.Format("{0,-30}{1,15}", books.strTitle, books.sngInventoryTotal.ToString("c"))
        For Each book In booksInRange
            Console.WriteLine(vbTab & book)
        Next
        Console.WriteLine()
        Console.WriteLine("The books between $100.00 - 150.00 are:")
        Console.WriteLine()
        booksInRange = From books In lstBooks
                       Where books.sngInventoryTotal > 100 And books.sngInventoryTotal <= 150
                       Order By books.sngInventoryTotal Ascending
                       Select String.Format("{0,-30}{1,15}", books.strTitle, books.sngInventoryTotal.ToString("c"))
        For Each book In booksInRange
            Console.WriteLine(vbTab & book)
        Next
        Console.WriteLine()
        Console.WriteLine("The books 150.00 and above:")
        Console.WriteLine()
        booksInRange = From books In lstBooks
                       Where books.sngInventoryTotal > 150
                       Order By books.sngInventoryTotal Ascending
                       Select String.Format("{0,-30}{1,15}", books.strTitle, books.sngInventoryTotal.ToString("c"))
        For Each book In booksInRange
            Console.WriteLine(vbTab & book)
        Next
        Return booksInRange
    End Function

    '------------------------------------------------------------
    '-            Subprogram Name: sbCateStats                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub calculates and prints out each category specific-
    '- statistics like max, min, avg and count                  -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- theAvg - query object of the avg price for each category -
    '- theCount - query object of the number of titles          -
    '- theMax - query object of the max price                   -
    '- theMin - min price of each category                      -
    '------------------------------------------------------------
    Sub sbCateStats()
        Console.WriteLine(StrDup(75, "-"))
        Console.WriteLine(StrDup(10, " ") & "Unit Price Range by Category Statistics")
        Console.WriteLine(StrDup(75, "-"))
        Console.WriteLine("Category" & StrDup(5, " ") & "# of Titles" & StrDup(10, " ") & "Low" & StrDup(15, " ") & "AVG" & StrDup(15, " ") & "High")
        Console.WriteLine()
        Dim theAvgFic = Aggregate books In lstBooks Where books.strCategory = "F" Into Average(books.sngPrice)
        Dim theMaxFic = Aggregate books In lstBooks Where books.strCategory = "F" Into Max(books.sngPrice)
        Dim theMinFic = Aggregate books In lstBooks Where books.strCategory = "F" Into Min(books.sngPrice)
        Dim theCountFic = Aggregate books In lstBooks Into Count(books.strCategory = "F")
        Console.WriteLine(StrDup(5, " ") & "F" & StrDup(8, ".") & theCountFic & StrDup(15, ".") & theMinFic.ToString("f2") & StrDup(15, ".") & theAvgFic.ToString("f2") & StrDup(15, ".") & theMaxFic.ToString("f2"))
        Console.WriteLine()
        Dim theAvgNonFic = Aggregate books In lstBooks Where books.strCategory = "N" Into Average(books.sngPrice)
        Dim theMaxNonFic = Aggregate books In lstBooks Where books.strCategory = "N" Into Max(books.sngPrice)
        Dim theMinNonFic = Aggregate books In lstBooks Where books.strCategory = "N" Into Min(books.sngPrice)
        Dim theCountNonFic = Aggregate books In lstBooks Into Count(books.strCategory = "N")
        Console.WriteLine(StrDup(5, " ") & "N" & StrDup(8, ".") & theCountNonFic & StrDup(15, ".") & theMinNonFic.ToString("f2") & StrDup(15, ".") & theAvgNonFic.ToString("f2") & StrDup(15, ".") & theMaxNonFic.ToString("f2"))
        Console.WriteLine()
        Dim theAvgSciFi = Aggregate books In lstBooks Where books.strCategory = "S" Into Average(books.sngPrice)
        Dim theMaxSciFi = Aggregate books In lstBooks Where books.strCategory = "S" Into Max(books.sngPrice)
        Dim theMinSciFi = Aggregate books In lstBooks Where books.strCategory = "S" Into Min(books.sngPrice)
        Dim theCountSciFi = Aggregate books In lstBooks Into Count(books.strCategory = "S")
        Console.WriteLine(StrDup(5, " ") & "S" & StrDup(8, ".") & theCountSciFi & StrDup(15, ".") & theMinSciFi.ToString("f2") & StrDup(15, ".") & theAvgSciFi.ToString("f2") & StrDup(15, ".") & theMaxSciFi.ToString("f2"))
    End Sub

    '------------------------------------------------------------
    '-            Subprogram Name: sbOverAllStats               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/28/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub calculates and prints out the overall stats on  -
    '- all books, like max/min price and max/min qtys           -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- queryMaxOverall - query object of the max price          -
    '- queryMaxQTYOverall - query object of the max qty         -
    '- queryMinOverall - query object of the min price          -
    '- queryMinQTYOverall - query object of the min qty         -
    '- theMaxOverall-query object of the max price of all books -
    '- theMaxQTYOverall - query object of max qty of all books  -
    '- theMinOverall - min price of all books                   -
    '- theMinQTYOverall - min qty of all books                  -	
    '------------------------------------------------------------
    Sub sbOverAllStats()
        Console.WriteLine(StrDup(75, "-"))
        Console.WriteLine(StrDup(12, " ") & "Overall Book Statistics")
        Console.WriteLine(StrDup(75, "-"))
        Dim theMinOverall = Aggregate books In lstBooks Into Min(books.sngPrice)
        Dim queryMinOverall As Object
        queryMinOverall = From books In lstBooks
                          Where books.sngPrice = theMinOverall
                          Select vbTab & books.strTitle
        Console.WriteLine("The cheapest book title(s) at a unit price of " & theMinOverall.ToString("c") & " are: ")
        For Each book In queryMinOverall
            Console.WriteLine(book)
        Next
        Console.WriteLine()
        Dim theMaxOverall = Aggregate books In lstBooks Into Max(books.sngPrice)
        Dim queryMaxOverall As Object
        queryMaxOverall = From books In lstBooks
                          Where books.sngPrice = theMaxOverall
                          Select vbTab & books.strTitle
        Console.WriteLine("The most expensive book title(s) at a unit price of " & theMaxOverall.ToString("c") & " are: ")
        For Each book In queryMaxOverall
            Console.WriteLine(book)
        Next
        Console.WriteLine()
        Dim theMinQTYOverall = Aggregate books In lstBooks Into Min(books.intQty)
        Dim queryMinQTYOverall As Object
        queryMinQTYOverall = From books In lstBooks
                             Where books.intQty = theMinQTYOverall
                             Select vbTab & books.strTitle
        Console.WriteLine("The book title(s) with the least amount of quantity on hand is at " & theMinQTYOverall & " are: ")
        For Each book In queryMinQTYOverall
            Console.WriteLine(book)
        Next
        Console.WriteLine()
        Dim theMaxQTYOverall = Aggregate books In lstBooks Into Max(books.intQty)
        Dim queryMaxQTYOverall As Object
        queryMaxQTYOverall = From books In lstBooks
                             Where books.intQty = theMaxQTYOverall
                             Select vbTab & books.strTitle
        Console.WriteLine("The book title(s) with the most amount of quantity on hand is at " & theMaxQTYOverall & " are: ")
        For Each book In queryMaxQTYOverall
            Console.WriteLine(book)
        Next
    End Sub
End Module