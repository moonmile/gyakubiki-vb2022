Imports System.Net.Sockets
Imports System.Security.Claims
Imports System.Text.Encodings.Web
Imports Microsoft.AspNetCore.Authentication
Imports Microsoft.AspNetCore.DataProtection.KeyManagement
Imports Microsoft.Extensions.Logging
Imports Microsoft.Extensions.Options

Public Class MyAuthHandler
    Inherits AuthenticationHandler(Of AuthenticationSchemeOptions)

    Public Sub New(options As IOptionsMonitor(Of AuthenticationSchemeOptions), logger As ILoggerFactory, encoder As UrlEncoder, clock As ISystemClock)
        MyBase.New(options, logger, encoder, clock)
    End Sub

    Protected Overrides Function HandleAuthenticateAsync() As Task(Of AuthenticateResult)
        Dim apikey = Context.Request.Headers("X-API-KEY").ToString()
        If apikey = "XXXX-XXXX-XXXX" Then
            Dim ticket As New AuthenticationTicket(
                New ClaimsPrincipal(
                New ClaimsIdentity(
                {New Claim("name", "admin")}, "authtype")),
                "xapi")
            Return Task.FromResult(Of AuthenticateResult)(AuthenticateResult.Success(ticket))
        Else
            Return Task.FromResult(AuthenticateResult.Fail("Invalid API Key"))
        End If
    End Function
End Class
