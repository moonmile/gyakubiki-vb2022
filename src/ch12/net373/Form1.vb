Imports System.Net.NetworkInformation

Public Class Form1
    ''' <summary>
    ''' PINGを送信する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Ping As New Ping()
        Dim host = TextBox1.Text
        ListBox1.Items.Clear()
        ' 1秒おきに4回送信する
        For i = 0 To 3
            Dim reply = Await Ping.SendPingAsync(host, 2000)
            ListBox1.Items.Add($"ip: {reply.Address} {reply.Status} time: {reply.RoundtripTime} ms")
            Await Task.Delay(1000)
        Next
    End Sub
End Class
