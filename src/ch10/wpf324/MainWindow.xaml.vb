Imports System.Collections.ObjectModel

Class MainWindow
    Private _vm As New ViewModel
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        _vm.Person.Id = 100
        Me.DataContext = _vm
    End Sub

    Private Sub clickSubmit(sender As Object, e As RoutedEventArgs)
        _vm.Message = $"{_vm.Person.Name} さん、登録完了"
        _vm.Items.Add(_vm.Person)
        _vm.Person = New Person() With {.Id = _vm.Person.Id + 1}
    End Sub
End Class


Public Class Person

    Public Property Id As Integer
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String

    Public Overrides Function ToString() As String
        Return $"{Id}: {Name}({Age}) in {Address}"
    End Function
End Class

Public Class ViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _person As New Person
    Public Property Person As Person
        Get
            Return _person
        End Get
        Set(value As Person)
            SetProperty(_person, value, NameOf(Person))
        End Set
    End Property
    Public Property Items As New ObservableCollection(Of Person)

    Private _message As String
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            SetProperty(_message, value, NameOf(Message))
        End Set
    End Property

End Class



