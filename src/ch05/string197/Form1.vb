﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        Label3.Text = text.Length.ToString()
    End Sub
End Class
