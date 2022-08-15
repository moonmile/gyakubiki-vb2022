Imports System.Collections.ObjectModel
Imports Microsoft.EntityFrameworkCore

Class MainWindow
    Private _vm As New ViewModel
    Private _context As SQLiteContext

    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        If System.IO.File.Exists("sample.sqlite3") = False Then

            _context = New SQLiteContext()
            _context.Database.ExecuteSqlRaw("
CREATE TABLE Person (
    Id    INTEGER NOT NULL,
    Name  TEXT NOT NULL,
    Age    INTEGER NOT NULL,
    Address  TEXT NOT NULL,
    PRIMARY KEY(ID AUTOINCREMENT)
);")
        Else
            _context = New SQLiteContext()
        End If

        _context.Person.ToList().ForEach(
            Sub(t)
                _vm.Items.Add(t)
            End Sub)
        If _context.Person.Count() > 0 Then
            _vm.Person.Id = _context.Person.Max(
                Function(t)
                    Return t.Id
                End Function) + 1
        End If

        Me.DataContext = _vm
    End Sub

    Private Sub clickSubmit(sender As Object, e As RoutedEventArgs)
        _context.Person.Add(_vm.Person)
        _context.SaveChanges()

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
Public Class SQLiteContext
    Inherits DbContext

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        MyBase.OnConfiguring(optionsBuilder)
        Dim Path = "sample.sqlite3"
        optionsBuilder.UseSqlite($"Data Source={path}")
    End Sub

    Protected Overrides Sub OnModelCreating(modelBuilder As ModelBuilder)
        MyBase.OnModelCreating(modelBuilder)
        modelBuilder.Entity(Of Person)().HasKey("Id")
    End Sub




    Public Property Person As DbSet(Of Person)
End class



