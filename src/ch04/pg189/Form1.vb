Public Class Form1

    Private Async Function OnWork(label As Label) As Task
        Dim text = ""
        For i = 1 To 10
            text += "☺"
            Me.Invoke(
                Sub()
                    label.Text = text
                End Sub)
            ' 500msecまでランダムに待つ
            Await Task.Delay(Random.Shared.Next(500))
        Next
    End Function


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Label11.Text = "開始 " + DateTime.Now.ToString()
        Await Task.Run(
            Sub()
                Dim lst = New List(Of Task)()
                ' 5つのタスクを同時実行する
                lst.Add(Task.Run(Async Function()
                                     Await OnWork(Label1)
                                 End Function))
                lst.Add(Task.Run(Async Function()
                                     Await OnWork(Label2)
                                 End Function))
                lst.Add(Task.Run(Async Function()
                                     Await OnWork(Label3)
                                 End Function))
                lst.Add(Task.Run(Async Function()
                                     Await OnWork(Label4)
                                 End Function))
                lst.Add(Task.Run(Async Function()
                                     Await OnWork(Label5)
                                 End Function))
                ' すべてのタスクが終わるまで待つ
                Task.WaitAll(lst.ToArray())
            End Sub)
        Label11.Text = "完了 " + DateTime.Now.ToString()
    End Sub
End Class
