Public Class Form1
    Private list As New List(Of Sample)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' オブジェクトを生成して追加する
        Dim obj As New Sample() With {.Value = "新規生成"}
        list.Add(obj)
        ' 内容を確認
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(list.ToArray())
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' カウンタをリセットして追加
        Sample.Reset()
        Dim obj As New Sample With {.Value = "リセット"}
        list.Add(obj)
        ' 内容を確認
        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(list.ToArray())
    End Sub
End Class

Public Class Sample
    Public Shared _uniqid = 0   ' クラスに固有な値
    Private _id As Integer = 0
    Private _value As String = ""
    Private _created As DateTime

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    Public Sub New()
        _uniqid += 1
        _id = _uniqid
        _created = DateTime.Now
    End Sub

    Public ReadOnly Property ID As Integer
        Get
            Return _id
        End Get
    End Property
    Public Property Value As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return $"{_id} : {_value} : {_created}"
    End Function

    ''' <summary>
    ''' IDをリセットする
    ''' </summary>
    Public Shared Sub Reset()
        _uniqid = 0
    End Sub
End Class