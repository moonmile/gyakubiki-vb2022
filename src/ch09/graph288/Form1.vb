Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        ' 画像の大きさを変える
        Dim image = My.Resources.book
        Dim mx = New System.Drawing.Drawing2D.Matrix()
        mx.Scale(2.0F, 2.0F)
        g.Transform = mx
        g.DrawImage(image, New Point(0, 0))
    End Sub
End Class
