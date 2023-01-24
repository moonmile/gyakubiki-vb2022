Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim items = {
                "PowerPoint", "Word", "Excel", "Access"
        }

        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()
        ' ソート前
        ListBox1.Items.AddRange(items)
        ' 昇順でソート
        Array.Sort(items)
        ListBox2.Items.AddRange(items)
        ' 降順でソート
        Array.Reverse(items)
        ListBox3.Items.AddRange(items)
    End Sub
End Class
