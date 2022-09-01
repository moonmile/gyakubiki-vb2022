Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function

    ''' <summary>
    ''' 追加したビューを表示する
    ''' </summary>
    ''' <returns></returns>
    Function Index2() As ActionResult
        Return View()
    End Function


End Class
