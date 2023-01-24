Public Class Form1

    Private map As New Dictionary(Of String, String)

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim id = Integer.Parse(TextBox1.Text)
        Dim Name = TextBox2.Text
        ' キーと値を追加
        map.Add(id, Name)
        ' 以下でも良い
        ' map[id] = name

        ' 内容を確認する
        ListBox1.Items.Clear()
        For Each it In map
            ListBox1.Items.Add($"{it.Key} : {it.Value}")
        Next
    End Sub
End Class
