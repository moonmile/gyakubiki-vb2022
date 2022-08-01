Public Class Form1

    ''' <summary>
    ''' ラムダ式の初期値
    ''' </summary>
    Dim _func As Func(Of Integer, Integer, Integer) =
        Function(x, y)
            Return 0
        End Function

    ''' <summary>
    ''' ラムダ式を設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If RadioButton1.Checked Then
            _func = Function(x, y)
                        Return x + y
                    End Function
        End If
        If RadioButton2.Checked Then
            _func = Function(x, y)
                        Return x * y
                    End Function
        End If
        If RadioButton3.Checked Then
            _func = Function(x, y)
                        Return Math.Pow(x, y)
                    End Function
        End If
    End Sub

    ''' <summary>
    ''' ラムダ式を実行
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim x = Integer.Parse(TextBox1.Text)
        Dim y = Integer.Parse(TextBox2.Text)
        Dim ans = _func(x, y)
        Label4.Text = ans.ToString()
    End Sub
End Class
