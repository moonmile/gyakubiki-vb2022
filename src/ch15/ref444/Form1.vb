Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Name = TextBox1.Text
        Dim mi = GetType(Sample).GetMethod(Name)
        If mi Is Nothing Then
            TextBox2.Text = "メソッドが見つかりませんでした"
        Else
            Dim Text = $"
メソッド名： {mi.Name}
引数の数： {mi.GetParameters().Length}
戻り値の型： {mi.ReturnType}
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

