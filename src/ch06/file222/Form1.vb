Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim asm = System.Reflection.Assembly.GetExecutingAssembly()
        Dim path = System.IO.Path.GetDirectoryName(asm.Location)
        Label2.Text = path
    End Sub
End Class
