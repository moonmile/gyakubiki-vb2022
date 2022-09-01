Imports System.Security.Policy
Imports System.Web.Mvc

Namespace Controllers
    Public Class PersonController
        Inherits Controller
        ' GET: Book
        Function Index() As ActionResult
            ' 空モデルをビューに渡す
            Return View(New Person)
        End Function

        <HttpPost>
        Function Post(person As Person) As ActionResult
            ViewBag.ErrorMessage = ""
            If String.IsNullOrEmpty(person.Name) Or
                 String.IsNullOrEmpty(person.Telephone) Then
                ViewBag.ErrorMessage = "名前と電話番号の両方を入力してください"
                Return View("Index", person)
            Else
                ' 結果のページを表示
                Return View("Result", person)
            End If
        End Function
    End Class
End Namespace