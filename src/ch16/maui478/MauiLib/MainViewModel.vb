Imports Microsoft.Maui.ApplicationModel
Imports Prism.Commands

Public Class MainViewModel


    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Async Sub()
                Dim url = "https://www.shuwasystem.co.jp/"
                Await Browser.OpenAsync(url)
            End Sub)
    End Sub

End Class
