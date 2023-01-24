Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            ListBox1.Items.Clear()
            For Each sh In wb.Worksheets
                ListBox1.Items.Add(sh.Name)
            Next
        End Using
    End Sub
End Class
