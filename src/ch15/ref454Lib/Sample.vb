Public Class Sample
    Public Property Id As Integer
    Public Property Name As String
    Public Property Address As String
    Public Function ShowData() As String
        Return $"{Id} : {Name} in {Address}"
    End Function
End Class
