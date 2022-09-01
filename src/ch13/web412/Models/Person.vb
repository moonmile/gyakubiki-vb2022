Imports System
Imports System.Collections.Generic
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Data.Entity.Spatial

<Table("Person")>
Partial Public Class Person
    <Key>
    <Column(Order:=0)>
    Public Property Id As Integer

    <Key>
    <Column(Order:=1)>
    <StringLength(50)>
    Public Property Name As String

    <Key>
    <Column(Order:=2)>
    <DatabaseGenerated(DatabaseGeneratedOption.None)>
    Public Property Age As Integer

    <Key>
    <Column(Order:=3)>
    <StringLength(50)>
    Public Property Address As String
End Class
