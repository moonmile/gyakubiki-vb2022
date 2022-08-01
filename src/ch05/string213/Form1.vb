Imports System.Text.RegularExpressions

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Text = TextBox1.Text
        ' 全角数字を半角数字に変換
        Dim Replace = Regex.Replace(Text, "[０-９]",
                New MatchEvaluator(
                Function(t)
                    Select Case t.Value
                        Case "０" : Return "0"
                        Case "１" : Return "1"
                        Case "２" : Return "2"
                        Case "３" : Return "3"
                        Case "４" : Return "4"
                        Case "５" : Return "5"
                        Case "６" : Return "6"
                        Case "７" : Return "7"
                        Case "８" : Return "8"
                        Case "９" : Return "9"
                        Case Else : Return t.Value
                    End Select
                End Function
            ))
        ' 長音やマイナスを削除
        Label4.Text = Regex.Replace(Replace, "[ーー-]", "")
    End Sub
End Class
