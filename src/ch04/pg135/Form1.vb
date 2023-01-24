Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim s1 = ""
        Dim s2 = ""
        ' チェック済みを調べる
        For Each it As CheckBox In groupBox1.Controls
            If it.Checked = True Then
                s1 += it.Text + ","
                Continue For
            End If
            ' 残りの項目
            s2 += it.Text + ","
        Next
        Label1.Text = $"{s1} を選択しました"
        Label2.Text = $"{s2} が未選択でした"
    End Sub
End Class
