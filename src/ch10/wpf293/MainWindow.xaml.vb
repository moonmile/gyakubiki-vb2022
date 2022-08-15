Class MainWindow
    Private Sub Window_Loaded(sender As Object, e As RoutedEventArgs)
        ' メソッドを呼び出す
        AddHandler btnSend.Click, AddressOf BtnSend_Click
        ' ラムダ式でイベントを記述する
        AddHandler btnRecv.Click,
            Sub()
                message.Text = "受信ボタンを押しました"
            End Sub
    End Sub

    Private Sub clickOpen(sender As Object, e As RoutedEventArgs)
        message.Text = "開くボタンを押しました"
    End Sub

    Private Sub BtnSend_Click(sender As Object, e As RoutedEventArgs)
        message.Text = "送信ボタンを押しました"
    End Sub

End Class
