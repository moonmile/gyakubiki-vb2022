Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x = Integer.Parse(TextBox1.Text)
        Dim ans = sample(x)
        MessageBox.Show($"計算結果: {ans}")
    End Sub

    Private Function sample(x As Integer) As Integer
        ' 範囲をチェックする
        If 0 <= x And x <= 100 Then
            Return x * x
        Else
            Debug.Fail("範囲外です")
            Return 0
        End If
    End Function
End Class
