Public Class Form1
    ''' <summary>
    ''' 配列内をすべてクリアする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim ary = {"東京", "神奈川", "埼玉", "千葉", "栃木", "群馬", "茨城"}
        ListBox1.Items.AddRange(ary)
        ' すべてクリアする
        Array.Clear(ary)
        For Each it In ary
            ListBox2.Items.Add(IIf(it Is Nothing, "(Nothing)", it))
        Next

    End Sub

    ''' <summary>
    ''' 配列内を部分的にクリアする
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        Dim ary = {"東京", "神奈川", "埼玉", "千葉", "栃木", "群馬", "茨城"}
        ListBox1.Items.AddRange(ary)
        ' 2番目と3番目をクリアする
        Array.Clear(ary, 2, 2)
        For Each it In ary
            ListBox2.Items.Add(IIf(it Is Nothing, "(Nothing)", it))
        Next
    End Sub
End Class
