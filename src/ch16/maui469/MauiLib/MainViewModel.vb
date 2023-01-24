
Imports System.Runtime.CompilerServices

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _isToggled As Boolean = True
    Private _isVisible As Boolean = True
    Public Property IsToggled As Boolean
        Get
            Return _isToggled
        End Get
        Set(value As Boolean)
            SetProperty(_isToggled, value, NameOf(IsToggled))
            Me.IsVisible = value
        End Set
    End Property
    Public Property IsVisible As Boolean
        Get
            Return _isVisible
        End Get
        Set(value As Boolean)
            SetProperty(_isVisible, value, NameOf(IsVisible))
        End Set
    End Property
End Class
