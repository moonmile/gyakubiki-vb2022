Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username = TextBox1.Text
        Dim password = TextBox2.Text
        MessageBox.Show($"ユーザー名:{username}" + vbCrLf + $"パスワード:{password}")
    End Sub
End Class
