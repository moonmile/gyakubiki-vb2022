Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        listBox1.Items.Clear()
        ' 指定した回数だけ処理を繰り返す
        For i = 1 To 10
            listBox1.Items.Add($"No.{i}")
        Next
    End Sub
End Class
