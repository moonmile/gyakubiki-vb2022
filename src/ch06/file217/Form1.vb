Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname = TextBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            System.IO.Directory.Delete(fname)
            Label3.Text = $"フォルダー {fname} を削除しました"
        ElseIf System.IO.File.Exists(fname) = True Then
            System.IO.File.Delete(fname)
            Label3.Text = $"ファイル {fname} を削除しました"
        Else
            Label3.Text = $"{fname} が見つかりませんでした"
        End If
    End Sub
End Class
