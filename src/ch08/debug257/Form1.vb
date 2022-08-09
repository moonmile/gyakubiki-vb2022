Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pa As New Person With {
            .Name = "マスダトモアキ",
            .Age = 50,
            .Address = "東京都板橋区"
        }
        Dim xml =
            <person>
                <Name>増田智明</Name>
                <Age>50</Age>
                <Address>板橋区</Address>
            </person>
        TextBox1.Text = xml.ToString()
    End Sub
End Class

Public Class Person
    Public Property Name As String
    Public Property Age As Integer
    Public Property Address As String
End Class

