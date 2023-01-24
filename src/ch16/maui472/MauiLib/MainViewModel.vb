
Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _message As String
    Private _caldate As DateTime = DateTime.Today

    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            SetProperty(_message, value, NameOf(Message))
        End Set
    End Property
    Public Property CalDate As DateTime
        Get
            Return _caldate
        End Get
        Set(value As DateTime)
            SetProperty(_caldate, value, NameOf(CalDate))
            Message = CalDate.ToString("yyyy”NMMŒŽdd“ú")
        End Set
    End Property

End Class
