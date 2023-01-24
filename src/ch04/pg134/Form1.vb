Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s = ""
        ' チェック済みを調べる
        For Each it As CheckBox In groupBox1.Controls
            If it.Checked = True Then
                s += it.Text + ","
            End If
        Next
        Label1.Text = $"{s} を選択しました"
    End Sub
End Class
