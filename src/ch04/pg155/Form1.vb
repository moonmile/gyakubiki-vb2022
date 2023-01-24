Public Class Form1

    ' Cupオブジェクトの作成
    Private _cup As New Cup

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        _cup.add(20)
        Label2.Text = $"Value is {_cup.Value}"
    End Sub
End Class

Public Class Cup
    Private _value As Integer = 0      ' 内容量
    Private Const MAX As Integer = 100 ' 最大値

    ''' <summary>
    ''' 内容量を増やすメソッド
    ''' </summary>
    ''' <param name="x"></param>
    Public Sub add(x As Integer)
        _value += x
        If _value > MAX Then
            _value = MAX
        End If
        ' 戻り値はない
    End Sub

    Public ReadOnly Property Value As Integer
        Get
            Return _value
        End Get
    End Property
End Class
