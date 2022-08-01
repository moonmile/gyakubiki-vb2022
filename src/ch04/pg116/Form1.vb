Public Class Form1
    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        For Each obj As Control In Controls
            If TypeOf obj Is Button Then
                obj.Text = "🍎🍊🍌"
            End If
        Next
    End Sub
End Class
