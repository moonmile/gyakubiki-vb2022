Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = "c:\C#2022\Sample.txt"
        Label5.Text = "赤" + ControlChars.CrLf +
            "青" + ControlChars.CrLf +
            "黄色"
        TextBox1.Text = "赤" + ControlChars.Tab +
            "青" + ControlChars.Tab +
            "黄色"
    End Sub
End Class
