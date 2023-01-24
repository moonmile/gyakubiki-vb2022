Public Class Form1
    Sub New()
        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()
        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler Me.Load,
            Sub()
                TextBox1.Text = _obj.Name
            End Sub
    End Sub

    Private _obj As New Sample With {
        .Id = 100,
        .Name = "マスダトモアキ",
        .Address = "板橋区"
    }

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' リフレクションで設定
        Dim pi = GetType(Sample).GetProperty("Name")
        Dim value As String = pi?.GetValue(_obj)
        TextBox2.Text = value
    End Sub
End Class

Public Class Sample
    Public Property Id As Integer
    Public Property Name As String
    Public Property Address As String
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

