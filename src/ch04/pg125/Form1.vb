Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt1 = DateTime.Now
        Dim dt2 = dt1.ToUniversalTime()
        Label3.Text = dt1.ToString()
        Label4.Text = dt2.ToString()
        Label5.Text = dt1.ToString("zzz")
    End Sub
End Class
