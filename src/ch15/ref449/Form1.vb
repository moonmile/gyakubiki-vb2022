﻿Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Reflection

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ListBox1.Items.Clear()
        ' プロパティの属性を取得する
        For Each pi In GetType(Sample).GetProperties()
            Dim attr = pi.GetCustomAttribute(Of DisplayNameAttribute)()
            ListBox1.Items.Add($"{pi.Name} {attr?.DisplayName}")
        Next

    End Sub
End Class

<Table("サンプルクラス")> ' この属性を取得
Public Class Sample
    <Key>
    <DisplayNameAttribute("識別子")>
    Public Property Id As Integer
    <DisplayNameAttribute("名前")>
    Public Property Name As String
    <DisplayNameAttribute("住所")>
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

