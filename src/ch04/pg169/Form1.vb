Public Class Form1

    Private _obj As Sample

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        _obj = New Sample("秀和太郎")
        ' イベントハンドラを追加する
        AddHandler _obj.OnChangedName, AddressOf _obj_OnChangedName
        Label3.Text = _obj.Name
        Label4.Text = ""
    End Sub

    Private Sub _obj_OnChangedName(time As DateTime)
        Label3.Text = _obj.Name
        Label4.Text = $"Name を変更した {time}"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' イベントを発生させる
        _obj.Name = "秀和次郎"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' イベントを削除する
        RemoveHandler _obj.OnChangedName, AddressOf _obj_OnChangedName
    End Sub

End Class

Public Class Sample
    Private _name As String
    Private _modified As DateTime

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="name"></param>
    Public Sub New(name As String)
        _name = name
    End Sub

    ''' <summary>
    ''' イベントの定義
    ''' </summary>
    Public Event OnChangedName As Action(Of DateTime)

    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
            _modified = DateTime.Now
            ' イベントを発生させる
            RaiseEvent OnChangedName(_modified)
        End Set
    End Property
End Class
