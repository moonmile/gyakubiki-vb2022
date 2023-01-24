Public Class Form1

    Function changeArray(arg As String()) As String()
        ' 配列内の文字列をすべて大文字に変換する
        Dim result(arg.Length - 1) As String
        For i = 0 To arg.Length - 1
            result(i) = arg(i).ToUpper()
        Next
        Return result
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim ary = {
                "microsoft",
                "apple",
                "ibm",
                "oracle",
                "shuwasystem"
            }
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(ary)
        Dim resullt = changeArray(ary)
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(resullt)
    End Sub

    Function changeList(lst As List(Of String)) As List(Of String)
        ' リスト内の文字列をすべて大文字に変換する
        Dim result As New List(Of String)
        For Each it In lst
            result.Add(it.ToUpper())
        Next
        Return result
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim lst As New List(Of String) From {
                    "orange",
                    "apple",
                    "raspberry",
                    "nano",
                    "banana"
            }
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())
        Dim resullt = changeList(lst)
        ListBox2.Items.Clear()
        ListBox2.Items.AddRange(resullt.ToArray())

    End Sub
End Class
