﻿Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim obj = makeStruct("ますだともあき", 54, "いたばしく")
        Label2.Text = obj.ToString()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim obj = makeClass("増田智明", 54, "板橋区")
        Label2.Text = obj.ToString()
    End Sub

    ''' <summary>
    ''' 構造体を返す関数
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="age"></param>
    ''' <param name="address"></param>
    ''' <returns></returns>
    Function makeStruct(name As String, age As Integer, address As String) _
        As SampleStruct
        Dim obj As SampleStruct
        obj.Name = name
        obj.Age = age
        obj.Address = address
        Return obj
    End Function

    ''' <summary>
    ''' クラスを返す関数
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="age"></param>
    ''' <param name="address"></param>
    ''' <returns></returns>
    Function makeClass(name As String, age As Integer, address As String) _
        As SampleClass
        Dim obj As New SampleClass
        obj.Name = name
        obj.Age = age
        obj.Address = address
        Return obj
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
