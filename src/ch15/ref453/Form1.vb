Imports System.Reflection
Imports System.Runtime.Intrinsics

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim asm = Assembly.GetExecutingAssembly()
        Dim obj = asm.CreateInstance("ref453.Sample")
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

Public Class Sample
    Public Property Id As Integer
    Public Property Name As String
    Public Property Address As String
    Public Function ShowData() As String
        Return $"{Id} : {Name} in {Address}"
    End Function
End Class

