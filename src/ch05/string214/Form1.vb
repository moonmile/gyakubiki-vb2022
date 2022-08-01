Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Label4.Text = Regex.Match(Text, "^[A-Z]:\\\\").Value
        Label5.Text = Regex.Match(Text, "\\..*$").Value
    End Sub
End Class
