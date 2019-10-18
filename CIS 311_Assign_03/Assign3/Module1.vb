'------------------------------------------------------------
'-                File Name : Module 1.vb                   - 
'-                Part of Project: Assign3                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/12/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the main application module for the   -
'- console app                                              -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program allows users to interact with a command     -
'- like interface (console app) the program should be able  -
'- to read in a text file, path given by user, and anyalze  -
'- its contents, it should keep track of words in the file  -
'- and possibly print out a histogram of all words in the   - 
'- file. Either way it writes to a text file at the end     -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- strFileName - holds the file to read in, given by user   –
'- strucWords - container of all words in the text file     -
'------------------------------------------------------------
Module Module1
    Structure WordsAndCount
        Dim strWord As String
        Dim intOverAllCount As Integer
        Dim bolState As Boolean
    End Structure
    Dim strFileName As String
    Dim strucWords(0) As WordsAndCount
    '------------------------------------------------------------
    '-             Subprogram Name: Main                        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/12/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This is the main function, it calls all the shots and is -
    '- used only once. It controls what the user sees and keeps –
    '- track of what the user inputs and how to manipulate it   -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- bolReadyToMoveOn - keeps track of valid path name        - 
    '- bolReadyWithReportPath - report path's validation        -
    '- bolWaitingToEnd - if the user wants to see report        -
    '- streamReader - reads the file the user selects           -
    '- streamWriter - writes the report text file               -
    '- strFileNameForReport - pathname to write report to       - 
    '- strViewReport - raw data if the user wants to see report -
    '- strViewReportContainer - uppercase letter to see report  -
    '------------------------------------------------------------
    Sub Main()
        Dim streamReader As System.IO.StreamReader
        Dim streamWriter As System.IO.StreamWriter
        Dim bolReadyToMoveOn As Boolean = False
        Dim bolWaitingToEnd As Boolean = False
        Dim strFileNameForReport As String
        Dim bolReadyWithReportPath As Boolean = False
        Dim strViewReport As String
        Dim strViewReportContainer As String

        Console.ForegroundColor = ConsoleColor.DarkBlue
        Console.BackgroundColor = ConsoleColor.White
        Console.Title = "Word Analyzer"
        Console.Clear()

        Console.WriteLine("Please type a file path name ")
        strFileName = Console.ReadLine
        Do While (bolReadyToMoveOn = False)
            If System.IO.File.Exists(strFileName) Then
                streamReader = System.IO.File.OpenText(strFileName)
                bolReadyToMoveOn = True
                Console.WriteLine("Enter a path name to which you want the report file to be saved, with .txt at the end ")
                strFileNameForReport = Console.ReadLine
                Do While (bolReadyWithReportPath = False)
                    If (System.IO.File.Exists(strFileNameForReport)) Then
                        bolReadyWithReportPath = False
                        MsgBox("Please enter a real path")
                        strFileNameForReport = Console.ReadLine
                    Else
                        bolReadyWithReportPath = True
                        Call Report()
                        Console.WriteLine("Do you want to see the report before closing (y/n) ")
                        strViewReport = Console.ReadLine
                        strViewReportContainer = strViewReport.ToUpper()
                        Do While (bolWaitingToEnd = False)
                            If (strViewReportContainer = "Y") Then
                                For intPrintReport As Integer = 0 To strucWords.Length - 1
                                    Console.WriteLine(strucWords(intPrintReport).strWord & " " & strucWords(intPrintReport).intOverAllCount)
                                Next
                                streamWriter = System.IO.File.CreateText(strFileNameForReport)
                                For intSaveReport As Integer = 0 To strucWords.Length - 1
                                    streamWriter.WriteLine(strucWords(intSaveReport).strWord & " " & strucWords(intSaveReport).intOverAllCount)
                                Next
                                streamWriter.Close()
                                bolWaitingToEnd = True
                            ElseIf (strViewReportContainer = "N") Then
                                streamWriter = System.IO.File.CreateText(strFileNameForReport)
                                For intSaveReport As Integer = 0 To strucWords.Length - 1
                                    streamWriter.WriteLine(strucWords(intSaveReport).strWord & " " & strucWords(intSaveReport).intOverAllCount)
                                Next
                                streamWriter.Close()
                                Console.WriteLine("Your report has been written to path name: " & strFileNameForReport)
                                bolWaitingToEnd = True
                            ElseIf (strViewReportContainer <> "Y" Or strViewReportContainer <> "N") Then
                                Console.WriteLine("Please enter proper control, y or n")
                                strViewReport = Console.ReadLine
                                strViewReportContainer = strViewReport.ToUpper()
                            End If
                        Loop
                    End If
                Loop
            Else
                bolReadyToMoveOn = False
                MsgBox("Please enter a real path")
                strFileName = Console.ReadLine
            End If
        Loop
        Console.WriteLine("Press Enter to end program")
        Console.ReadLine()
    End Sub
    '------------------------------------------------------------
    '-             Function Name: Report                        -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 02/12/2018                    -
    '------------------------------------------------------------
    '- Function Purpose:                                        -
    '-                                                          -
    '- This function holds the code to generate word report     -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (none)                                                   –
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- charOnlyArray - array of all chars in file               - 
    '- charUpperArray - array of all chars in uppercase         -
    '- intIsVistedCounter - keeps track of visited words        -
    '- intPlaceHolder - count of all chars in file              - 
    '- strArrayOfCharOnly - string array of chars in word form  -
    '- strIsVisitedArray - keeps track of reference words       -
    '- strReadFileIn - reads file user specified                -
    '- strSplitArray - array of words after spliting them apart -
    '- strUpper - makes the file all uppercase letters          -
    '------------------------------------------------------------
    Function Report()
        Dim strReadFileIn() As String = IO.File.ReadAllLines(strFileName)
        Dim strUpper As String = UCase(strReadFileIn(0))
        Dim charUpperArray() As Char = strUpper.ToCharArray
        Dim charOnlyArray() As Char
        Dim intPlaceHolder As Integer = -1
        Dim strArrayOfCharOnly As String = New String(charOnlyArray)
        Dim strSplitArray() As String = Split(strArrayOfCharOnly)
        Dim strIsVisitedArray() As String
        Dim intIsVistedCounter As Integer = -1

        For intTempDataCount As Integer = 0 To charUpperArray.Count - 1
            If (Char.IsLetter(charUpperArray(intTempDataCount)) = True) Then
                intPlaceHolder += 1
                ReDim Preserve charOnlyArray(intPlaceHolder)
                charOnlyArray(intPlaceHolder) = charUpperArray(intTempDataCount)
            ElseIf (Char.IsLetter(charUpperArray(intTempDataCount)) = False) Then
                If (Char.IsLetter(charUpperArray(intTempDataCount - 1)) = False) Then
                ElseIf (Char.IsLetter(charUpperArray(intTempDataCount - 1)) = True) Then
                    intPlaceHolder += 1
                    ReDim Preserve charOnlyArray(intPlaceHolder)
                    charOnlyArray(intPlaceHolder) = " "
                End If
            End If
        Next
        'Console.WriteLine(strUpper)
        'Console.WriteLine(charOnlyArray)
        'Console.WriteLine("Press Enter to show string array")
        'Console.ReadLine()
        For intCheckerOfSameWords As Integer = 0 To strSplitArray.Count - 1
            intIsVistedCounter += 1
            ReDim Preserve strIsVisitedArray(intIsVistedCounter)
            strIsVisitedArray(intIsVistedCounter) = strSplitArray(intCheckerOfSameWords)

            For intIsVistedLoopChecker As Integer = 0 To strIsVisitedArray.Count - 1
                'ReDim Preserve strucWords(intCheckerOfSameWords)
                'strucWords(intIsVistedLoopChecker).bolState = False
                ReDim Preserve strucWords(intIsVistedCounter)
                If ((StrComp(strSplitArray(intCheckerOfSameWords), strIsVisitedArray(intIsVistedLoopChecker))) = 0) Then
                    If (strucWords(intIsVistedLoopChecker).bolState = False) Then
                        'ReDim Preserve strucWords(intIsVistedLoopChecker)
                        strucWords(intIsVistedLoopChecker).strWord = strIsVisitedArray(intIsVistedLoopChecker)
                        strucWords(intIsVistedLoopChecker).intOverAllCount += 1
                        strucWords(intIsVistedLoopChecker).bolState = True
                    ElseIf (strucWords(intIsVistedLoopChecker).bolState = True) Then
                        'Console.Beep()
                        'ReDim Preserve strucWords(intIsVistedLoopChecker)
                        strucWords(intIsVistedLoopChecker).strWord = strIsVisitedArray(intIsVistedLoopChecker)
                        strucWords(intIsVistedLoopChecker).intOverAllCount += 1
                        'strucWords(intIsVistedLoopChecker).strWord.CompareTo
                    ElseIf ((StrComp(strSplitArray(intCheckerOfSameWords), strIsVisitedArray(intIsVistedLoopChecker))) = -1 Or 1) Then
                        'ReDim Preserve strucWords(intIsVistedLoopChecker)
                    End If
                End If
                'ReDim strucWords(intIsVistedCounter)
                'ReDim Preserve strucWords(intCheckerOfSameWords)
            Next
        Next

        For intStrucOutSideLoopCounter As Integer = 0 To strucWords.Count - 1
            If (StrComp((strucWords(intStrucOutSideLoopCounter).strWord), strucWords(intStrucOutSideLoopCounter).strWord) = 0) Then
                'Console.Beep()
                'ReDim Preserve strucWords(intPrintHisto)
                'strucWords(intStrucOutSideLoopCounter).strWord = strucWords(intStrucOutSideLoopCounter).strWord
            End If
            'Console.WriteLine(strucWords(intStrucOutSideLoopCounter).strWord & " " & strucWords(intStrucOutSideLoopCounter).intOverAllCount)
        Next
        Return strucWords
    End Function
End Module
