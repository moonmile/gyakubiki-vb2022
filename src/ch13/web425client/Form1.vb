Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    ''' <summary>
    ''' 書籍IDを指定して、書名と価格を変更する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim url = TextBox1.Text
        Dim client As New HttpClient()
        Dim bookUpdate = New BookUpdate() With
            {
                .Id = Integer.Parse(TextBox2.Text),
                .Title = TextBox3.Text,
                .Price = Integer.Parse(TextBox4.Text)
            }
        Dim Json = System.Text.Json.JsonSerializer.Serialize(bookUpdate)
        Dim context = New StringContent(Json, System.Text.Encoding.UTF8, "application/json")
        Dim response = Await client.PostAsync($"{url}/{bookUpdate.Id}", context)
        TextBox5.Text = Await response.Content.ReadAsStringAsync()

    End Sub
End Class

Public Class BookUpdate
    Public Property Id As Integer
    Public Property Title As String
    Public Property Price As Integer
End Class