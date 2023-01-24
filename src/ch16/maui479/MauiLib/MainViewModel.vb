Imports Microsoft.Maui.Devices.Sensors
Imports Prism.Commands

Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _x As Single = 0.0
    Private _y As Single = 0.0
    Private _z As Single = 0.0

    Public Property X As Single
        Get
            Return _x
        End Get
        Set(value As Single)
            SetProperty(_x, value, NameOf(X))
        End Set
    End Property
    Public Property Y As Single
        Get
            Return _y
        End Get
        Set(value As Single)
            SetProperty(_y, value, NameOf(Y))
        End Set
    End Property
    Public Property Z As Single
        Get
            Return _z
        End Get
        Set(value As Single)
            SetProperty(_z, value, NameOf(Z))
        End Set
    End Property

    Public Property OnClickedCommand As DelegateCommand
    Public Sub New()
        AddHandler Accelerometer.ReadingChanged,
            Sub(s, e)
                Me.X = e.Reading.Acceleration.X
                Me.Y = e.Reading.Acceleration.Y
                Me.Z = e.Reading.Acceleration.Z
            End Sub
        OnClickedCommand = New DelegateCommand(
            Sub()
                Accelerometer.Start(New SensorSpeed())
            End Sub)
    End Sub
End Class
