Imports System.Net
Imports System.Reflection

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Dim model = New SampleModel() With
        {
            .Name = "マスダトモアキ",
            .Address = "東京都板橋区"
        }
        Return View(model)
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
