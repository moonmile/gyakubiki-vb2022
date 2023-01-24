Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 普通の直線
        For i = 0 To 99
            ' ランダムに直線を描く
            Dim x1 = Random.Shared.Next(PictureBox1.Width)
            Dim y1 = Random.Shared.Next(PictureBox1.Height)
            Dim x2 = Random.Shared.Next(PictureBox1.Width)
            Dim y2 = Random.Shared.Next(PictureBox1.Height)
            g.DrawLine(Pens.Black, x1, y1, x2, y2)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 太い線で描画
        Dim pen As New Pen(Color.Red, 5)
        For i = 0 To 99
            ' ランダムに直線を描く
            Dim x1 = Random.Shared.Next(PictureBox1.Width)
            Dim y1 = Random.Shared.Next(PictureBox1.Height)
            Dim x2 = Random.Shared.Next(PictureBox1.Width)
            Dim y2 = Random.Shared.Next(PictureBox1.Height)
            g.DrawLine(pen, x1, y1, x2, y2)
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 点線で描画
        Dim pen As New Pen(Color.Blue) With
            {
                .DashStyle = System.Drawing.Drawing2D.DashStyle.Dot
            }
        For i = 0 To 99
            ' ランダムに直線を描く
            Dim x1 = Random.Shared.Next(PictureBox1.Width)
            Dim y1 = Random.Shared.Next(PictureBox1.Height)
            Dim x2 = Random.Shared.Next(PictureBox1.Width)
            Dim y2 = Random.Shared.Next(PictureBox1.Height)
            g.DrawLine(pen, x1, y1, x2, y2)
        Next
    End Sub
End Class
