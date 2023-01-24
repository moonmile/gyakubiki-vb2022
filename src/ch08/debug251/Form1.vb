Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        ' 数値でない場合、例外が発生する
        Dim x = Integer.Parse(Text)
    End Sub
End Class
