Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Label4.Text = "[" + Text.PadLeft(10) + "]"
        Label5.Text = "[" + Text.PadRight(10) + "]"
    End Sub
End Class
