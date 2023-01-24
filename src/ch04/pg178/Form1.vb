Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RadioButton1.Checked = True
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton1.CheckedChanged
        label3.Text = "縦"
        label4.Text = "横"
        TextBox4.Visible = True
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton2.CheckedChanged
        label3.Text = "高さ"
        label4.Text = "底辺"
        TextBox4.Visible = True
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) _
        Handles RadioButton3.CheckedChanged
        label3.Text = "半径"
        label4.Text = ""
        TextBox4.Visible = False
    End Sub

    ''' <summary>
    ''' 面積を計算する
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) _
        Handles Button1.Click
        Dim shape As IShape
        If RadioButton1.Checked = True Then
            shape = New Square() With {
                .Height = Integer.Parse(TextBox3.Text),
                .Width = Integer.Parse(TextBox4.Text)
            }
        ElseIf RadioButton2.Checked = True Then
            shape = New Triangle() With {
               .Height = Integer.Parse(TextBox3.Text),
               .Width = Integer.Parse(TextBox4.Text)
            }
        ElseIf RadioButton3.Checked = True Then
            shape = New Circle() With {
                .Radius = Integer.Parse(TextBox3.Text)
            }
        Else
            Return
        End If
        ' X座標とY座標はまとめて設定できる
        shape.X = Integer.Parse(TextBox1.Text)
        shape.Y = Integer.Parse(TextBox2.Text)
        ' 面積を計算する
        Label6.Text = shape.Area.ToString("0.00")

    End Sub

End Class


Public Interface IShape
    Property X As Integer   ' X 座標
    Property Y As Integer   ' Y 座標
    ReadOnly Property Area As Double ' 面積
End Interface

Public Class Triangle
    Implements IShape

    Private _x As Integer
    Private _y As Integer
    Private _width As Integer
    Private _height As Integer

    Public Property X As Integer Implements IShape.X
        Get
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property

    Public Property Y As Integer Implements IShape.Y
        Get
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return _width
        End Get
        Set(value As Integer)
            _width = value
        End Set
    End Property
    Public Property Height As Integer
        Get
            Return _height
        End Get
        Set(value As Integer)
            _height = value
        End Set
    End Property

    Public ReadOnly Property Area As Double Implements IShape.Area
        Get
            Return _width * _height / 2.0
        End Get
    End Property
End Class


Public Class Square
    Implements IShape

    Private _x As Integer
    Private _y As Integer
    Private _width As Integer
    Private _height As Integer

    Public Property X As Integer Implements IShape.X
        Get
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property
    Public Property Y As Integer Implements IShape.Y
        Get
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Public Property Width As Integer
        Get
            Return _width
        End Get
        Set(value As Integer)
            _width = value
        End Set
    End Property
    Public Property Height As Integer
        Get
            Return _height
        End Get
        Set(value As Integer)
            _height = value
        End Set
    End Property

    Public ReadOnly Property Area As Double Implements IShape.Area
        Get
            Return _width * _height
        End Get
    End Property
End Class


Public Class Circle
    Implements IShape

    Private _x As Integer
    Private _y As Integer
    Private _radius As Integer

    Public Property X As Integer Implements IShape.X
        Get
            Return _x
        End Get
        Set(value As Integer)
            _x = value
        End Set
    End Property
    Public Property Y As Integer Implements IShape.Y
        Get
            Return _y
        End Get
        Set(value As Integer)
            _y = value
        End Set
    End Property

    Public Property Radius As Integer
        Get
            Return _radius
        End Get
        Set(value As Integer)
            _radius = value
        End Set
    End Property

    Public ReadOnly Property Area As Double Implements IShape.Area
        Get
            Return _radius * _radius * Math.PI
        End Get
    End Property
End Class

