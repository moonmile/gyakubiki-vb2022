Public Class Form1

    ''' <summary>
    ''' 数値を受け取るメソッド
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    ''' <summary>
    ''' 文字列を受け取るメソッド
    ''' </summary>
    ''' <param name="s1"></param>
    ''' <param name="s2"></param>
    ''' <returns></returns>
    Function append(s1 As String, s2 As String) As String
        Return $"{s1} {s2} 様宛"
    End Function

    Function makeStr(p As Person) As String
        Return $"{p.Name} ({p.Age}) in {p.Address}"
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x = 10
        Dim y = 20
        Dim ans = add(x, y)
        Label4.Text = ans.ToString()

        Dim s1 = "Mausda"
        Dim s2 = "Tomoaki"
        Dim s3 = append(s1, s2)
        Label5.Text = s3

        Dim p As New Person() With {
        .Name = "マスダトモアキ",
                .Age = 53,
                .Address = "東京都"
            }
        Dim text = makeStr(p)
        Label6.Text = text

    End Sub
End Class

Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class
