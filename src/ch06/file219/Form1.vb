Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fname1 = TextBox1.Text

        If System.IO.File.Exists(fname1) = False Then
            Label4.Text = "コピー元のファイルがありません"
            Return
        End If

        ' 最初のコピー先を作成
        Dim fname2 =
                System.IO.Path.GetDirectoryName(fname1) + "\" +
                System.IO.Path.GetFileNameWithoutExtension(fname1) +
                " - コピー" +
                System.IO.Path.GetExtension(fname1)

        Dim n = 1
        While System.IO.File.Exists(fname2) = True
            n += 1
            fname2 =
                    System.IO.Path.GetDirectoryName(fname1) + "\" +
                    System.IO.Path.GetFileNameWithoutExtension(fname1)
            System.IO.Path.GetExtension(fname1)
        End While
        System.IO.File.Copy(fname1, fname2)
        Label4.Text = $"{fname2} にコピーしました"
    End Sub
End Class
