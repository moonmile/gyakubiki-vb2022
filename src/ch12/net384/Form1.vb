Imports System.Net.Http
Imports System.Security.Policy
Imports System.Text.Json

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim author = TextBox1.Text
        Dim Publisher = TextBox2.Text
        Dim item = New SearchItem With
        {
            .AuthorName = author,
            .PublisherName = Publisher,
        }

        Dim cl As New HttpClient()
        Dim Url = $"http://localhost:5000/api/Gyakubiki/searchJson"
        Dim Json = JsonSerializer.Serialize(item)
        Dim context = New StringContent(Json)
        context.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("application/json")
        Dim response = Await cl.PostAsync(Url, context)
        TextBox3.Text = Await response.Content.ReadAsStringAsync()

    End Sub
End Class

Public Class SearchItem
    Public Property AuthorName As String
    Public Property PublisherName As String
End Class
