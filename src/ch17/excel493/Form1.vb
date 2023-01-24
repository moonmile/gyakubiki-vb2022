Imports Microsoft.Office.Interop
Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim xapp = New Excel.Application()
        Dim Path = AppDomain.CurrentDomain.BaseDirectory + "\sample.xlsx"
        Dim wb = xapp.Workbooks.Open(Path)
        Dim sh = CType(wb.ActiveSheet, Excel.Worksheet)
        sh.PrintOutEx()
        xapp.Quit()
        MessageBox.Show("印刷しました")

    End Sub
End Class
