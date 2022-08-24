Imports System.Net.Http
Imports System.Reflection.Metadata
Imports System.Security.Policy
Imports System.Text.Json
Imports System.Windows.Forms.Design.AxImporter
Public Class Form1
Private async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        dim id = integer.Parse(textBox1.Text)
        dim cl as new HttpClient()
        dim url = $"http://localhost:5000/api/Gyakubiki/{id}"
        dim response = await cl.GetStringAsync(url)
        ' JSONの大文字小文字を区別せずにデシリアライズする
        dim options = new JsonSerializerOptions With
        {
            .PropertyNameCaseInsensitive = true
        }
        dim book = JsonSerializer.Deserialize( Of Book)(response, options)
        If Not book Is Nothing Then
            TextBox2.Text =
$"書名：{book.Title} 
著者名：{book.Author?.Name} 
出版社名：{book.Publisher?.Name} 
価格：{book.Price} 
"
        End If

    End Sub
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
