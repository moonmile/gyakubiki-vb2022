Imports System
Imports Xunit

Namespace debug268
    Public Class UnitTest1
        <Fact>
        Sub TestSub()
            Dim t As New Target
            Dim ans = t.Add(10, 20)
            Assert.Equal(30, ans)
        End Sub
    End Class
End Namespace

Public Class Target
    Public Function Add(x As Integer, y As Integer) As Integer
        Return x + y
    End Function
End Class


