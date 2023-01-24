Imports System
Imports Microsoft.SqlServer
Imports System.Net.Sockets
Imports System.IO

Module Program
    Sub Main(args As String())
        Console.WriteLine("TCP/IP server")
        ' TCP/IP�̃T�[�o�[���N������
        Dim server As New TcpListener(System.Net.IPAddress.Loopback, 9000)
        server.Start()
        Console.WriteLine("Listen...")
        Do
            ' �N���C�A���g����̎�M���󂯕t����
            Dim client = server.AcceptTcpClient()
            Dim stream = client.GetStream()
            Task.Factory.StartNew(
                Sub()
                    While stream.Socket.Connected
                        ' ��M�f�[�^�̓ǂݏo��
                        ' 1�o�C�g�� : ����
                        ' 2�o�C�g�� : �^�C�v
                        ' 3�o�C�g�ȍ~: �f�[�^
                        Dim length = stream.ReadByte()
                        Dim type = stream.ReadByte()
                        Dim data = New Byte(length - 1) {}
                        stream.Read(data, 0, length)
                        Console.WriteLine("Receive Data")
                        Console.WriteLine($"  Length: {length}")
                        Console.WriteLine($"  Type: {type}")
                        Console.WriteLine("  Data: " + BitConverter.ToString(data))
                        If type = 1 Then

                            ' �N���C�A���g�Ƀf�[�^��Ԃ�
                            Dim data2 = System.Text.Encoding.ASCII.GetBytes("HELLO")
                            Dim type2 = &H2
                            stream.WriteByte(data2.Length)
                            stream.WriteByte(type2)
                            stream.Write(data)
                            stream.Flush()
                        End If
                        If type = 0 Then
                            ' �N���[�Y����
                            Exit While
                        End If
                    End While
                    Console.WriteLine(" Close")
                    stream.Close()
                End Sub)
        Loop
    End Sub
End Module
