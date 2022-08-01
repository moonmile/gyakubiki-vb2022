Public Class Form1
    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        TextBox1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
