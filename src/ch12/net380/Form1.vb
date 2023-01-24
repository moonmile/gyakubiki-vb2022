Imports System.Net.Http

Public Class Form1
    Private Async Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim client As New HttpClient()
        Try
            ' 指定URLのファイルをダウンロードする
            Dim Data = Await client.GetByteArrayAsync(
                    "http://localhost:5000/api/Gyakubiki/donwload/1")
            Dim fs = System.IO.File.OpenWrite("sample-download.zip")
            fs.Write(Data, 0, Data.Length)
            fs.Close()
            MessageBox.Show("ダウンロードが完了しました")
        Catch ex As Exception
            ' URLが不正の場合は例外が発生する
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
