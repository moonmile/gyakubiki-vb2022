Imports System.Net
Imports System.Net.Http
Imports System.Security.Policy

Public Class Form1
    Private _cl As HttpClient
    Private _cookie As CookieContainer

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Load,
            Sub()
                ' クッキーを再利用するため
                _cookie = New CookieContainer()
                _cl = New HttpClient(New HttpClientHandler() With
                {
                    .UseCookies = True,
                    .CookieContainer = _cookie
                })
            End Sub
    End Sub


    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id = Integer.Parse(TextBox1.Text)
        Dim url = $"http://localhost:5000/api/Gyakubiki/checkCookie"
        Dim response = Await _cl.GetStringAsync(url)
        Dim userkey = _cookie.GetCookies(New Uri(url))("User-Key")?.ToString()
        TextBox2.Text = userkey
    End Sub
End Class
