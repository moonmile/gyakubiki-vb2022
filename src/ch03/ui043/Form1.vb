Public Class Form1
    ''' <summary>
    ''' 透明度を指定する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Opacity = 0.5
        TrackBar1.Value = 50

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Opacity = 0.2
        TrackBar1.Value = 20

    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Opacity = TrackBar1.Value / 100.0
    End Sub
End Class
