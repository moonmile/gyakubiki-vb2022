Imports System.IO
Imports System.Net.Http
Imports System.Security.Policy
Imports System.Text.Json

Public Class Form1
    ''' <summary>
    ''' https://weather.tsukumijima.net/ を利用
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim city = 130000 ' 東京都
        Dim url = $"https://www.jma.go.jp/bosai/forecast/data/overview_forecast/{city}.json"
        Dim cl = New HttpClient()
        Dim json = Await cl.GetStringAsync(url)
        TextBox1.Text = json
        Dim doc = JsonDocument.Parse(json)
        Dim root = doc.RootElement

        Dim title = root.GetProperty("targetArea").GetString()
        Dim dt = root.GetProperty("reportDatetime").GetString()
        Dim headline = root.GetProperty("headlineText").GetString()
        Dim description = root.GetProperty("text").GetString()
        description = description.Replace("\n", vbCrLf)

        Dim Path = "sample.xlsx"
        Using wb As New ClosedXML.Excel.XLWorkbook(Path)
            Dim sh = wb.Worksheets.First()
            sh.Cell(1, 2).Value = title
            sh.Cell(2, 2).Value = dt
            sh.Cell(3, 2).Value = headline
            sh.Cell(4, 2).Value = description
            wb.Save()
        End Using
        MessageBox.Show("天気予測データを取得しました")


    End Sub
End Class
