Imports System.Threading
Imports System.Net.Sockets
Imports System.IO
Imports System.ComponentModel

Public Class frmServer
    Dim tcpServer As TcpListener
    Dim sktServerConnection As Socket
    Dim nsNetStream As NetworkStream
    Dim bwNetWriter As BinaryWriter
    Dim brNetReader As BinaryReader
    Dim thdData As Thread
    Dim strGameSetup As String
    Dim charGamePlay(8) As Char
    Dim charSendToClient(8) As Char
    Dim intMove As Integer = 1
    Dim charOtherPlayerLetter As Char

    Private Sub frmServer_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlSetUp.Visible = True
        pnlBoard.Enabled = False
        btnStopServer.Enabled = False
        btnStartServer.Enabled = False
        btnSubmitStart.Enabled = False
        CheckForIllegalCrossThreadCalls = False
        lblWinner.Text = Nothing
        txtPort.Text = 1000
    End Sub

    Private Sub btnStartServer_Click(sender As Object, e As EventArgs) Handles btnStartServer.Click
        ReDim charSendToClient(8)
        ReDim charGamePlay(8)
        txtLog.Clear()
        lblWinner.Text = Nothing
        Try
            txtPort.ReadOnly = True
            txtLog.Text &= "Starting server" & vbCrLf
            tcpServer = New TcpListener(Net.IPAddress.Parse("127.0.0.1"), CInt(txtPort.Text))
            tcpServer.Start()
            btnStopServer.Enabled = True
            btnStartServer.Enabled = False
            txtLog.Text = "Listening for client" & vbCrLf
            Application.DoEvents()
            sktServerConnection = tcpServer.AcceptSocket
            txtLog.Text &= "Now connected" & vbCrLf
            nsNetStream = New NetworkStream(sktServerConnection)
            bwNetWriter = New BinaryWriter(nsNetStream)
            brNetReader = New BinaryReader(nsNetStream)
            txtLog.Text &= "Network Writer/Reader now created" & vbCrLf
            txtLog.Text &= "Preparing thread" & vbCrLf
            thdData = New Thread(AddressOf GetDataFromClient)
            thdData.Start()
            bwNetWriter.Write("S" & strGameSetup)
        Catch IOEx As IOException
            txtLog.Text &= "Error in setting up server, now closing" & vbCrLf
        Catch socketEx As SocketException
            txtLog.Text &= "Server already exists" & vbCrLf
        End Try
    End Sub

    Sub GetDataFromClient()
        Dim strData As String
        txtLog.Text &= "Watching active thread" & vbCrLf
        Try
            Do
                strData = brNetReader.ReadString
                If (strData(0) = "P") Then
                    For intLoop = 0 To 8 Step 1
                        charGamePlay(intLoop) = strData(intLoop + 1)
                    Next
                    Call checkOtherPlayMoves(charGamePlay)
                    Call gamePlay()
                    If (checkWinPatterns(charGamePlay) = True) Then
                        bwNetWriter.Write("W" & charOtherPlayerLetter)
                    ElseIf ((checkWinPatterns(charGamePlay) = False) And intMove = 10) Then
                        bwNetWriter.Write("W" & "C")
                    End If
                ElseIf (strData(0) = "W") Then
                    lblWinner.Text = strData(1) & " Wins"
                    bwNetWriter.Write("W" & strData(1))
                    If ((strData(0) = "W") And strData(1) = "C") Then
                        lblWinner.Text = "Tie"
                    End If
                    txtLog.Text &= "From Client: " & strData & vbCrLf
                    Call StopListening()
                End If
                    txtLog.Text &= "From Client: " & strData & vbCrLf
            Loop While (strData <> "~~END~~") And sktServerConnection.Connected
            Call StopListening()
        Catch IOEx As IOException
            txtLog.Text &= "Closing connection" & vbCrLf
            Call StopListening()
        End Try
    End Sub

    Private Sub btnStopServer_Click(sender As Object, e As EventArgs) Handles btnStopServer.Click
        Call StopListening()
    End Sub

    Sub StopListening()
        pnlBoard.Enabled = False
        btnStartServer.Enabled = False
        btnStopServer.Enabled = False
        btnSubmitStart.Enabled = False
        intMove = 1
        Call clearBtns()
        txtLog.Text &= vbCrLf & "Closing connection" & vbCrLf
        Try
            bwNetWriter.Write("~~END~~")
        Catch Ex As Exception
        End Try
        Try
            bwNetWriter.Close()
            brNetReader.Close()
            nsNetStream.Close()
            tcpServer.Stop()
            bwNetWriter = Nothing
            brNetReader = Nothing
            nsNetStream = Nothing
            tcpServer = Nothing
            Try
                thdData.Abort()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        Finally
            txtLog.Text &= "Server Stopped" & vbCrLf
            pnlSetUp.Visible = True
        End Try
    End Sub

    Private Sub frmServer_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call StopListening()
    End Sub

    Private Sub rbtn_Click(sender As Object, e As EventArgs) Handles rbtnO.Click, rbtnX.Click, rbtnXFirst.Click, rbtnOFirst.Click
        If ((rbtnX.Checked Or rbtnO.Checked = True) And (rbtnXFirst.Checked Or rbtnOFirst.Checked = True)) Then
            btnSubmitStart.Enabled = True
            If (rbtnX.Checked = True) Then
                gbxPlayer.Tag = "X"
                charOtherPlayerLetter = "O"
            Else
                gbxPlayer.Tag = "O"
                charOtherPlayerLetter = "X"
            End If
            If (rbtnXFirst.Checked = True) Then
                gbxFirst.Tag = "X"
            Else
                gbxFirst.Tag = "O"
            End If
        Else
        End If
    End Sub

    Private Sub btnSubmitStart_Click(sender As Object, e As EventArgs) Handles btnSubmitStart.Click
        strGameSetup = gbxPlayer.Tag & gbxFirst.Tag
        Me.Text = "Server - Tic Tac Toe - " & gbxFirst.Text
        If (gbxPlayer.Tag = gbxFirst.Tag) Then
            intMove += 1
            Call myTurn(intMove)
        Else
        End If
        pnlSetUp.Visible = False
        btnStartServer.Enabled = True
    End Sub

    Private Sub btnP0_Click(sender As Object, e As EventArgs) Handles btnP0.Click
        charSendToClient(0) = "1"
        btnP0.Text = gbxPlayer.Tag
        btnP0.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP1_Click(sender As Object, e As EventArgs) Handles btnP1.Click
        charSendToClient(1) = "1"
        btnP1.Text = gbxPlayer.Tag
        btnP1.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP2_Click(sender As Object, e As EventArgs) Handles btnP2.Click
        charSendToClient(2) = "1"
        btnP2.Text = gbxPlayer.Tag
        btnP2.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP3_Click(sender As Object, e As EventArgs) Handles btnP3.Click
        charSendToClient(3) = "1"
        btnP3.Text = gbxPlayer.Tag
        btnP3.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP4_Click(sender As Object, e As EventArgs) Handles btnP4.Click
        charSendToClient(4) = "1"
        btnP4.Text = gbxPlayer.Tag
        btnP4.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP5_Click(sender As Object, e As EventArgs) Handles btnP5.Click
        charSendToClient(5) = "1"
        btnP5.Text = gbxPlayer.Tag
        btnP5.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP6_Click(sender As Object, e As EventArgs) Handles btnP6.Click
        charSendToClient(6) = "1"
        btnP6.Text = gbxPlayer.Tag
        btnP6.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP7_Click(sender As Object, e As EventArgs) Handles btnP7.Click
        charSendToClient(7) = "1"
        btnP7.Text = gbxPlayer.Tag
        btnP7.Enabled = False
        Call writeToClient()
    End Sub

    Private Sub btnP8_Click(sender As Object, e As EventArgs) Handles btnP8.Click
        charSendToClient(8) = "1"
        btnP8.Text = gbxPlayer.Tag
        btnP8.Enabled = False
        Call writeToClient()
    End Sub

    Function convertTo1D()
        Dim strConverted = Nothing
        For intLoop = 0 To 8 Step 1
            If (charSendToClient(intLoop) = Nothing) Then
                strConverted &= " "
            ElseIf (charSendToClient(intLoop) = "1") Then
                strConverted &= gbxPlayer.Tag
            End If
        Next
        Return strConverted
    End Function

    Sub writeToClient()
        intMove += 1
        Call myTurn(intMove)
        bwNetWriter.Write("P" & convertTo1D())
    End Sub

    Sub clearBtns()
        btnP0.Text = Nothing
        btnP0.Enabled = True
        btnP1.Text = Nothing
        btnP1.Enabled = True
        btnP2.Text = Nothing
        btnP2.Enabled = True
        btnP3.Text = Nothing
        btnP3.Enabled = True
        btnP4.Text = Nothing
        btnP4.Enabled = True
        btnP5.Text = Nothing
        btnP5.Enabled = True
        btnP6.Text = Nothing
        btnP6.Enabled = True
        btnP7.Text = Nothing
        btnP7.Enabled = True
        btnP8.Text = Nothing
        btnP8.Enabled = True
    End Sub

    Sub gamePlay()
        intMove += 1
        Call myTurn(intMove)
    End Sub

    Sub checkOtherPlayMoves(currentMoves() As Char)
        If (currentMoves(0) = charOtherPlayerLetter) Then
            btnP0.Text = charOtherPlayerLetter
            btnP0.Enabled = False
        End If
        If (currentMoves(1) = charOtherPlayerLetter) Then
            btnP1.Text = charOtherPlayerLetter
            btnP1.Enabled = False
        End If
        If (currentMoves(2) = charOtherPlayerLetter) Then
            btnP2.Text = charOtherPlayerLetter
            btnP2.Enabled = False
        End If
        If (currentMoves(3) = charOtherPlayerLetter) Then
            btnP3.Text = charOtherPlayerLetter
            btnP3.Enabled = False
        End If
        If (currentMoves(4) = charOtherPlayerLetter) Then
            btnP4.Text = charOtherPlayerLetter
            btnP4.Enabled = False
        End If
        If (currentMoves(5) = charOtherPlayerLetter) Then
            btnP5.Text = charOtherPlayerLetter
            btnP5.Enabled = False
        End If
        If (currentMoves(6) = charOtherPlayerLetter) Then
            btnP6.Text = charOtherPlayerLetter
            btnP6.Enabled = False
        End If
        If (currentMoves(7) = charOtherPlayerLetter) Then
            btnP7.Text = charOtherPlayerLetter
            btnP7.Enabled = False
        End If
        If (currentMoves(8) = charOtherPlayerLetter) Then
            btnP8.Text = charOtherPlayerLetter
            btnP8.Enabled = False
        End If
    End Sub

    Sub myTurn(move)
        If (move Mod 2 = 0) Then
            pnlBoard.Enabled = True
        Else
            pnlBoard.Enabled = False
        End If
    End Sub

    Function checkWinPatterns(currentMoves() As Char)
        If ((currentMoves(0) = charOtherPlayerLetter) And (currentMoves(1) = charOtherPlayerLetter) And (currentMoves(2) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(3) = charOtherPlayerLetter) And (currentMoves(4) = charOtherPlayerLetter) And (currentMoves(5) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(6) = charOtherPlayerLetter) And (currentMoves(7) = charOtherPlayerLetter) And (currentMoves(8) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(0) = charOtherPlayerLetter) And (currentMoves(3) = charOtherPlayerLetter) And (currentMoves(6) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(0) = charOtherPlayerLetter) And (currentMoves(3) = charOtherPlayerLetter) And (currentMoves(6) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(1) = charOtherPlayerLetter) And (currentMoves(4) = charOtherPlayerLetter) And (currentMoves(7) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(2) = charOtherPlayerLetter) And (currentMoves(5) = charOtherPlayerLetter) And (currentMoves(8) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(0) = charOtherPlayerLetter) And (currentMoves(4) = charOtherPlayerLetter) And (currentMoves(8) = charOtherPlayerLetter)) Then
            Return True
        ElseIf ((currentMoves(2) = charOtherPlayerLetter) And (currentMoves(4) = charOtherPlayerLetter) And (currentMoves(6) = charOtherPlayerLetter)) Then
            Return True
        End If
    End Function
End Class
