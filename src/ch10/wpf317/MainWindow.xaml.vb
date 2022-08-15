Class MainWindow
    Private Sub clickStart(sender As Object, e As RoutedEventArgs)
        For i = 0 To 9
            Dim rc As New Rectangle With
                {
                    .Stroke = box1.Stroke,
                    .StrokeThickness = box1.StrokeThickness,
                    .Width = box1.Width,
                    .Height = box1.Height
                }
            Dim x = Random.Shared.Next(-50, 250)
            Dim y = Random.Shared.Next(-50, 250)
            ' 位置を設定する
            Canvas.SetLeft(rc, x)
            Canvas.SetTop(rc, y)
            ' キャンバスに追加する
            cv.Children.Add(rc)
        Next
    End Sub
End Class
