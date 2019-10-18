Imports System.ComponentModel
Imports System.IO
Imports System.Net.Sockets
Imports System.Threading

Public Class frmClient
    Dim tcpClient As TcpClient
    Dim nsNetStream As NetworkStream
    Dim bwNetWriter As BinaryWriter
    Dim brNetReader As BinaryReader
    Dim thdData As Thread
    Dim charMyLetter As Char
    Dim charSendToServer(8) As Char
    Dim charGamePlay(8) As Char
    Dim intMove As Integer = 1
    Dim charOtherPlayerLetter As Char

    Private Sub frmClient_Load(sender As Object, e As EventArgs) Handles Me.Load
        pnlBoard.Enabled = False
        btnStartClient.Enabled = True
        btnStopClient.Enabled = False
        CheckForIllegalCrossThreadCalls = False
        txtAddress.Text = "127.0.0.1"
        txtPort.Text = 1000
        lblWinner.Text = Nothing
    End Sub

    Private Sub btnStartClient_Click(sender As Object, e As EventArgs) Handles btnStartClient.Click
        ReDim charSendToServer(8)
        ReDim charGamePlay(8)
        lblWinner.Text = Nothing
        txtLog.Clear()
        Try
            txtAddress.ReadOnly = True
            txtPort.ReadOnly = True
            txtLog.Text &= "Attempting Connection" & vbCrLf
            tcpClient = New TcpClient
            tcpClient.Connect(txtAddress.Text, CInt(txtPort.Text))
            nsNetStream = tcpClient.GetStream()
            bwNetWriter = New BinaryWriter(nsNetStream)
            brNetReader = New BinaryReader(nsNetStream)
            txtLog.Text &= "Network reader/writer created" & vbCrLf
            btnStartClient.Enabled = False
            btnStopClient.Enabled = True
            txtLog.Text &= "Preparing to watch for data" & vbCrLf
            thdData = New Thread(AddressOf GetDataFromServer)
            thdData.Start()
        Catch IOEx As IOException
            txtLog.Text &= "Error in setting up client" & vbCrLf
        Catch socketEx As SocketException
            txtLog.Text &= "Cannot find server, try again later"
        End Try
    End Sub

    Sub GetDataFromServer()
        Dim strData As String
        txtLog.Text &= "Thread now active" & vbCrLf
        Call myTurn(intMove)
        Try
            Do
                strData = brNetReader.ReadString
                If (strData(0) = "S") Then
                    Call setUpFirstMove(strData)
                ElseIf (strData(0) = "P") Then
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
                    txtLog.Text &= "From Server: " & strData & vbCrLf
                    Call DisconnectClient()
                End If
                txtLog.Text &= "From Server: " & strData & vbCrLf
            Loop While (strData <> "~~END~~")
            Call DisconnectClient()
        Catch IOEx As IOException
            txtLog.Text &= "Closing connection" & vbCrLf
            Call DisconnectClient()
        End Try
    End Sub

    Private Sub btnStopClient_Click(sender As Object, e As EventArgs) Handles btnStopClient.Click
        Call DisconnectClient()
    End Sub

    Sub DisconnectClient()
        pnlBoard.Enabled = False
        btnStartClient.Enabled = True
        btnStopClient.Enabled = False
        intMove = 1
        Call clearBtns()
        txtLog.Text &= vbCrLf & "Disconnecting from server" & vbCrLf
        Try
            bwNetWriter.Write("~~END~~")
        Catch ex As Exception
        End Try
        Try
            bwNetWriter.Close()
            brNetReader.Close()
            nsNetStream.Close()
            tcpClient.Close()
            bwNetWriter = Nothing
            brNetReader = Nothing
            nsNetStream = Nothing
            tcpClient = Nothing
            Try
                thdData.Abort()
            Catch ex As Exception
            End Try
        Catch ex As Exception
        Finally
            txtLog.Text &= "Disconnected" & vbCrLf
        End Try
    End Sub

    Private Sub txtSend_textChanged(sender As Object, e As EventArgs)
        Try
        Catch socketEx As SocketException
            txtLog.Text &= "Failed writing to server"
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnP0_Click(sender As Object, e As EventArgs) Handles btnP0.Click
        charSendToServer(0) = "1"
        btnP0.Text = charMyLetter
        btnP0.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP1_Click(sender As Object, e As EventArgs) Handles btnP1.Click
        charSendToServer(1) = "1"
        btnP1.Text = charMyLetter
        btnP1.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP2_Click(sender As Object, e As EventArgs) Handles btnP2.Click
        charSendToServer(2) = "1"
        btnP2.Text = charMyLetter
        btnP2.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP3_Click(sender As Object, e As EventArgs) Handles btnP3.Click
        charSendToServer(3) = "1"
        btnP3.Text = charMyLetter
        btnP3.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP4_Click(sender As Object, e As EventArgs) Handles btnP4.Click
        charSendToServer(4) = "1"
        btnP4.Text = charMyLetter
        btnP4.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP5_Click(sender As Object, e As EventArgs) Handles btnP5.Click
        charSendToServer(5) = "1"
        btnP5.Text = charMyLetter
        btnP5.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP6_Click(sender As Object, e As EventArgs) Handles btnP6.Click
        charSendToServer(6) = "1"
        btnP6.Text = charMyLetter
        btnP6.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP7_Click(sender As Object, e As EventArgs) Handles btnP7.Click
        charSendToServer(7) = "1"
        btnP7.Text = charMyLetter
        btnP7.Enabled = False
        Call writeToServer()
    End Sub

    Private Sub btnP8_Click(sender As Object, e As EventArgs) Handles btnP8.Click
        charSendToServer(8) = "1"
        btnP8.Text = charMyLetter
        btnP8.Enabled = False
        Call writeToServer()
    End Sub

    Function convertTo1D()
        Dim strConverted = Nothing
        For intLoop = 0 To 8 Step 1
            If (charSendToServer(intLoop) = Nothing) Then
                strConverted &= " "
            ElseIf (charSendToServer(intLoop) = "1") Then
                strConverted &= charMyLetter
            End If
        Next
        Return strConverted
    End Function

    Sub writeToServer()
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

    Private Sub frmClient_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        Call DisconnectClient()
    End Sub

    Sub setUpFirstMove(strData)
        If (strData(1) = "X") Then
            charMyLetter = "O"
            charOtherPlayerLetter = "X"
        Else
            charMyLetter = "X"
            charOtherPlayerLetter = "O"
        End If
        If (strData(2) = charMyLetter) Then
            intMove += 1
            Call myTurn(intMove)
        Else
            Call myTurn(intMove)
        End If
        Me.Text = "Client - Tic Tac Toe - " & charMyLetter
    End Sub

    Sub gamePlay()
        intMove += 1
        Call myTurn(intMove)
    End Sub

    Sub myTurn(move)
        If (move Mod 2 = 0) Then
            pnlBoard.Enabled = True
        Else
            pnlBoard.Enabled = False
        End If
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