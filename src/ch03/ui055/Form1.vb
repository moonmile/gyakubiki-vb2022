Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim total = 0
        If CheckBox1.Checked = True Then
            total += 1000
        End If
        If CheckBox2.Checked = True Then
            total += 500
        End If
        If CheckBox3.Checked = True Then
            total += 2000
        End If
        Label1.Text = $"合計金額は {total:#,##0}円です"
    End Sub
End Class
