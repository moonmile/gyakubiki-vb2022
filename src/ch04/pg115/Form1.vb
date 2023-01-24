Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim result = CheckBox1.Checked AndAlso CheckBox2.Checked
        Label1.Text = $"演算結果 : {result}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim result = CheckBox1.Checked OrElse CheckBox2.Checked
        Label1.Text = $"演算結果 : {result}"
    End Sub
End Class
