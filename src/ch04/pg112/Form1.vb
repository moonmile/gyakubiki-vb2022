Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim person = ("マスダトモアキ", 53, "東京")
        Label5.Text = person.Item1
        Label6.Text = person.Item2
        Label7.Text = person.Item3
        Label1.Text = SampleA.ToString(person)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim person = ("マスダトモアキ", 53, "東京")
        Label5.Text = person.Item1
        Label6.Text = person.Item2
        Label7.Text = person.Item3
        Label1.Text = SampleB.ToString(person)
    End Sub
End Class


Module SampleA
    Function ToString(p As (String, Integer, String))
        Return $"名前:{p.Item1} 年齢:{p.Item2} 住所:{p.Item3}"
    End Function
End Module
Module SampleB
    Function ToString(p As (name As String, age As Integer, address As String))
        Return $"Name:{p.name} Age:{p.age} Address:{p.address}"
    End Function
End Module
