Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label2.Text = ComboBox1.Text
        Select Case ComboBox1.Text
            Case "オレンジ"
                Label2.BackColor = Color.Orange
            Case "ブルー"
                Label2.BackColor = Color.Blue
            Case "イエロー"
                Label2.BackColor = Color.Yellow
            Case Else
                Label2.BackColor = Color.Empty
        End Select
    End Sub
End Class
