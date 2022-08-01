Public Class Form1
    ''' <summary>
    ''' 2つの数値を加算する
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function

    ''' <summary>
    ''' 2つの文字列を連結する
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <returns></returns>
    Function add(x As String, y As String) As String
        Return x + " " + y
    End Function

    ''' <summary>
    ''' 指定回数繰り返す
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="n"></param>
    ''' <returns></returns>
    Function add(x As String, n As Integer) As String
        Dim result = ""
        For i = 0 To n - 1
            result += x + " "
        Next
        Return result
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label4.Text = add(10, 20).ToString()
        Label5.Text = add("masdua", "tomoaki")
        Label6.Text = add("ABC", 5)

    End Sub
End Class
