Public Class Form1
    ''' <summary>
    ''' 指定したタスクを即実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Task.Run(
            Async Function()
                ' 10秒後に停止する
                Dim endtime = DateTime.Now.AddSeconds(10)
                While DateTime.Now < endtime
                    Me.Invoke(
                    Sub()
                        ' 現在時刻を表示
                        Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    ' 100msec待つ
                    Await Task.Delay(100)
                End While
            End Function)
    End Sub

    ''' <summary>
    ''' 作成後5秒間待ってから実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim tsk = New Task(
            Async Sub()
                ' 10秒後に停止する
                Dim endtime = DateTime.Now.AddSeconds(10)
                While DateTime.Now < endtime
                    Me.Invoke(
            Sub()
                ' 現在時刻を表示
                Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
            End Sub)
                    ' 100msec待つ
                    Await Task.Delay(100)
                End While
            End Sub)
        Await Task.Delay(5000)
        tsk.Start()
    End Sub
End Class
