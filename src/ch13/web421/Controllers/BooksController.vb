Imports Microsoft.AspNetCore.Mvc
Imports Microsoft.EntityFrameworkCore

<Route("api/[controller]")>
<ApiController>
Public Class BooksController
    Inherits ControllerBase

    Private ReadOnly _context As ApplicationDbContext
    Public Sub New(context As ApplicationDbContext)
        _context = context
    End Sub

    ' GET: api/Books
    <HttpGet>
    Public Async Function GetBook() As Task(Of IEnumerable(Of Book))
        ' JOIN を利用する
        Dim items = Await _context.Book.Include("Author").
            Include("Publisher").
            OrderBy(Function(t) t.Id).
            ToListAsync()
        Return items
    End Function

    ' GET: api/Books/5
    <HttpGet("{id}")>
    Public Async Function GetBook(id As Integer) As Task(Of ActionResult(Of Book))
        Dim Book = Await _context.Book.FindAsync(id)

        If Book Is Nothing Then
            Return NotFound()
        End If
        Return Book
    End Function

    ' PUT api/Books/5
    <HttpPut("{id}")>
    Public Async Function PutBook(id As Integer, book As Book) As Task(Of IActionResult)
        If id <> book.Id Then
            Return BadRequest()
        End If
        _context.Entry(book).State = EntityState.Modified
        Try
            Await _context.SaveChangesAsync()
        Catch ex As DbUpdateConcurrencyException
            If Not BookExists(id) Then
                Return NotFound()
            Else
                Throw
            End If
        End Try
        Return NoContent()
    End Function

    ' POST: api/Books
    <HttpPost>
    Public Async Function PostBook(Book As Book) As Task(Of ActionResult(Of Book))
        _context.Book.Add(Book)
        Await _context.SaveChangesAsync()
        Return CreatedAtAction("GetBook", New With {.id = Book.Id}, Book)

    End Function

    ' DELETE: api/Books/5
    <HttpDelete("{id}")>
    Public Async Function DeleteBook(id As Integer) As Task(Of IActionResult)
        Dim Book = Await _context.Book.FindAsync(id)
        If Book Is Nothing Then
            Return NotFound()
        End If
        _context.Book.Remove(Book)
        Await _context.SaveChangesAsync()
        Return NoContent()
    End Function


    Private Function BookExists(id As Integer)
        Return _context.Book.Any(Function(e) e.Id = id)
    End Function
End Class
