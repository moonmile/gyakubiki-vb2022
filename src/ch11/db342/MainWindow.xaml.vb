Imports System.ComponentModel.DataAnnotations
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded, Sub()
                                  _vm = New ViewModel
                                  DataContext = _vm
                              End Sub
    End Sub

    Private _vm As ViewModel

    ''' <summary>
    ''' データベースから検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context = New MyContext()
        Dim q = context.Book _
            .Join(context.Author,
                Function(book) book.AuthorId,
                Function(author) author.Id,
                Function(book, author) New With {book, author}) _
            .Join(context.Publisher,
                Function(t) t.book.PublisherId,
                Function(publisher) publisher.Id,
                Function(t, publisher) New With {t.book, t.author, publisher})

        ' 条件を追加する
        If _vm.Title <> "" Then
            q = q.Where(Function(t) t.book.Title.Contains(_vm.Title))
        End If
        If _vm.Price <> 0 Then
            q = q.Where(Function(t) t.book.Price < _vm.Price)
        End If

        ' 結果を取得する
        Dim items = q.OrderBy(Function(t) t.book.Id) _
            .Select(Function(t) New ResultItem() With
                {
                    .Id = t.book.Id,
                    .Title = t.book.Title,
                    .AuthorName = t.author.Name,
                    .PublisherName = t.publisher.Name,
                    .Price = t.book.Price
                }).ToList()
        _vm.Items = items
    End Sub
End Class

Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _title As String = ""
    Private _price As Integer = 0
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            SetProperty(_title, value, NameOf(Title))
        End Set
    End Property
    Public Property Price As Integer
        Get
            Return _price
        End Get
        Set(value As Integer)
            SetProperty(_price, value, NameOf(Price))
        End Set
    End Property

    Private _items As New List(Of ResultItem)
    Public Property Items As List(Of ResultItem)
        Get
            Return _items
        End Get
        Set(value As List(Of ResultItem))
            SetProperty(_items, value, NameOf(Items))
        End Set
    End Property
End Class

Public Class ResultItem
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorName As String
    Public Property PublisherName As String
    Public Property Price As Integer
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
