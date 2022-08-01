Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = 100
        Label3.Text = (x / 20).ToString()
        x += 20
        Label4.Text = x.ToString()
    End Sub
End Class
