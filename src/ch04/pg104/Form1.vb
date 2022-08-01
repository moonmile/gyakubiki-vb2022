Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Double = Double.Parse(TextBox1.Text)
        Dim y As Double = Double.Parse(TextBox2.Text)
        Dim ans As Double = x + y
        TextBox3.Text = ans.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x As Double = 0.0
        Dim y As Double = 0.0
        ' 安全に文字列から数値へ変換する
        If Double.TryParse(TextBox1.Text, x) = False Then
            Return
        End If
        If Double.TryParse(TextBox2.Text, y) = False Then
            Return
        End If
        Dim ans As Double = x + y
        TextBox3.Text = ans.ToString()

    End Sub
End Class
