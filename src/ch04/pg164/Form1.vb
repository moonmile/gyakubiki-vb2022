Public Class Form1

    Private Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' クラス内で定義した関数
        Dim a = Integer.Parse(TextBox1.Text)
        Dim b = Integer.Parse(TextBox2.Text)
        Dim ans = add(a, b)
        Label4.Text = ans.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' ラムダ式の設定
        Dim add = Function(x As Integer, y As Integer)
                      Return x + y
                  End Function
        Dim a = Integer.Parse(TextBox1.Text)
        Dim b = Integer.Parse(TextBox2.Text)
        Dim ans = add(a, b)
        Label4.Text = ans.ToString()

    End Sub
End Class
