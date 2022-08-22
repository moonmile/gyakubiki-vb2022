Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore
Imports Prism.Mvvm
Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports System.Net
Imports System.Security.Policy

Class MainWindow


    ''' <summary>
    ''' テストデータを作成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickInitialize(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        context.Initialize()
    End Sub


    ''' <summary>
    ''' データベースから検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        Dim q = From book In context.Book
                Join author In context.Author On book.AuthorId Equals author.Id
                Join publisher In context.Publisher On book.PublisherId Equals publisher.Id
                Order By book.Id
                Select New With {
                        .Id = book.Id,
                        .Title = book.Title,
                        .AuthorName = author.Name,
                        .PublisherName = publisher.Name,
                        .Price = book.Price
                    }
        Me.dg.ItemsSource = q.ToList()
    End Sub
End Class


''' <summary>
''' 在庫クラス
''' </summary>
Public Class Store
    <Key>
    Public Property Id As Integer
    Public Property BookId As Integer
    Public Property Stock As Integer
    Public Property CreatedAt As DateTime ' 扱い始めた日時
    Public Property UpdatedAt As DateTime ' 在庫を更新した日時
End Class
''' <summary>
''' 書籍クラス
''' </summary>
Public Class Book
    <Key>
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer
    Public Property PublisherId As Integer?       ' 自費出版のときは null
    Public Property Price As Integer
End Class
''' <summary>
''' 著者クラス
''' </summary>
Public Class Author
    <Key>
    Public Property Id As Integer
    Public Property Name As String
End Class
''' <summary>
''' 出版社クラス
''' </summary>
Public Class Publisher
    <Key>
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class


Public Class MyContext
    Inherits DbContext

    Public Property Store As DbSet(Of Store)
    Public Property Book As DbSet(Of Book)
    Public Property Author As DbSet(Of Author)
    Public Property Publisher As DbSet(Of Publisher)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = "(local)"
            builder.InitialCatalog = "sampledb"
            builder.IntegratedSecurity = True
            optionsBuilder.UseSqlServer(builder.ConnectionString)
        End If
    End Sub

    ''' <summary>
    '' データベースに初期値を入れる
    ''' </summary>
    Public Sub Initialize()
        ' 既存のデータを削除する
        Database.ExecuteSqlRaw("delete from Publisher")
        Database.ExecuteSqlRaw("delete from Author")
        Database.ExecuteSqlRaw("delete from Book")
        Database.ExecuteSqlRaw("delete from Store")

        Publisher.Add(New Publisher With {.Name = "秀和システム", .Telephone = "03-6264-XXXX", .Address = "東京都江東区"})
        Publisher.Add(New Publisher With {.Name = "日経BP", .Telephone = "", .Address = "東京都港区"})
        Publisher.Add(New Publisher With {.Name = "技術評論社", .Telephone = "03-3513-XXXX", .Address = "東京都新宿区"})
        Publisher.Add(New Publisher With {.Name = "共立出版", .Telephone = "03-3947-XXXX", .Address = "東京都文京区"})
        Publisher.Add(New Publisher With {.Name = "オーム社", .Telephone = "03-3233-XXXX", .Address = "東京都千代田区"})
        Publisher.Add(New Publisher With {.Name = "ピアソン・エデュケーション", .Telephone = "03-3233-XXXX", .Address = "東京都千代田区"})

        Author.Add(New Author With {.Name = "増田智明"})
        Author.Add(New Author With {.Name = "トム・デマルコ"})
        Author.Add(New Author With {.Name = "G.M.ワインバーグ"})
        Author.Add(New Author With {.Name = "ウンベルト・エーコ"})
        Author.Add(New Author With {.Name = "野中郁次郎"})
        Author.Add(New Author With {.Name = "ケント・ベック"})

        SaveChanges()

        Book.Add(New Book With
            {
                .Title = "逆引き大全C#2022版",
                .AuthorId = (From t In Author Where t.Name = "増田智明").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "秀和システム").First().Id,
                .Price = 2000})
        Book.Add(New Book With
            {
                .Title = "逆引き大VB#2022版",
                .AuthorId = (From t In Author Where t.Name = "増田智明").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "秀和システム").First().Id,
                .Price = 2000
            })
        Book.Add(New Book With
            {
                .Title = ".NET6プログラミング入門",
                .AuthorId = (From t In Author Where t.Name = "増田智明").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "日経BP").First().Id,
                .Price = 2000
            })
        Book.Add(New Book With
            {
                .Title = "ピープルウェア",
                .AuthorId = (From t In Author Where t.Name = "トム・デマルコ").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "日経BP").First().Id,
                .Price = 2000
            })
        Book.Add(New Book With
            {
                .Title = "コンサルタントの道具箱",
                .AuthorId = (From t In Author Where t.Name = "G.M.ワインバーグ").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "日経BP").First().Id,
                .Price = 2000
            })
        Book.Add(New Book With
            {
                .Title = "テスト駆動開発入門",
                .AuthorId = (From t In Author Where t.Name = "ケント・ベック").First().Name,
                .PublisherId = (From t In Publisher Where t.Name = "ピアソン・エデュケーション").First().Id,
                .Price = 2000
            })
        SaveChanges()

        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = "逆引き大全C#2022版").First.Id, .Stock = 100, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = "逆引き大VB#2022版").First.Id, .Stock = 0, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = ".NET6プログラミング入門").First.Id, .Stock = 50, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = "ピープルウェア").First.Id, .Stock = 200, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = "コンサルタントの道具箱").First.Id, .Stock = 200, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        Store.Add(New Store With {.BookId = (From t In Book Where t.Title = "テスト駆動開発入門").First.Id, .Stock = 0, .CreatedAt = DateTime.Now, .UpdatedAt = DateTime.Now})
        SaveChanges()
    End Sub
End Class
