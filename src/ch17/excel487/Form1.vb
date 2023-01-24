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
            ' 各行の罫線を引く
            rg.Style.Border.TopBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            rg.Style.Border.BottomBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            rg.Style.Border.LeftBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            rg.Style.Border.RightBorder = ClosedXML.Excel.XLBorderStyleValues.Thin
            ' 全体を太枠で囲む
            rg.Style.Border.OutsideBorder = ClosedXML.Excel.XLBorderStyleValues.Thick
            ' タイトル部分に色を塗る
            Dim rtitle = sh.Range(sh.Cell(1, 1), sh.Cell(1, 4))
            rtitle.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Orange
            wb.Save()
        End Using
        MessageBox.Show("罫線を設定しました")
    End Sub
End Class
