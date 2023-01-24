Imports Newtonsoft.Json

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim json = "{ name: ""増田智明"", age: 53 }"
        Dim o = JsonConvert.DeserializeObject(json)
        ' name や age は実行時に解決される
        Label3.Text = o.Item("name").Value
        Label4.Text = o.Item("age").ToString()

    End Sub
End Class
