Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        Dim sum = 0
        For i = 0 To 99
            If i Mod 3 = 0 Then
                ' 3の倍数のときに加算する
                sum += i
#If DEBUG Then
                ' デバッグ時に途中経過を表示する
                System.Diagnostics.Debug.WriteLine($"経過 {sum}")
#End If
            End If
        Next
        MessageBox.Show($"合計値: {sum}")

#If MASUDA Then
        Dim a = 10
#End If
    End Sub
End Class
