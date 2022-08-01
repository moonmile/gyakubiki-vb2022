Public Class Form1

    Private slst1 As New List(Of String)() From {
        "東京", "神奈川", "埼玉", "千葉", "茨城", "栃木", "群馬"}
    Private slst2 As New List(Of String)()

    Private olst1 As New List(Of Prefecture)() From {
        New Prefecture With {.Code = "13", .Name = "東京"},
        New Prefecture With {.Code = "14", .Name = "神奈川"},
        New Prefecture With {.Code = "11", .Name = "埼玉"},
        New Prefecture With {.Code = "12", .Name = "千葉"},
        New Prefecture With {.Code = "08", .Name = "茨城"},
        New Prefecture With {.Code = "09", .Name = "栃木"},
        New Prefecture With {.Code = "10", .Name = "群馬"}
    }
    Private olst2 As New List(Of Prefecture)()

    ''' <summary>
    ''' 文字列を扱う場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(slst1.ToArray())
        slst2 = slst1.ToList()
        ListBox2.Items.AddRange(slst2.ToArray())

    End Sub

    ''' <summary>
    ''' コピー元の値を変更する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim index = slst1.FindIndex(
            Function(t)
                Return t = "東京"
            End Function
            )
        slst1(index) = "TOKYO"
        ' 内容を確認する
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(slst1.ToArray())
        ListBox2.Items.AddRange(slst2.ToArray())
        ' 新しいリストの場合は文字列がコピーされるので
        ' コピー先は変更されない
    End Sub

    ''' <summary>
    ''' クラス（オブジェクト）を扱う場合
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(olst1.ToArray())
        olst2 = olst1.ToList()
        ListBox2.Items.AddRange(olst2.ToArray())

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        ' コピー元の要素を変更する
        Dim index = olst1.FindIndex(
            Function(t)
                Return t.Name = "東京"
            End Function
        )
        olst1(index).Name = "TOKYO"
        ' 内容を確認する
        ListBox1.Items.Clear()
        ListBox2.Items.Clear()
        ListBox1.Items.AddRange(olst1.ToArray())
        ListBox2.Items.AddRange(olst2.ToArray())
        ' 要素となるオブジェクトを共有しているので、
        ' Nameプロパティの値が変わる
    End Sub
End Class

Public Class Prefecture
    Public Property Code As String
    Public Property Name As String
    Public Overrides Function ToString() As String
        Return $"{Code}: {Name}"
    End Function
End Class
