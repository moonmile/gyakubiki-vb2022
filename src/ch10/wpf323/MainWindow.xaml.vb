Class MainWindow
    Private _vm As New ViewModel

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _vm.Id = 100
        Me.DataContext = _vm
    End Sub

    Private Sub clickSubmit(sender As Object, e As RoutedEventArgs)
        _vm.Message = $"{_vm.Name} さん、登録完了"

        ' ID をひとつ増やして、
        ' 他のテキストボックスを空欄にする
        _vm.Id += 1
        _vm.Name = ""
        _vm.Age = 0
        _vm.Address = ""
    End Sub
End Class

Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _id = 0
    Private _name = ""
    Private _age = 0
    Private _address = ""
    Private _message = ""

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
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            SetProperty(_message, value, NameOf(Message))
        End Set
    End Property
End Class



