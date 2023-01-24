Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim url = "https://www.shuwasystem.co.jp/book/9784798050027.html"
        Dim cl = New HttpClient()
        Dim html = Await cl.GetStringAsync(url)
        Dim doc = New HtmlAgilityPack.HtmlDocument()
        doc.LoadHtml(html)

        Dim title = doc.DocumentNode.SelectSingleNode("//h1[@class='titleType1']").InnerText.Trim()
        Dim div = doc.DocumentNode.SelectSingleNode("//div[@class='right']")
        Dim table = div.SelectSingleNode(".//table")
        Dim items = table.SelectNodes("*/tr/td")
        Dim author = items(0).InnerText.Trim()
        Dim isbn = items(3).InnerText.Trim()
        Dim dt = items(2).InnerText.Trim()
        TextBox1.Text = $"
タイトル {title}
著者: {author}
ISBN: {isbn}
発売日: {dt}
"
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            sh.Cell(1, 1).Value = "タイトル"
            sh.Cell(2, 1).Value = "著者"
            sh.Cell(3, 1).Value = "ISBN"
            sh.Cell(4, 1).Value = "発売日"

            sh.Cell(1, 2).Value = title
            sh.Cell(2, 2).Value = author
            sh.Cell(3, 2).SetValue(Of String)(isbn)
            sh.Cell(4, 2).SetValue(Of String)(dt)
            wb.Save()
        End Using
    End Sub
End Class
