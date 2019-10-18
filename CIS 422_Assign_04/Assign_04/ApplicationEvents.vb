'------------------------------------------------------------
'-           File Name : ApplicationEvents.vb               - 
'-              Part of Project: Assign_04                  -
'------------------------------------------------------------
'-                Written By: Robert Zinger                 -
'-                Written On: 10/23/2018                    -
'------------------------------------------------------------
'- File Purpose:                                            -
'- This file contains the global application startup source -
'- code                                                     -
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
'- DefaultFile - signifies if the default order file should -
'-      be used when populating the tables                  -
'- ConnString - db connection string                        -
'- DBName - constant db name "Plastico"                     -
'- DBPath - file path to db                                 -
'- ServerName - local computer server name to use           -
'------------------------------------------------------------

Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    Partial Friend Class MyApplication
        Public bolDefaultFile = True
        Public gstrConnString As String
        Public Const gstrDBName As String = "Plastico"
        Public gstrDBPath As String
        Public Const gstrServerName As String = "(localdb)\MSSQLLocalDB"

        Private Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim fileExists As Boolean = False
            gstrDBPath = My.Application.Info.DirectoryPath & "\" & gstrDBName & ".mdf"
            gstrConnString = "SERVER=" & gstrServerName & ";DATABASE=" &
                gstrDBName & ";Integrated Security=SSPI;AttachDbFileName=" &
                gstrDBPath
            fileExists = My.Computer.FileSystem.FileExists(gstrDBPath)
            If Not fileExists Then
                Call MakeDatabase() 'db doesnt exist, create db and populate the tables in the db
            Else
                Call PopulateAllTables(bolDefaultFile) 'db exists, just clears tables and populates them
            End If
        End Sub
    End Class
End Namespace
