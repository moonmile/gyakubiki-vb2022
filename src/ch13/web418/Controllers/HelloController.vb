Imports Microsoft.AspNetCore.Mvc

<Route("api/[controller]")>
<ApiController>
Public Class HelloController
    Inherits ControllerBase

    ' GET: api/Hello
    <HttpGet>
    Public Function GetHello() As String
        Return "Hello Visual Basic"
    End Function

End Class