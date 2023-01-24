Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Image = New Bitmap(My.Resources.book)
        Dim g = Graphics.FromImage(Image)
        ' 文字を入れる
        Dim Text = DateTime.Now.ToString("HH:mm")
        g.DrawString(Text,
                New Font("Meiryo", 30.0F),
                Brushes.Red,
                New Point(0, 0))
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.Image = Image
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim Image = New Bitmap(PictureBox1.Image)
        Image.Save(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) +
                $"\{DateTime.Now.ToString("yyyy-MM-dd")}.png",
                System.Drawing.Imaging.ImageFormat.Png)
        MessageBox.Show("画像を保存しました")
    End Sub
End Class
