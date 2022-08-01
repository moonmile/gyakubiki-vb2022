<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.textBox3 = New System.Windows.Forms.TextBox()
        Me.textBox2 = New System.Windows.Forms.TextBox()
        Me.textBox1 = New System.Windows.Forms.TextBox()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.toolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'textBox3
        '
        Me.textBox3.Location = New System.Drawing.Point(132, 110)
        Me.textBox3.Name = "textBox3"
        Me.textBox3.Size = New System.Drawing.Size(218, 31)
        Me.textBox3.TabIndex = 11
        Me.toolTip1.SetToolTip(Me.textBox3, "2021年1月1日")
        '
        'textBox2
        '
        Me.textBox2.Location = New System.Drawing.Point(133, 66)
        Me.textBox2.Name = "textBox2"
        Me.textBox2.Size = New System.Drawing.Size(218, 31)
        Me.textBox2.TabIndex = 10
        Me.toolTip1.SetToolTip(Me.textBox2, "例：やまだ　たろう")
        '
        'textBox1
        '
        Me.textBox1.Location = New System.Drawing.Point(133, 23)
        Me.textBox1.Name = "textBox1"
        Me.textBox1.Size = New System.Drawing.Size(218, 31)
        Me.textBox1.TabIndex = 9
        Me.toolTip1.SetToolTip(Me.textBox1, "例：山田　太郎")
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Location = New System.Drawing.Point(24, 116)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(102, 25)
        Me.label3.TabIndex = 8
        Me.label3.Text = "生年月日："
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(24, 69)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(87, 25)
        Me.label2.TabIndex = 7
        Me.label2.Text = "ふりがな："
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(24, 26)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(66, 25)
        Me.label1.TabIndex = 6
        Me.label1.Text = "氏名："
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(378, 173)
        Me.Controls.Add(Me.textBox3)
        Me.Controls.Add(Me.textBox2)
        Me.Controls.Add(Me.textBox1)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents textBox3 As TextBox
    Private WithEvents toolTip1 As ToolTip
    Private WithEvents textBox2 As TextBox
    Private WithEvents textBox1 As TextBox
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents label1 As Label
End Class
