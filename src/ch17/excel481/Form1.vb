Public Class Form1
    ''' <summary>
    ''' Microsoft Excel Object Library の利用
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim xapp = New Microsoft.Office.Interop.Excel.Application()
        xapp.Quit()
    End Sub

    ''' <summary>
    ''' ClosedXML の利用
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Using wb = New ClosedXML.Excel.XLWorkbook()
            Dim Sheet = wb.Worksheets.Add("sample")
        End Using
    End Sub
End Class

