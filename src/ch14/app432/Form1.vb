Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim proc = New System.Diagnostics.Process()
        ' メモ帳を起動する
        proc.StartInfo.FileName = "notepad.exe"
        ' アプリケーションの終了を待つ
        proc.EnableRaisingEvents = True
        AddHandler proc.Exited,
            Sub()
                ' 終了のイベントを取得する
                MessageBox.Show("メモ帳を終了しました")
            End Sub
        proc.Start()
    End Sub
End Class
