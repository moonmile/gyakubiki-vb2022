Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = Integer.Parse(TextBox1.Text)
        Dim Url = $"http://localhost:5000/api/Gyakubiki/checkUserAgent"
        Dim cl = New HttpClient()
        cl.DefaultRequestHeaders.Add("User-Agent", "Gyakubiki-App")
        Dim response = Await cl.GetStringAsync(Url)
        TextBox2.Text = response
    End Sub
End Class
