Imports System
Imports System.Collections.Generic
Imports System.Data
Imports System.Data.Entity
Imports System.Linq
Imports System.Net
Imports System.Web
Imports System.Web.Mvc
Imports web412

Namespace Controllers
    Public Class BooksController
        Inherits System.Web.Mvc.Controller

        Private db As New Model1

        ' GET: Books
        Function Index() As ActionResult
            Dim book = db.Book.Include(Function(b) b.Author).Include(Function(b) b.Publisher)
            Return View(book.ToList())
        End Function

        ' GET: Books/Details/5
        Function Details(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = db.Book.
                Include("Author").
                Include("Publisher").
                Where(Function(m) m.Id = id).
                FirstOrDefault()
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' GET: Books/Create
        Function Create() As ActionResult
            ViewBag.AuthorId = New SelectList(db.Author, "Id", "Name")
            ViewBag.PublisherId = New SelectList(db.Publisher, "Id", "Name")
            Return View()
        End Function

        ' POST: Books/Create
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Create(<Bind(Include:="Id,Title,AuthorId,PublisherId,Price")> ByVal book As Book) As ActionResult
            If ModelState.IsValid Then
                db.Book.Add(book)
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.AuthorId = New SelectList(db.Author, "Id", "Name", book.AuthorId)
            ViewBag.PublisherId = New SelectList(db.Publisher, "Id", "Name", book.PublisherId)
            Return View(book)
        End Function

        ' GET: Books/Edit/5
        Function Edit(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = db.Book.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            ViewBag.AuthorId = New SelectList(db.Author, "Id", "Name", book.AuthorId)
            ViewBag.PublisherId = New SelectList(db.Publisher, "Id", "Name", book.PublisherId)
            Return View(book)
        End Function

        ' POST: Books/Edit/5
        '過多ポスティング攻撃を防止するには、バインド先とする特定のプロパティを有効にしてください。
        '詳細については、https://go.microsoft.com/fwlink/?LinkId=317598 をご覧ください。
        <HttpPost()>
        <ValidateAntiForgeryToken()>
        Function Edit(<Bind(Include:="Id,Title,AuthorId,PublisherId,Price")> ByVal book As Book) As ActionResult
            If ModelState.IsValid Then
                db.Entry(book).State = EntityState.Modified
                db.SaveChanges()
                Return RedirectToAction("Index")
            End If
            ViewBag.AuthorId = New SelectList(db.Author, "Id", "Name", book.AuthorId)
            ViewBag.PublisherId = New SelectList(db.Publisher, "Id", "Name", book.PublisherId)
            Return View(book)
        End Function

        ' GET: Books/Delete/5
        Function Delete(ByVal id As Integer?) As ActionResult
            If IsNothing(id) Then
                Return New HttpStatusCodeResult(HttpStatusCode.BadRequest)
            End If
            Dim book As Book = db.Book.Find(id)
            If IsNothing(book) Then
                Return HttpNotFound()
            End If
            Return View(book)
        End Function

        ' POST: Books/Delete/5
        <HttpPost()>
        <ActionName("Delete")>
        <ValidateAntiForgeryToken()>
        Function DeleteConfirmed(ByVal id As Integer) As ActionResult
            Dim book As Book = db.Book.Find(id)
            db.Book.Remove(book)
            db.SaveChanges()
            Return RedirectToAction("Index")
        End Function

        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If (disposing) Then
                db.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub
    End Class
End Namespace
