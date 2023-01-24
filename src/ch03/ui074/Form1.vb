Public Class Form1
    Private Sub LeftToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftToolStripMenuItem.Click
        Dim tb As TextBox = ContextMenuStrip1.SourceControl
        If Not tb Is Nothing Then
            tb.TextAlign = HorizontalAlignment.Left
        End If

    End Sub

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) _
        Handles CenterToolStripMenuItem.Click
        Dim tb As TextBox = ContextMenuStrip1.SourceControl
        If Not tb Is Nothing Then
            tb.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub RightToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightToolStripMenuItem.Click
        Dim tb As TextBox = ContextMenuStrip1.SourceControl
        If Not tb Is Nothing Then
            tb.TextAlign = HorizontalAlignment.Right
        End If
    End Sub
End Class
