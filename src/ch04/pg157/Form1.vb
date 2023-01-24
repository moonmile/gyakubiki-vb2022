Public Class Form1

    Sub Calc(ByRef nx As DateTime, ByRef prev As DateTime)
        ' 10年後と10年前を計算して参照で同時に返す
        nx = nx.AddYears(10)
        prev = prev.AddYears(-10)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' ref で渡す場合は、あらかじめ初期化しておく
        Dim nx = DateTime.Now
        Dim prev = DateTime.Now
        Calc(nx, prev)
        Label2.Text = $"10年後 : {nx}"
        Label3.Text = $"10年前 : {prev}"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' クラスを利用してプロパティで返す
        Dim dt As New CalcDate With
            {
                .PrevData = DateTime.Now,
                .NextData = DateTime.Now
            }
        calc2(dt)
        Label2.Text = $"10年後 : {dt.NextData}"
        Label3.Text = $"10年前 : {dt.PrevData}"

    End Sub

    Class CalcDate
        Public Property PrevData As DateTime
        Public Property NextData As DateTime
    End Class

    Sub calc2(dt As CalcDate)
        dt.NextData = dt.NextData.AddYears(10)
        dt.PrevData = dt.PrevData.AddYears(-10)
    End Sub
End Class
