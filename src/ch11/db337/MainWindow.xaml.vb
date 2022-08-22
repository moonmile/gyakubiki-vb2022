Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore
Imports Prism.Mvvm
Imports System.Collections.ObjectModel
Imports System.ComponentModel.DataAnnotations
Imports System.Net
Imports System.Security.Policy

Class MainWindow
    Public Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。

        AddHandler Me.Loaded,
            Sub()
                _vm = New ViewModel()
                Me.DataContext = _vm
            End Sub
    End Sub
    Private _vm As ViewModel
    Private _context As New MyContext

    ''' <summary>
    ''' データベースから検索
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        _vm.Items = New ObservableCollection(Of Person)(
                _context.Person.ToList())
    End Sub

    ''' <summary>
    ''' 新規にクリアする
    ''' カーソルを外して、テキストボックスを空欄にする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickNew(sender As Object, e As RoutedEventArgs)
        _vm.SelectedItem = Nothing
        _vm.Name = ""
        _vm.Age = 0
        _vm.Address = ""
    End Sub

    ''' <summary>
    ''' データベースに追加
    ''' （あらかじめて「新規」ボタンでクリアしておく
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickAdd(sender As Object, e As RoutedEventArgs)
        Dim item As New Person() With
            {
                .Name = _vm.Name,
                .Age = _vm.Age,
                .Address = _vm.Address
            }
        _context.Person.Add(item)
        _context.SaveChanges()
        ' DataGridにも追加する
        _vm.Items.Add(item)
    End Sub

    ''' <summary>
    ''' データベースを更新
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickUpdate(sender As Object, e As RoutedEventArgs)
        ' 選択位置の項目を更新する
        If _vm.SelectedItem Is Nothing Then Return
        Dim item = _vm.SelectedItem
        item.Name = _vm.Name
        item.Age = _vm.Age
        item.Address = _vm.Address
        _context.Person.Update(item)
        _context.SaveChanges()
    End Sub

    ''' <summary>
    ''' データベースから削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickDelete(sender As Object, e As RoutedEventArgs)
        ' 選択位置の項目を削除する
        If _vm.SelectedItem Is Nothing Then Return
        Dim item = _vm.SelectedItem
        _context.Person.Remove(item)
        _context.SaveChanges()
        ' カーソルを外す
        _vm.SelectedItem = Nothing
        _vm.Items.Remove(item)
    End Sub
End Class

Public Class ViewModel
    Inherits BindableBase
    Private _name As String
    Private _age As Integer
    Private _address As String
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

    Private _selectedItem As Person
    Private _items As ObservableCollection(Of Person)
    Public Property SelectedItem As Person
        Get
            Return _selectedItem
        End Get
        Set(value As Person)
            SetProperty(_selectedItem, value, NameOf(SelectedItem))
            If Not value Is Nothing Then
                Me.Name = value.Name
                Me.Age = value.Age
                Me.Address = value.Address
            End If
        End Set
    End Property
    Public Property Items As ObservableCollection(Of Person)
        Get
            Return _items
        End Get
        Set(value As ObservableCollection(Of Person))
            SetProperty(_items, value, NameOf(Items))
        End Set
    End Property
End Class


Public Class Person
    <Key>
    Public Property Id As Integer
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class



Public Class MyContext
    Inherits DbContext

    Public Property Person As DbSet(Of Person)

    Protected Overrides Sub OnConfiguring(optionsBuilder As DbContextOptionsBuilder)
        If Not optionsBuilder.IsConfigured Then
            Dim builder As New SqlConnectionStringBuilder()
            builder.DataSource = "(local)"
            builder.InitialCatalog = "sampledb"
            builder.IntegratedSecurity = True
            optionsBuilder.UseSqlServer(builder.ConnectionString)
        End If
    End Sub
End Class
