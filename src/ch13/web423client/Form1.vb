Imports System.ComponentModel.DataAnnotations
Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url = TextBox1.Text
        Dim cl As New HttpClient()
        Dim json = Await cl.GetStringAsync(url)
        Dim book = System.Text.Json.JsonSerializer.Deserialize(Of Book)(
                json, New System.Text.Json.JsonSerializerOptions With
                {
                    .PropertyNameCaseInsensitive = True
                })

        If book Is Nothing Then
            textBox2.Text = "書籍が見つかりませんでした"
        Else
            textBox2.Text = $"
ID: {book.Id}
書名: {book.Title}
著者名: {book.Author.Name}
出版社名: {book.Publisher.Name}
価格: {book.Price} 円
"
        End If
    End Sub
End Class

Partial Public Class Book
    <Key>
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?
    Public Property Price As Integer
    ' 関連テーブル
    Public Property Author As Author
    Public Property Publisher As Publisher
End Class

Partial Public Class Author
    <Key>
    Public Property Id As Integer
    Public Property Name As String
End Class

Partial Public Class Publisher
    <Key>
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class
