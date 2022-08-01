Public Class Form1
    ''' <summary>
    ''' 引数で構造体を渡す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim obj As SampleStruct
        obj.Name = "マスダトモアキ"
        obj.Age = 53
        obj.Address = "東京都"
        Label2.Text = ShowStruct(obj)
    End Sub

    ''' <summary>
    ''' 引数でクラスを渡す
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj As New SampleClass()
        obj.Name = "マスダトモアキ"
        obj.Age = 53
        obj.Address = "東京都"
        Label2.Text = ShowClass(obj)
    End Sub

    ''' <summary>
    ''' 構造体を受け取る
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    Function ShowStruct(obj As SampleStruct)
        Return obj.ToString()
    End Function

    ''' <summary>
    ''' クラスを受け取る
    ''' </summary>
    ''' <param name="obj"></param>
    ''' <returns></returns>
    Function ShowClass(obj As SampleClass)
        Return obj.ToString()
    End Function
End Class

''' <summary>
''' 構造体の定義
''' </summary>
Public Structure SampleStruct
    Public Name As String
    Public Age As Integer
    Public Address As String
    Public Overrides Function ToString() As String
        Return $"構造体：{Name} ({Age}) in {Address}"
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
        Return $"クラス：{Name} ({Age}) in {Address}"
    End Function
End Class

