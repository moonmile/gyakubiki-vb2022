Imports System.ComponentModel.DataAnnotations
Imports System.Linq.Expressions
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded, Sub()
                                  DataContext = _vm
                              End Sub
    End Sub
    Private _vm As New ViewModel

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
                Join store In context.Store On book.Id Equals store.BookId
                Order By store.Id
                Select New ResultItem() With
                    {
                        .Title = book.Title,
                        .AuthorName = author.Name,
                        .PublisherName = publisher.Name,
                        .Price = book.Price,
                        .Stock = store.Stock,
                        .UpdatedAt = store.UpdatedAt
                    }
        ' 件数を表示
        _vm.Count = q.Count()
        ' 取得したデータを表示
        _vm.Items = q.ToList()
    End Sub
End Class


Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase
    Private _count As Integer = 0
    Private _items As List(Of ResultItem)

    Public Property Count As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            SetProperty(_count, value, NameOf(Count))
        End Set
    End Property

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

    Public Property Title As String
    Public Property AuthorName As String
    Public Property PublisherName As String
    Public Property Price As Integer
    Public Property Stock As Integer
    Public Property UpdatedAt As DateTime
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
