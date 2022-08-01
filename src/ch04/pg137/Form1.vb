Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 配列の宣言時に初期値を入れる
        Dim names = New String() {
                "荒俣", "夢野", "沼", "柄谷", "谷崎"
            }
        ' 以下の書き方も可能
        ' Dim names = {
        '        "荒俣", "夢野", "沼", "柄谷", "谷崎"
        '    }
        Dim index = ComboBox1.SelectedIndex
        If index = -1 Then
            Label2.Text = "クラスを選択してください"
            Return
        End If
        Label2.Text = $"{ComboBox1.Text} 担任 {names(index)} 先生"
    End Sub
End Class
