Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim target = TextBox1.Text
        Dim search = TextBox2.Text
        If target.Contains(search) = True Then
            Label4.Text = "含まれています"
        Else
            Label4.Text = "含まれていません"
        End If
    End Sub
End Class
