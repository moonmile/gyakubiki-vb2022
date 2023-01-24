Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            Return
        End If
        Dim attr = File.GetAttributes(path)
        CheckBox1.Checked = (attr And FileAttributes.ReadOnly) <> 0
        CheckBox2.Checked = (attr And FileAttributes.Hidden) <> 0
        CheckBox3.Checked = (attr And FileAttributes.Compressed) <> 0
        CheckBox4.Checked = (attr And FileAttributes.System) <> 0
    End Sub
End Class
