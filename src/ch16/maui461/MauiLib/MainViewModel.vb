Imports System.Runtime.CompilerServices
Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _count As Integer = 0
    Private _time As String

    Public Property Count As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            SetProperty(_count, value, NameOf(Count))
        End Set
    End Property
    Public Property Time As String
        Get
            Return _time
        End Get
        Set(value As String)
            SetProperty(_time, value, NameOf(Time))
        End Set
    End Property

    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Sub()
                Count += 1
                Time = DateTime.Now.ToString("HH:mm:ss")
            End Sub)
    End Sub
End Class
