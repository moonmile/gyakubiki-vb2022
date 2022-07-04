Class MainWindow
    Private Sub clickSearch(sender As Object, e As RoutedEventArgs)
        Dim context As New sampledbContext
        Me.dg.ItemsSource = context.Person.ToList()
    End Sub
End Class
