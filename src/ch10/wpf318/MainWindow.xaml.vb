Imports System.Net

Class MainWindow
    Private _vm As ViewModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _vm = New ViewModel() With
            {
                .Id = 100,
                .Name = "山田太郎",
                .Age = 20,
                .Address = "北海道"
            }
        Me.DataContext = _vm
    End Sub
End Class

Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _id = 0
    Private _name = ""
    Private _age = 0
    Private _address = ""

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
End Class

