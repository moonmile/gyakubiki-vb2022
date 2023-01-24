Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim lst As New List(Of Person)()

        lst.Add(New Person With {
                .Name = "増田智明", .Age = 53, .Address = "東京都"})
        lst.Add(New Person With {
                .Name = "秀和太郎", .Age = 30, .Address = "大阪府"})
        lst.Add(New Person With {
                .Name = "秀和次郎", .Age = 25, .Address = "北海道"})
        lst.Add(New Person With {
                .Name = "秀和三郎", .Age = 20, .Address = "福岡県"})

        ListBox1.Items.Clear()
        ListBox1.Items.AddRange(lst.ToArray())

    End Sub
End Class

''' <summary>
''' クラスを分割して編集する
''' </summary>
Partial Public Class Person
    Private Shared _seed As Integer = 0
    Private _id As Integer
    Public ReadOnly Property Id As Integer
        Get
            Return _id
        End Get
    End Property

    Public Sub New()
        _seed += 1
        _id = _seed
    End Sub

    Public Overrides Function ToString() As String
        Return $"{Id}: {Name} ({Age}) in {Address}"
    End Function

End Class