Imports System.Security.Policy
Imports System.Web.Mvc

Namespace Controllers
    Public Class BookController
        Inherits Controller
        ' GET: Book
        Function Index() As ActionResult
            Return View()
        End Function
    End Class
End Namespace