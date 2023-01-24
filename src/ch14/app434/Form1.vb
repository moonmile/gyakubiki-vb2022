Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Clipboard.Clear()
        Clipboard.SetText(TextBox1.Text)
        MessageBox.Show("クリップボードにコピーしました", "確認")
    End Sub
End Class
