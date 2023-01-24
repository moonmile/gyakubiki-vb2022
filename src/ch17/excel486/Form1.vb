Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim title = TextBox1.Text
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim r = 2
            While sh.Cell(r, 1).GetString() <> ""
                ' 書名を調べる
                If sh.Cell(r, 2).GetString() = title Then
                    ' 列全体に色を付ける
                    Dim rg = sh.Range(sh.Cell(r, 1), sh.Cell(r, 4))
                    rg.Style.Fill.BackgroundColor = ClosedXML.Excel.XLColor.Pink
                End If
                r += 1
            End While
            wb.Save()
        End Using
        MessageBox.Show("色を変更しました")
    End Sub
End Class
