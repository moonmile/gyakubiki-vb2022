Public Class Form1

    Private objMutex As System.Threading.Mutex

    Private Sub Form1_Load(sender As Object, e As EventArgs) _
        Handles MyBase.Load
        objMutex = New System.Threading.Mutex(False, "app433")
        If objMutex.WaitOne(0, False) = False Then
            MessageBox.Show("既にアプリケーションが起動しています")
            Me.Close()
        End If
    End Sub

    Private Sub Form1_FormClosed(
        sender As Object, e As FormClosedEventArgs) _
        Handles MyBase.FormClosed
        ' フォームを閉じるときにミューテックスを解放する
        objMutex.Close()
    End Sub
End Class
