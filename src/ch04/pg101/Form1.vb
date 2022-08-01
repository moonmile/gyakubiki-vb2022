Public Class Form1

    ' クラス内の定数
    Const APPLI = "Visual Basic 2022 逆引き大全"
    Const TIPS = 500

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' メソッド内の定数
        Const STR = "の極意"

        Label1.Text = APPLI + " " + TIPS.ToString() + STR
        Label2.Text = $"{APPLI} {TIPS}{STR}"

    End Sub
End Class
