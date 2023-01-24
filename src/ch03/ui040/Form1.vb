Public Class Form1
    ''' <summary>
    ''' モーダルで開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim form As New Form2
        form.ShowDialog()

    End Sub

    ''' <summary>
    ''' モードレスで開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim form As New Form2
        form.Show()
    End Sub
End Class
