Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        If MaximizeBox And MinimizeBox Then
            MaximizeBox = False
            MinimizeBox = False
        Else
            MaximizeBox = True
            MinimizeBox = True
        End If
    End Sub
End Class
