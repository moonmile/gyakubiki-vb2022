Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x As Integer?
        ' 入力により x に値を入れる
        If TextBox1.Text = "" Then
            x = Nothing
        Else
            x = Integer.Parse(TextBox1.Text)
        End If

        ' 結果を表示する
        If x.HasValue = False Then
            Label2.Text = "x には値がありません(Nothing)"
        Else
            Label2.Text = $"x = {x}"
        End If

    End Sub
End Class
