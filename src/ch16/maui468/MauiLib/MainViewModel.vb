Public Class MainViewModel
    Inherits Prism.Mvvm.BindableBase

    Public Property Items As List(Of Data)
    Private _selectedItem As Data
    Public Property SelectedItem As Data
        Get
            Return _selectedItem
        End Get
        Set(value As Data)
            If value IsNot Nothing Then
                SetProperty(_selectedItem, value,
            NameOf(SelectedItem))
                RaiseEvent DisplayAlert("選択", value.Name, "OK")
            End If
        End Set
    End Property
    Public Event DisplayAlert As Action(Of String, String, String)


    Public Sub New()
        Items = New List(Of Data)
        Items.Add(New Data With {.Id = 1, .Name = "ブラームス：間奏曲２番"})
        Items.Add(New Data With {.Id = 2, .Name = "バッハ：リュート組曲　第４番"})
        Items.Add(New Data With {.Id = 3, .Name = "タンスマン：カヴァティーナ組曲より"})
        Items.Add(New Data With {.Id = 4, .Name = "レノックス・バークリー：ギターのためのソナチネより"})
        Items.Add(New Data With {.Id = 5, .Name = "ヴィラ・ロボス：12の練習曲より"})
        Items.Add(New Data With {.Id = 6, .Name = "ドビュッシー：月の光～ベルガマスク組曲より"})
    End Sub


End Class

Public Class Data
    Public Property Id As Integer
    Public Property Name As String
End Class
