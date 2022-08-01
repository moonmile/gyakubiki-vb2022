Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Not RichTextBox1.SelectionFont Is Nothing Then
            ' フォントサイズを変更
            Dim Font = RichTextBox1.SelectionFont
            RichTextBox1.SelectionFont = New Font(Font.Name, 14)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Not RichTextBox1.SelectionFont Is Nothing And
               RichTextBox1.SelectionColor <> Color.Empty Then
            ' フォントの色を変更
            RichTextBox1.SelectionColor =
                    IIf(RichTextBox1.SelectionColor = Color.Black, Color.Red, Color.Black)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Not RichTextBox1.SelectionFont Is Nothing Then
            ' フォントの太文字を変更
            Dim font = RichTextBox1.SelectionFont
            Dim style As FontStyle = IIf(font.Bold = True, FontStyle.Regular, FontStyle.Bold)
            RichTextBox1.SelectionFont = New Font(font.Name, font.Size, style)
        End If
    End Sub
End Class
