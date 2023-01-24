Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        Try
            ' 4文字目から3文字分取得
            TextBox2.Text = text.Substring(4, 3)
        Catch ex As ArgumentOutOfRangeException
            MessageBox.Show(ex.Message)
            Return
        End Try
    End Sub
End Class
