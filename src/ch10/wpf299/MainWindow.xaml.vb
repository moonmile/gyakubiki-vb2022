Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        cb2.Items.Add("こくご")
        cb2.Items.Add("さんすう")
        cb2.Items.Add("りか")
        cb2.Items.Add("しゃかい")
        cb2.Items.Add("ぷろぐらみんぐ")
    End Sub

    Private Sub selectComboBox1(sender As Object, e As SelectionChangedEventArgs)
        Dim item As ComboBoxItem = cb1.SelectedItem
        message.Text = "選択科目：" + item?.Content.ToString()
    End Sub

    Private Sub selectComboBox2(sender As Object, e As SelectionChangedEventArgs)
        message.Text = "選択科目：" + cb2.SelectedItem.ToString()
    End Sub
End Class
