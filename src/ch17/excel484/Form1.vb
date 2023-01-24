Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim path = "sample.xlsx"
        Using wb = New ClosedXML.Excel.XLWorkbook(path)
            Dim sh = wb.Worksheets.First()
            Dim items As New List(Of Book)
            Dim r = 2
            While sh.Cell(r, 1).GetString() <> ""
                Dim book As New Book With {
                    .Id = sh.Cell(r, 1).GetValue(Of Integer)(),
                    .Title = sh.Cell(r, 2).GetValue(Of String)(),
                    .Price = sh.Cell(r, 3).GetValue(Of Integer)()
                    }
                items.Add(book)
                r += 1
            End While
            DataGridView1.DataSource = items
        End Using
    End Sub
End Class

Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property Price As Integer
End Class


