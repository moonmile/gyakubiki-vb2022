Imports System
Imports Xunit

Namespace debug271
    Public Class UnitTest1
        ''' <summary>
        ''' �ʏ�̏�����
        ''' </summary>
        <Fact>
        Sub Test1()
            Dim t = Target.CreatePoint(10, 10)
            Assert.NotNull(t)
            Assert.Equal(10, t.X)
            Assert.Equal(10, t.Y)
        End Sub

        ''' <summary>
        ''' ��O�̃`�F�b�N
        ''' </summary>
        <Fact>
        Sub Test2()
            Try

                Dim t = Target.CreatePoint(-1, -1)
            Catch ex As Exception
                Assert.Equal("��O����", ex.Message)
                Return
            End Try
            ' ��O���������Ȃ��ꍇ�A�e�X�g�����s
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
                ' �s���Ȓl�ŏ����������ꍇ�́A��O�𔭐�����
                Throw New ArgumentException("��O����")
            End If
            Return New Target With {.X = x, .Y = y}
        End Function
    End Class

End Namespace

