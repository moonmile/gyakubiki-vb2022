Public Class Form1
    Private Sub BoldToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles BoldToolStripMenuItem.Click
        BoldToolStripMenuItem.Checked = Not BoldToolStripMenuItem.Checked
        If BoldToolStripMenuItem.Checked = True Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold)
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular)
        End If
    End Sub
End Class
