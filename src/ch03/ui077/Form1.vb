Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0
        Task.Factory.StartNew(
            Async Function()
                While ProgressBar1.Value < ProgressBar1.Maximum
                    Invoke(
                    Sub()
                        ProgressBar1.Value += 1
                        Label1.Text = $"{ProgressBar1.Value} % 経過"
                    End Sub)
                    Await Task.Delay(100)
                End While
            End Function)
    End Sub
End Class
