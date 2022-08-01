Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim o As New Sample With {
                .Name = "マスダトモアキ",
                .Age = 53,
                .Address = "東京都"
            }
        ' 通常のメソッド
        Label4.Text = o.ShowData()
        ' 拡張メソッド
        Label5.Text = o.ToJson()

        Dim Name = "マスダトモアキ"
        Label6.Text = Name.ToKanma()
    End Sub
End Class

''' <summary>
''' サンプルクラス
''' </summary>
Public Class Sample
    Public Property Name As String = ""
    Public Property Age As Integer = 0
    Public Property Address As String = ""

    Public Function ShowData() As String
        Return $"{Name} ({Age}) {Address}"
    End Function
End Class

Module SampleEx
    <Extension()>
    Public Function ToJson(o As Sample)
        Return $"{{ name: ""{o.Name}"", age: {o.Age}, addresss: ""{o.Address}"""
    End Function
End Module

Module StringEx
    <Extension()>
    Public Function ToKanma(o As String)
        Return String.Join(",", o.ToArray())
    End Function
End Module
