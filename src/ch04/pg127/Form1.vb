﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTime.Now
        dt = DateTime.Parse("2022/10/10 15:02:18")
        Label6.Text = dt.ToString()
        Label7.Text = dt.ToShortDateString()
        Label8.Text = dt.ToShortTimeString()
        Label9.Text = dt.ToString("tt h時 m分 s秒")
        Label10.Text = dt.ToString("yyyy年 M月 d日 dddd")
    End Sub
End Class
