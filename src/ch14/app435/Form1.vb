﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Clipboard.Clear()
        Clipboard.SetImage(PictureBox1.Image)
        MessageBox.Show("クリップボードにコピーしました")
    End Sub
End Class
