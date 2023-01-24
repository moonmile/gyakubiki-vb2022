Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim dt = DateTimePicker1.Value
        Dim title = TextBox1.Text
        Dim check = CheckBox1.Checked

        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim r = 2
            ' 末尾あるいは要件がマッチする行を探す
            While sh.Cell(r, 1).GetString() <> ""
                If sh.Cell(r, 1).GetString() = title Then
                    Exit While
                End If
                r += 1
            End While
            If sh.Cell(r, 1).GetString() = "" Then
                ' 末尾に追加する
                sh.Cell(r, 1).Value = dt.ToString("yyyy/MM/dd")
                sh.Cell(r, 2).Value = title
                sh.Cell(r, 3).Value = If(check, "完了", "未完了")
            Else
                ' チェックだけを更新する
                sh.Cell(r, 3).Value = If(check, "完了", "未完了")
            End If
            ' 上書きで保存
            wb.Save()
        End Using
        MessageBox.Show("データを更新しました")
    End Sub
End Class
