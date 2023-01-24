Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Label1.Text = wb.Worksheets.First().Name
        End Using
    End Sub
End Class
