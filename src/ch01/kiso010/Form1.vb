Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 引数のあるメソッドの呼び出し
        TextBox2.AppendText(TextBox1.Text + vbCrLf)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 引数のないメソッドの呼び出し
        TextBox2.Clear()
    End Sub
End Class
