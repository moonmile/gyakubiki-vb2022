Public Class Form1
    ''' <summary>
    ''' テキストボックスの文字列を取得する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = TextBox1.Text
    End Sub

    ''' <summary>
    ''' テキストボックスの入力をクリアする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Label2.Text = TextBox1.Text
    End Sub
End Class
