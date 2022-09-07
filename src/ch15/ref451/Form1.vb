Imports System.Reflection

Public Class Form1
    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Load,
            Sub()
                TextBox1.Text = _obj.hiddenData
            End Sub

    End Sub

    Private _obj As New Sample With {
        .Id = 100,
        .Name = "増田智明",
        .Address = "板橋区"
        }
    ' .hiddenData = "初期値"  ' private プロパティに設定できない

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' プロパティがpriavteのため設定できない
        ' _obj.hiddenData = "初期値";
        ' リフレクションを使って設定する
        SetPrivateProperty(_obj, "hiddenData", "初期値")
        ' 変更後を参照する
        TextBox2.Text = _obj.hiddenData
    End Sub
    Private Sub SetPrivateProperty(Of T)(target As T, name As String, value As Object, ParamArray args As Object())
        Dim tt As Type = GetType(T)
        Dim pi = tt.GetTypeInfo().GetDeclaredProperty(name)
        pi.SetValue(target, Convert.ChangeType(value, pi.PropertyType), args)

    End Sub

End Class

Public Class Sample
    Public Property Id As Integer
    Public Property Name As String
    Public Property Address As String
    Private _hiddenData As String = "initial value"
    Public Property hiddenData As String
        Get
            Return _hiddenData
        End Get
        Private Set(value As String)
            _hiddenData = value
        End Set
    End Property
    ''' <summary>
    ''' プロパティの値を表示する
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowData() As String
        Return $"{Id} : {Name} in {Address}"
    End Function
    ''' <summary>
    ''' 住所を変更する
    ''' </summary>
    ''' <param name="address"></param>
    Public Sub ChangeAddress(address As String)
        Me.Address = address
    End Sub
End Class

