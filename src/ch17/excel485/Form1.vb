Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click

        Dim title = TextBox1.Text
        Dim stock = Integer.Parse(TextBox2.Text)

        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim r = 2
            While sh.Cell(r, 1).GetString() <> ""
                ' 書名を調べる
                If sh.Cell(r, 2).GetString() = title Then
                    ' 在庫数を書き込む
                    sh.Cell(r, 4).Value = stock
                End If
                r += 1
            End While
            wb.Save()
        End Using
        MessageBox.Show("在庫数を更新しました")

    End Sub
End Class

Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property Price As Integer
    Public Property Stock As Integer
End Class


