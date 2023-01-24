Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim Image = My.Resources.book
        ' 画像を描画する
        g.DrawImage(Image,
                New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height),
                0, 0, Image.Width, Image.Height, GraphicsUnit.Pixel)
        ' 文字を入れる
        Dim text = DateTime.Now.ToString("yyyy-MM-dd")
        g.DrawString(text,
                New Font("Meiryo", 30.0F),
                Brushes.Red,
                New Point(0, 0))
    End Sub
End Class
