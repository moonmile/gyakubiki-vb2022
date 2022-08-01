Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = TextBox1.Text
        If System.IO.Directory.Exists(fname) = True Then
            Label3.Text = $"フォルダー {fname} が見つかりました"
        ElseIf System.IO.File.Exists(fname) = True Then
            Label3.Text = $"ファイル {fname} が見つかりました"
        Else
            Label3.Text = $"{fname} が見つかりませんでした"
        End If
    End Sub
End Class
