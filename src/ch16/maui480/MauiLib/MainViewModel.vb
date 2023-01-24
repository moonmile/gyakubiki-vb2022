Imports System.Runtime.CompilerServices
Imports Microsoft.Maui.Devices.Sensors
Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _latitude As Single
    Private _longitude As Single
    Private _altitude As Single

    Public Property Latitude As Single
        Get
            Return _latitude
        End Get
        Set(value As Single)
            SetProperty(_latitude, value, NameOf(Latitude))
        End Set
    End Property
    Public Property Longitude As Single
        Get
            Return _longitude
        End Get
        Set(value As Single)
            SetProperty(_longitude, value, NameOf(Longitude))
        End Set
    End Property
    Public Property Altitude As Single
        Get
            Return _altitude
        End Get
        Set(value As Single)
            SetProperty(_altitude, value, NameOf(Altitude))
        End Set
    End Property



    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        OnClickedCommand = New DelegateCommand(
            Async Sub()
                Dim request = New GeolocationRequest(GeolocationAccuracy.Medium, TimeSpan.FromSeconds(10))
                Dim loc = Await Geolocation.Default.GetLocationAsync(request)
                Me.Latitude = loc.Latitude
                Me.Longitude = loc.Longitude
                Me.Altitude = loc.Altitude
            End Sub)
    End Sub
End Class
