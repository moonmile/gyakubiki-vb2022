Imports System.Security.Policy
Imports System.Web.Mvc
Imports Microsoft.Ajax.Utilities

Namespace Controllers
    Public Class BookController
        Inherits Controller

        ' テスト用のデータ
        Private books As New List(Of Book)
        Private authors As New List(Of Author)
        Private publishers As New List(Of Publisher)

        Public Sub New()
            ' 初期値をいれておく
            books = New List(Of Book)
            books.Add(New Book With
            {
                .Id = 1,
                .AuthorId = 1,
                .PublisherId = 1,
                .Title = "逆引き大全VB2022",
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
            authors = New List(Of Author)
            authors.Add(New Author With {.Id = 1, .Name = "増田智明"})
            authors.Add(New Author With {.Id = 2, .Name = "トム・デマルコ"})
            authors.Add(New Author With {.Id = 3, .Name = "G.M.ワインバーグ"})
            authors.Add(New Author With {.Id = 4, .Name = "ウンベルト・エーコ"})
            publishers = New List(Of Publisher)
            publishers.Add(New Publisher With {.Id = 1, .Name = "秀和システム", .Telephone = "03-XXXX-XXXX"})
            publishers.Add(New Publisher With {.Id = 2, .Name = "日経BP", .Telephone = "03-XXXX-XXXX"})
        End Sub

        ' GET: Book
        Function Index(Optional id As Integer = 0) As ActionResult
            For Each book In books
                book.Author = authors.FirstOrDefault(Function(t) t.Id = book.AuthorId)
                book.Publisher = publishers.FirstOrDefault(Function(t) t.Id = book.PublisherId)
            Next
            ' モデルをビューに渡す
            Return View(books)
        End Function
    End Class
End Namespace