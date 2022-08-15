Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        lst2.Items.Add("こくご")
        lst2.Items.Add("さんすう")
        lst2.Items.Add("りか")
        lst2.Items.Add("しゃかい")
        lst2.Items.Add("プログラミング")
    End Sub

    Private Sub selectList1(sender As Object, e As SelectionChangedEventArgs)
        Dim item As ListBoxItem = lst1.SelectedItem
        message.Text = "選択科目：" + item?.Content.ToString()
    End Sub

    Private Sub selectList2(sender As Object, e As SelectionChangedEventArgs)
        message.Text = "選択科目：" + lst2.SelectedItem.ToString()
    End Sub
End Class
