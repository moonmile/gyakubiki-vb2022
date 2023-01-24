Imports System.Configuration

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim appSettings = ConfigurationManager.AppSettings
        Dim key = TextBox1.Text
        Dim value = IIf(appSettings(key) Is Nothing, "(none)", appSettings(key))
        TextBox2.Text = value
    End Sub
End Class
