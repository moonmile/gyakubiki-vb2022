Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As Boolean = CheckBox1.Checked And CheckBox2.Checked
        Label1.Text = $"演算結果 : {result}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As Boolean = CheckBox1.Checked Or CheckBox2.Checked
        Label1.Text = $"演算結果 : {result}"
    End Sub
End Class
