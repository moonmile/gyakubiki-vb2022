Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim num = 0
        ' 入力されているかどうかをチェック
        If TextBox1.Text = "" Then
            Label2.Text = "数値を入力してください"
            Return
        End If
        ' 数値かどうかをチェック
        If Integer.TryParse(TextBox1.Text, num) = False Then
            Label2.Text = "数字で入力してください"
            Return
        End If
        ' 範囲をチェック
        If num < 0 Or num > 100 Then
            Label2.Text = "範囲を正しく入力してください。"
            Return
        End If
        ' 入力した数値を表示する
        Label2.Text = $"入力した数値は {num} です"
    End Sub
End Class
