Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim rx = New Regex("[様君殿行]$")
        Label3.Text = rx.Replace(Text, "御中")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Text = TextBox1.Text
        Label3.Text = Regex.Replace(Text, "[様君殿行]$", "御中")
    End Sub
End Class
