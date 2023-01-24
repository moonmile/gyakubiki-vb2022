Public Class Form1
    ''' <summary>
    ''' ファイルから表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        PictureBox1.Image = Image.FromFile("とうもろこし.jpg")
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    ''' <summary>
    ''' リソースから表示
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        PictureBox1.Image = My.Resources.にんじん
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom

    End Sub

    ''' <summary>
    ''' 画像をクリア
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        PictureBox1.Image = Nothing
    End Sub
End Class
