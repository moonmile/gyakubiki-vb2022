Imports System.IO
Imports System.Runtime.CompilerServices
Imports Microsoft.Maui.Media
Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _message As String = ""
    Public Property Message As String
        Get
            Return _message
        End Get
        Set(value As String)
            SetProperty(_message, value, NameOf(Message))
        End Set
    End Property

    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Async Sub()
                If MediaPicker.Default.IsCaptureSupported Then
                    Dim photo = Await MediaPicker.Default.CapturePhotoAsync()

                    If photo IsNot Nothing Then
                        Dim filename = Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), photo.FileName)
                        Using st = Await photo.OpenReadAsync()
                            Using fs = File.OpenWrite(filename)
                                Await st.CopyToAsync(fs)
                                Me.Message = "ŽB‰e‚µ‚Ü‚µ‚½ " + DateTime.Now.ToString()
                            End Using
                        End Using
                    End If
                End If
            End Sub)
    End Sub
End Class
