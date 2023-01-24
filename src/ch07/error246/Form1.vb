Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Try
            Dim a = Integer.Parse(Text)
        Catch ex As FormatException
            ' 引数が無効の場合
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
