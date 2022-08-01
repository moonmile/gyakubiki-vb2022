Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt = DateTime.Now
        Label6.Text = dt.ToString()
        Label7.Text = dt.AddDays(10).ToLongDateString()
        Label8.Text = dt.AddHours(-5).ToString()
        Label9.Text = New DateTime(dt.Year, dt.Month, 1).AddMonths(1).AddDays(-1).ToLongDateString()
        Label10.Text = New DateTime(dt.Year, dt.Month, 1).AddDays(-1).ToLongDateString()
    End Sub
End Class
