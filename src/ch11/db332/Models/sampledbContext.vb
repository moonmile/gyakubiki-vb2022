Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Public Class Book
    Public Property Id As Integer
    Public Title As String = ""
    Public Author As String = ""
    Public Price As Integer
End Class


' 「ツール」→「NuGet パッケージマネージャ」から「パッケージマネージャコンソール」を開く
' Add-Migration Initial
' Update-Database


Public Class sampledbContext
    Inherits DbContext

    Public Sub New()

    End Sub

    Public Sub New(options As DbContextOptions(Of sampledbContext))
        MyBase.New(options)
    End Sub

    Public Property Book As DbSet(Of Book)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = "(local)"
            builder.InitialCatalog = "sampledb"
            builder.IntegratedSecurity = True
            optionsBuilder.UseSqlServer(builder.ConnectionString)
        End If
    End Sub
End Class
