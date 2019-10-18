'------------------------------------------------------------
'-               File Name : modAssign_9.vb                 - 
'-                Part of Project: Assign 9                 -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 04/11/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main program, taking the user's   -
'- input for the students, adding them to a dictionary, then-
'- writes the values to excel using the COM, and also       -
'- calculates final grades and avg, std, max, and min for   -
'- each assignment                                          -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program creates multiple instances of different     -
'- students, 4 grades, and final exam scores, which later   -
'- is used to calculate a final hw grade, the final grade   -
'- with proper weight, using excel formulas, also average   -
'- grades, standard dev, max, and min                       -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- Students - sorted dictionary of all of the student's info-
'------------------------------------------------------------
Imports Microsoft.Office.Interop

Module modAssign_9
    Friend dicStudents As New SortedDictionary(Of String, clsStudents)

    '------------------------------------------------------------
    '-                  Subprogram Name: Main                   -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/11/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub drives the program; adding students to the      -
    '- dictionary, calling other subs at the right time and     -
    '- writes everything to excel                               -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Sub Main()
        dicStudents.Add("Borstellis", New clsStudents("V.A.", "Borstellis", {25, 25, 25, 25}, 100.0))
        dicStudents.Add("Reid", New clsStudents("A.S.", "Reid", {20, 21, 20, 18}, 75.0))
        dicStudents.Add("Tyler", New clsStudents("C.U.", "Tyler", {19, 20, 21, 24}, 75.5))
        dicStudents.Add("Renee", New clsStudents("H.A.", "Renee", {20, 23, 23, 25}, 80.5))
        dicStudents.Add("Douglas", New clsStudents("I.A.", "Douglas", {24, 23, 25, 25}, 95.0))
        dicStudents.Add("Elenaips", New clsStudents("M.A.", "Elenaips", {23, 24, 23, 21}, 94.5))
        dicStudents.Add("Emmet", New clsStudents("A.L.", "Emmet", {21, 19, 18, 15}, 73.0))
        dicStudents.Add("James", New clsStudents("S.U.", "James", {21, 24, 23, 22}, 87.5))
        dicStudents.Add("Issacs", New clsStudents("S.H.", "Issacs", {23, 24, 21, 21}, 93.0))
        dicStudents.Add("Opus", New clsStudents("B.I.", "Opus", {23, 24, 25, 23}, 97.5))
        dicStudents.Add("Alski", New clsStudents("T.R.", "Alski", {24, 25, 25, 23}, 95.5))
        dicStudents.Add("Zeus", New clsStudents("H.E.", "Zeus", {23, 24, 23, 23}, 77.0))
        dicStudents.Add("Ustaf", New clsStudents("S.C.", "Ustaf", {24, 23, 24, 25}, 91.0))
        dicStudents.Add("Chrint", New clsStudents("K.I.", "Chrint", {23, 23, 24, 21}, 89.0))
        dicStudents.Add("Yaz", New clsStudents("J.E.", "Yaz", {25, 24, 23, 24}, 92.5))
        dicStudents.Add("Franks", New clsStudents("F.R.", "Franks", {23, 19, 18, 23}, 88.5))
        dicStudents.Add("Walton", New clsStudents("W.I.", "Walton", {24, 23, 23, 19}, 90.0))
        dicStudents.Add("Gilch", New clsStudents("K.A.", "Gilch", {24, 23, 25, 24}, 92.0))
        dicStudents.Add("Little", New clsStudents("R.O.", "Little", {23, 24, 23, 24}, 94.0))
        dicStudents.Add("Xerxes", New clsStudents("S.A.", "Xerxes", {24, 23, 25, 23}, 94.0))
        dicStudents.Add("Harris", New clsStudents("W.I.", "Harris", {23, 24, 25, 23}, 92.0))
        dicStudents.Add("Vargo", New clsStudents("T.I.", "Vargo", {24, 23, 25, 25}, 99.0))
        dicStudents.Add("Interas", New clsStudents("I.E.", "Interas", {24, 23, 25, 25}, 97.5))
        dicStudents.Add("Kiliens", New clsStudents("T.O.", "Kiliens", {23, 19, 18, 18}, 73.0))
        dicStudents.Add("Manrose", New clsStudents("E.R.", "Manrose", {23, 24, 25, 23}, 84.0))
        dicStudents.Add("Nelson", New clsStudents("W.A.", "Nelson", {23, 24, 25, 23}, 87.0))
        dicStudents.Add("Quaras", New clsStudents("K.U.", "Quaras", {23, 24, 25, 23}, 96.5))
        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.BackgroundColor = ConsoleColor.White
        Console.Title = "Assignment 9"
        Console.Clear()
        Console.WriteLine("Writing to excel")
        Call writeStudentsToExcel(createExcelDoc)
        Console.WriteLine("Complete")
        Console.WriteLine("Hit enter to exit console and excel")
        Console.ReadLine()
        createExcelDoc.Quit()
    End Sub

    '------------------------------------------------------------
    '-           Subprogram Name: writeStudentsToExcel          -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/11/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub writes the info to excel, it also tells excel   -
    '- how and when the formulas are used, keeping track of all -
    '- count variables to make sure everything is calculated    -
    '- properly and formatted properly in the excel output      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- excelStudents - the output from the function             -
    '-      createExcelDoc                                      -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- RowCount - count variable to know what student should be -
    '-      written to each row in excel                        -
    '- Stats - count variable to keep track of where the        -
    '-      statistics should be outputted                      -
    '------------------------------------------------------------
    Sub writeStudentsToExcel(excelStudents)
        Dim intStats As Integer
        Dim intRowCount As Integer = 1
        excelStudents.Workbooks.Add()
        excelStudents.Sheets.Add()
        excelStudents.Cells(1, 1) = "Name"
        excelStudents.Cells(1, 2) = "Intials"
        excelStudents.Cells(1, 3) = "Grade 1"
        excelStudents.Cells(1, 4) = "Grade 2"
        excelStudents.Cells(1, 5) = "Grade 3"
        excelStudents.Cells(1, 6) = "Grade 4"
        excelStudents.Cells(1, 7) = "Total"
        excelStudents.Cells(1, 8) = "Exam"
        excelStudents.Cells(1, 9) = "Grade"
        For Each student In dicStudents.Keys
            intRowCount += 1
            excelStudents.Cells(intRowCount, 1) = dicStudents(student).strLastName
            excelStudents.Cells(intRowCount, 2) = dicStudents(student).strInitials
            excelStudents.Cells(intRowCount, 3) = dicStudents(student).arrHW(0)
            excelStudents.Cells(intRowCount, 4) = dicStudents(student).arrHW(1)
            excelStudents.Cells(intRowCount, 5) = dicStudents(student).arrHW(2)
            excelStudents.Cells(intRowCount, 6) = dicStudents(student).arrHW(3)
            excelStudents.Cells(intRowCount, 7) = "=sum(c" & intRowCount & ".." & "f" & intRowCount & ")"
            excelStudents.Cells(intRowCount, 8) = dicStudents(student).intExamScore
            excelStudents.Cells(intRowCount, 9) = "=(g" & intRowCount & "*.40) + (h" & intRowCount & "*.60)"
        Next
        intStats = intRowCount + 2
        excelStudents.Cells(intStats, 2) = "AVG:"
        excelStudents.Cells(intStats, 3) = "=AVERAGE(c1..c" & intRowCount & ")"
        excelStudents.Cells(intStats, 4) = "=AVERAGE(d1..d" & intRowCount & ")"
        excelStudents.Cells(intStats, 5) = "=AVERAGE(e1..e" & intRowCount & ")"
        excelStudents.Cells(intStats, 6) = "=AVERAGE(f1..f" & intRowCount & ")"
        excelStudents.Cells(intStats, 7) = "=AVERAGE(g1..g" & intRowCount & ")"
        excelStudents.Cells(intStats, 8) = "=AVERAGE(h1..h" & intRowCount & ")"
        excelStudents.Cells(intStats, 9) = "=AVERAGE(i1..i" & intRowCount & ")"
        intStats += 1
        excelStudents.Cells(intStats, 2) = "STD:"
        excelStudents.Cells(intStats, 3) = "=STDEV(c1..c" & intRowCount & ")"
        excelStudents.Cells(intStats, 4) = "=STDEV(d1..d" & intRowCount & ")"
        excelStudents.Cells(intStats, 5) = "=STDEV(e1..e" & intRowCount & ")"
        excelStudents.Cells(intStats, 6) = "=STDEV(f1..f" & intRowCount & ")"
        excelStudents.Cells(intStats, 7) = "=STDEV(g1..g" & intRowCount & ")"
        excelStudents.Cells(intStats, 8) = "=STDEV(h1..h" & intRowCount & ")"
        excelStudents.Cells(intStats, 9) = "=STDEV(i1..i" & intRowCount & ")"
        intStats += 1
        excelStudents.Cells(intStats, 2) = "MIN:"
        excelStudents.Cells(intStats, 3) = "=MIN(c1..c" & intRowCount & ")"
        excelStudents.Cells(intStats, 4) = "=MIN(d1..d" & intRowCount & ")"
        excelStudents.Cells(intStats, 5) = "=MIN(e1..e" & intRowCount & ")"
        excelStudents.Cells(intStats, 6) = "=MIN(f1..f" & intRowCount & ")"
        excelStudents.Cells(intStats, 7) = "=MIN(g1..g" & intRowCount & ")"
        excelStudents.Cells(intStats, 8) = "=MIN(h1..h" & intRowCount & ")"
        excelStudents.Cells(intStats, 9) = "=MIN(i1..i" & intRowCount & ")"
        intStats += 1
        excelStudents.Cells(intStats, 2) = "MAX:"
        excelStudents.Cells(intStats, 3) = "=MAX(c1..c" & intRowCount & ")"
        excelStudents.Cells(intStats, 4) = "=MAX(d1..d" & intRowCount & ")"
        excelStudents.Cells(intStats, 5) = "=MAX(e1..e" & intRowCount & ")"
        excelStudents.Cells(intStats, 6) = "=MAX(f1..f" & intRowCount & ")"
        excelStudents.Cells(intStats, 7) = "=MAX(g1..g" & intRowCount & ")"
        excelStudents.Cells(intStats, 8) = "=MAX(h1..h" & intRowCount & ")"
        excelStudents.Cells(intStats, 9) = "=MAX(i1..i" & intRowCount & ")"
    End Sub

    '------------------------------------------------------------
    '-              Function Name: createExcelDoc               -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/11/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This subroutine is called when it is time to open an     -
    '- excel document.                                          -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- checkExcel - object to check to see if excel is open     -
    '- excelDoc - the excel application                         -
    '------------------------------------------------------------
    '- Returns:                                                 -
    '- excelDoc - new doc if excel is not running in mem, or new-
    '-      instance of excel when not running                  -
    '------------------------------------------------------------
    Function createExcelDoc()
        Dim checkExcel As Object = Nothing
        Dim excelDoc As Excel.Application
        Try
            checkExcel = GetObject(, "Excel.Application")
        Catch ex As Exception
        End Try
        If checkExcel Is Nothing Then
            excelDoc = New Excel.Application()
            excelDoc.Visible = True
        Else
            excelDoc = checkExcel
            excelDoc.Visible = True
        End If
        Return excelDoc
    End Function
End Module