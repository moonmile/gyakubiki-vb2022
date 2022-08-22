Imports System.ComponentModel.DataAnnotations
Imports System.Linq
Imports System.Reflection.Metadata.BlobBuilder
Imports System.Security.Policy
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    ''' <summary>
    ''' 検索を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearchByQuery(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        Dim q = From book In context.Book
                Group Join author In context.Author
                    On book.AuthorId Equals author.Id
                    Into temp = Group
                From authorj In temp.DefaultIfEmpty()
                Group Join publisher In context.Publisher
                    On book.PublisherId Equals publisher.Id
                    Into temp2 = Group
                From publisherj In temp2.DefaultIfEmpty()
                Order By book.Id
                Select New With
                            {
                                .Title = book.Title,
                                .AuthorName = authorj.Name,
                                .PublisherName = publisherj.Name,
                                .Price = book.Price
                            }
        dg.ItemsSource = q.ToList()
    End Sub
    ''' <summary>
    ''' メソッド呼び出しで実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearchByMethod(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
#If False Then
        Dim items = context.Book _
        .GroupJoin(context.Author,
                    Function(Book) Book.AuthorId,
                    Function(Author) Author.Id,
                    Function(book, author) New With {book, .Author = author.FirstOrDefault()}) _
        .GroupJoin(context.Publisher,
                    Function(t) t.book.PublisherId,
                    Function(publisher) publisher.Id,
                    Function(t, publisher) New With {t.book, t.Author, .Publisher = publisher.FirstOrDefault()}) _
        .OrderBy(Function(t) t.book.Id) _
        .Select(Function(t) New With
                {
                    .Title = t.book.Title,
                    .AuthorName = t.Author.Name,
                    .PublisherName = t.Publisher.Name,
                    .Price = t.book.Price
                }).ToList()

#Else
        ' 参考
        ' SQL Server の場合、GroupJoin が正しく動かない。
        ' メモリ上の List(of T) だと、同じ GroupJoin を書いても動作する

        Dim books = context.Book.ToList()
        Dim authors = context.Author.ToList()
        Dim publishers = context.Publisher.ToList()

        Dim items = books _
        .GroupJoin(authors,
                    Function(Book) Book.AuthorId,
                    Function(Author) Author.Id,
                    Function(book, author) New With {book, .Author = author.FirstOrDefault()}) _
        .GroupJoin(publishers,
                    Function(t) t.book.PublisherId,
                    Function(publisher) publisher.Id,
                    Function(t, publisher) New With {t.book, t.Author, .Publisher = publisher.FirstOrDefault()}) _
        .OrderBy(Function(t) t.book.Id) _
        .Select(Function(t) New With
                {
                    .Title = t.book.Title,
                    .AuthorName = t.Author?.Name,
                    .PublisherName = t.Publisher?.Name,
                    .Price = t.book.Price
                }).ToList()
        dg.ItemsSource = items
#End If
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
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?       ' 自費出版のときは null
    Public Property Price As Integer?
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
End Class
