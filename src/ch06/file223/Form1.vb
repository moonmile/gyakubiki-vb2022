Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        If path = String.Empty Then
            Return
        End If
        System.IO.Directory.CreateDirectory(path)
        MessageBox.Show($"フォルダーを作成しました {path}")
    End Sub
End Class
