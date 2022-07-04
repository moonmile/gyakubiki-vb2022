Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' リソースから文字列を表示
        Label1.Text = My.Resources.subject
        ' リソースから画像を表示
        PictureBox1.Image = My.Resources.cock
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
    End Sub
End Class
