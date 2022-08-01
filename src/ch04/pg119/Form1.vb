Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label5.Text = dt.ToString()
        Label6.Text = dt.Year.ToString()
        Label7.Text = dt.Month.ToString()
        Label8.Text = dt.Day.ToString()
    End Sub
End Class
