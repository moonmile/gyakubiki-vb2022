Imports System.IO
Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        Using sw = New System.IO.StreamWriter(path)

            sw.WriteLine("逆引き大全 VIsual Basic 2022の極意")
            sw.WriteLine($"日付: {DateTime.Now}")
        End Using
        MessageBox.Show("ファイルを作成しました")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' シフトJISの場合は、プロバイダを登録する
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        Dim path = TextBox1.Text
        Using sw = New StreamWriter(
                path,
                False,
                Encoding.GetEncoding("shift_jis")))
                sw.WriteLine("逆引き大全 Visual Basic 2022の極意")
            sw.WriteLine($"日付: {DateTime.Now}")
            sw.WriteLine("シフトJISコードで保存されています")
        End Using
        MessageBox.Show("シフトJISでファイルを作成しました")
    End Sub
End Class
