Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 折れ線を描画
        Dim points As New List(Of Point)()
        For i = 0 To 19

            Dim x = PictureBox1.Width / 20 * i
            Dim y = Random.Shared.Next(PictureBox1.Height)
            points.Add(New Point(x, y))
        Next
        g.DrawLines(Pens.Black, points.ToArray())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 閉じた多角形を描画
        Dim points As New List(Of Point)()
        For i = 0 To 19

            Dim x = PictureBox1.Width / 20 * i
            Dim y = Random.Shared.Next(PictureBox1.Height)
            points.Add(New Point(x, y))
        Next
        g.DrawPolygon(Pens.Red, points.ToArray())
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        Dim g = PictureBox1.CreateGraphics()
        g.Clear(DefaultBackColor)
        ' 塗りつぶした多角形を描画
        Dim points As New List(Of Point)()
        For i = 0 To 19

            Dim x = PictureBox1.Width / 20 * i
            Dim y = Random.Shared.Next(PictureBox1.Height)
            points.Add(New Point(x, y))
        Next
        g.FillPolygon(Brushes.Green, points.ToArray())
    End Sub
End Class
