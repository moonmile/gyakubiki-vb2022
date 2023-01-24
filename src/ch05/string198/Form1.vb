Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        ' 大文字に変換
        Label4.Text = Text.ToUpper()
        ' 小文字に変換
        Label5.Text = Text.ToLower()
    End Sub
End Class
