Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim Text = TextBox1.Text
        Dim coll = Regex.Matches(Text, "\w+[都道府県][,]*")
        ListBox1.Items.Clear()
        For Each it As Match In coll
            ListBox1.Items.Add(it.Value.Replace(",", ""))
        Next
    End Sub
End Class
