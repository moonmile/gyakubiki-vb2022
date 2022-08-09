Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        Try
            Dim img = Image.FromFile(path)
        Catch ex As System.IO.FileNotFoundException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
