Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.ImeMode = ImeMode.Alpha
        TextBox2.ImeMode = ImeMode.On
        ' フォーカスがあったときに強制的に半角モードにする
        AddHandler TextBox1.GotFocus,
            Sub()
                TextBox1.ImeMode = ImeMode.Alpha
            End Sub
    End Sub
End Class
