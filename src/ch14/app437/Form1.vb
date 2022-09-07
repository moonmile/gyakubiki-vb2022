Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 画像形式でペーストする
        If Clipboard.ContainsImage() Then
            Dim Image = Clipboard.GetImage()
            PictureBox1.Image = Image
        End If
    End Sub
End Class
