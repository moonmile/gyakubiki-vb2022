Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' ホスト名を取得
        Dim hostname = System.Net.Dns.GetHostName()
        Label2.Text = hostname
    End Sub
End Class
