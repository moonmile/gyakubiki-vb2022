Imports System.Configuration
Imports System.Runtime

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim settings = ConfigurationManager.ConnectionStrings
        Dim key = TextBox1.Text
        Dim value = IIf(settings(key)?.ConnectionString Is Nothing, "(none)", settings(key)?.ConnectionString)
        TextBox2.Text = value
    End Sub
End Class
