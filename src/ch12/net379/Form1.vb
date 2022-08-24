Imports System.Net.Http

Public Class Form1
    ''' <summary>
    ''' クエリ文字列を使って検索する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim client As New HttpClient()
        Dim ub As New UriBuilder("https://www.google.co.jp/search")
        Dim query = System.Web.HttpUtility.ParseQueryString("")
        query.Add("q", System.Web.HttpUtility.UrlPathEncode(Text))
        query.Add("hl", "jp")
        ub.Query = query.ToString()
        Try
            Dim response = Await client.GetAsync(ub.Uri)
            TextBox2.Text = Await response.Content.ReadAsStringAsync()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
