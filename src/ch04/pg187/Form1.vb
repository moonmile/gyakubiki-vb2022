Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result = Await Task.Run(Of String)(
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
                Return DateTime.Now.ToString() + " に完了"
            End Function)
        Label2.Text = result
    End Sub
End Class
