Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer = 100
        Dim x As Long = i       ' 暗黙の型変換

        Dim d As Double = 123.456
        Label3.Text = d.ToString()
        Dim n = CType(d, Integer)  ' キャスト（桁落ちする）    
        Label4.Text = n.ToString()

        Dim o As Object = i       ' オブジェクト型にキャスト
        o = "Visual Basic 2022"   ' オブジェクト型の文字列を入れる

        Dim str1 As String = DirectCast(o, String)  ' 強制的に文字列にキャスト
        Dim str2 As String = TryCast(o, String)     ' 安全に型変換する

    End Sub
End Class
