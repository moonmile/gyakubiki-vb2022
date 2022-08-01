Public Class Form1
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox1.ReadOnly = True
            TextBox2.Enabled = False
        Else
            TextBox1.ReadOnly = False
            TextBox2.Enabled = True
        End If
    End Sub
End Class
