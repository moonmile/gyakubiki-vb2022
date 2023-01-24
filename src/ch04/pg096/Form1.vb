Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim i
        ' 行頭に「'」を記述すると、行全体がコメントになります
        i = 100 * 2 ' 行の途中からもコメントが書けます

        ' 次の行は行頭に「'」があるので実行されません
        ' i += 100 ;

        '
        ' 複数行のブロックコメントは、
        ' ツールバーのコメントアウトの機能を使います
        ' Ctrl+K, Ctrl+C
        '
        MessageBox.Show($"i = {i}", "確認")

    End Sub
End Class
