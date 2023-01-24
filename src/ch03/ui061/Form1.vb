Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(
                {"赤", "橙", "黄", "緑", "青", "藍", "紫"})
    End Sub

    ''' <summary>
    ''' 先頭に追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim text = TextBox1.Text
        If text <> "" Then
            ListBox1.Items.Insert(0, text)
            TextBox1.Clear()
        End If
    End Sub

    ''' <summary>
    ''' 末尾に追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim text = TextBox1.Text
        If text <> "" Then
            ListBox1.Items.Add(text)
            TextBox1.Clear()
        End If
    End Sub
End Class
