﻿Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        If File.Exists(path) = False Then
            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        ListBox1.Items.Clear()
        Using sr = New StreamReader(path)
            Dim n = 0
            While True
                Dim line = sr.ReadLine()
                If line Is Nothing Then
                    Exit While
                End If
                n += 1
                ListBox1.Items.Add($"{n}: {line}")
            End While
        End Using
    End Sub
End Class
