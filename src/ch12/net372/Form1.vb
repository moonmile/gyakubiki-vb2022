Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hostname = System.Net.Dns.GetHostName()
        ' IPアドレスを取得
        Dim addrs = System.Net.Dns.GetHostAddresses(hostname)
        ListBox1.Items.Clear()
        For Each ip In addrs
            ' iPv4 のみ追加
            If ip.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                ListBox1.Items.Add(ip.ToString())
            End If
        Next
    End Sub
End Class
