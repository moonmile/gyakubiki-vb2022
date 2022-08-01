Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = TextBox1.Text
        Try
            ' 先頭の3文字だけ残す
            Label3.Text = text.Remove(3)
        Catch ex As ArgumentOutOfRangeException
            ' 範囲外の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
