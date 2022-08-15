Imports System.Reflection

Public Class PersonControl

    Public Sub New()

        ' この呼び出しはデザイナーで必要です。
        InitializeComponent()

        ' InitializeComponent() 呼び出しの後で初期化を追加します。
        AddHandler textName.TextChanged,
            Sub()
                _person.Name = textName.Text
            End Sub
        AddHandler textAge.TextChanged,
            Sub()
                _person.Age = Integer.Parse(textAge.Text)
            End Sub
        AddHandler textAddress.TextChanged,
            Sub()
                _person.Address = textAddress.Text
            End Sub
    End Sub

    ' <summary>
    ' 依存プロパティの定義
    ' </summary>
    Public Shared ReadOnly ItemProperty As DependencyProperty =
        DependencyProperty.Register(
                "Item",
                GetType(Person),
                GetType(PersonControl),
                New FrameworkPropertyMetadata(
                    Nothing,
                    FrameworkPropertyMetadataOptions.BindsTwoWayByDefault,
                    New PropertyChangedCallback(
                    Sub(o, e)
                        Dim uc As PersonControl = o
                        If Not uc Is Nothing Then

                            If Not e.NewValue Is Nothing Then
                                Dim pa As Person = e.NewValue
                                If Not pa Is Nothing Then

                                    uc._person = pa
                                    uc.textId.Text = pa.Id.ToString()
                                    uc.textName.Text = pa.Name
                                    uc.textAge.Text = pa.Age.ToString()
                                    uc.textAddress.Text = pa.Address
                                End If
                            End If
                        End If
                    End Sub)))


    Private Property _person As New Person
    Public Property Item As Person
        Get
            Return _person
        End Get
        Set(value As Person)
            Me.SetValue(ItemProperty, value)
        End Set
    End Property

End Class
