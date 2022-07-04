Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' ラベルに現在日時を表示する
        Label2.Text = DateTime.Now.ToString()
    End Sub
End Class
