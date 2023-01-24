Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Private _imageHeight As Single = 310.0
    Private _sliderValue As Single = 310.0
    Private _labelText As String = ""

    Public Property LabelText As String
        Get
            Return _labelText
        End Get
        Set(value As String)
            SetProperty(_labelText, value, NameOf(LabelText))
        End Set
    End Property
    Public Property ImageHeight As Single
        Get
            Return _imageHeight
        End Get
        Set(value As Single)
            SetProperty(_imageHeight, value, NameOf(ImageHeight))
        End Set
    End Property
    Public Property SliderValue As Single
        Get
            Return _sliderValue
        End Get
        Set(value As Single)
            SetProperty(_sliderValue, value, NameOf(SliderValue))
            Me.ImageHeight = value
            Me.LabelText = $"{ImageHeight:0.00}"
        End Set
    End Property
End Class
