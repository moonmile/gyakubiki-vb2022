Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label5.Text = dt.ToString()
        Label6.Text = dt.Hour.ToString()
        Label7.Text = dt.Minute.ToString()
        Label8.Text = dt.Second.ToString()
    End Sub
End Class
