Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CheckedListBox1.Items.AddRange(
                {"テニス", "バドミントン", "陸上", "柔道", "水泳"})
    End Sub

    ''' <summary>
    ''' チェックした項目をリストへ追加
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        For Each it In CheckedListBox1.CheckedItems
            ListBox1.Items.Add(it)
        Next
    End Sub
End Class
