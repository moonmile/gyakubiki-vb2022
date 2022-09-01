Imports System
Imports System.Data.Entity
Imports System.Linq

Partial Public Class Model1
    Inherits DbContext

    Public Sub New()
        MyBase.New("name=Model1")
    End Sub

    Public Overridable Property Author As DbSet(Of Author)
    Public Overridable Property Book As DbSet(Of Book)
    Public Overridable Property Publisher As DbSet(Of Publisher)
    Public Overridable Property Store As DbSet(Of Store)
    Public Overridable Property Person As DbSet(Of Person)

    Protected Overrides Sub OnModelCreating(ByVal modelBuilder As DbModelBuilder)
        modelBuilder.Entity(Of Person)() _
            .Property(Function(e) e.Name) _
            .IsUnicode(False)

        modelBuilder.Entity(Of Person)() _
            .Property(Function(e) e.Address) _
            .IsUnicode(False)
    End Sub
End Class
