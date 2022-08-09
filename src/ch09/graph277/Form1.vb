Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 四角形を表示
        For i = 0 To 99
            ' ランダムに直線を描く
            Dim x = Random.Shared.Next(PictureBox1.Width)
            Dim y = Random.Shared.Next(PictureBox1.Height)
            Dim Width = Random.Shared.Next(PictureBox1.Width / 2)
            Dim Height = Random.Shared.Next(PictureBox1.Height / 2)
            g.DrawRectangle(Pens.Black, x, y, Width, Height)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        Dim burshs As New List(Of Brush)() From
            {
                Brushes.Red,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Pink
            }
        ' 四角形を表示
        For i = 0 To 99
            ' ランダムに直線を描く
            Dim x = Random.Shared.Next(PictureBox1.Width)
            Dim y = Random.Shared.Next(PictureBox1.Height)
            Dim Width = Random.Shared.Next(PictureBox1.Width / 2)
            Dim Height = Random.Shared.Next(PictureBox1.Height / 2)
            Dim brush = burshs(Random.Shared.Next(burshs.Count))
            g.FillRectangle(brush, x, y, Width, Height)
        Next
    End Sub
End Class
