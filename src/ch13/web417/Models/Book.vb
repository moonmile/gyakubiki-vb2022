Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Book")>
Partial Public Class Book
    <Key>
    Public Property Id As Integer
    <DisplayName("書名")>
    <Required(ErrorMessage:="{0}は必須項目です")>
    Public Property Title As String

    Public Property AuthorId As Integer?

    Public Property PublisherId As Integer?
    <DisplayName("価格")>
    <Range(100, 9999, ErrorMessage:="{0}は{1}から{2}までの間で指定してください")>
    Public Property Price As Integer

    ' 関連テーブル
    Public Property Author As Author
    Public Property Publisher As Publisher

End Class
