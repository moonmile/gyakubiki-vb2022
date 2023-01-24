Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
#If DEBUG Then
        MessageBox.Show("DEBUGモードでビルド")
#Else
        MessageBox.Show("RELEASEモードでビルド")
#End If
    End Sub
End Class
