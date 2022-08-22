Imports System.ComponentModel.DataAnnotations
Imports System.Security.Policy
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    Private _vm As New ViewModel
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Loaded,
            Sub()
                _vm = New ViewModel()
                Me.DataContext = _vm
            End Sub
    End Sub
    ''' <summary>
    ''' 検索を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        search()
    End Sub
    Private Sub search()
        Dim context As New MyContext()
        Dim q = From book In context.Book.Include("Author").Include("Publisher")
                Order By book.Id
                Select New BookItem With
                    {
                        .Id = book.Id,
                        .Title = book.Title,
                        .AuthorName = If(book.Author Is Nothing, "", book.Author.Name),
                        .PublisherName = If(book.Publisher Is Nothing, "", book.Publisher.Name),
                        .Price = book.Price
                    }
        _vm.Item = Nothing
        _vm.Items = q.ToList()
    End Sub

    ''' <summary>
    ''' 新規作成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickNewItem(sender As Object, e As RoutedEventArgs)
        ' 項目を空欄にする
        _vm.Item = New BookItem()
    End Sub

    ''' <summary>
    ''' 項目を追加あるいは更新する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickUpdate(sender As Object, e As RoutedEventArgs)
        If _vm.Item Is Nothing Then Return

        Dim context As New MyContext()
        Dim author As Author = Nothing
        Dim publisher As Publisher = Nothing
        ' トランザクションを開始

        Dim tr = context.Database.BeginTransaction()

        ' 著者名を調べてなければ追加する
        If _vm.Item.AuthorName <> "" Then

            author = context.Author.FirstOrDefault(Function(t) t.Name = _vm.Item.AuthorName)
            If author Is Nothing Then
                author = New Author With
                    {
                        .Name = _vm.Item.AuthorName
                    }
                context.Author.Add(author)
                ' 新しい著者を登録してIDを取得する
                context.SaveChanges()
            End If
        End If
        ' 出版社名を調べてなければ追加する
        If _vm.Item.PublisherName <> "" Then

            publisher = context.Publisher.FirstOrDefault(Function(t) t.Name = _vm.Item.PublisherName)
            If publisher Is Nothing Then
                publisher = New Publisher With
                    {
                        .Name = _vm.Item.PublisherName
                    }
                context.Publisher.Add(publisher)
                ' 新しい出版社を登録してIDを取得する
                context.SaveChanges()
            End If
        End If
        If _vm.Item.Id = 0 Then
            ' 書籍を追加する
            context.Book.Add(New Book With
                {
                    .Title = _vm.Item.Title,
                    .Price = _vm.Item.Price,
                    .AuthorId = author?.Id,
                    .PublisherId = publisher?.Id
                })
        Else

            ' 書籍を更新する
            Dim it = context.Book.Find(_vm.Item.Id)
            it.Title = _vm.Item.Title
            it.Price = _vm.Item.Price
            it.AuthorId = author?.Id
            it.PublisherId = publisher?.Id
            context.Book.Update(it)
        End If

        context.SaveChanges()
        ' コミットする
        tr.Commit()
        ' 再検索する
        search()
    End Sub

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickDelete(sender As Object, e As RoutedEventArgs)
        If _vm.Item Is Nothing Then Return

        Dim context As New MyContext()
        ' トランザクションを開始
        Dim tr = context.Database.BeginTransaction()
        Dim it = context.Book.Find(_vm.Item.Id)
        context.Book.Remove(it)
        context.SaveChanges()
        ' コミットする
        tr.Commit()
        ' 再検索する
        search()
    End Sub
End Class



Public Class BookItem
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorName As String
    Public Property PublisherName As String
    Public Property Price As Integer
End Class

Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _items As New List(Of BookItem)
    Private _item As BookItem
    Public Property Items As List(Of BookItem)
        Get
            Return _items
        End Get
        Set(value As List(Of BookItem))
            SetProperty(_items, value, NameOf(Items))
        End Set
    End Property
    Public Property Item As BookItem
        Get
            Return _item
        End Get
        Set(value As BookItem)
            SetProperty(_item, value, NameOf(Item))
        End Set
    End Property
End Class


''' <summary>
''' 在庫クラス
''' </summary>
Public Class Store
    <Key>
    Public Property Id As Integer
    Public Property BookId As Integer
    Public Property Stock As Integer
    Public Property CreatedAt As DateTime     ' 扱い始めた日時
    Public Property UpdatedAt As DateTime     ' 在庫を更新した日時
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
    Public Property Price As Integer

    Public Property Author As Author
    Public Property Publisher As Publisher
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

