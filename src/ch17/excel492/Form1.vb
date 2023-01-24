Imports System.IO
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim xapp = New Excel.Application()
        Dim path = AppDomain.CurrentDomain.BaseDirectory + "\sample.xlsx"
        Dim wb = xapp.Workbooks.Open(path)
        Dim sh = CType(wb.ActiveSheet, Excel.Worksheet)
        sh.ExportAsFixedFormat2(Excel.XlFixedFormatType.xlTypePDF,
            AppDomain.CurrentDomain.BaseDirectory + "\sample.pdf")
        xapp.Quit()
        MessageBox.Show("PDFファイルに保存しました")
    End Sub
End Class
