Public Class Form1

    ''' <summary>
    ''' 参照渡しで足し算と掛け算の答えを同時に返す
    ''' </summary>
    ''' <param name="x"></param>
    ''' <param name="y"></param>
    ''' <param name="ans1"></param>
    ''' <param name="ans2"></param>
    Private Sub Calc(x As Integer, y As Integer, ByRef ans1 As Integer, ByRef ans2 As Integer)
        ans1 = x + y
        ans2 = x * y
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim x = 10
        Dim y = 20
        Dim ans1 As Integer, ans2 As Integer
        ' 計算する
        Calc(x, y, ans1, ans2)
        Label2.Text = $"ans1 = {ans1}"
        Label3.Text = $"ans2 = {ans2}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim x = 10
        Dim y = 20
        Dim o As New Calc()
        ' 計算する
        o.Go(x, y)
        Label2.Text = $"o.ans1 = {o.Ans1}"
        Label3.Text = $"o.ans2 = {o.Ans2}"

    End Sub
End Class

Public Class Calc
    Public Property Ans1 As Integer
    Public Property Ans2 As Integer
    Public Sub Go(x As Integer, y As Integer)
        ' 戻り値はプロパティで返す
        Me.Ans1 = x + y
        Me.Ans2 = x * y
    End Sub
End Class
