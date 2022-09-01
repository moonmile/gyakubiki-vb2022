Imports System.Runtime.CompilerServices

Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ' 初回のみセッション情報に保存する
        If Session("ACCESS-DATE") Is Nothing Then
            Dim dt = DateTime.Now
            Session("ACCESS-DATE") = dt.ToString()
            ViewData("DATE") = dt
        Else
            Dim dt = DateTime.Parse(Session("ACCESS-DATE"))
            ViewData("DATE") = dt
        End If
        Return View()
    End Function

    Function About() As ActionResult
        ' ここでセッション情報を取得する
        Try
            Dim dt = DateTime.Parse(Session("ACCESS-DATE"))
            ViewData("DATE") = dt
        Catch
        End Try
        ViewData("Message") = "Your application description page."
        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
