Public Class MainViewModel

    Public Property Items As New List(Of Card)
    Public Sub New()
        Items = New List(Of Card)
        Items.Add(New Card With {.ImageUrl = "cock.jpg", .Name = "Cooking", .Location = "Japan"})
        Items.Add(New Card With {.ImageUrl = "book.jpg", .Name = "Book Boy", .Location = "Japan"})
        Items.Add(New Card With {.ImageUrl = "dotnet_bot.svg", .Name = ".NET", .Location = "USA"})
    End Sub
End Class

Public Class Card
    Public Property ImageUrl As String
    Public Property Name As String
    Public Property Location As String
End Class