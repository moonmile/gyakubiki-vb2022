Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        If Text.Length < 4 Then
            Label2.Text = "4文字以上入力してください"
        Else
            Label2.Text = $"{Text.Length}文字入力されました"
        End If
    End Sub
End Class
