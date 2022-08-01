Public Class Form1
    ''' <summary>
    ''' 列挙型を定義する
    ''' </summary>
    Enum Rank
        Special
        Standard
        Basic
    End Enum

    Function checkRank(n As Integer) As Rank
        If n >= 80 Then Return Rank.Special
        If n >= 60 Then Return Rank.Standard
        Return Rank.Basic
    End Function


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n = Integer.Parse(TextBox1.Text)
        Dim result = checkRank(n)
        Label3.Text = result.ToString()
        Label4.Text = DirectCast(result, Integer).ToString()
    End Sub
End Class
