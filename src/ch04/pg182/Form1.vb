Public Class Form1
    ''' <summary>
    ''' 配列を利用する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim ary = New Sample() {
            New Sample With {.Id = 100, .Name = "増田智明", .Address = "東京都"},
            New Sample With {.Id = 101, .Name = "秀和太郎", .Address = "大阪府"},
            New Sample With {.Id = 102, .Name = "秀和次郎", .Address = "北海道"},
            New Sample With {.Id = 103, .Name = "秀和三郎", .Address = "福岡県"}
        }
        ListBox1.Items.Clear()
        For Each item In ary
            ListBox1.Items.Add(item)
        Next
    End Sub

    ''' <summary>
    ''' コレクションを利用する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim ary = New List(Of Sample) From {
                New Sample With {.Id = 200, .Name = "マスダトモアキ", .Address = "東京都"},
                New Sample With {.Id = 201, .Name = "シュウワタロウ", .Address = "大阪府"},
                New Sample With {.Id = 202, .Name = "シュウワジロウ", .Address = "北海道"},
                New Sample With {.Id = 203, .Name = "シュウワサブロウ", .Address = "福岡県"}
        }
        ListBox1.Items.Clear()
        For Each item In ary
            ListBox1.Items.Add(item)
        Next
    End Sub
End Class

''' <summary>
''' 構造体の定義
''' </summary>
Public Structure Sample
    Public Id As Integer
    Public Name As String
    Public Address As String
    Public Overrides Function ToString() As String
        Return $"{Id}: {Name} in {Address}"
    End Function
End Structure
