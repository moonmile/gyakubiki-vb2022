Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim cl As New HttpClient()
        Dim Url = $"http://localhost:5000/api/Gyakubiki/search"
        Dim dic = New Dictionary(Of String, String)()
        dic.Add("Title", TextBox1.Text)
        Dim context = New FormUrlEncodedContent(dic)
        Dim response = Await cl.PostAsync(Url, context)
        TextBox2.Text = Await response.Content.ReadAsStringAsync()
    End Sub
End Class
