Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ary1 = {"東京", "神奈川", "埼玉", "千葉", "茨城", "栃木", "群馬"}
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox3.Items.Clear()

        ListBox1.Items.AddRange(ary1)
        ' CopyToを使う
        Dim ary2(ary1.Length - 1) As String
        ary1.CopyTo(ary2, 0)
        ' Cloneを使う
        Dim ary3() As String = ary1.Clone()

        ListBox1.Items.AddRange(ary1)
        ListBox2.Items.AddRange(ary2)
        ListBox3.Items.AddRange(ary3)

    End Sub
End Class
