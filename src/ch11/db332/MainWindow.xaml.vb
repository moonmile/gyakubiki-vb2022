Class MainWindow
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New DatabaseContext
        Me.dg.ItemsSource = context.Book.ToList()
    End Sub
End Class
