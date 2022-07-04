Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _id As Integer
    Private _name As String
    Private _age As Integer
    Private _address As String
    Private _result As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            SetProperty(_id, value, NameOf(Id))
        End Set
    End Property

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            SetProperty(_name, value, NameOf(Name))
        End Set
    End Property

    Public Property Age As Integer
        Get
            Return _age
        End Get
        Set(value As Integer)
            SetProperty(_age, value, NameOf(Age))
        End Set
    End Property
    Public Property Address As String
        Get
            Return _address
        End Get
        Set(value As String)
            SetProperty(_address, value, NameOf(Address))
        End Set
    End Property

    Public Property Result As String
        Get
            Return _result
        End Get
        Set(value As String)
            SetProperty(_result, value, NameOf(Result))
        End Set
    End Property
End Class
