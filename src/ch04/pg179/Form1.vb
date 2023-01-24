Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim p As New Person With {
            .Name = "マスダトモアキ",
            .Age = 53,
            .Address = "東京都"
        }
        Me.ShowPerson(p)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        Dim p As New SubPerson With {
            .Name = "マスダトモアキ",
            .Age = 53,
            .Address = "東京都"
        }
        Me.ShowPerson(p)
    End Sub

    Private Sub ShowPerson(p As Person)
        ' 呼び出し元が Person か SubPerson で結果が異なる
        label3.Text = $"{p.Name} ({p.Age}) in {p.Address}"
    End Sub
End Class

''' <summary>
''' Person.Age プロパティを継承元で書き換え
''' られないように継承不可にする
''' </summary>
' Public NotInheritable Class Person
Public Class Person
    Public Property Name As String = ""
    Public Property Age As Integer = 0
    Public Property Address As String = ""
End Class

Public Class SubPerson
    Inherits Person
    Public Property Age As Integer
        Get
            Return MyBase.Age
        End Get
        Set(value As Integer)
            MyBase.Age = value - 20 ' サバを読む
        End Set
    End Property
End Class
