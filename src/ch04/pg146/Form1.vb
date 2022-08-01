Public Class Form1

    Private lst As New List(Of String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim marks = {"♠", "♥", "♦", "♣"}
        Dim nums = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"}
        For i = 0 To 12
            Dim mark = marks(Random.Shared.Next(4))
            Dim num = nums(Random.Shared.Next(13))
            lst.Add($"{mark}{num}")
        Next
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' リスト全体をコピーする
        Dim lst2 = lst.ToList()
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(lst2.ToArray())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 部分的にコピーする
        Dim lst2 = lst.Where(
            Function(t)
                Return t.StartsWith("♠")
            End Function
        ).ToList()
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(lst2.ToArray())
    End Sub

End Class
