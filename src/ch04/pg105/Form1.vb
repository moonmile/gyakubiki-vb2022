Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As Double = 123.45
        Dim m As Integer = 10000

        Label5.Text = n.ToString()
        Label6.Text = m.ToString("#,###円")
        Label7.Text = n.ToString("#.###")
        Label8.Text = n.ToString("0.000")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim n As Double = 123.45
        Dim m As Integer = 10000


        Label5.Text = $"{n}"
        Label6.Text = $"{m:#,###}円"
        Label7.Text = $"{n:#.###}"
        Label8.Text = $"{n:#0.000}"
    End Sub
End Class
