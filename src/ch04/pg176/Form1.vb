Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim lst As New List(Of Integer) From {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10}
        Dim sum = lst.Sum()
        Label4.Text = sum.ToString()
        Dim items = lst.Where(
        Function(t) As Boolean
            Return t Mod 3 = 0
        End Function
        ).ToList()
        Label5.Text = items.Count.ToString()
        Label6.Text =
        String.Join(",", items.Select(
            Function(t) As String
                Return t.ToString()
            End Function))
    End Sub
End Class
