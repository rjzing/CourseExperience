'------------------------------------------------------------
'-                File Name : ApplicationEvents.vb          - 
'-                Part of Project: Assign2                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 02/05/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the overall application events it     -
'- tells the prgram what to start and what to close         -
'------------------------------------------------------------
'- Global Variable Dictionary:                              -
'- (none)                                                   –
'------------------------------------------------------------
Imports Microsoft.VisualBasic.ApplicationServices
Namespace My
    Partial Friend Class MyApplication
        '------------------------------------------------------------
        '-       Subprogram Name: MyApplication_Startup             -
        '------------------------------------------------------------
        '-                Written By: Robert Zinger                 -
        '-                Written On: 02/05/2018                    -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is only used once, when the application  -
        '- actually loads for the first time                        -
        '------------------------------------------------------------
        '- Parameter Dictionary:                                    -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the StartupEventArgs object sent to the routine-
        '------------------------------------------------------------
        '- Local Variable Dictionary:                               -
        '- (None)                                                   -
        '------------------------------------------------------------
        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Form1.Visible = True
            frmAssign2_Invoice.Visible = False
        End Sub
        '------------------------------------------------------------
        '-       Subprogram Name: MyApplication_Shutdown            -
        '------------------------------------------------------------
        '-                Written By: Robert Zinger                 -
        '-                Written On: 02/05/2018                    -
        '------------------------------------------------------------
        '- Subprogram Purpose:                                      -
        '-                                                          -
        '- This subroutine is only used once, when the application  -
        '- actually closes                                          -
        '------------------------------------------------------------
        '- Parameter Dictionary:                                    -
        '- sender – Identifies which particular control raised the  –
        '-          click event                                     - 
        '- e – Holds the EventArgs object sent to the routine       -
        '------------------------------------------------------------
        '- Local Variable Dictionary:                               -
        '- (None)                                                   -
        '------------------------------------------------------------
        Private Sub MyApplication_Shutdown(sender As Object, e As EventArgs) Handles Me.Shutdown
            Form1.Close()
            frmAssign2_Invoice.Close()
        End Sub
    End Class
End Namespace
