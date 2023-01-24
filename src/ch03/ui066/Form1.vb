Public Class Form1
    ''' <summary>
    ''' 選択項目を取得
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        For Each tab As TabPage In TabControl1.TabPages
            For Each btn As RadioButton In tab.Controls
                If btn.Checked = True Then
                    ListBox1.Items.Add(btn.Text)
                End If
            Next
        Next
    End Sub
End Class
