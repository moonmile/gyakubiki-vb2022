Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Author")>
Partial Public Class Author
    Public Property Id As Integer

    <Required>
    Public Property Name As String
End Class
