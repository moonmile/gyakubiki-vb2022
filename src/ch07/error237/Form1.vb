﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim x = 0
        Try
            x = Integer.Parse(Text)
        Catch ex As Exception
            MessageBox.Show("予期しないエラーが発生しました", "エラー発生");
        End Try
    End Sub
End Class