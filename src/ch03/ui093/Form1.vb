Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim dlg = New FontDialog() With {
        .ShowColor = True,
                .Font = RichTextBox1.SelectionFont,
                .Color = RichTextBox1.SelectionColor
            }
        If dlg.ShowDialog() = DialogResult.OK Then
            RichTextBox1.SelectionFont = dlg.Font
            RichTextBox1.SelectionColor = dlg.Color
        End If
    End Sub
End Class
