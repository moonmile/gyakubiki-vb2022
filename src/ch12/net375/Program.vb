Imports System
Imports System.Net.Sockets

Module Program
    Sub Main(args As String())
        Console.WriteLine("TCP/IP Client")
        Dim client As New TcpClient()
        client.Connect("localhost", 9000)
        Dim stream = client.GetStream()

        ' 10âÒëóêMÇ∑ÇÈ
        For i = 1 To 10
            Console.WriteLine($"Send Data {i}")
            Dim data = System.Text.Encoding.ASCII.GetBytes("Hello")
            Dim type As Byte = &H1
            stream.WriteByte((data.Length))
            stream.WriteByte(type)
            stream.Write(data)
            stream.Flush()
            Task.Delay(1000).Wait()
        Next
        stream.Write(New Byte() {0, 0})
        stream.Close()
        Console.WriteLine("  Close")
    End Sub
End Module
