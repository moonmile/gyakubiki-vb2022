Imports System.IO

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListView1.View = View.Details
        ListView1.Columns.Add("ファイル名", 200)
        ListView1.Columns.Add("サイズ", 100, HorizontalAlignment.Right)
        ListView1.Columns.Add("更新日", 200)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        If Directory.Exists(Text) = False Then
            MessageBox.Show("指定したフォルダーが見つかりません")
            Return
        End If
        Dim dirinfo = New DirectoryInfo(Text)
        Dim files = dirinfo.GetFiles()
        ListView1.Items.Clear()
        For Each it In files
            Dim item = New ListViewItem(it.Name)
            item.SubItems.Add(it.Length.ToString())
            item.SubItems.Add(it.LastWriteTime.ToString())
            ListView1.Items.Add(item)
        Next
    End Sub

End Class
