Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label4.Text = dt.ToString()
        Label5.Text = dt.ToLongDateString()
        Label6.Text = dt.ToLongTimeString()
    End Sub
End Class
