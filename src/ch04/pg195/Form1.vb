Public Class Form1
    Private cts As System.Threading.CancellationTokenSource

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cts = New System.Threading.CancellationTokenSource()
        Dim result = Await Task.Run(Of Boolean)(
            Async Function()
                Dim endtime = DateTime.Now.AddSeconds(10)
                While DateTime.Now < endtime
                    ' キャンセルされていれば、途中でループを終える
                    If cts.Token.IsCancellationRequested = True Then
                        Return False
                    End If
                    Me.Invoke(
                    Sub()
                        Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    Await Task.Delay(100)
                End While
                Return True
            End Function, cts.Token)
        Label1.Text = $"タスク結果: {result}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' タスクをキャンセルする
        If Not cts Is Nothing Then
            cts.Cancel()
        End If
    End Sub
End Class
