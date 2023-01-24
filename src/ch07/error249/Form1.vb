Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        Try
            Dim reader = System.IO.File.OpenText(path)
            Dim Text = reader.ReadToEnd()
            reader.Close()
        Catch ex As System.IO.IOException
            ' 読み込みに失敗したときに例外が発生する
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
