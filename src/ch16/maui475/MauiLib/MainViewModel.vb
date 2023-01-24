Imports System.Net.Http
Imports Prism.Commands
Imports System.Text.Json
Imports System.Runtime.CompilerServices

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Public Property Id As Integer
    Public Property Price As Integer
    Private _result As String
    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            SetProperty(_result, value, NameOf(Result))
        End Set
    End Property


    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Async Sub()
                Dim url = $"https://moonmile-gyakubiki.azurewebsites.net/api/postbook"
                Dim book = New Book With {.Id = id, .Price = Price}
                Dim Json = $"{{ ""id"": {Id}, ""price"": {Price} }}"
                Dim context = New StringContent(Json)

                Dim cl = New HttpClient()
                Dim response = Await cl.PostAsync(url, context)
                Dim Text = Await response.Content.ReadAsStringAsync()
                Me.Result = Text
            End Sub)
    End Sub
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
