Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Publisher")>
Partial Public Class Publisher
    <Key>
    Public Property Id As Integer

    <DisplayName("o”ÅŽÐ")>
    <Required>
    Public Property Name As String

    <Required>
    Public Property Telephone As String

    <Required>
    Public Property Address As String
End Class
