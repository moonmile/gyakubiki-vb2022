Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim cm As New System.Drawing.Imaging.ColorMatrix() With
            {
                .Matrix00 = 0.393F,
                .Matrix01 = 0.349F,
                .Matrix02 = 0.272F,
                .Matrix10 = 0.769F,
                .Matrix11 = 0.686F,
                .Matrix12 = 0.534F,
                .Matrix20 = 0.189F,
                .Matrix21 = 0.168F,
                .Matrix22 = 0.131F,
                .Matrix33 = 1.0F,
                .Matrix44 = 1.0F
            }
        Dim ia As New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorMatrix(cm)
        ' 画像を描画する
        Dim image = My.Resources.kazu
        g.DrawImage(
                image,
                New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height),
                0, 0, image.Width, image.Height,
                GraphicsUnit.Pixel,
                ia)
    End Sub
End Class
