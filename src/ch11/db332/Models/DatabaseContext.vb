Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore


' 「ツール」→「NuGet パッケージマネージャ」から「パッケージマネージャコンソール」を開く
' Add-Migration Initial
' Update-Database


Public Class DatabaseContext
    Inherits DbContext

    Public Sub New()

    End Sub

    Public Sub New(options As DbContextOptions(Of DatabaseContext))
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
