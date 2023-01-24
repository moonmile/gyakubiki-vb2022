Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary(5) As Integer
        ' 配列に数値を代入する
        Dim n = 1
        For i = 0 To ary.Length - 1
            ary(i) = n * n
            n += 1
        Next
        ' 配列の内容を表示する
        ListBox1.Items.Clear()
        For i = 0 To ary.Length - 1
            ListBox1.Items.Add($"ary[{i}] = {ary(i)}")
        Next

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim ary(2, 3) As Integer
        ' 配列に数値を代入する
        Dim n = 1
        For i = 0 To 1
            For j = 0 To 2
                ary(i, j) = n * n
                n += 1
            Next
        Next
        ' 配列の内容を表示する
        ListBox1.Items.Clear()
        For i = 0 To 1
            For j = 0 To 2
                ListBox1.Items.Add($"ary[{i},{j}] = {ary(i, j)}")
            Next
        Next
    End Sub
End Class
