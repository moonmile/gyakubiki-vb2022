Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(
                {"赤", "橙", "黄", "緑", "青", "藍", "紫"})
    End Sub

    ''' <summary>
    ''' リストを初期化する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(
                {"赤", "橙", "黄", "緑", "青", "藍", "紫"})

    End Sub

    ''' <summary>
    ''' 先頭の項目を削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.RemoveAt(0)
        End If
    End Sub

    ''' <summary>
    ''' 末尾の項目を削除
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ListBox1.Items.Count > 0 Then
            ListBox1.Items.RemoveAt(ListBox1.Items.Count - 1)
        End If
    End Sub

End Class
