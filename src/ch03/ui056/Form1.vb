Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = ""
        If RadioButton1.Checked = True Then
            Text = "商品A"
        End If
        If RadioButton2.Checked = True Then
            Text = "商品B"
        End If
        If RadioButton3.Checked = True Then
            Text = "商品C"
        End If
        Label1.Text = $"{Text} が選択されました"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        RadioButton1.Checked = True
        Label1.Text = ""
    End Sub
End Class
