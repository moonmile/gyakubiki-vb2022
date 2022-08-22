Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    ''' <summary>
    ''' 検索を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        Dim q = From t In context.Person
                Select t
        dg.ItemsSource = q.ToList()
    End Sub
End Class


Public Class Person
    Public Property Id As Integer
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class

Public Class MyContext
    Inherits DbContext

    Public Property Person As DbSet(Of Person)

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
