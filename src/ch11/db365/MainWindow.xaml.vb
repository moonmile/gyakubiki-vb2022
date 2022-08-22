Imports System.Collections.ObjectModel
Imports System.Collections.Specialized
Imports Microsoft.Data.SqlClient
Imports Microsoft.EntityFrameworkCore

Class MainWindow

    Private _context As New MyContext()
    ''' <summary>
    ''' 検索を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New MyContext()
        Dim q = From t In context.Person
                Select t
        Dim items As New ObservableCollection(Of Person)(q.ToList())
        dg.ItemsSource = items

        ' 新規追加と更新を判別する
        Dim insertOrUpdate = False
        AddHandler dg.AddingNewItem,
            Sub()
                insertOrUpdate = True
            End Sub
        ' 行の更新が終わったとき
        AddHandler dg.RowEditEnding,
            Sub(_s, ee)
                If ee.EditAction = DataGridEditAction.Commit Then
                    If insertOrUpdate Then

                        ee.Row.Dispatcher.BeginInvoke(
                        Async Sub()

                            ' DataContext の中身を更新するまで少し待つ
                            Await Task.Delay(10)
                            _context.Person.Add(ee.Row.DataContext)
                            _context.SaveChanges()
                        End Sub)
                    Else
                        ee.Row.Dispatcher.BeginInvoke(
                        Async Sub()
                            ' DataContext の中身を更新するまで少し待つ
                            Await Task.Delay(10)
                            _context.Person.Update(ee.Row.DataContext)
                            _context.SaveChanges()
                        End Sub
                        )
                    End If
                End If
                insertOrUpdate = False
            End Sub
        ' 行が削除されたとき
        AddHandler items.CollectionChanged,
            Sub(_s, ee)
                If ee.Action = NotifyCollectionChangedAction.Remove Then
                    For Each item As Person In ee.OldItems
                        _context.Person.Remove(item)
                    Next
                    _context.SaveChanges()
                End If
            End Sub

    End Sub
End Class


Public Class Person
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
