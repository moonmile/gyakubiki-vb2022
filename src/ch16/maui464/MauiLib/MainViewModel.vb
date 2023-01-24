Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
    Private _result As String
    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            SetProperty(_result, value, NameOf(Result))
        End Set
    End Property

    Public Property OnInputCommand As DelegateCommand
    Public Sub New()
        OnInputCommand = New DelegateCommand(
            Sub()
                Result = $"{Name} ({Age}) in {Address}"
            End Sub)
    End Sub
End Class
