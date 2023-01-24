Imports System.ComponentModel.DataAnnotations
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim db = New MyContext()
        ' Excel から読み込み
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim r = 2
            While sh.Cell(r, 1).GetString() <> ""
                Dim id = sh.Cell(r, 1).GetValue(Of Integer)()
                Dim price = sh.Cell(r, 5).GetValue(Of Integer)()
                Dim item = db.Book.FirstOrDefault(Function(t) t.Id = id)
                If Not item Is Nothing Then
                    ' 価格を更新
                    item.Price = price
                End If
                r += 1
            End While
            db.SaveChanges()
        End Using
        MessageBox.Show("価格を更新しました")


    End Sub
End Class


''' <summary>
''' 在庫クラス
''' </summary>
Public Class Store
    <Key>
    Public Property Id As Integer
    Public Property BookId As Integer
    Public Property Stock As Integer
    Public Property CreatedAt As DateTime
    Public Property UpdatedAt As DateTime
End Class
''' <summary>
''' 書籍クラス
''' </summary>
Public Class Book
    <Key>
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer
    Public Property PublisherId As Integer?
    Public Property Price As Integer

    Public Property Author As Author
    Public Property Publisher As Publisher
End Class
''' <summary>
''' 著者クラス
''' </summary>
Public Class Author
    <Key>
    Public Property Id As Integer
    Public Property Name As String
End Class
''' <summary>
''' 出版社クラス
''' </summary>
Public Class Publisher
    <Key>
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class

Public Class MyContext
    Inherits DbContext
    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = "(local)"
        builder.InitialCatalog = "sampledb"
        builder.IntegratedSecurity = True
        optionsBuilder.UseSqlServer(builder.ConnectionString)
    End Sub
    Public Property Store As DbSet(Of Store)
    Public Property Book As DbSet(Of Book)
    Public Property Author As DbSet(Of Author)
    Public Property Publisher As DbSet(Of Publisher)
End Class


