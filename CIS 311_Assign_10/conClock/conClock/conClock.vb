'------------------------------------------------------------
'-                 File Name : conClock.vb                  - 
'-                Part of Project: Assign 10                -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 04/18/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the source code for the control,      -
'- conClock                                                 -
'------------------------------------------------------------
'- Program Purpose:                                         -
'-                                                          -
'- This program creates a control and sets it as a .dll to  -
'- use in other programs as a control                       -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- ArialFont - holds the constant font style                -
'- Brush - the color the clock should be rendered           -
'- CurrentForeColor - holds the current fore color          -
'- DateToShow - which date format should be shown           -
'- TimeToShow - which time format to show                   -
'------------------------------------------------------------
Public Class conClock
    Dim fonArialFont As New Font("Arial", 12, FontStyle.Regular)
    Dim bshBrush As New SolidBrush(Color.Black)
    Dim colCurrentForeColor As Color = Color.Black
    Dim intDateToShow As Integer = 0
    Dim intTimeToShow As Integer = 1

    '------------------------------------------------------------
    '-              Subprogram Name: tmeTimer_Tick              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called every second to refresh the current   -
    '- time and when the control should refresh to stay in sync -
    '- with current time and current clock being displayed      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub tmeTimer_Tick(sender As Object, e As EventArgs) Handles tmeTimer.Tick
        Me.Refresh()
    End Sub

    Overrides Property ForeColor() As Color
        Get
            Return (colCurrentForeColor)
        End Get
        Set(ByVal Value As Color)
            colCurrentForeColor = Value
            Me.Invalidate()
        End Set
    End Property

    '------------------------------------------------------------
    '-                Subprogram Name: OnPaint                  -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called when the control needs to be refreshed-
    '- this actually takes care of how the clock is shown and   -
    '- what color the control text should be                    -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- e – Holds the PaintEventArgs paint object                -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- gfx - property in PaintEventArgs that is overridden      -
    '------------------------------------------------------------
    Protected Overrides Sub OnPaint(e As PaintEventArgs)
        Dim gfx As Graphics = e.Graphics
        bshBrush.Color = colCurrentForeColor
        If (intDateToShow = 0 And intTimeToShow = 1) Then
            gfx.DrawString(DateTime.Now.ToLongTimeString & vbCrLf & Date.Now.ToLongDateString, fonArialFont, bshBrush, 10, 10) 'reg time/long date
        ElseIf (intDateToShow = 1 And intTimeToShow = 1) Then
            gfx.DrawString(DateTime.Now.ToLongTimeString & vbCrLf & Date.Now.ToShortDateString, fonArialFont, bshBrush, 10, 10) 'reg time/short date
        ElseIf (intDateToShow = 0 And intTimeToShow = 0) Then
            gfx.DrawString(TimeString & vbCrLf & Date.Now.ToLongDateString, fonArialFont, bshBrush, 10, 10) 'military/long date
        ElseIf (intDateToShow = 1 And intTimeToShow = 0) Then
            gfx.DrawString(TimeString & vbCrLf & Date.Now.ToShortDateString, fonArialFont, bshBrush, 10, 10) 'military/short date
        End If
    End Sub

    '------------------------------------------------------------
    '-              Subprogram Name: btnLong_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called when the user clicks on the long btn  -
    '- to show the long current date of the system and sets the -
    '- global varriable to tell the display to display the clock-
    '- with the long date                                       -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnLong_Click(sender As Object, e As EventArgs) Handles btnLong.Click
        intDateToShow = 0
        Me.Refresh()
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btnShort_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called when the user clicks on the short btn -
    '- to show the long current date of the system and sets the -
    '- global varriable to tell the display to display the clock-
    '- with the short date                                      -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnShort_Click(sender As Object, e As EventArgs) Handles btnShort.Click
        intDateToShow = 1
        Me.Refresh()
    End Sub

    '------------------------------------------------------------
    '-             Subprogram Name: btn24Hour_Click             -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called when the user clicks on the military  -
    '- btn to show the clock in the 24 hour format              -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btn24Hour_Click(sender As Object, e As EventArgs) Handles btn24Hour.Click
        intTimeToShow = 0
        Me.Refresh()
    End Sub


    '------------------------------------------------------------
    '-              Subprogram Name: RegTime_Click              -
    '------------------------------------------------------------
    '-                Written By: Robert Zinger                 -
    '-                Written On: 04/18/2018                    -
    '------------------------------------------------------------
    '- Subprogram Purpose:                                      -
    '-                                                          -
    '- This sub is called when the user clicks on the regular   -
    '- time btn to show the clock in the regular format         -
    '------------------------------------------------------------
    '- Parameter Dictionary:                                    -
    '- sender – Identifies which particular control raised the  –
    '-          click event                                     - 
    '- e – Holds the EventArgs object sent to the routine       -
    '------------------------------------------------------------
    '- Local Variable Dictionary:                               -
    '- (None)                                                   -
    '------------------------------------------------------------
    Private Sub btnRegTime_Click(sender As Object, e As EventArgs) Handles btnRegTime.Click
        intTimeToShow = 1
        Me.Refresh()
    End Sub
End Class
