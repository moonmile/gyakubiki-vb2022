Public Class Form1

    Private Data As New ModifiedValue(Of String)()

    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim names = {"増田智明", "ますだともあき", "マスダトモアキ"}
        Data.Value = names(Random.Shared.Next(names.Length))
        Label3.Text = $"{Data.Value} {Data.Modified.ToString()}"

    End Sub

    Private Name1 = "マスダ"
    Private Name2 = "トモアキ"

    Private Sub Button2_Click(sender As Object, e As EventArgs) _
        Handles Button2.Click
        ' 値を交換する
        Swap(Name1, Name2)
        Label4.Text = $"{Name1} <=> {Name2}"
    End Sub


    ''' <summary>
    ''' ジェネリックを使ったクラスの例
    ''' 値を更新した時刻を保持する
    ''' 
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    Public Class ModifiedValue(Of T)
        Private _value As T           ' 型指定できるフィールド
        Private _modified As DateTime ' 更新日時

        Public Property Value As T
            Get
                Return _value
            End Get
            Set(value As T)
                _value = value
                _modified = DateTime.Now
            End Set
        End Property
        Public ReadOnly Property Modified As DateTime
            Get
                Return _modified
            End Get
        End Property

    End Class

    ''' <summary>
    ''' ジェネリックを使った関数の例
    ''' 値を交換する
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="a"></param>
    ''' <param name="b"></param>
    Private Sub Swap(Of T)(ByRef a As T, ByRef b As T)
        Dim temp As T = a
        a = b
        b = temp
    End Sub

End Class

