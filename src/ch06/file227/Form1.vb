Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' ドキュメント
        Label5.Text = System.Environment.
            GetFolderPath(Environment.SpecialFolder.MyDocuments)
        ' デスクトップ
        Label6.Text = System.Environment.
            GetFolderPath(Environment.SpecialFolder.Desktop)
        ' ピクチャ
        Label7.Text = System.Environment.
            GetFolderPath(Environment.SpecialFolder.MyPictures)
        ' ビデオ
        Label8.Text = System.Environment.
            GetFolderPath(Environment.SpecialFolder.MyVideos)
        ' アプリケーションデータ
        Label9.Text = System.Environment.
            GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
    End Sub
End Class
