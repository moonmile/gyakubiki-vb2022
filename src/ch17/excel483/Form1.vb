Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sheet = wb.Worksheets.First()
            ' セル名を指定
            Label1.Text = sheet.Cell("A1").GetString()
            ' 行番号,列番号を指定
            ' label1.Text = sheet.Cell(1,1).GetString()
        End Using
    End Sub
End Class
