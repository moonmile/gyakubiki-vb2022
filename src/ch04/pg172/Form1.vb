Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' 基本クラスの利用
        Dim obj As New Sample With {
            .Name = "マスダトモアキ",
            .Age = 53,
            .Address = "東京都"
            }
        Label4.Text = obj.Name
        Label5.Text = obj.Age.ToString()
        Label6.Text = obj.Address
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim obj As New SubSample With {
            .Name = "マスダトモアキ",
            .Age = 53,
            .Address = "東京都",
            .Telephone = "090-XXXX-XXXX"
            }
        Label4.Text = obj.Name
        Label5.Text = obj.Age.ToString()
        Label6.Text = obj.Address
        Label7.Text = obj.Telephone

    End Sub
End Class

''' <summary>
''' Sample クラス
''' </summary>
Public Class Sample
    Public Property Name As String = ""
    Public Property Age As Integer = 0
    Public Property Address As String = ""

    ''' <summary>
    ''' デフォルトコンストラクタ
    ''' </summary>
    Public Sub New()

    End Sub

    ''' <summary>
    ''' 初期化付きコンストラクタ
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="age"></param>
    ''' <param name="address"></param>
    Public Sub New(name As String, age As Integer, address As String)
        Me.Name = name
        Me.Age = age
        Me.Address = address
    End Sub
End Class

''' <summary>
''' 派生クラス
''' </summary>
Public Class SubSample
    Inherits Sample

    Public Property Telephone As String = ""

    Public Sub New()

    End Sub

    Public Sub New(
        name As String,
        age As Integer,
        address As String,
        telephone As String)

        Me.Name = name
        Me.Age = age
        Me.Address = address
        Me.Telephone = telephone
    End Sub
End Class
