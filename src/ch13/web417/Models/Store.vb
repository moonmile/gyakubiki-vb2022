Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Store")>
Partial Public Class Store
    Public Property Id As Integer

    Public Property BookId As Integer

    Public Property Stock As Integer

    <Column(TypeName:="datetime2")>
    Public Property CreatedAt As Date

    <Column(TypeName:="datetime2")>
    Public Property UpdatedAt As Date
End Class
