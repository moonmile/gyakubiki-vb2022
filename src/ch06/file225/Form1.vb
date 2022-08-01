Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        ' フォルダー名を取得
        Label6.Text = System.IO.Path.GetDirectoryName(path)
        ' ファイル名を取得
        Label7.Text = System.IO.Path.GetFileName(path)
        ' 拡張子を取得
        Label8.Text = System.IO.Path.GetExtension(path)
        ' 拡張子を除いたファイル名を取得
        Label9.Text = System.IO.Path.GetFileNameWithoutExtension(path)
    End Sub
End Class
