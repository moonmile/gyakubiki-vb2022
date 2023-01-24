Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Security.Policy
Public Class Form1
    Private Async Sub button1_Click(sender As Object, e As EventArgs) _
        Handles button1.Click
        Dim Url = "http://localhost:5000/api/Gyakubiki/upload"
        Dim Path = "sample-upload.zip"
        Dim FileStream = System.IO.File.OpenRead(Path)

        Dim MultipartContent As New MultipartFormDataContent()
        MultipartContent.Add(New StreamContent(FileStream), "zipfile", Path)
        MultipartContent.Headers.ContentDisposition =
        New ContentDispositionHeaderValue("form-data") With {
            .Name = "zipfile", .FileName = Path}
        Dim client As New HttpClient()
        Try
            Dim response = Await client.PostAsync(Url, MultipartContent)
            If response.IsSuccessStatusCode Then
                MessageBox.Show("アップロードが完了しました")
            Else
                MessageBox.Show("アップロードに失敗しました")
            End If
        Catch ex As Exception
            ' アップロードが異常の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
