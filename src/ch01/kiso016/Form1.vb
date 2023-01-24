Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        If CheckBox1.Checked = True Then
            ' チェックされているときの処理を書く
            MessageBox.Show("選択状態です")
        Else
            ' チェックしていないときの処理を書く
            MessageBox.Show("未選択状態です")
        End If
    End Sub
End Class
