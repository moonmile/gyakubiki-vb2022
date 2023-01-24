Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = ""
        Dim lst As New List(Of Integer) From
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        ' ラムダ式で連結する
        lst.ForEach(
            Sub(x)
                text += $"{x * x},"
            End Sub)
        Label2.Text = text
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim text = ""
        Dim lst As New List(Of Integer) From
            {1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        ' For Eachで連結する
        For Each it In lst
            text += $"{it * it},"
        Next
        Label2.Text = text
    End Sub
End Class
