Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim obj As New Sample("秀和太郎")
        Label3.Text = obj.ShowData()
        Label4.Text = obj.GetAtena("御中")
    End Sub
End Class

''' <summary>
''' Sample クラス
''' </summary>
Public Class Sample
    Private _id As String
    Private _name As String

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="name"></param>
    Public Sub New(name As String)
        _name = name
        _id = Guid.NewGuid().ToString()
    End Sub

    ''' <summary>
    ''' 宛名を取得
    ''' </summary>
    ''' <param name="post"></param>
    ''' <returns></returns>
    Public Function GetAtena(post As String) As String
        Return $"{_name} {post}"
    End Function

    ''' <summary>
    ''' 先頭の８文字のみ表示する
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowData() As String
        Return _name + " " + _id.Substring(0, 8) + "..."
    End Function

End Class
