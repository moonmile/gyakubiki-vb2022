Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then

            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        Using sr = New StreamReader(path)
            TextBox2.Text = sr.ReadToEnd()
        End Using
    End Sub
End Class
