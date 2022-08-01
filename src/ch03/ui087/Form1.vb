Public Class Form1
    Private Sub DockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DockToolStripMenuItem.Click
        DockToolStripMenuItem.Checked = Not DockToolStripMenuItem.Checked
        If DockToolStripMenuItem.Checked = True Then
            pictureBox1.Dock = DockStyle.Fill
        Else
            pictureBox1.Dock = DockStyle.None
        End If
    End Sub
End Class
