Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
        RadioButton6.Checked = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text1 = ""
        Dim text2 = ""
        For Each btn As RadioButton In groupBox1.Controls
            If btn.Checked = True Then

                text1 = btn.Text
                Exit For
            End If
        Next
        For Each btn As RadioButton In groupBox2.Controls

            If btn.Checked = True Then

                text2 = btn.Text
                Exit For
            End If
        Next
        Label2.Text = $"年代:{text1}  性別:{text2}"
    End Sub
End Class
