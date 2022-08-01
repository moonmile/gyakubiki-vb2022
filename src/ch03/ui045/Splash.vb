Public Class Splash
    Private Sub Splash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim timer1 As New Timer
        timer1.Interval = 3000
        AddHandler timer1.Tick,
            Sub()
                Me.Close()
            End Sub
        timer1.Start()
    End Sub
End Class