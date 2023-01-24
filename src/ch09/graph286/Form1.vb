Public Class Form1

    Private page As Integer = -1

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim image = My.Resources.cocks
        ' ページを進める
        page += 1
        If page >= 5 Then

            page = 0
        End If
        Dim pt As New Point(0, page * 600)
        g.DrawImage(image,
            New Rectangle(0, 0,
                PictureBox1.Width, PictureBox1.Height),
            New RectangleF(0, page * 600, 800, 600),
            GraphicsUnit.Pixel)
    End Sub

    Sub makeBitmap()
        Dim bmp As New Bitmap(My.Resources.cock001, 800, 600 * 5)
        Dim g = Graphics.FromImage(bmp)
        Dim Width = My.Resources.cock001.Width
        Dim height = My.Resources.cock001.Height
        g.DrawImage(My.Resources.cock001, New Rectangle(0, 600 * 0, 800, 600), 0, 0, Width, height, GraphicsUnit.Pixel)
        g.DrawImage(My.Resources.cock002, New Rectangle(0, 600 * 1, 800, 600), 0, 0, Width, height, GraphicsUnit.Pixel)
        g.DrawImage(My.Resources.cock003, New Rectangle(0, 600 * 2, 800, 600), 0, 0, Width, height, GraphicsUnit.Pixel)
        g.DrawImage(My.Resources.cock004, New Rectangle(0, 600 * 3, 800, 600), 0, 0, Width, height, GraphicsUnit.Pixel)
        g.DrawImage(My.Resources.cock005, New Rectangle(0, 600 * 4, 800, 600), 0, 0, Width, height, GraphicsUnit.Pixel)
        bmp.Save("cocks.bmp", System.Drawing.Imaging.ImageFormat.Bmp)
    End Sub

End Class
