Imports System
Imports Xunit

Namespace debug273
    Public Class UnitTest1
        <Fact>
        Sub Test1()
            Dim t As New Target()
            Dim ans = t.Add(10, 20)
            Assert.Equal(30, ans)
        End Sub
        <Fact>
        Sub Test2()
            Dim t As New Target()
            Dim ans = t.Add("マスダ", "トモアキ")
            Assert.Equal("マスダトモアキ", ans)
        End Sub
        <Fact>
        Sub Test3()
            Dim t = Target.CreatePoint(-1, -1)
            Assert.Null(t)
            t = Target.CreatePoint(10, 20)
            Assert.NotNull(t)
            Assert.Equal(10, t.X)
            Assert.Equal(20, t.Y)
        End Sub
    End Class

    Public Class Target
        Public Function Add(x As Integer, y As Integer) As Integer
            Return x + y
        End Function
        Public Function Add(x As String, y As String) As String
            Return x + y
        End Function

        Public Property X As Integer
        Public Property Y As Integer
        Public Shared Function CreatePoint(x As Integer, y As Integer) As Target
            If x <= 0 Or y <= 0 Then Return Nothing
            Return New Target With {.X = x, .Y = y}
        End Function
    End Class

End Namespace

