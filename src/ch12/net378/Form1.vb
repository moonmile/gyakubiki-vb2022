Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    ''' <summary>
    ''' Webサーバーに接続する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Try
            Dim client As New HttpClient()
            Dim url = TextBox1.Text
            Dim response = Await client.GetAsync(url)
            TextBox2.Text = Await response.Content.ReadAsStringAsync()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
