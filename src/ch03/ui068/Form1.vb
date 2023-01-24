Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Label1.Text = DateTimePicker1.Value.ToLongDateString()
    End Sub
End Class
