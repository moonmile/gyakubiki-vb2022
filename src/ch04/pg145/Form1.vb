Public Class Form1

    Private lst = New List(Of String)()

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
        ' 先頭を削除する
        lst.RemoveAt(0)
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' 項目を探しながら削除する
        Dim items As New List(Of String)()

        For Each it In lst
            If it.StartsWith("♠") Then
                items.Add(it)
            End If
        Next
        For Each it In items
            lst.Remove(it)
        Next
        ' 内容を表示する
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
    End Sub

End Class
