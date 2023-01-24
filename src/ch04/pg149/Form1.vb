Public Class Form1

    Private map As New Dictionary(Of String, String)() From {
            {"JP", "日本"},
            {"KR", "韓国"},
            {"US", "アメリカ"},
            {"UK", "イギリス"},
            {"GB", "ドイツ"},
            {"IT", "イタリア"},
            {"FR", "フランス"},
            {"CN", "中国"}
    }

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        ' リスト表示
        For Each it In map
            ListBox1.Items.Add($"{it.Key} : {it.Value}")
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim key = TextBox1.Text
        If map.ContainsKey(key) = True Then
            Label3.Text = map(key)
        Else
            Label3.Text = "キーが見つかりませんでした"
        End If
    End Sub

End Class
