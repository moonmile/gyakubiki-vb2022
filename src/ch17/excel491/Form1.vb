Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim Path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(Path)
            ' 最後に新しいシートを追加する
            Dim sh = wb.Worksheets.Add(0)
            sh.Name = TextBox1.Text
            sh.Cell("A1").Value = "新しいシート"
            wb.Save()
        End Using
        MessageBox.Show("シートを追加しました")
    End Sub
End Class
