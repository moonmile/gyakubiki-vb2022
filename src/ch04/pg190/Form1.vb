Public Class Form1

    Private Async Function onWork() As Task(Of Integer)
        Dim sum = 0
        For i = 1 To 100
            sum += i
            Invoke(Sub()
                       Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                   End Sub)
            Await Task.Delay(100)
        Next
        Return sum
    End Function


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 非同期でタスクを実行
        ' UIスレッドを占有しない
        Dim sum = Await Task.Run(Of Integer)(AddressOf onWork)
        ' 結果を表示
        Label2.Text = $"合計値: {sum}"
    End Sub
End Class
