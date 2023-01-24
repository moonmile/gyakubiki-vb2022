Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        Dim i = 0
        While i < 10
            ListBox1.Items.Add($"No.{i + 1}")
            i += 1
        End While
    End Sub
End Class
