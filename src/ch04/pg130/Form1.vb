Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num = 0
        num = Integer.Parse(TextBox1.Text)

        Dim x = IIf(num < 0 Or num > 100, -1, num)
        ' 以下と同じ
        'Dim x = 0
        'If num < 0 Or num > 100 Then
        '    x = -1
        'Else
        '    x = num
        'End If

        Label2.Text = $"入力した数値は {num} です"
        Label3.Text = $"補正した数値は {x} です"

    End Sub
End Class
