Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i = 100 ' 初期値を100にする
        Do
            ListBox1.Items.Add($"No.{i}")
            i += 1
        Loop While i < 10
    End Sub
End Class
