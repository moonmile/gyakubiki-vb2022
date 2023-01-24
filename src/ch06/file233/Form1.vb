Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        Using sw = New System.IO.StreamWriter(path, True)
            sw.WriteLine($"書き込み日時: {DateTime.Now}")
        End Using
        MessageBox.Show("ファイルに追記しました")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim path = TextBox1.Text
        If System.IO.File.Exists(path) = True Then
            System.IO.File.Delete(path)
        End If
        MessageBox.Show("ファイルを削除しました")
    End Sub
End Class
