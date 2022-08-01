Imports System.Threading

Public Class Form1

    Private mre As System.Threading.ManualResetEvent

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Task.Run(
            Async Function()
                mre = New ManualResetEvent(False)
                ' 終了時刻
                Dim endtime = DateTime.Now.AddSeconds(20)
                ' 一時停止する時刻
                Dim stoptime = DateTime.Now.AddSeconds(10)
                While DateTime.Now < endtime
                    If DateTime.Now > stoptime Then
                        ' 10秒後にイベント待ちになる
                        Me.Invoke(
                        Sub()
                            Label1.Text = "解除イベント待ち"
                        End Sub)
                        mre.Reset()
                        ' イベント待ち
                        mre.WaitOne()
                        ' 一時停止をやめる
                        stoptime = endtime
                    End If
                    Me.Invoke(
                    Sub()
                        Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    Await Task.Delay(100)
                End While
                Label1.Text = "タスク終了 " + DateTime.Now.ToString("HH:MM:ss.fff")
            End Function)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not mre Is Nothing Then
            ' イベント待ちを解除
            mre.Set()
        End If
    End Sub
End Class
