Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        If System.IO.Directory.Exists(path) = False Then
            MessageBox.Show("指定フォルダーが見つかりません")
            Return
        End If
        ListBox1.Items.Clear()
        Dim files = System.IO.Directory.GetFiles(path)
        For Each file In files
            ListBox1.Items.Add(file)
        Next
    End Sub
End Class
