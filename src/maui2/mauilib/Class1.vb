Imports Microsoft.Maui.Devices.Sensors

Public Class AccelerometerVb

    Public Sub Initialize()
		AddHandler Accelerometer.ReadingChanged, AddressOf Accelerometer_ReadingChanged
		Accelerometer.Start(New SensorSpeed())

    End Sub

	Private Sub Accelerometer_ReadingChanged(sender As Object, e As AccelerometerChangedEventArgs)
		Dim x As Single = e.Reading.Acceleration.X
		Dim y As Single = e.Reading.Acceleration.Y
		Dim z As Single = e.Reading.Acceleration.Z


		'' this.labelX.Text = $"X: {x:0.000}"
		'' this.labelY.Text = $"Y: {y:0.000}"
		'' this.labelZ.Text = $"Z: {z:0.000}"
	End Sub

End Class
