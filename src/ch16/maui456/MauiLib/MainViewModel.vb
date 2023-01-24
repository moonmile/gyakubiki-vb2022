Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _count As Integer = 0
    Public Property Count As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            SetProperty(_count, value, NameOf(Count))
        End Set
    End Property

    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Sub()
                Count += 1
            End Sub)
    End Sub
End Class
