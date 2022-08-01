Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim a = ("masuda", 53, "Tokyo")
        label1.Text = a.ToString()
        Label5.Text = a.Item1
        Label6.Text = a.Item2.ToString()
        Label7.Text = a.Item3

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim a = (Name:="masuda", age:=53, address:="Tokyo")
        label1.Text = a.ToString()
        Label5.Text = a.name
        Label6.Text = a.age.ToString()
        Label7.Text = a.address
    End Sub
End Class
