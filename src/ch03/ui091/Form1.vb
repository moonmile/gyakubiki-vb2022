Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dlg = New OpenFileDialog() With {
                .Title = "画像ファイルの選択",
                .CheckFileExists = True,
                .RestoreDirectory = True,
                .Filter = "イメージファイル|*.bmp;*.jpg;*.png;"
        }
        If dlg.ShowDialog() = DialogResult.OK Then
            Label1.Text = dlg.FileName
            Label2.Text = dlg.SafeFileName
            PictureBox1.Image = Image.FromFile(dlg.FileName)
        Else
            Label1.Text = ""
            Label2.Text = ""
            PictureBox1.Image = Nothing
        End If
    End Sub
End Class
