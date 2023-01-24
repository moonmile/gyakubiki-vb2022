Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        _dt1 = DateTime.Today
        Label3.Text = _dt1.ToLongDateString()
        AddHandler MonthCalendar1.DateChanged,
            Sub()
                _dt2 = MonthCalendar1.SelectionStart
                Label4.Text = _dt2.ToLongDateString()
            End Sub
    End Sub

    Private _dt1 As DateTime
    Private _dt2 As DateTime

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim span = _dt2.Subtract(_dt1)
        Label5.Text = $"{span.Days} 日間"
    End Sub

End Class
