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
                Dim url = $"https://moonmile-gyakubiki.azurewebsites.net/api/getbook?id={id}"
                Dim cl = New HttpClient()
                Dim response = Await cl.GetAsync(url)
                Dim Book = Await JsonSerializer.DeserializeAsync(Of Book)(response.Content.ReadAsStream(),
                    New JsonSerializerOptions() With {.PropertyNameCaseInsensitive = True})
                Me.Title = Book.Title
                Me.Author = Book.Author?.Name
                Me.Publisher = Book.Publisher?.Name
                Me.Price = $"{Book.Price} 円"

            End Sub)
    End Sub

    Private _title As String
    Private _author As String
    Private _publisher As String
    Private _price As String
    Public Property Title As String
        Get
            Return _title
        End Get
        Set(value As String)
            SetProperty(_title, value, NameOf(Title))
        End Set
    End Property
    Public Property Author As String
        Get
            Return _author
        End Get
        Set(value As String)
            SetProperty(_author, value, NameOf(Author))
        End Set
    End Property
    Public Property Publisher As String
        Get
            Return _publisher
        End Get
        Set(value As String)
            SetProperty(_publisher, value, NameOf(Publisher))
        End Set
    End Property
    Public Property Price As String
        Get
            Return _price
        End Get
        Set(value As String)
            SetProperty(_price, value, NameOf(Price))
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
