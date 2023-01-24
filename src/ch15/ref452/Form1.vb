Imports System.Reflection

Public Class Form1
    Private _obj As New Sample With {
        .Id = 100,
        .Name = "増田智明",
        .Address = "板橋区"
        }

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        TextBox1.Text = MyInvoke(_obj, "privateShowData", New Object())
    End Sub

    Private Function MyInvoke(Of T)(target As T, name As String, value As Object, ParamArray args As Object())

        Dim tt = GetType(T)
        Dim mi = tt.GetTypeInfo().GetDeclaredMethod(name)
        Return mi.Invoke(target, args)
    End Function

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

    Private Function privateShowData() As String
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
