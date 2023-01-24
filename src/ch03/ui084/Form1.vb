Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        TrackBar1.Minimum = 10
        TrackBar1.Maximum = 50
        TrackBar1.Value = 10
        TrackBar1.TickFrequency = 1
        TrackBar1.SmallChange = 1
        TrackBar1.LargeChange = 5
        Label1.Text = TrackBar1.Value.ToString()
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) _
        Handles TrackBar1.Scroll
        Label1.Text = TrackBar1.Value.ToString()
        Dim font = Label2.Font
        Label2.Font = New Font(font.FontFamily, TrackBar1.Value)
    End Sub
End Class
