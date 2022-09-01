Imports System.Buffers.Text
Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.EntityFrameworkCore

<Route("api/[controller]")>
<ApiController>
Public Class BooksController
    Inherits ControllerBase

    <HttpPost("upload")>
    Public Function Upload(<FromBody> base64 As String) As ActionResult
        ' BASE64形式でデータを受信する
        Dim data = System.Convert.FromBase64String(base64)
        ' バイナリデータにコンバートする
        Dim Text = BitConverter.ToString(data)
        Return Ok(Text)
    End Function
End Class
