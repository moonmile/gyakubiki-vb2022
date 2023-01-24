Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dlg = New SaveFileDialog() With {
                .Title = "保存先の画像ファイルの選択",
                .Filter = "画像ファイル(*.jgp)|*.jpg|画像ファイル(*.png)|*.png"
            }
        If dlg.ShowDialog() = DialogResult.Cancel Then
            Return
        End If
        If dlg.FilterIndex = 1 Then
            PictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        Else
            PictureBox1.Image.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        Label1.Text = dlg.FileName
        Label2.Text = "保存しました"
    End Sub
End Class
