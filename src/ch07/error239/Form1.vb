Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim x = 0
        Try
            x = Integer.Parse(Text)
        Catch ex As FormatException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
