﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim a = Integer.Parse(TextBox1.Text)
        Dim b = Integer.Parse(TextBox2.Text)
        Try
            Dim ans = calc(a, b)
            MessageBox.Show($"ans: {ans}")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub

    Private Function calc(a As Integer, b As Integer) As Integer

        ' 0除算をチェックする
        If b = 0 Then

            ' 例外を発生させる
            Throw New DivideByZeroException("0で除算はできません")
        End If
        Return a / b
    End Function
End Class
