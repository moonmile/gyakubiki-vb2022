Imports System.Security.Policy

Class MainWindow
    Private Sub clickOpen(sender As Object, e As RoutedEventArgs)
        Dim url = tb.Text
        Web.Source = New Uri(url)
    End Sub
End Class
