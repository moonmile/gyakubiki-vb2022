Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Book")>
Partial Public Class Book
    Public Property Id As Integer

    <Required>
    Public Property Title As String

    Public Property AuthorId As Integer?

    Public Property PublisherId As Integer?

    Public Property Price As Integer
End Class
