Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' [新しいフォルダーを作成]ボタンを表示しない
        Dim dlg As New FolderBrowserDialog() With
            {
                .ShowNewFolderButton = False
            }
        If dlg.ShowDialog() = DialogResult.OK Then
            Label2.Text = dlg.SelectedPath
        End If
    End Sub
End Class
