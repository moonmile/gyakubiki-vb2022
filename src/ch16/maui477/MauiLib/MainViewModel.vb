Imports System.Runtime.CompilerServices
Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _urlSource As String
    Public Property UrlSource As String
        Get
            Return _urlSource
        End Get
        Set(value As String)
            SetProperty(_urlSource, value, NameOf(UrlSource))
        End Set
    End Property
    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Sub()
                UrlSource = "https://www.shuwasystem.co.jp/"
            End Sub)
    End Sub
End Class
