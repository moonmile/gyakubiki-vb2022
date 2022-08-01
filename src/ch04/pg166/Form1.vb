Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New Sample(TextBox1.Text)
        Label3.Text = o.Id
    End Sub
End Class

Public Class Sample
    Private _id As String
    Private _name As String

    ''' <summary>
    ''' コンストラクタ
    ''' </summary>
    ''' <param name="name"></param>
    Sub New(name As String)
        _name = name
        _id = Guid.NewGuid.ToString()
    End Sub

    ' 読み取り用のプロパティ
    Public ReadOnly Property Name As String
        Get
            Return _name
        End Get
    End Property
    Public ReadOnly Property Id As String
        Get
            Return _id
        End Get
    End Property
End Class
