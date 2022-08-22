Imports Microsoft.EntityFrameworkCore
Imports System.ComponentModel.DataAnnotations

Public Class Book

    <Key>
    Public Property Id As Integer
    <MaxLength(32)>
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property Price As Integer
    Public Property PublisherId As Integer?
End Class

Public Class Publisher

    <Key>
    Public Property Id As Integer
    <MaxLength(32)>
    Public Property Name As String
    <MaxLength(32)>
    Public Address As String
End Class


Public Class sampledbContext
    Inherits DbContext

    Public Sub New()

    End Sub

    Public Sub New(options As DbContextOptions(Of sampledbContext))
        MyBase.New(options)
    End Sub

    Public Property Book As DbSet(Of Book)
    Public Property Publisher As DbSet(Of Publisher)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseSqlServer("Server=.;Database=sampledb;Trusted_connection=True")
        End If
    End Sub
End Class
