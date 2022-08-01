Public Class Form1

    Function checkTest(result As Boolean, ParamArray kamoku As String())
        If result = True Then
            Return "合格"
        Else
            Dim gouhi = "追試 -> "
            For Each it In kamoku
                gouhi += $"{it} ,"
            Next
            Return gouhi
        End If
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 最初の引数のみ指定
        Label4.Text = checkTest(True)
        ' ２番目の引数を指定
        Label5.Text = checkTest(False, "国語")
        ' ２番目の引数を３つ指定
        Label6.Text = checkTest(False, "国語", "数学", "情報")
    End Sub
End Class
