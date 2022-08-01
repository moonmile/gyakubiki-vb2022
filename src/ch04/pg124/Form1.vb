Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dt1 = New DateTime(2022, 4, 1)
        Dim dt2 = New DateTime(2022, 5, 2, 12, 34, 56)

        Label3.Text = dt1.ToString()
        Label4.Text = dt2.ToString()
    End Sub
End Class
