Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Name = TextBox1.Text
        Dim pi = GetType(Sample).GetProperty(Name)
        If pi Is Nothing Then
            TextBox2.Text = "プロパティが見つかりません"
        Else
            Dim Text = $"
プロパティ名： {pi.Name}
型： {pi.PropertyType}
読み取り： {pi.CanRead}
書き込み： {pi.CanWrite}
"
            TextBox2.Text = Text
        End If
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
