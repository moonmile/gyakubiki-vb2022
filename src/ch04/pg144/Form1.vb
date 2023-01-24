Public Class Form1
    Private lst As New List(Of String)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim mark = {"♠", "♥", "♦", "♣"}(Random.Shared.Next(4))
        Dim num = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            }(Random.Shared.Next(13))

        ' ひとつの要素を追加する
        lst.Add($"{mark}{num}")
        ' 項目を末尾に追加する
        lst.Add(DateTime.Now.ToString())
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim num = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            }(Random.Shared.Next(13))
        ' 複数の要素を一度に追加する
        lst.AddRange(
            {$"♠{num}", $"♥{num}", $"♦{num}", $"♣{num}"})
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub
End Class
