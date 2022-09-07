Imports System.Reflection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' プロパティ一覧を取得する
        Dim pis = GetType(Sample).GetProperties()
        ListBox1.Items.Clear()
        For Each pi In pis
            ListBox1.Items.Add($"{pi.Name} : {pi.PropertyType}")
        Next
    End Sub
End Class

Public Class Sample
    Public Property Id As Integer
    Public Property Name As String
    Public Property Address As String
    ''' <summary>
    ''' プロパティの値を表示する
    ''' </summary>
    ''' <returns></returns>
    Public Function ShowData() As String
        Return $"{Id} : {Name} in {Address}"
    End Function
    ''' <summary>
    ''' 住所を変更する
    ''' </summary>
    ''' <param name="address"></param>
    Public Sub ChangeAddress(address As String)
        Me.Address = address
    End Sub
End Class


