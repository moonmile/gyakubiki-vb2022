Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ' 完了フラグ
        Dim complete = False
        ' 進捗率
        Dim raito = 0

        ' プログレスバーを更新
        Dim tsk = New Task(
            Async Sub()
                While complete = False
                    Me.Invoke(
                    Sub()
                        label1.Text = $"進捗率：{raito} %"
                        ProgressBar1.Value = raito
                    End Sub)
                    ' 100msec 単位で画面を更新する
                    Await Task.Delay(100)
                End While
            End Sub)
        tsk.Start()

        ' 計算タスク
        Dim sum0 = Await Task.Run(Of Integer)(
            Async Function()
                Dim sum = 0
                For i = 1 To 100
                    raito = i
                    sum += i
                    Await Task.Delay(100)
                Next
                raito = 100
                complete = True
                Return sum
            End Function)
        label2.Text = $"合計値：{sum0}"
    End Sub
End Class
