Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' テキスト形式でペーストする
        If Clipboard.ContainsText() Then
            Dim Text = Clipboard.GetText()
            TextBox1.Text = Text
        End If
    End Sub
End Class
