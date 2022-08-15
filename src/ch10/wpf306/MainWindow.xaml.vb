Class MainWindow
    Private Sub changeDatePicker(sender As Object, e As SelectionChangedEventArgs)
        Dim dt = dp.SelectedDate
        message.Text = dt.ToString()
    End Sub

    Private Sub changeCalendar(sender As Object, e As SelectionChangedEventArgs)
        Dim dt = cal.SelectedDate
        message.Text = dt.ToString()
    End Sub
End Class
