Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        ' 市松模様で塗る
        g.FillRectangle(Brushes.Black, 0, 0, CInt(PictureBox1.Width / 2),
                        CInt(PictureBox1.Height / 2))
        g.FillRectangle(Brushes.Black,
                CInt(PictureBox1.Width / 2), CInt(PictureBox1.Height / 2),
                CInt(PictureBox1.Width / 2), CInt(PictureBox1.Height / 2))
        ' 透明度を指定する
        Dim cm As New System.Drawing.Imaging.ColorMatrix() With
            {
                .Matrix00 = 1.0F, ' 赤
                .Matrix11 = 1.0F, ' 緑
                .Matrix22 = 1.0F, ' 青
                .Matrix33 = 0.5F, ' 透明度（アルファチャンネル）
                .Matrix44 = 1.0F
            }
        Dim ia As New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorMatrix(cm)
        Dim Image = My.Resources.book
        ' 画像を半透明にして貼る
        g.DrawImage(
            Image,
            New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height),
            0, 0, Image.Width, Image.Height,
            GraphicsUnit.Pixel,
            ia)
    End Sub
End Class
