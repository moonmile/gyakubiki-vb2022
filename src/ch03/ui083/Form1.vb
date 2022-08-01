Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NumericUpDown1.Minimum = 0
        NumericUpDown1.Maximum = 100
        NumericUpDown1.Value = 50
        NumericUpDown1.Increment = 10
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' decimal型をint型にキャストする
        Dim num As Integer = NumericUpDown1.Value
        Label1.Text = $"入力した数値は {num} です"
    End Sub
End Class
