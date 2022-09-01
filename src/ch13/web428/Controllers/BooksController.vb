Imports Microsoft.AspNetCore.Mvc

<Route("api/[controller]")>
<ApiController>
Public Class BooksController
    Inherits ControllerBase

    Public Function hello() As HelloResujlt
        Dim apikey = Me.Response.Headers("X-API-KEY")
        If apikey.FirstOrDefault() <> "TEST-SERVER" Then
            Return New HelloResujlt With {
                .ErrorMesssage = "apikey error."
            }
        Else
            Return New HelloResujlt With {
                .Id = 1,
                .Name = "masuda",
                .ErrorMesssage = ""
            }
        End If
    End Function
End Class

Public Class HelloResujlt
    Public Property Id As Integer
    Public Property Name As String
    Public Property ErrorMesssage As String
End Class
