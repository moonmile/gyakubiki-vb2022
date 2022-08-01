Public Class Form1
    Private _obj As Sample

    ''' <summary>
    ''' インスタンスの生成
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        _obj = New Sample(TextBox1.Text)
        Label3.Text = _obj.Id
    End Sub

    ''' <summary>
    ''' 名前を変更する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If _obj Is Nothing Then Return
        _obj.Name = TextBox1.Text
        ' _obj.Id = "xxxxxx"    '' Id プロパティは変更できない
        Label3.Text = _obj.Id
    End Sub
End Class

Public Class Sample
    Private _id As String
    Private _name As String

    Public Sub New(name As String)
        _name = name
        _id = Guid.NewGuid().ToString()
    End Sub

    ''' <summary>
    ''' 読み取り専用のプロパティ
    ''' </summary>
    ''' <returns></returns>
    Public ReadOnly Property Id As String
        Get
            Return _id
        End Get
    End Property

    ''' <summary>
    ''' 読み書きできるプロパティ
    ''' </summary>
    ''' <returns></returns>
    Public Property Name As String
        Get
            Return _name
        End Get
        Set(value As String)
            _name = value
        End Set
    End Property


End Class