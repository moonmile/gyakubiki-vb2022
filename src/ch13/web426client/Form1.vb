Imports System.Buffers.Text
Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    ''' <summary>
    ''' BASE64文字列に変換する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Data = System.Text.Encoding.UTF8.GetBytes(TextBox1.Text)
        TextBox2.Text = System.Convert.ToBase64String(Data)
    End Sub

    ''' <summary>
    ''' サーバーにBASE64文字列を送信する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Url = "https://localhost:5001/api/Books/upload"
        Dim Base64 = TextBox2.Text
        Dim cl As New HttpClient()
        Dim context = New StringContent("""" + Base64 + """")
        context.Headers.ContentType =
            New System.Net.Http.Headers.MediaTypeHeaderValue("text/json")
        Dim response = Await cl.PostAsync(Url, context)
        TextBox3.Text = Await response.Content.ReadAsStringAsync()
    End Sub
End Class
