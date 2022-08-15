Class MainWindow
    Private Sub clickLogin(sender As Object, e As RoutedEventArgs)
        MessageBox.Show($"ユーザー名：{username.Text}\nパスワード：{password.Password}")
    End Sub
End Class
