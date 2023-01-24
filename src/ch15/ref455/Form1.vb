Imports System.Reflection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        ' プロパティの属性を取得する
        For Each pi In GetType(Sample).GetProperties()
            Dim attr = pi.GetCustomAttribute(Of MyCustomAttribute)()
            ListBox1.Items.Add($"{pi.Name} {attr?.Name} {attr?.Description}")
        Next
    End Sub
End Class

' <summary>
' カスタム属性
' </summary>
Public Class MyCustomAttribute
    Inherits Attribute
    Public Property Name As String
    Public Property Description As String
End Class

Public Class Sample
    <MyCustom(Name:="識別子", Description:="オブジェクトを一意に識別する")>
    Public Property Id As Integer
    <MyCustom(Name:="名前", Description:="名前を日本語で記述します")>
    Public Property Name As String
    <MyCustom(Name:="住所", Description:="住所を日本語で記述します")>
    Public Property Address As String
    Public Function ShowData() As String
        Return $"{Id} : {Name} in {Address}"
    End Function
End Class



