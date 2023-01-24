Public Class Form1
    ''' <summary>
    ''' 透過色を指定した場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 透過色を設定する
        Dim ia = New System.Drawing.Imaging.ImageAttributes()
        ia.SetColorKey(Color.Red, Color.Red)
        ' 画像を描画する
        Dim image = My.Resources.book
        g.DrawImage(
                image,
                New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height),
                0, 0, image.Width, image.Height,
                GraphicsUnit.Pixel,
                ia)
    End Sub

    ''' <summary>
    ''' 透過色を指定しない場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 透過色を設定しない
        Dim ia = New System.Drawing.Imaging.ImageAttributes()
        ' 画像を描画する
        Dim image = My.Resources.book
        g.DrawImage(
            image,
            New Rectangle(0, 0, PictureBox1.Width, PictureBox1.Height),
            0, 0, image.Width, image.Height,
            GraphicsUnit.Pixel,
            ia)
    End Sub
End Class
