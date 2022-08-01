Public Class Form1
    ''' <summary>
    ''' カレントフォルダーを取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox1.Text = System.IO.Directory.GetCurrentDirectory()
    End Sub

    ''' <summary>
    ''' カレントフォルダーを設定
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim path = TextBox1.Text
        If path = String.Empty Then
            Return
        End If
        System.IO.Directory.SetCurrentDirectory(path)
        MessageBox.Show($"カレントフォルダーを設定しました {path}")
    End Sub
End Class
