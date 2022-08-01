Public Class Form1
    Private Function GetCard() As String
        Dim mark = {"♠", "♥", "♦", "♣"}(Random.Shared.Next(4))
        Dim num = {
                "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K"
            }(Random.Shared.Next(13))
        Return $"{mark}{num}"
    End Function

    Private cards As New List(Of String)()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        For i = 1 To 20
            cards.Add(GetCard())
        Next
        ListBox1.Items.AddRange(cards.ToArray())
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' マーク順に編集する
        Dim items As New List(Of List(Of String))()
        For Each mark In {"♠", "♥", "♦", "♣"}
            Dim lst = cards.Where(
                Function(t)
                    Return t.StartsWith(mark)
                End Function
                ).ToList()
            items.Add(lst)
        Next

        ' 内容を確認する
        ListBox2.Items.Clear()
        For Each it In items
            ListBox2.Items.Add(String.Join(",", it))
        Next
    End Sub

End Class
