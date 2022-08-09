Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        ' 1文字ずつ分割する
        Dim lst = Text.ToList()
        Try
            For Each ch In lst
                ' コレクションを動的に操作してはいけない
                If ch = "A" Then
                    lst.Remove(ch)
                End If
            Next
        Catch ex As InvalidOperationException
            MessageBox.Show(ex.Message, "エラー発生")
        End Try
    End Sub
End Class
