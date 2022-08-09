Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Try
            ' 10文字目を取得する
            Dim t = Text.Substring(10, 1)
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
