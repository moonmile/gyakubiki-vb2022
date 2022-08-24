Imports System
Imports System.Net.Sockets

Module Program
    Sub Main(args As String())
        Console.WriteLine("TCP/IP Client")
        Dim client As New TcpClient()
        client.Connect("localhost", 9000)
        Dim stream = client.GetStream()

        ' 10回送信する
        For i = 1 To 10
            Console.WriteLine($"Send Data {i}")
            Dim data = System.Text.Encoding.ASCII.GetBytes("Hello")
            Dim type As Byte = &H1
            stream.WriteByte((data.Length))
            stream.WriteByte(type)
            stream.Write(data)
            stream.Flush()
            ' サーバーからのデータを受信する
            Dim length2 = stream.ReadByte()
            Dim type2 = stream.ReadByte()
            Dim data2 = New Byte(length2) {}
            stream.Read(data2, 0, length2)
            Console.WriteLine("Receive Data")
            Console.WriteLine($"  Length: {length2}")
            Console.WriteLine($"  Type: {type2}")
            Console.WriteLine("  Data: " + BitConverter.ToString(data2))

            Task.Delay(1000).Wait()
        Next
        ' クローズ用のコマンドを送信
        stream.Write(New Byte() {0, 0})
        ' クローズ
        stream.Close()
        Console.WriteLine("  Close")
    End Sub
End Module
