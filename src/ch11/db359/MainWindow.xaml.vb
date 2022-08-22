Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Linq.Expressions
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    ''' <summary>
    ''' データベースから検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        Dim items = context.Store _
            .Include("Book") _
            .Include("Book.Author") _
            .Include("Book.Publisher") _
            .OrderByDescending(Function(t) t.Stock) _
            .Select(Function(t) t) _
            .ToList()
        dg.ItemsSource = items
    End Sub
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
<Table("Store")>
Public Class StoreItem
    <Key>
    Public Property Id As Integer
    Public Property BookId As Integer
    Public Property Stock As Integer
    Public Property CreatedAt As DateTime ' 扱い始めた日時
    Public Property UpdatedAt As DateTime ' 在庫を更新した日時
    ' 関連テーブル
    Public Property Book As BookItem

End Class
''' <summary>
''' 書籍クラス
''' </summary>
<Table("Book")>
Public Class BookItem
    <Key>
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?       ' 自費出版のときは null
    Public Property Price As Integer?
    ' 関連テーブル
    Public Property Author As AuthorItem
    Public Property Publisher As PublisherItem

End Class
''' <summary>
''' 著者クラス
''' </summary>
<Table("Author")>
Public Class AuthorItem
    <Key>
    Public Property Id As Integer
    Public Property Name As String
End Class
''' <summary>
''' 出版社クラス
''' </summary>
<Table("Publisher")>
Public Class PublisherItem
    <Key>
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class

Public Class MyContext
    Inherits DbContext

    Public Property Store As DbSet(Of StoreItem)
    Public Property Book As DbSet(Of BookItem)
    Public Property Author As DbSet(Of AuthorItem)
    Public Property Publisher As DbSet(Of PublisherItem)
    ' 検索結果を取得する
    Public Property Result As DbSet(Of ResultItem)

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
