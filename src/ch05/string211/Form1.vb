Imports System.Text

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim text = TextBox1.Text
        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance)
        Dim unicode = Encoding.Unicode.GetBytes(text)
        Dim sjis = Encoding.GetEncoding("shift_jis").GetBytes(text)
        Dim utf8 = Encoding.UTF8.GetBytes(text)

        Label4.Text = BitConverter.ToString(unicode)
        Label5.Text = BitConverter.ToString(sjis)
        Label6.Text = BitConverter.ToString(utf8)


        For Each en In Encoding.GetEncodings()
            System.Diagnostics.Debug.WriteLine(en.Name)
        Next

    End Sub
End Class
