Public Class Form1
    ''' <summary>
    ''' JSON形式で書き出す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim person As New Person With
            {
                .Id = 100,
                .Name = "マスダトモアキ",
                .Age = 53,
                .Address = "東京都"
            }

        Dim path = TextBox1.Text
        Dim json = System.Text.Json.JsonSerializer.Serialize(person)
        System.IO.File.WriteAllText(path, json)
        MessageBox.Show("JSON形式で書き出しました")
    End Sub

    ''' <summary>
    ''' JSON形式の読み込み
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim path = TextBox1.Text
        Dim json = System.IO.File.ReadAllText(path)
        Dim person = System.Text.Json.JsonSerializer.Deserialize(Of Person)(json)
        MessageBox.Show("JSON形式を読み込みました" + vbCrLf +
                $"Name: {person?.Name}" + vbCrLf +
                $"Address: {person?.Address}")
    End Sub
End Class

Public Class Person
    Public Property Id As Integer
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class

