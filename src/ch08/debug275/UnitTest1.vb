Imports System
Imports Xunit

Namespace debug275
    Public Class UnitTest1
        Implements IDisposable

        Const _path = "test.txt"

        ''' <summary>
        ''' テスト前の初期化を行う
        ''' </summary>
        Public Sub New()
            System.IO.File.WriteAllText(_path, "10,20")
        End Sub
        ''' <summary>
        ''' 後処理を実行する
        ''' </summary>
        Public Sub Dispose() Implements IDisposable.Dispose
            System.IO.File.Delete(_path)
        End Sub
        <Fact>
        Sub Test1()
            Dim text = System.IO.File.ReadAllText(_path)
            Dim lst = text.Split(",")
            Dim a = Integer.Parse(lst(0))
            Dim b = Integer.Parse(lst(1))
            Dim t As New Target()
            Dim ans = t.Add(a, b)
            Assert.Equal(30, ans)

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

