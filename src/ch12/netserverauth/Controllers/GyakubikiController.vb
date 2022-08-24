Imports System.IO
Imports System.IO.Pipelines
Imports System.Net.Mime
Imports System.Text.Json
Imports System.Xml.Serialization
Imports Microsoft.AspNetCore.Http
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.Extensions.Logging

Namespace Controllers
    <ApiController>
    <Route("api/[controller]")>
    Public Class GyakubikiController
        Inherits ControllerBase

        Private ReadOnly _logger As ILogger(Of GyakubikiController)

        Private books As New List(Of Book)()
        Private authors As New List(Of Author)()
        Private publishers As New List(Of Publisher)()

        Public Sub New(logger As ILogger(Of GyakubikiController))
            _logger = logger

            ''' 初期値を入れておく
            Me.books = New List(Of Book)()
            books.Add(New Book With
            {
                .Id = 1,
                .AuthorId = 1,
                .PublisherId = 1,
                .Title = "逆引き大全C#2022",
                .Price = 1000
            })
            books.Add(New Book With
            {
                .Id = 2,
                .AuthorId = 1,
                .PublisherId = 1,
                .Title = "逆引き大全C#2022",
                .Price = 1000
            })
            books.Add(New Book With
            {
                .Id = 3,
                .AuthorId = 1,
                .PublisherId = 2,
                .Title = ".NET6プログラミング入門",
                .Price = 1000
            })
            authors = New List(Of Author)()
            authors.Add(New Author With {.Id = 1, .Name = "増田智明"})
            authors.Add(New Author With {.Id = 2, .Name = "トム・デマルコ"})
            authors.Add(New Author With {.Id = 3, .Name = "G.M.ワインバーグ"})
            authors.Add(New Author With {.Id = 4, .Name = "ウンベルト・エーコ"})
            publishers = New List(Of Publisher)()
            publishers.Add(New Publisher With {.Id = 1, .Name = "秀和システム", .Telephone = "03-XXXX-XXXX"})
            publishers.Add(New Publisher With {.Id = 2, .Name = "日経BP", .Telephone = "03-XXXX-XXXX"})

        End Sub

        <HttpPost>
        Public Sub Post()

        End Sub

        <HttpGet("{id}")>
        Public Function GetData(id As Integer) As Book

            Dim book = books.FirstOrDefault(Function(x) x.Id = id)
            If book Is Nothing Then
                Return Nothing
            Else
                book.Author = authors.FirstOrDefault(Function(x) x.Id = book.AuthorId)
                book.Publisher = publishers.FirstOrDefault(Function(x) x.Id = book.PublisherId)

                'Dim options = New JsonSerializerOptions With
                '{
                '    .Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
                '    .WriteIndented = True
                '}
                'Dim json = JsonSerializer.Serialize(book, options)
                'Return json
                Return book
            End If
        End Function

        ''' <summary>
        ''' XML形式で返す
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        <HttpGet("{id}/xml")>
        Public Function GetXml(id As Integer) As String
            Dim Book = books.FirstOrDefault(Function(x) x.Id = id)
            If Book Is Nothing Then
                Return "{}"
            Else
                Book.Author = authors.FirstOrDefault(Function(x) x.Id = Book.AuthorId)
                Book.Publisher = publishers.FirstOrDefault(Function(x) x.Id = Book.PublisherId)
                Dim serializer = New XmlSerializer(Book.GetType())
                Using sw = New StringWriter()
                    serializer.Serialize(sw, Book)
                    Return sw.ToString()
                End Using
            End If
        End Function

        <HttpPost("search")>
        Public Function Search(<FromForm> title As String) As List(Of Book)
            Dim items = books.Where(Function(x) x.Title.Contains(title)).ToList()
            For Each it In items
                it.Author = authors.FirstOrDefault(Function(x) x.Id = it.AuthorId)
                it.Publisher = publishers.FirstOrDefault(Function(x) x.Id = it.PublisherId)
            Next
            Return books
        End Function

        <HttpPost("searchJson")>
        Public Function SearchJson(<FromBody> item As SearchItem) As List(Of Book)
            If item Is Nothing Then
                Return New List(Of Book)()
            End If

            Dim items As New List(Of Book)()

            ' 著者名が指定された場合
            If item.AuthorName <> "" Then
                Dim Author = authors.FirstOrDefault(Function(t) t.Name = item.AuthorName)
                If Not Author Is Nothing Then
                    items = books.Where(Function(t) t.AuthorId = Author.Id).ToList()
                End If
                ' 出版社名が指定された場合
            ElseIf item.PublisherName <> "" Then
                Dim Publisher = publishers.FirstOrDefault(Function(t) t.Name = item.PublisherName)
                If Not Publisher Is Nothing Then
                    items = books.Where(Function(t) t.PublisherId = Publisher.Id).ToList()
                End If
            End If
            For Each it In items

                it.Author = authors.FirstOrDefault(Function(x) x.Id = it.AuthorId)
                it.Publisher = publishers.FirstOrDefault(Function(x) x.Id = it.PublisherId)
            Next
            Return items
        End Function

        Public Class SearchItem
            Public Property AuthorName As String
            Public Property PublisherName As String
        End Class


        <HttpPost("searchApiKey")>
        Public Function SearchApiKey(<FromBody> item As SearchItem) As List(Of Book)
            If item Is Nothing Then
                Return New List(Of Book)()
            End If
            Dim items As New List(Of Book)()

            ' 著者名が指定された場合
            If item.AuthorName <> "" Then
                Dim Author = authors.FirstOrDefault(Function(t) t.Name = item.AuthorName)
                If Not Author Is Nothing Then
                    items = books.Where(Function(t) t.AuthorId = Author.Id).ToList()
                End If
                ' 出版社名が指定された場合
            ElseIf item.PublisherName <> "" Then
                Dim Publisher = publishers.FirstOrDefault(Function(t) t.Name = item.PublisherName)
                If Not Publisher Is Nothing Then
                    items = books.Where(Function(t) t.PublisherId = Publisher.Id).ToList()
                End If
            End If
            For Each it In items
                it.Author = authors.FirstOrDefault(Function(x) x.Id = it.AuthorId)
                it.Publisher = publishers.FirstOrDefault(Function(x) x.Id = it.PublisherId)
            Next
            Return items
        End Function


        <HttpGet("checkUserAgent")>
        Public Function CheckUserAgent() As String
            ' ヘッダ部の User-Agent をそのまま返す
            Dim userAgent = Me.HttpContext.Request.Headers("User-Agent").ToString()
            Return userAgent
        End Function

        <HttpGet("checkCookie")>
        Public Function checkCookie() As String
            ' Cookie に User-Key を入れる
            If Me.HttpContext.Request.Cookies.ContainsKey("User-Key") = False Then
                Me.HttpContext.Response.Cookies.Append("User-Key", "XXXX-XXXX")
            End If
            Return "ユーザーキー設定"
        End Function

        ''' <summary>
        ''' Tips380 Webサーバーからファイルをダウンロードする
        ''' </summary>
        ''' <param name="id"></param>
        ''' <returns></returns>
        <HttpGet("donwload/{id}")>
        Public Function FileDownload(Optional id As Integer = 0) As IActionResult
            ' 実際はidにより、ダウンロードするファイルを切り替える
            Dim Path = "sample.zip"
            Dim Content = System.IO.File.OpenRead(Path)
            Dim ContentType = "APPLICATION/octet-stream"
            Dim fileName = "sample.zip"
            Return File(Content, ContentType, fileName)
        End Function


        <HttpGet("upload")>
        Public Async Function FileUpload(zipfile As IFormFile) As Task(Of IActionResult)
            Dim Path = "sample.zip"
            Using stream = System.IO.File.Create(Path)
                Await zipfile.CopyToAsync(stream)
            End Using
            Return Ok()
        End Function

    End Class


End Namespace


''' <summary>
''' 書籍クラス
''' </summary>
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


