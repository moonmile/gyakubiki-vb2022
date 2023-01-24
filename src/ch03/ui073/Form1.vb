Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        CenterToolStripMenuItem.ShortcutKeys = Keys.Control Or Keys.C
    End Sub

    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles LeftToolStripMenuItem.Click
        textBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles CenterToolStripMenuItem.Click
        textBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles RightToolStripMenuItem.Click
        textBox1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
