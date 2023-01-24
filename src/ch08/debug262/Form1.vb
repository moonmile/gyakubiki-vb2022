Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        For i = 0 To 9
            Debug.WriteLine(i * 2)
        Next
    End Sub
End Class
