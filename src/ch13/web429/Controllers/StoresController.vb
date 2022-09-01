Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.EntityFrameworkCore

<Route("api/[controller]")>
<ApiController>
Public Class StoresController
    Inherits ControllerBase

    Private ReadOnly _context As ApplicationDbContext
    Public Sub New(context As ApplicationDbContext)
        _context = context
    End Sub

    <HttpGet("{id}")>
    Public Function GetItem(id As Integer?) As ActionResult
        If id Is Nothing Then
            Return NotFound()
        End If
        Dim store = _context.Store.FirstOrDefault(Function(m) m.Id = id)
        If store Is Nothing Then
            Return NotFound()
        End If
        Return Ok(store)
    End Function

    <HttpPost("{id}")>
    Public Function Edit(id As Integer, <FromBody> store As Store) As ActionResult
        If id <> store.Id Then
            Return NotFound()
        End If
        ' 更新日時をチェックする
        Dim item = _context.Store.FirstOrDefault(Function(m) m.Id = id)
        If item Is Nothing Then
            Return NotFound()
        End If
        If item.UpdatedAt <> store.UpdatedAt Then
            ' 更新日時が異なる場合
            Return BadRequest()
        End If
        item.UpdatedAt = DateTime.Now
        item.Stock = store.Stock
        _context.Store.Update(item)
        _context.SaveChanges()
        Return Ok()
    End Function

End Class
