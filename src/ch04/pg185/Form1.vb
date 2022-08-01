Public Class Form1
    Private _task As Task

    ''' <summary>
    ''' ラムダ式で処理関数を記述する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _task = New Task(
            Async Sub()
                ' 10秒後に停止する
                Dim endtime = DateTime.Now.AddSeconds(10)
                While DateTime.Now < endtime
                    Me.Invoke(
                    Sub()
                        ' 現在時刻を表示
                        label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    ' 100msec待つ
                    Await Task.Delay(100)
                End While
            End Sub)
        _task.Start()
    End Sub

    ''' <summary>
    ''' メソッドで処理関数を記述する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        _task = New Task(AddressOf onWork)
        _task.Start()
    End Sub

    Private Async Sub onWork()
        ' 10秒後に停止する
        Dim endtime = DateTime.Now.AddSeconds(10)
        While DateTime.Now < endtime
            Me.Invoke(
                    Sub()
                        ' 現在時刻を表示
                        label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
            ' 100msec待つ
            Await Task.Delay(100)
        End While
    End Sub
End Class
