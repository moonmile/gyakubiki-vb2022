Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim rmax = 2
            ' 終端を探す
            While sh.Cell(rmax, 1).GetString() <> ""
                rmax += 1
            End While
            rmax -= 1
            Dim rg = sh.Range(sh.Cell(1, 1), sh.Cell(rmax, 4))
            ' フォントを変える
            rg.Style.Font.FontName = "UD デジタル 教科書体 N-B"
            rg.Style.Font.Italic = True
            wb.Save()
        End Using
        MessageBox.Show("フォントを設定しました")
    End Sub
End Class
