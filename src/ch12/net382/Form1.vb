Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    ''' <summary>
    ''' GETメソッドの呼び出し
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = Integer.Parse(TextBox1.Text)

        Dim cl As New HttpClient()
        Dim Url = $"http://localhost:5000/api/Gyakubiki/{id}"
        Dim response = Await cl.GetStringAsync(Url)
        TextBox2.Text = response
    End Sub
End Class
