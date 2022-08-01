Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        If Text <> "" Then
            RichTextBox1.SelectionStart += RichTextBox1.SelectionLength
            RichTextBox1.SelectionLength = 0
            RichTextBox1.Focus()
            Dim pos = RichTextBox1.Find(Text, RichTextBox1.SelectionStart, RichTextBoxFinds.None)
            If pos <> -1 Then
                ' 検索にマッチした場所の色を変える
                RichTextBox1.SelectionBackColor = Color.Red
                RichTextBox1.SelectionColor = Color.White
            End If
        End If
    End Sub
End Class
