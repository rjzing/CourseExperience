'------------------------------------------------------------
'-                File Name : clsStudents.vb                - 
'-                Part of Project: Assign 9                 -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 04/11/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the class, clsStudents. Including all -
'- properties and new operators                             -
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
'- arrHw - array containing indivdual hw grades             -
'- ExamScore - final exam grade                             -
'- Initials - student's first and middle initial            -
'- LastName - student's last name                           -
'------------------------------------------------------------
Public Class clsStudents
    Protected Friend strInitials As String
    Protected Friend strLastName As String
    Protected Friend arrHW(3) As Integer
    Protected Friend intExamScore As Double

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/11/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub intializes a student with default values        -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- (None)                                                   -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Protected Friend Sub New()
        strInitials = ""
        strLastName = ""
        arrHW(3) = 1
        intExamScore = 0
    End Sub

    '------------------------------------------------------------
    '-                   Subprogram Name: New                   -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/11/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub intializes a student with given properties given-
    '- by the user                                              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- examScore - the students final exam score                -
    '- hw - the 4 individual hw scores in an array              -
    '- initials - the student's fir and middle initials         -
    '- lastName - student's last ma,e                           -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Protected Friend Sub New(ByVal initials As String, ByVal lastName As String, hw() As Integer, ByVal examScore As Double)
        strInitials = initials
        strLastName = lastName
        arrHW(0) = hw(0)
        arrHW(1) = hw(1)
        arrHW(2) = hw(2)
        arrHW(3) = hw(3)
        intExamScore = examScore
    End Sub

    Private Property initials As String
        Get
            Return strInitials
        End Get
        Set(value As String)
            strInitials = value
        End Set
    End Property
    Private Property lastName As String
        Get
            Return strLastName
        End Get
        Set(value As String)
            strLastName = value
        End Set
    End Property

    Private Property hw() As Integer
        Get
            Return arrHW(0)
            Return arrHW(1)
            Return arrHW(2)
            Return arrHW(3)
        End Get
        Set(value As Integer)
            arrHW(0) = value
            arrHW(1) = value
            arrHW(2) = value
            arrHW(3) = value
        End Set
    End Property

    Private Property examScore As Double
        Get
            Return intExamScore
        End Get
        Set(value As Double)
            intExamScore = value
        End Set
    End Property
End Class
