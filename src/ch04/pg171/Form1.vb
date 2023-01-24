Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        ' インスタンスの生成と同時にプロパティに値を設定
        Dim obj As New Sample With {
            .Name = "マスダトモアキ",
            .Age = 53,
            .Address = "東京都"
            }
        Label4.Text = obj.Name
        Label5.Text = obj.Age.ToString()
        Label6.Text = obj.Address
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' コンストラクタを使って初期化
        Dim obj As New Sample(
            "マスダトモアキ", 53, "東京都")
        Label4.Text = obj.Name
        Label5.Text = obj.Age.ToString()
        Label6.Text = obj.Address
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) _
        Handles Button3.Click
        ' コンストラクタで変数名を指定する
        Dim obj As New Sample(
            name:="マスダトモアキ",
            age:=53,
            address:="東京都")
        Label4.Text = obj.Name
        Label5.Text = obj.Age.ToString()
        Label6.Text = obj.Address

    End Sub
End Class

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
