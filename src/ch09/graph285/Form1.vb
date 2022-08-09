Public Class Form1

    Private n As Integer = 0

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        Dim image = My.Resources.book
        Dim mx As New System.Drawing.Drawing2D.Matrix()
        ' 画像を中央で5度ずつ回転させる
        mx.Translate(-PictureBox1.Width / 2, -PictureBox1.Height / 2, System.Drawing.Drawing2D.MatrixOrder.Append)
        mx.RotateAt(n, New Point(0, 0), System.Drawing.Drawing2D.MatrixOrder.Append)
        mx.Translate(PictureBox1.Width / 2, PictureBox1.Height / 2, System.Drawing.Drawing2D.MatrixOrder.Append)
        g.Transform = mx
        g.DrawImage(image, New Point(0, 0))
        n += 5

    End Sub
End Class
