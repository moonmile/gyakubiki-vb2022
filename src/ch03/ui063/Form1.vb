Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.AddRange(
                 {"A4用紙", "A3用紙", "B5用紙", "B4用紙", "はがき", "レポート用紙"})
        ListBox1.SelectionMode = SelectionMode.MultiSimple
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim items As New List(Of String)()
        For Each it As String In ListBox1.SelectedItems
            ListBox2.Items.Add(it)
            ' 削除する項目を保存しておく
            items.Add(it)
        Next
        For Each it As String In items
            ListBox1.Items.Remove(it)
        Next
    End Sub
End Class
