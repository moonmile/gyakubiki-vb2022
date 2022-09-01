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
    <DisplayName("����")>
    <Required(ErrorMessage:="{0}�͕K�{���ڂł�")>
    Public Property Title As String

    Public Property AuthorId As Integer?

    Public Property PublisherId As Integer?
    <DisplayName("���i")>
    <Range(100, 9999, ErrorMessage:="{0}��{1}����{2}�܂ł̊ԂŎw�肵�Ă�������")>
    Public Property Price As Integer

    ' �֘A�e�[�u��
    Public Property Author As Author
    Public Property Publisher As Publisher

End Class
