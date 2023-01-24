Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        ' グラデーションを作成
        Dim br As New System.Drawing.Drawing2D.LinearGradientBrush(
                New Point(0, 0), New Point(0, PictureBox1.Height),
                Color.Green, Color.White)
        g.FillRectangle(br, 0, 0,
                        PictureBox1.Width,
                        PictureBox1.Height)
    End Sub
End Class
