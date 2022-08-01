Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = TextBox1.Text
        Dim text2 = TextBox2.Text
        If text1.Length < 3 Then
            ' 3文字未満なら終了する
            Return
        End If
        Label3.Text = text1.Insert(3, text2)
    End Sub
End Class
