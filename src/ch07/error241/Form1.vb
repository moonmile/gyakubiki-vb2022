Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Try
            Dim x = sample(Text)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub

    ''' <summary>
    ''' 文字列を数値に変換する関数
    ''' </summary>
    ''' <param name="Text"></param>
    ''' <returns></returns>
    Private Function sample(Text As String) As Integer
        ' 数値に変換できないときは例外が発生する
        Dim a = Integer.Parse(Text)
        Return a
    End Function

End Class
