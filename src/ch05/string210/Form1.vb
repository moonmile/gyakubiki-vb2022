Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst As New List(Of String) From {
                    "東京都",
                    "北海道",
                    "大阪府",
                    "福岡県"
            }
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
        ' 連結する
        Label3.Text = String.Join("★", lst)
    End Sub
End Class
