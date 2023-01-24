Imports System.Net.Http
Imports System.Security.Policy
Imports System.Text.Json
Imports System.Windows.Forms.Design.AxImporter

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim author = TextBox1.Text
        Dim publisher = TextBox2.Text
        Dim apikey = TextBox3.Text
        Dim item As New SearchItem With
        {
            .AuthorName = author,
            .PublisherName = publisher
        }
        Dim cl As New HttpClient()
        Dim url = $"http://localhost:5000/api/Gyakubiki/searchApiKey"
        Dim Json = JsonSerializer.Serialize(item)
        Dim context = New StringContent(Json)
        ' API-KEYを指定する
        context.Headers.Add("X-API-KEY", apikey)
        context.Headers.ContentType = New System.Net.Http.Headers.MediaTypeHeaderValue("application/json")
        Dim response = Await cl.PostAsync(url, context)
        If response.StatusCode <> System.Net.HttpStatusCode.OK Then
            MessageBox.Show($"Error: {response.ReasonPhrase}")
            Return
        End If
        Json = Await response.Content.ReadAsStringAsync()
        ' JSONの大文字小文字を区別せずにデシリアライズする
        Dim options = New JsonSerializerOptions With
        {
            .PropertyNameCaseInsensitive = True
        }
        Dim books = JsonSerializer.Deserialize(Of List(Of Book))(Json, options)
        ListBox1.Items.Clear()
        If Not books Is Nothing Then
            For Each it In books
                ListBox1.Items.Add($"{it.Title} {it.Price}円")
            Next
        End If
    End Sub
End Class

Public Class SearchItem
    Public Property AuthorName As String
    Public Property PublisherName As String
End Class



''' <summary>
''' 書籍クラス
'' </summary>
Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?
    Public Property Price As Integer

    Public Property Author As Author
    Public Property Publisher As Publisher
End Class

''' <summary>
''' 著者クラス
''' </summary>
Public Class Author
    Public Property Id As Integer
    Public Property Name As String
End Class

''' <summary>
''' 出版社クラス
''' </summary>
Public Class Publisher
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class
