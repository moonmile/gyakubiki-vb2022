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


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Task.Run(Of Integer)(AddressOf onWork).ContinueWith(
            Sub(t)
                ' 結果を表示
                Dim sum = t.Result
                Me.Invoke(
                Sub()
                    Label2.Text = $"合計値：{sum}"
                End Sub)
            End Sub)
    End Sub
End Class
