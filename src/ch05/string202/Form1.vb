Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = TextBox1.Text
        Dim text2 = TextBox2.Text
        Dim result = text1.CompareTo(text2)
        If result = 0 Then
            Label4.Text = "同じです。"
        ElseIf result < 0 Then
            Label4.Text = $"{text1} のほうが小さい"
        Else
            Label4.Text = $"{text1} のほうが大きい"
        End If
    End Sub
End Class
