Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = MaskedTextBox1.Text
        Label2.Text = text
    End Sub
End Class
