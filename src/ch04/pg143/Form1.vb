Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst As New List(Of String)() From {
                "東京", "神奈川", "埼玉", "千葉", "茨城", "栃木", "群馬"
            }

        Label3.Text = lst.First() ' lst(0) でも良い
        Label4.Text = lst.Count.ToString()
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())

    End Sub
End Class
