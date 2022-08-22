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
        Dim Name = _vm.Name
        If Name = "" Then
            ' 空欄の場合はすべて検索
            _vm.Items = _context.Person.ToList()
            _vm.Count = _vm.Items.Count
        Else
            ' 入力した文字列を含む Person を検索する
            Dim q = From t In _context.Person
                    Where t.Name.Contains(Name)
                    Select t
            _vm.Items = q.ToList()
            _vm.Count = q.Count()
            ' 以下でもよい
            ' _vm.Count = _vm.Items.Count
        End If
    End Sub
End Class

Public Class ViewModel
    Inherits BindableBase
    Private _name As String
    Private _count As Integer
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            SetProperty(_name, value, NameOf(Name))
        End Set
    End Property
    Public Property Count As Integer
        Get
            Return _count
        End Get
        Set(value As Integer)
            SetProperty(_count, value, NameOf(Count))
        End Set
    End Property

    Private _items As List(Of Person)
    Public Property Items As List(Of Person)
        Get
            Return _items
        End Get
        Set(value As List(Of Person))
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
