Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dlg As New ColorDialog()
        If dlg.ShowDialog() = DialogResult.OK Then
            Label1.BackColor = dlg.Color
        End If
    End Sub
End Class
