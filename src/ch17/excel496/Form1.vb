Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim url = "https://my.redmine.jp/demo/projects.json"
        Dim cl As New HttpClient()
        Dim json = Await cl.GetStringAsync(url)
        TextBox1.Text = json
        Dim doc = System.Text.Json.JsonDocument.Parse(json)

        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()

            Dim projects = doc.RootElement.GetProperty("projects")
            Dim r = 2
            For Each project In projects.EnumerateArray()
                sh.Cell(r, 1).Value = project.GetProperty("id").GetInt16()
                sh.Cell(r, 2).Value = project.GetProperty("identifier").GetString()
                sh.Cell(r, 3).Value = project.GetProperty("name").GetString()
                sh.Cell(r, 4).Value = project.GetProperty("description").GetString()
                r += 1
            Next
            wb.Save()
        End Using
        MessageBox.Show("JSON形式で取得しました")
    End Sub
End Class
