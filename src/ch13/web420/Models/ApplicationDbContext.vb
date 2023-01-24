Imports Microsoft.EntityFrameworkCore
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema

Public Class ApplicationDbContext
    Inherits DbContext
    Public Sub New(options As DbContextOptions(Of ApplicationDbContext))
        MyBase.New(options)
    End Sub
    Public Property Book As DbSet(Of Book)
    Public Property Author As DbSet(Of Author)
    Public Property Publisher As DbSet(Of Publisher)
    Public Property Store As DbSet(Of Store)
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


