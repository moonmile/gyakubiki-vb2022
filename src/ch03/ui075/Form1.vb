Public Class Form1
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) _
        Handles ToolStripButton1.Click
        textBox1.TextAlign = HorizontalAlignment.Left
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) _
        Handles ToolStripButton2.Click
        textBox1.TextAlign = HorizontalAlignment.Center
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) _
        Handles ToolStripButton3.Click
        textBox1.TextAlign = HorizontalAlignment.Right
    End Sub
End Class
