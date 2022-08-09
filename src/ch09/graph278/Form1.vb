Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        For i = 0 To 99
            ' ランダムに円を描く
            Dim x = Random.Shared.Next(PictureBox1.Width)
            Dim y = Random.Shared.Next(PictureBox1.Height)
            Dim r = Random.Shared.Next(140) + 10
            g.DrawEllipse(Pens.Black, x, y, r, r)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim burshs As New List(Of Brush) From
            {
                Brushes.Red,
                Brushes.Blue,
                Brushes.Yellow,
                Brushes.Green,
                Brushes.Pink
            }
        g.Clear(DefaultBackColor)
        For i = 0 To 99
            ' ランダムに円を描く
            Dim x = Random.Shared.Next(PictureBox1.Width)
            Dim y = Random.Shared.Next(PictureBox1.Height)
            Dim r = Random.Shared.Next(140) + 10
            Dim brush = burshs(Random.Shared.Next(burshs.Count))
            g.FillEllipse(Brush, x, y, r, r)
        Next

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim g = PictureBox1.CreateGraphics()
        Dim brush = New TextureBrush(My.Resources.book)
        g.Clear(DefaultBackColor)
        For i = 0 To 9
            ' ランダムに円を描く
            Dim x = Random.Shared.Next(PictureBox1.Width)
            Dim y = Random.Shared.Next(PictureBox1.Height)
            Dim r = 200
            g.FillEllipse(brush, x, y, r, r)
        Next
    End Sub
End Class
