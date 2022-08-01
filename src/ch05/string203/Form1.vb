Public Class Form1
    Private lst As New List(Of String)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lst = New List(Of String)
        lst.Add("東京都")
        lst.Add("埼玉県")
        lst.Add("神奈川県")
        lst.Add("千葉県")
        lst.Add("茨城県")
        lst.Add("栃木県")
        lst.Add("群馬県")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        For Each it In lst
            ListBox1.Items.Add(it)
            ' 末尾が「県」であれば追加する
            If it.EndsWith("県") Then
                ListBox2.Items.Add(it)
            End If
        Next
    End Sub

End Class
