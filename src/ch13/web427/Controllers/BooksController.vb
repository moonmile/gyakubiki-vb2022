Imports Microsoft.AspNetCore.Mvc

''' <summary>
''' ルーティングを変更する
''' </summary>
<Route("Books")>
<ApiController>
Public Class BooksController
    Inherits ControllerBase

    ''' <summary>
    ''' Hello という文字列を返す
    ''' </summary>
    ''' <returns></returns>
    <HttpGet("hello")>
    Public Function hello() As ActionResult
        Return Ok("hello")
    End Function

    ''' <summary>
    ''' 2つの数字を加算する
    ''' </summary>
    ''' <returns></returns>
    <HttpGet("add/{x}/{y}")>
    Public Function add(x As Integer, y As Integer) As ActionResult
        Return Ok(x + y)
    End Function
End Class
