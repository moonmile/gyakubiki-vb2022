Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim fname1 = TextBox1.Text
        Dim fname2 = TextBox2.Text
        Try
            System.IO.Directory.Move(fname1, fname2)
            Label4.Text = "フォルダーを移動しました"
        Catch ex As IOException
            ' 移動先にフォルダーがある場合は、例外が発生する
            Label4.Text = ex.Message
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim fname1 = TextBox1.Text
        Dim fname2 = TextBox2.Text
        Try
            System.IO.File.Move(fname1, fname2)
            Label4.Text = "ファイルを移動しました"
        Catch ex As IOException
            ' 移動先にファイルがある場合は、例外が発生する
            Label4.Text = ex.Message
        End Try
    End Sub
End Class
