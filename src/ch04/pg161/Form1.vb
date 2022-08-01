Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AddHandler Button1.Click,
            Sub()
                Label2.Text = "ラムダ式で実行しました"
            End Sub
        AddHandler Button2.Click, AddressOf Button2_Click
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs)
        Label2.Text = "イベントで実行しました"
    End Sub

End Class
