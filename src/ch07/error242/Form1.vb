﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Try
            Dim a = Integer.Parse(Text)
        Catch ex As Exception
            MessageBox.Show(ex.GetType().Name, "エラー発生")
        End Try
    End Sub
End Class
