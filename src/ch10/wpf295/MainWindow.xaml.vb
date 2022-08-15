Class MainWindow
    Private Sub clickAdd(sender As Object, e As RoutedEventArgs)
        Dim Text = tb.Text
        If Not String.IsNullOrEmpty(Text) Then
            lst.Items.Add(Text)
        End If
    End Sub
End Class
