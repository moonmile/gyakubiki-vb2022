Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim proc As New System.Diagnostics.Process()
        ' メモ帳を起動する
        proc.StartInfo.FileName = "notepad.exe"
        proc.Start()
    End Sub
End Class
