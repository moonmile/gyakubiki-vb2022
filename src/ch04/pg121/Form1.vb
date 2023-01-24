Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now
        Label5.Text = dt.ToString()
        Label6.Text = dt.ToString("yyyy-MM-dd(ddd)")
        Label7.Text = dt.DayOfWeek.ToString()
        Label8.Text = dt.ToString("dddd")
    End Sub
End Class
