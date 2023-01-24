Imports System.Runtime.Intrinsics

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' あらかじめ dll をコピーしておく
        Dim asm = System.Reflection.Assembly.LoadFrom("ref454Lib.dll")
        Dim obj = asm.CreateInstance("ref454Lib.Sample")
        If Not obj Is Nothing Then
            ' プロパティを設定
            obj.Id = 100
            obj.Name = "増田智明"
            obj.Address = "東京都板橋区"
            ' メソッドの呼び出し
            TextBox1.Text = obj.ShowData()
        Else
            TextBox1.Text = "インスタンスを生成できません"
        End If
    End Sub
End Class
