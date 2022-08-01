Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebView21.Source = New Uri(TextBox1.Text)
    End Sub
End Class
