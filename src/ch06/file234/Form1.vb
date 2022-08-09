Imports System.IO

Public Class Form1
    ''' <summary>
    ''' バイナリデータを書き出す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim path = TextBox1.Text
        ' 出力する8バイトのデータ
        Dim data = New Byte() {
            &H0, &H0, &H0, &H0,
            &HFF, &HFF, &HFF, &HFF
        }
        Using fs = File.OpenWrite(path)
            Using bw = New BinaryWriter(fs)
                bw.Write(data)
            End Using
        End Using
        MessageBox.Show("バイナリデータを書き込みました")
    End Sub

    ''' <summary>
    ''' バイナリデータを読み込む
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Path = TextBox1.Text
        Using fs = File.OpenRead(Path)
            Using br = New BinaryReader(fs)
                ' ファイルの長さだけ読み込む
                Dim count As Integer = fs.Length
                Dim data = br.ReadBytes(count)
                MessageBox.Show("バイナリデータを読み込みました" + vbCrLf +
                        BitConverter.ToString(data))
            End Using
        End Using
    End Sub
End Class
