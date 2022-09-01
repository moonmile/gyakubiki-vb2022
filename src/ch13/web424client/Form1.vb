Imports System.IO
Imports System.Net.Http
Imports System.Net.Http.Headers
Imports System.Security.Policy
Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Url = TextBox1.Text
        Dim cl = New HttpClient()
        cl.DefaultRequestHeaders.Accept.Add(New MediaTypeWithQualityHeaderValue("image/jpeg"))
        Dim Data = Await cl.GetByteArrayAsync(Url)
        Dim mem = New MemoryStream(Data)
        Dim bmp = Bitmap.FromStream(mem)
        PictureBox1.Image = bmp
    End Sub
End Class
