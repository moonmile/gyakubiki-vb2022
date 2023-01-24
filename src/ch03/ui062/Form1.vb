Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(
                {"赤", "橙", "黄", "緑", "青", "藍", "紫"})
    End Sub

    ''' <summary>
    ''' 選択を表示する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim index = ListBox1.SelectedIndex
        If index = -1 Then
            Label1.Text = "未選択"
        Else
            Dim text = ListBox1.SelectedItem.ToString()
            Label1.Text = $"{index}番目の {text} を選択"
        End If
        ' SelectedItem プロパティでも良い
        ' If ListBox1.SelectedItem <> Nothing Then
    End Sub

    ''' <summary>
    ''' 選択を解除する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ListBox1.SelectedIndex = -1
        Label1.Text = ""
    End Sub
End Class
