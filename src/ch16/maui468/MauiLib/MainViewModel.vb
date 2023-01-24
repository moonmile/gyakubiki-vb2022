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
                RaiseEvent DisplayAlert("�I��", value.Name, "OK")
            End If
        End Set
    End Property
    Public Event DisplayAlert As Action(Of String, String, String)


    Public Sub New()
        Items = New List(Of Data)
        Items.Add(New Data With {.Id = 1, .Name = "�u���[���X�F�ԑt�ȂQ��"})
        Items.Add(New Data With {.Id = 2, .Name = "�o�b�n�F�����[�g�g�ȁ@��S��"})
        Items.Add(New Data With {.Id = 3, .Name = "�^���X�}���F�J���@�e�B�[�i�g�Ȃ��"})
        Items.Add(New Data With {.Id = 4, .Name = "���m�b�N�X�E�o�[�N���[�F�M�^�[�̂��߂̃\�i�`�l���"})
        Items.Add(New Data With {.Id = 5, .Name = "���B���E���{�X�F12�̗��K�Ȃ��"})
        Items.Add(New Data With {.Id = 6, .Name = "�h�r���b�V�[�F���̌��`�x���K�}�X�N�g�Ȃ��"})
    End Sub


End Class

Public Class Data
    Public Property Id As Integer
    Public Property Name As String
End Class
