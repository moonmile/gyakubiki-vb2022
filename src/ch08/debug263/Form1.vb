Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim listener = New TextWriterTraceListener("trace.txt")
        Trace.Listeners.Add(listener)
        For i = 0 To 9
            Trace.WriteLine($"計算: {i * 2}")
        Next
        Trace.Flush()
        MessageBox.Show("トレース結果をファイルに出力しました")
    End Sub
End Class
