Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname = TextBox1.Text
        If System.IO.File.Exists(fname) = False Then
            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        Using sr = New System.IO.StreamReader(fname)
            MessageBox.Show("読み込み専用でファイルを開きました")
        End Using
        ' あるいは以下のように Close メソッドを使う
        ' Dim sr = new System.IO.StreamReader(fname)
        ' sr.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim fname = TextBox1.Text
        If System.IO.File.Exists(fname) = False Then
            MessageBox.Show("ファイルが見つかりません")
            Return
        End If
        Using sw = New System.IO.StreamWriter(fname)
            MessageBox.Show("書き出し専用でファイルを開きました")
        End Using
        ' あるいは以下のように Close メソッドを使う
        ' Dim sw = new System.IO.StreamWriter(fname)
        ' sw.Close()
    End Sub
End Class
