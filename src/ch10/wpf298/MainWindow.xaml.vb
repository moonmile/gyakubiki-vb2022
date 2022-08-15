Class MainWindow
    Private Sub clickCheck(sender As Object, e As RoutedEventArgs)
        Dim s = ""
        If chk1.IsChecked = True Then s += "国語, "
        If chk2.IsChecked = True Then s += "算数, "
        If chk3.IsChecked = True Then s += "理科, "
        If chk4.IsChecked = True Then s += "社会, "
        If chk5.IsChecked = True Then s += "プログラミング, "
        message.Text = s
    End Sub
End Class
