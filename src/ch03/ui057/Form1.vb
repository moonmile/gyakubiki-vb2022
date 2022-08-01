Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = ""
        For Each btn As RadioButton In Panel1.Controls
            If btn.Checked = True Then
                Text = btn.Text
            End If
        Next
        Label2.Text = $"{Text} を選択しました"
    End Sub
End Class
