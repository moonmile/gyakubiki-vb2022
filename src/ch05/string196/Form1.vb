Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        If TextBox1.Text = "" Then Return
        ' 1文字目を取得
        Dim ch As Char = TextBox1.Text(0)
        Dim code = AscW(ch)
        Label3.Text = "0x" + code.ToString("X")
    End Sub
End Class
