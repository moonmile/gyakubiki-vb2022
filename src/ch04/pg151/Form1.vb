Public Class Form1

    Private dic As New Dictionary(Of String, ValueTuple(Of String, String))

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        dic = New Dictionary(Of String, ValueTuple(Of String, String))()
        dic.Add("JP", ("Japan", "日本"))
        dic.Add("CN", ("China", "中国"))
        dic.Add("KR", ("Republic of Korea", "韓国"))
        dic.Add("UK", ("United Kingdom", "イギリス"))
        dic.Add("US", ("United States of America", "アメリカ"))
        dic.Add("CA", ("Canada", "カナダ"))
        ' リストに表示
        For Each it In dic
            ListBox1.Items.Add($"{it.Key}: {it.Value}")
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim key = TextBox1.Text
        If dic.ContainsKey(key) = True Then
            Dim item = dic(key)
            Label3.Text = $"{item.Item1} {item.Item2}"
        Else
            Label3.Text = "キーが見つかりません"
        End If
    End Sub

End Class
