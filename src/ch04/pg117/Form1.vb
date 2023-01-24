Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x As Integer?
        If TextBox1.Text = "" Then
            x = Nothing
        Else
            x = Integer.Parse(TextBox1.Text)
        End If
        ' x が null の場合は 0 に変える
        Label2.Text = $"変数 x = {If(x Is Nothing, 0, x)}"
    End Sub
End Class
