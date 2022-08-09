Imports System
Imports Xunit

Namespace debug271
    Public Class UnitTest1
        ''' <summary>
        ''' 通常の初期化
        ''' </summary>
        <Fact>
        Sub Test1()
            Dim t = Target.CreatePoint(10, 10)
            Assert.NotNull(t)
            Assert.Equal(10, t.X)
            Assert.Equal(10, t.Y)
        End Sub

        ''' <summary>
        ''' 例外のチェック
        ''' </summary>
        <Fact>
        Sub Test2()
            Try

                Dim t = Target.CreatePoint(-1, -1)
            Catch ex As Exception
                Assert.Equal("例外発生", ex.Message)
                Return
            End Try
            ' 例外が発生しない場合、テストが失敗
            Assert.True(False)
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
            If x < 0 Or y < 0 Then
                ' 不正な値で初期化した場合は、例外を発生する
                Throw New ArgumentException("例外発生")
            End If
            Return New Target With {.X = x, .Y = y}
        End Function
    End Class

End Namespace

