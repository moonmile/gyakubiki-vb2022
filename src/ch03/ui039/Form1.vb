Public Class Form1
    Private Sub Form1_HelpRequested(sender As Object, hlpevent As HelpEventArgs) Handles MyBase.HelpRequested
        If RectangleToScreen(Button1.Bounds).Contains(hlpevent.MousePos) = True Then
            MessageBox.Show("これは一番上のボタンです")
        End If
        If RectangleToScreen(Button2.Bounds).Contains(hlpevent.MousePos) = True Then
            MessageBox.Show("これは真ん中のボタンです")
        End If
        If RectangleToScreen(Button3.Bounds).Contains(hlpevent.MousePos) = True Then
            MessageBox.Show("これは一番下のボタンです")
        End If
    End Sub
End Class
