Public Class Form1
    Private Async Function onWork(label As Label) As Task
        Dim endtime = DateTime.Now.AddSeconds(10)
        While DateTime.Now < endtime
            Me.Invoke(
                Sub()
                    ' 現在時刻を表示
                    label.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                End Sub)
            ' 100msec待つ
            Await Task.Delay(100)
        End While

    End Function

    ''' <summary>
    ''' タスクを順次実行する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Await Task.Run(
            Async Function()
                Await onWork(Label1)
            End Function)
        Await Task.Run(
            Async Function()
                Await onWork(Label2)
            End Function)
    End Sub

    ''' <summary>
    ''' タスクを同時に実行する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Task.Run(
            Async Function()
                Await onWork(Label1)
            End Function)
        Task.Run(
            Async Function()
                Await onWork(Label2)
            End Function)
    End Sub
End Class
