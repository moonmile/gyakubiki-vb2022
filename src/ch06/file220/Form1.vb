Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = TextBox1.Text
        If File.Exists(fname) = True Then
            Label4.Text = File.GetCreationTime(fname).ToString()
            Label5.Text = File.GetLastWriteTime(fname).ToString()
        ElseIf Directory.Exists(fname) = True Then
            Label4.Text = Directory.GetCreationTime(fname).ToString()
            Label5.Text = Directory.GetLastWriteTime(fname).ToString()
        Else
            Label4.Text = $"{fname} が見つかりませんでした"
            Label5.Text = ""
        End If
    End Sub
End Class
