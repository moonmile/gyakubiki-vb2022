Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormBorderStyle = FormBorderStyle.Fixed3D
        Label1.Text = FormBorderStyle.Fixed3D.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        FormBorderStyle = FormBorderStyle.FixedToolWindow
        Label1.Text = FormBorderStyle.FixedToolWindow.ToString()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        FormBorderStyle = FormBorderStyle.FixedDialog
        Label1.Text = FormBorderStyle.FixedDialog.ToString()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        FormBorderStyle = FormBorderStyle.Sizable
        Label1.Text = FormBorderStyle.Sizable.ToString()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        FormBorderStyle = FormBorderStyle.FixedSingle
        Label1.Text = FormBorderStyle.FixedSingle.ToString()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        FormBorderStyle = FormBorderStyle.SizableToolWindow
        Label1.Text = FormBorderStyle.SizableToolWindow.ToString()
    End Sub
End Class
