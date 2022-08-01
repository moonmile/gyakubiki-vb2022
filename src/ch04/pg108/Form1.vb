Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim s1 As String = "ワイン"
        Dim s2 As String = "チーズ"

        Label3.Text = $"{s1} と {s2}"
        Label4.Text = $"{s1} の長さは {s1.Length} です"
    End Sub
End Class
