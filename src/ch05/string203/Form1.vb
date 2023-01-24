Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim oldText = TextBox3.Text ' 置き換え対象
        Dim newText = TextBox4.Text ' 置き換える文字列
        TextBox2.Text = Text.Replace(oldText, newText)
    End Sub
End Class
