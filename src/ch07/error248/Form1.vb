Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Try
            ' null文字を追加する
            ' コンパイル時に警告がでる
            Dim t = Text.Insert(0, Nothing)
        Catch ex As ArgumentException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
