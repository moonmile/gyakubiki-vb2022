Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' 14日間選択できる
        MonthCalendar1.MaxSelectionCount = 14
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim startDay = MonthCalendar1.SelectionStart
        Dim endDay = MonthCalendar1.SelectionEnd
        Dim days = endDay.Subtract(startDay).Days + 1

        Label4.Text = startDay.ToLongDateString()
        Label5.Text = endDay.ToLongDateString()
        Label6.Text = $"{days}日間"
    End Sub
End Class
