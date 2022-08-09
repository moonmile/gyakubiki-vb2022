Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim image1 = My.Resources.kazu
        Dim image2 = My.Resources.frame
        ' 写真を描画する
        Dim rect As New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height)
        g.DrawImage(image1, rect, 0, 0, image1.Width, image1.Height, GraphicsUnit.Pixel)
        ' 透明色を設定してフレームを描画する
        Dim ia As New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorKey(Color.Red, Color.Red)
        g.DrawImage(image2, rect, 0, 0, image2.Width, image2.Height, GraphicsUnit.Pixel, ia)
    End Sub
End Class
