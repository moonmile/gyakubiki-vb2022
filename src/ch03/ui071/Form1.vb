﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        TextBox1.TextAlign = HorizontalAlignment.Center
        LeftToolStripMenuItem.Enabled = False
        RightToolStripMenuItem.Enabled = False
    End Sub
End Class
