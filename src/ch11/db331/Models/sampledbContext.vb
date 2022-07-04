Imports Microsoft.EntityFrameworkCore

Public Class sampledbContext
    Inherits DbContext

    Public Sub New()

    End Sub

    Public Sub New(options As DbContextOptions(Of sampledbContext))
        MyBase.New(options)
    End Sub

    Public Property Person As DbSet(Of Person)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            optionsBuilder.UseSqlServer("Server=.;Database=sampledb;Trusted_connection=True")
        End If
    End Sub
End Class
