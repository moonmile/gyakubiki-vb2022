Imports System
Imports Xunit

Namespace debug269
    Public Class UnitTest1
        <Fact>
        Sub Test1()
            Dim t As New Target
            Dim ans = t.Add(10, 20)
            Assert.Equal(30, ans)
        End Sub
        <Fact>
        Sub Test2()
            Dim t As New Target
            Dim ans = t.Add("マスダ", "トモアキ")
            Assert.Equal("マスダトモアキ", ans)
        End Sub
    End Class

    Public Class Target
        Public Function Add(x As Integer, y As Integer) As Integer
            Return x + y
        End Function
        Public Function Add(x As String, y As String) As String
            Return x + y
        End Function
    End Class

End Namespace



