Imports System.Windows.Media.Animation

Class MainWindow
    Private Sub clickStart(sender As Object, e As RoutedEventArgs)
        Dim sb As Storyboard = Me.Resources("Storyboard1")
        sb.Begin()
    End Sub
End Class
