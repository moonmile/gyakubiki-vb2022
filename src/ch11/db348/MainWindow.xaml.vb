Imports System.ComponentModel.DataAnnotations
Imports System.Linq.Expressions
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    ''' <summary>
    ''' 検索を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearchByQuery(sender As Object, e As RoutedEventArgs)
        Dim context = New MyContext()
        Dim q = From book In context.Book
                    Join author In context.Author On book.AuthorId Equals author.Id
                    Join publisher In context.Publisher On book.PublisherId Equals publisher.Id
                    Order By book.Id
                    Select New With {
                                    .Title = book.Title,
                                    .AuthorName = author.Name,
                                    .PublisherName = publisher.Name,
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
        Dim context = New MyContext()
        Dim items = context.Book _
        .Join(context.Author,
                    Function(Book) Book.AuthorId,
                    Function(Author) Author.Id,
                    Function(Book, Author) New With {Book, Author}) _
        .Join(context.Publisher,
                    Function(t) t.Book.PublisherId,
                    Function(publisher) publisher.Id,
                    Function(t, publisher) New With {t.Book, t.Author, publisher}) _
        .OrderBy(Function(t) t.Book.Id) _
        .Select(Function(t) New With
                {
                    .Title = t.Book.Title,
                    .AuthorName = t.Author.Name,
                    .PublisherName = t.publisher.Name,
                    .Price = t.Book.Price
                }).ToList()
        dg.ItemsSource = items

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
End Class
