Imports System.Net.Http
Imports Prism.Commands
Imports System.Text.Json
Imports System.Reflection.Metadata.Ecma335

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Async Sub()
                Dim id = 1
                Dim url = $"https://moonmile-gyakubiki.azurewebsites.net/api/books"
                Dim cl = New HttpClient()
                Dim response = Await cl.GetAsync(url)
                Dim books = Await JsonSerializer.DeserializeAsync(Of List(Of Book))(response.Content.ReadAsStream(),
                    New JsonSerializerOptions() With {.PropertyNameCaseInsensitive = True})
                Me.Items = books

                ' 返信されたJSON形式をそのまま表示
                'Dim json = Await cl.GetStringAsync(url)
                'System.Diagnostics.Debug.WriteLine(json)

            End Sub)
    End Sub

    Private _items As List(Of Book)
    Public Property Items As List(Of Book)
        Get
            Return _items
        End Get
        Set(value As List(Of Book))
            SetProperty(_items, value, NameOf(Items))
        End Set
    End Property
End Class

Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?
    Public Property Price As Integer
    ' 関連するテーブル
    Public Property Author As Author
    Public Property Publisher As Publisher
End Class

Public Class Author
    Public Property Id As Integer
    Public Property Name As String
End Class

Public Class Publisher
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class
