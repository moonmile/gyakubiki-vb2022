Imports System
Imports System.IO
Imports System.Net.Sockets

Module Program
    Sub Main(args As String())
        Console.WriteLine("TCP/IP Client")
        Dim client As New TcpClient()
        client.Connect("localhost", 9000)
        Dim stream = client.GetStream()

        Console.WriteLine("Send Data")
        Dim data As Byte() = New Byte() {1, 2, 3, 4}
        Dim type As Byte = &HFF
        stream.WriteByte((data.Length))
        stream.WriteByte(type)
        stream.Write(Data)
        stream.Flush()
        stream.Close()
        Console.WriteLine("  Close")
    End Sub
End Module
