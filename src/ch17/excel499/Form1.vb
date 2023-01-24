Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim url = "http://shuwasystem.co.jp"
        Dim cl As New HttpClient()
        Dim html = Await cl.GetStringAsync(url)
        Dim doc = New HtmlAgilityPack.HtmlDocument()
        doc.LoadHtml(html)
        Dim lst = doc.DocumentNode.SelectNodes("//li[@class='items']")
        Dim items = New List(Of String)()
        Dim books = New List(Of Book)()
        For Each it In lst
            Dim a = it.SelectSingleNode(".//a")
            Dim img = it.SelectSingleNode(".//img")
            Dim text = img.GetAttributeValue("alt", "")
            Dim link = a.GetAttributeValue("href", "")
            items.Add(text)
            books.Add(New Book With {.Title = text, .Link = link})
        Next
        ListBox1.DataSource = items

        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            sh.Cell(1, 1).Value = "タイトル"
            sh.Cell(1, 2).Value = "リンク"
            Dim r = 2
            For Each it In books
                sh.Cell(r, 1).Value = it.Title
                sh.Cell(r, 2).Value = it.Link
                r += 1
            Next
            wb.Save()
        End Using
    End Sub
End Class


Public Class Book
    Public Property Title As String
    Public Property Link As String
End Class
