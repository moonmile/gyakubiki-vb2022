Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim target = TextBox1.Text
        Dim search = TextBox2.Text

        ListBox1.Items.Clear()
        Dim pos = -1
        Do
            pos = target.IndexOf(search, pos + 1)
            If pos = -1 Then
                Exit Do
            End If
            ListBox1.Items.Add($"{pos + 1}文字目")
        Loop
    End Sub
End Class
