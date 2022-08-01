Public Class Form1
    ''' <summary>
    ''' 位置を指定して開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim form As New Form2 With {
            .StartPosition = FormStartPosition.Manual,
            .Location = New Point(0, 0)
        }
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' 画面の中央に開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim form As New Form2 With {
            .StartPosition = FormStartPosition.CenterScreen
        }
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' 既定の位置で開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim form As New Form2
        form.ShowDialog()
    End Sub

    ''' <summary>
    ''' 既定の位置で開く。デフォルトの大きさで開く。
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim form As New Form2 With {
            .StartPosition = FormStartPosition.WindowsDefaultBounds
        }
        form.ShowDialog()

    End Sub

    ''' <summary>
    ''' 親画面の中央で開く
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim form As New Form2 With {
            .StartPosition = FormStartPosition.CenterParent
        }
        form.ShowDialog()
    End Sub
End Class
