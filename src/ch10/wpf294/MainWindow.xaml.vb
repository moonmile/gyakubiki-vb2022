Class MainWindow
    Private Sub clickLarge(sender As Object, e As RoutedEventArgs)
        message.FontSize = message.FontSize * 1.2
        fntsize.Text = "font size: " + message.FontSize.ToString("0.00")

    End Sub

    Private Sub clickSmall(sender As Object, e As RoutedEventArgs)
        message.FontSize = message.FontSize * 0.8
        fntsize.Text = "font size: " + message.FontSize.ToString("0.00")
    End Sub
End Class
