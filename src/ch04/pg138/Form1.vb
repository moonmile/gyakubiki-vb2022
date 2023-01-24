Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary1(100) As Integer
        Dim ary2(10, 20) As Integer

        label1.Text = $"ary1 の要素数は {ary1.Length}"
        Dim text = $"ary2 の要素数は {ary2.Length} " + vbCrLf +
                 $"1つめの次元の要素数は {ary2.GetLength(0)}" + vbCrLf +
                 $"2つめの次元の要素数は {ary2.GetLength(1)}" + vbCrLf
        Label2.Text = text
    End Sub
End Class
