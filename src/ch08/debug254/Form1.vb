Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sum = 0
        For i = 0 To 99
            If i Mod 3 = 0 Then
                ' 3の倍数のときに加算する
                sum += i
            End If
        Next
        MessageBox.Show($"合計値: {sum}")
    End Sub
End Class
