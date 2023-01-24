Public Class Form1

    Private lst As New List(Of String)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' 項目を末尾に追加する
        lst.Add(DateTime.Now.ToString())
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' 項目をすべて削除
        lst.Clear()
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub
End Class
