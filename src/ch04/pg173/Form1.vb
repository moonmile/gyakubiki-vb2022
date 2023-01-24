Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim obj As New Sample With {
                .Name = "秀和太郎",
                .Age = 30,
                .Address = "東京都"
            }
        Label3.Text = obj.Name
        Label4.Text = obj.ShowData()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim obj As New SubSample With {
                .Name = "秀和太郎",
                .Age = 30,
                .Address = "東京都"
            }
        Label3.Text = obj.Name
        Label4.Text = obj.ShowData()

    End Sub
End Class


''' <summary>
''' 基本クラス
''' </summary>
Public Class Sample
    Public Property Name As String = ""
    Public Property Age As Integer = 0
    Public Property Address As String = ""

    Public Overridable Function ShowData() As String
        Return $"{Name} ({Age}) {Address}"
    End Function
End Class

''' <summary>
''' 派生クラス
''' </summary>
Public Class SubSample
    Inherits Sample

    Public Overrides Function ShowData() As String
        Return $"{Name}様 {Age}歳 住所（{Address})"
    End Function
End Class