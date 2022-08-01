Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Items.AddRange({
                "檸檬 🍋", "葡萄 🍇", "林檎 🍎", "メロン 🍈"
            })
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex = -1 Then
            Label1.Text = "項目が選択されていません"
        Else
            Label1.Text = ComboBox1.SelectedItem
        End If
    End Sub
End Class
