Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim apikey = TextBox1.Text
        Dim Url = $"https://localhost:5001/api/Books/hello"
        Dim cl = New HttpClient()
        ' API-KEYを指定する
        cl.DefaultRequestHeaders.Add("X-API-KEY", apikey)
        Dim response = Await cl.GetAsync(Url)
        TextBox2.Text = Await response.Content.ReadAsStringAsync()
    End Sub
End Class
