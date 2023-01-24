Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        ' 文字 char を指定して分割する
        Dim ch As Char = ","
        Dim ary = text.Split(ch)
        ListBox1.Items.Clear()
        For Each it In ary
            ListBox1.Items.Add(it)
        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim text = TextBox1.Text
        ' 文字列 string を指定して分割する
        Dim ary = text.Split(",")
        ListBox1.Items.Clear()
        For Each it In ary
            ListBox1.Items.Add(it)
        Next
    End Sub
End Class
