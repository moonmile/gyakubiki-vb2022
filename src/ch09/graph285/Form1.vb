Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        ' 画像を反転する
        Dim image = My.Resources.book
        g.DrawImage(image, PictureBox1.Width, 0,
                    -PictureBox1.Width, PictureBox1.Height)
    End Sub
End Class
