Public Class Form1
    ''' <summary>
    ''' 構造体の利用
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As SampleStruct
        obj.Name = "マスダトモアキ"
        obj.Age = 53
        obj.Address = "板橋区"
        Label2.Text = obj.ToString()
    End Sub

    ''' <summary>
    ''' クラスの利用
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj As New SampleClass()
        obj.Name = "増田智明"
        obj.Age = 53
        obj.Address = "東京都"
        Label2.Text = obj.ToString()
    End Sub
End Class

''' <summary>
''' 構造体の定義
''' </summary>
Public Structure SampleStruct
    Public Name As String
    Public Age As Integer
    Public Address As String
    Public Overrides Function ToString() As String
        Return $"{Name} ({Age}) in {Address}"
    End Function
End Structure

''' <summary>
''' クラスの定義
''' </summary>
Public Class SampleClass
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
    Public Overrides Function ToString() As String
        Return $"{Name} ({Age}) in {Address}"
    End Function
End Class
