Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = TextBox1.Text
        Label5.Text = "[" + text.Trim() + "]"
        Label6.Text = "[" + text.TrimStart() + "]"
        Label7.Text = "[" + text.TrimEnd() + "]"
    End Sub
End Class
