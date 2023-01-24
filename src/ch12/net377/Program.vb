Imports System
Imports Microsoft.SqlServer
Imports System.Net.Sockets
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("TCP/IP server")
        ' TCP/IPのサーバーを起動する
        Dim server As New TcpListener(System.Net.IPAddress.Loopback, 9000)
        server.Start()
        Console.WriteLine("Listen...")
        Do
            ' クライアントからの受信を受け付ける
            Dim client = server.AcceptTcpClient()
            Dim stream = client.GetStream()
            Task.Factory.StartNew(
                Sub()
                    While stream.Socket.Connected
                        ' 受信データの読み出し
                        ' 1バイト目 : 長さ
                        ' 2バイト目 : タイプ
                        ' 3バイト以降: データ
                        Dim length = stream.ReadByte()
                        Dim type = stream.ReadByte()
                        Dim data = New Byte(length - 1) {}
                        stream.Read(data, 0, length)
                        Console.WriteLine("Receive Data")
                        Console.WriteLine($"  Length: {length}")
                        Console.WriteLine($"  Type: {type}")
                        Console.WriteLine("  Data: " + BitConverter.ToString(data))
                        If type = 1 Then

                            ' クライアントにデータを返す
                            Dim data2 = System.Text.Encoding.ASCII.GetBytes("HELLO")
                            Dim type2 = &H2
                            stream.WriteByte(data2.Length)
                            stream.WriteByte(type2)
                            stream.Write(data)
                            stream.Flush()
                        End If
                        If type = 0 Then
                            ' クローズ処理
                            Exit While
                        End If
                    End While
                    Console.WriteLine(" Close")
                    stream.Close()
                End Sub)
        Loop
    End Sub
End Module
