Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Await Task.Run(
            Sub()
                For i = 1 To 100
                    Me.Invoke(
                    Sub()
                        Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    System.Threading.Thread.Sleep(100)
                Next
            End Sub)
        Label1.Text = "完了"
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Await Task.Run(
            Async Sub()
                For i = 1 To 100
                    Me.Invoke(
                    Sub()
                        Label1.Text = DateTime.Now.ToString("HH:MM:ss.fff")
                    End Sub)
                    Await Task.Delay(100)
                Next
            End Sub)
        Label1.Text = "完了"
    End Sub
End Class
