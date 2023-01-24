Public Class Form1

    ''' <summary>
    ''' 数値を返すメソッド
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    ''' <summary>
    ''' 文字列を返すメソッド
    ''' </summary>
    ''' <param name="s1"></param>
    ''' <param name="s2"></param>
    ''' <returns></returns>
    Function calc(x As Integer, y As Integer) As String
        Return $"{x} と {y} を足すと {x + y} になります"
    End Function

    Function makePerson(name As String, age As Integer, address As String) As Person
        Dim p = New Person
        p.Name = name
        p.Age = age
        p.Address = address
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x = 10
        Dim y = 20
        Dim v = add(x, y)
        Label4.Text = v.ToString()

        Dim s = calc(x, y)
        Label5.Text = s

        Dim p = makePerson("ますだともあき", 53, "TOKYO")
    End Sub
End Class

Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class
